using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPodataka.DataModel
{
    public class Relation
    {
        public int Id { get; set; }
        public int FirstResourceId { get; set; }
        public int SecondResourceId { get; set; }
        public RelationType Type  { get; set; }


        public Relation() 
        { 

        }

        public Relation(int id, int firstResourceId, int secondResourceId, RelationType type)
        {
            Id = id;
            FirstResourceId = firstResourceId;
            SecondResourceId = secondResourceId;
            Type = type;
        }
    }
}
