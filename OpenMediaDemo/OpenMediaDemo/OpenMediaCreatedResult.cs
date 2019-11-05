using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMediaDemo.OpenMediaCreatedResult
{
    public class Self
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
    }

    public class Embedded
    {
    }

    class OpenMediaCreatedResult
    {
        public Links _links { get; set; }
        public string id { get; set; }
        public string conversationState { get; set; }
        public DateTime timeOfferedToSystem { get; set; }
        public Embedded _embedded { get; set; }
    }
}
