﻿using Project.DAL.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class Entity : IEntity
    {
        public int  Id { get; set; }
    }
}
