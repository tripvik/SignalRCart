﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRCart.Models
{
    public class CartItem
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}