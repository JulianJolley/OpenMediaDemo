namespace OpenMediaDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbTargetUriEmbedded = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbQueues = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.cb_TargetUriEmbedded = new System.Windows.Forms.CheckBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tbCreatedItems = new System.Windows.Forms.TextBox();
            this.btnCompleteOpenMedia = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTargetUriEmbedded
            // 
            this.cbTargetUriEmbedded.AutoSize = true;
            this.cbTargetUriEmbedded.Location = new System.Drawing.Point(15, 507);
            this.cbTargetUriEmbedded.Name = "cbTargetUriEmbedded";
            this.cbTargetUriEmbedded.Size = new System.Drawing.Size(179, 24);
            this.cbTargetUriEmbedded.TabIndex = 1;
            this.cbTargetUriEmbedded.Text = "TargetUriEmbedded";
            this.cbTargetUriEmbedded.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.tbServer);
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.tbUser);
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.tbPassword);
            this.flowLayoutPanel2.Controls.Add(this.label11);
            this.flowLayoutPanel2.Controls.Add(this.lbQueues);
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Controls.Add(this.tbURL);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.tbFrom);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.tbSubject);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(527, 458);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "MiCC Server";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(3, 23);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(488, 26);
            this.tbServer.TabIndex = 1;
            this.tbServer.Text = "https://miccdemo.uk.mitel.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "User Name";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(3, 75);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(488, 26);
            this.tbUser.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(3, 127);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(488, 26);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Open Media Queue";
            // 
            // lbQueues
            // 
            this.lbQueues.FormattingEnabled = true;
            this.lbQueues.ItemHeight = 20;
            this.lbQueues.Location = new System.Drawing.Point(3, 179);
            this.lbQueues.Name = "lbQueues";
            this.lbQueues.Size = new System.Drawing.Size(488, 64);
            this.lbQueues.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "URL";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(3, 269);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(488, 26);
            this.tbURL.TabIndex = 9;
            this.tbURL.Text = "https://www.google.com";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "From";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(3, 321);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(488, 26);
            this.tbFrom.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 350);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Subject";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(3, 373);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(488, 26);
            this.tbSubject.TabIndex = 13;
            this.tbSubject.Text = "Demo";
            // 
            // cb_TargetUriEmbedded
            // 
            this.cb_TargetUriEmbedded.AutoSize = true;
            this.cb_TargetUriEmbedded.Checked = true;
            this.cb_TargetUriEmbedded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_TargetUriEmbedded.Location = new System.Drawing.Point(15, 507);
            this.cb_TargetUriEmbedded.Name = "cb_TargetUriEmbedded";
            this.cb_TargetUriEmbedded.Size = new System.Drawing.Size(179, 24);
            this.cb_TargetUriEmbedded.TabIndex = 1;
            this.cb_TargetUriEmbedded.Text = "TargetUriEmbedded";
            this.cb_TargetUriEmbedded.UseVisualStyleBackColor = true;
            // 
            // btn_Create
            // 
            this.btn_Create.Enabled = false;
            this.btn_Create.Location = new System.Drawing.Point(111, 554);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(152, 38);
            this.btn_Create.TabIndex = 2;
            this.btn_Create.Text = "Create Request";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(15, 554);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(79, 38);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbCreatedItems
            // 
            this.tbCreatedItems.Location = new System.Drawing.Point(19, 649);
            this.tbCreatedItems.Multiline = true;
            this.tbCreatedItems.Name = "tbCreatedItems";
            this.tbCreatedItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCreatedItems.Size = new System.Drawing.Size(495, 154);
            this.tbCreatedItems.TabIndex = 4;
            // 
            // btnCompleteOpenMedia
            // 
            this.btnCompleteOpenMedia.Location = new System.Drawing.Point(19, 828);
            this.btnCompleteOpenMedia.Name = "btnCompleteOpenMedia";
            this.btnCompleteOpenMedia.Size = new System.Drawing.Size(176, 39);
            this.btnCompleteOpenMedia.TabIndex = 5;
            this.btnCompleteOpenMedia.Text = "Complete Selected";
            this.btnCompleteOpenMedia.UseVisualStyleBackColor = true;
            this.btnCompleteOpenMedia.Click += new System.EventHandler(this.btnCompleteOpenMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 886);
            this.Controls.Add(this.btnCompleteOpenMedia);
            this.Controls.Add(this.tbCreatedItems);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.cb_TargetUriEmbedded);
            this.Controls.Add(this.cbTargetUriEmbedded);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OpenMediaDemo";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbTargetUriEmbedded;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.CheckBox cb_TargetUriEmbedded;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.ListBox lbQueues;
        private System.Windows.Forms.TextBox tbCreatedItems;
        private System.Windows.Forms.Button btnCompleteOpenMedia;
    }
}

