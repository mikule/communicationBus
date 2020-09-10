using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient
{
    public class Request
    {
        public string Verb { get; set; }
        public string Noun { get; set; }
        public Query Query { get; set; }
        public Fields Fields { get; set; }

        public Request(string verb, string noun,Query query, Fields fields)
        {
            Verb = verb;
            Noun = noun;
            Query = query;
            Fields = fields;
        }
        public Request()
        {

        }
    }
}
