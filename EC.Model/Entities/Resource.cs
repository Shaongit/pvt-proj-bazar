﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EC.Model.Entities
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Operations Operations { get; set; }
    }
}