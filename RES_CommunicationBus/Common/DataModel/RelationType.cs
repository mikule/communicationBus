using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPodataka.DataModel
{
   public class RelationType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public RelationType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public RelationType()
        {

        }
    }
}
