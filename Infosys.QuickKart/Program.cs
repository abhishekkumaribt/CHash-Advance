using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using QuickKartBusinessLayer;

namespace Infosys.QuickKart
{
    class Program
    {
        static void Main(string[] args)
        {
            WishList wishList = new WishList();

            Products pd1 = new Products();
            Products pd2 = new Products();
            Products pd3 = new Products();
            pd1.ProductName = "Product-1";
            pd2.ProductName = "Product-2";
            pd3.ProductName = "Product-3";
            pd1.Price = 2500;
            pd2.Price = 1400;
            pd3.Price = 850;

            wishList.AddProduct(pd1);
            wishList.AddProduct(pd2);
            wishList.AddProduct(pd3);

            Console.WriteLine("Total no of products in wishlist : " + wishList.GetTotalNumberOfRequest());

            Console.WriteLine();
            wishList.DisplayProductsInWishList();

            Products pd4 = new Products();
            pd4.ProductName = "Product-4";
            pd4.Price = 3300;
            wishList.InsertProduct(1, pd4);

            Console.WriteLine();
            wishList.DisplayProductsInWishList();

            wishList.RemoveProduct(pd2);

            Console.WriteLine();
            wishList.DisplayProductsInWishList();

            wishList.RemoveProductAtIndex(2);

            Console.WriteLine();
            wishList.DisplayProductsInWishList();

            pd1.ProductName = "Test";

            Console.WriteLine();
            wishList.DisplayProductsInWishList();
        }
    }
}
