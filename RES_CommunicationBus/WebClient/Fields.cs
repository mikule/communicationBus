using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient
{
    public class Fields
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Fields(string id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
        public Fields()
        {

        }
    }
}
