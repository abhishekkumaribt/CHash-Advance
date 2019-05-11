using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBusinessLayer
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Product(string productId, string productName, double price, string description)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Price = price;
            this.Description = description;
        }
    }
}
