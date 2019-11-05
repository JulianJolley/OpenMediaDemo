using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMediaDemo
{
    public class OpenMedia
    {
        public string TargetUri { get; set; }
        public bool TargetUriEmbedded { get; set; }
        public string Queue { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string PreviewUrl { get; set; }
        public string HistoryUrl { get; set; }
    }
}
