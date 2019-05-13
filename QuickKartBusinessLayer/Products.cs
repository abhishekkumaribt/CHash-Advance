using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBusinessLayer
{
    public class Products
    {
        private static int count;
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        static Products()
        {
            count = 1000;
        }
        public Products()
        {
            ProductId = count++;
        }
    }
}
