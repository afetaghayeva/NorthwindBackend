﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace NorthwindBackend.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
