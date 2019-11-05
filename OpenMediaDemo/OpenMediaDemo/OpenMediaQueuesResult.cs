using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMediaDemo
{
    public class Self
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Embedded
    {
        public List<Item> items { get; set; }
    }

    public class OpenMediaQueuesResult
    {
        public Links _links { get; set; }
        public int count { get; set; }
        public Embedded _embedded { get; set; }
    }
}
