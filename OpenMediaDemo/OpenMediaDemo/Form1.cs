using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenMediaDemo
{
    public partial class Form1 : Form
    {
        private string _accessToken;
        private int _expiresIn;
        List<string> _currentOpenMediaItems;
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form1()
        {
            InitializeComponent();
            _currentOpenMediaItems = new List<string>();
            if (!(tbServer.Text.ToLower().StartsWith("https://") || tbServer.Text.ToLower().StartsWith("http://")))
                tbServer.Text = $"http://{tbServer.Text}";
        }

        private async void GetToken(string server, string user, string password)
        {
            string tokenurl = server + "/AuthorizationServer/token";
            _log.Info("GetToken URL: " + tokenurl);
            HttpMethod reqMethod = HttpMethod.Post;
            try
            {
                var tokenresp = await GetTokenAsync(tokenurl, user, password);
                if (tokenresp.StatusCode == HttpStatusCode.OK)
                {
                    _log.Info("GetTokenAsync StatusCode == OK");
                    var tokendata = await tokenresp.Content.ReadAsStringAsync();
                    var x = JsonConvert.DeserializeObject<TokenObject>(tokendata);
                    _log.Info("x.access_token = " + x.access_token);
                    _accessToken = x.access_token;
                    _expiresIn = x.expires_in;
                    btn_Create.Enabled = true;
                    btn_Login.Enabled = false;
                    GetOpenMediaQueues();
                }
                else
                {
                    _log.Error("Failed to get token. HttpStatusCode: " + tokenresp.StatusCode.ToString());
                    MessageBox.Show("Failed to get Token. HttpStatusCode: " + tokenresp.StatusCode.ToString(), "Token Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _log.Error("Exception. Message: " + ex.Message);
                MessageBox.Show("Exception. Message: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Task<HttpResponseMessage> GetTokenAsync(string url, string username, string password)
        {
            HttpClient client = new HttpClient();
            var pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("password",password)
                };
            var content = new FormUrlEncodedContent(pairs);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
            return client.PostAsync(url, content);
        }

        private Task<HttpResponseMessage> CallMiCCSDKAsync(string url, string JSONData, string AccessToken, HttpMethod methodType)
        {
            HttpClient client = new HttpClient();
            var content = new StringContent(JSONData, Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = methodType,
                Content = content
            };
            request.Headers.Add("Authorization", "Bearer " + AccessToken);

            return client.SendAsync(request);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(lbQueues.SelectedItem != null)
            {
                OpenMedia om = new OpenMedia
                {
                    From = tbFrom.Text,
                    Queue = lbQueues.SelectedItem.ToString(),
                    Subject = tbSubject.Text,
                    TargetUri = tbURL.Text,
                    TargetUriEmbedded = cb_TargetUriEmbedded.Checked,
                    PreviewUrl = tbURL.Text,
                    HistoryUrl = tbURL.Text
                };
                string url = string.Format(@"{0}/MiccSdk/api/v1/openmedia",tbServer.Text);
                var JSONData = JsonConvert.SerializeObject(om);
                var response = CallMiCCSDKAsync(url, JSONData, _accessToken, HttpMethod.Post).Result;
                if(response.StatusCode == HttpStatusCode.Created)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    OpenMediaCreatedResult.OpenMediaCreatedResult result = JsonConvert.DeserializeObject<OpenMediaCreatedResult.OpenMediaCreatedResult>(content);
                    _log.Info("OpenMedia Item Created " + content);
                    _currentOpenMediaItems.Add(result.id);
                    tbCreatedItems.Text = "";
                    foreach (string item in _currentOpenMediaItems)
                    {
                        tbCreatedItems.Text = tbCreatedItems.Text + "\n" + item;
                    }
                    
                    
                }
            }
            else
            {
                MessageBox.Show("No OpenMedia Queue Selected.\nPlease select from List, then click create.", "No OpenMedia Queue Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GetToken(tbServer.Text, tbUser.Text, tbPassword.Text);
        }

        private async void GetOpenMediaQueues()
        {
            //prior to 9.1 select was supported: &$select=name,id
            string url = string.Format(@"{0}/miccsdk/api/v1/queues?$filter=mediaType%20eq%20%27OpenMedia%27",tbServer.Text);
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get,
            };
            request.Headers.Add("Authorization", "Bearer " + _accessToken);
           
            var response = await client.SendAsync(request);
            if(response.StatusCode ==  HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                OpenMediaQueuesResult result = JsonConvert.DeserializeObject<OpenMediaQueuesResult>(content);
                _log.Info("GetOpenMediaQueues Content = " + content);
                foreach(var obj in result._embedded.items)
                {
                    lbQueues.Items.Add(obj.name);
                }
            }
        }

        private void btnCompleteOpenMedia_Click(object sender, EventArgs e)
        {
            string itemToKill = tbCreatedItems.SelectedText;
            _log.Info("Selected Text = " + itemToKill);
            _currentOpenMediaItems.Remove(itemToKill);
            tbCreatedItems.Text = "";
            foreach (string item in _currentOpenMediaItems)
            {
                tbCreatedItems.Text = tbCreatedItems.Text + "\n" + item;
            }
            string url = string.Format(@"{0}/MiccSdk/api/v1/openmedia/{1}",tbServer.Text, itemToKill);
            var JSONData = "{ \"action\":\"Complete\"}";
            var response = CallMiCCSDKAsync(url, JSONData, _accessToken, HttpMethod.Put).Result;
            _log.Info("btnCompleteOpenMedia_Click result = " + response.StatusCode.ToString());

        }
    }
}
