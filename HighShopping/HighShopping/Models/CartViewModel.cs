﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighShopping.Models
{
    public class CartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public float GrandTotal { get; set; }
    }
}
