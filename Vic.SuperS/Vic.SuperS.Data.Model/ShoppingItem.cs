﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vic.SuperS.Data.Model
{
    public class ShoppingItem
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return this.Count * this.Price;
            }
        }

        public override string ToString()
        {
            return string.Format("ProductId = {0},Count = {1},TotalPrice = {2}", this.ProductId,this.Count,this.TotalPrice);
        }

    }
}
