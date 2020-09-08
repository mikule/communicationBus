﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPodataka.DataModel
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string Description  { get; set; }
        public ResourceType Type  { get; set; }

        public Resource() 
        {

        }

        public Resource(int id, string name, string description, ResourceType type)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
        }
    }
}
