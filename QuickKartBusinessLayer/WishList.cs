using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBusinessLayer
{
    public class WishList
    {
        private List<Products> products;
        public void AddProduct(Products p)
        {
            products.Add(p);
        }
        public void DisplayProductsInWishList()
        {
            foreach(Products p in products)
            {
                Console.WriteLine("Product Id : " + p.ProductId);
                Console.WriteLine("Product Name : " + p.ProductName);
                Console.WriteLine("Category Id : " + p.CategoryId);
                Console.WriteLine("Price : " + p.Price);
                Console.WriteLine("Quantity Available : " + p.QuantityAvailable);
                Console.WriteLine();
            }
        }
        public int GetTotalNumberOfRequest()
        {
            return products.Count;
        }
        public void InsertProduct(int index,Products p)
        {
            products.Insert(index, p);
        }
        public void RemoveProduct(Products p)
        {
            products.Remove(p);
        }
        public void RemoveProductAtIndex(int index)
        {
            products.RemoveAt(index);
        }
        public WishList()
        {
            products = new List<Products>();
        }
    }
}
