﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId; 
        }
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }
        
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) return false;
            if (ProductId <= 0) return false;
            if (PurchasePrice <= 0) return false;

            return isValid;
        }
    }
}
