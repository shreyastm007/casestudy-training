﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCaseIntegrate.Model
{
 
        public class Product
        {
            [Key]
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductDetails { get; set; }
            public int ProductPrice { get; set; }
        }
    }

