using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient
{
   public class Query
    {
        public  string Name { get; set; }
        public string Id { get; set; }

        public Query(string name, string id)
        {
            Name = name;
            Id = id;
        }
        public Query()
        {
        }
    }
}
