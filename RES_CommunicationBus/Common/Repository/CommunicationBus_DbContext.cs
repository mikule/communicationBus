using ModelPodataka.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public class CommunicationBus_DbContext : DbContext
    {
        DbSet<Relation> Relations { get; set; }
        DbSet<RelationType> RelationTypes { get; set; }
        DbSet<Resource> Resources { get; set; }
        DbSet<ResourceType> ResourceTypes { get; set; }

        public CommunicationBus_DbContext() : base("CommunicationBusDB")
        {

        }
    }
}
