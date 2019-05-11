using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBusinessLayer;

namespace Infosys.QuickKart
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prodObj1 = new Product("P101", "Table", 1034.00, "Good Quality");
            Product prodObj2 = new Product("P102", "Chair", 1134.00, "Good Quality");
            Product prodObj3 = new Product("P103", "Books", 534.00, "Good Quality");

            Product[] productList = new Product[5];

            productList[0] = prodObj1;
            productList[1] = prodObj2;
            productList[2] = prodObj3;
            try
            {
                for (int i = 0; i < productList.Length; i++)
                {
                    Console.WriteLine("ID = " + productList[i].ProductId +
                                               "\tName = " + productList[i].ProductName +
                                               "\tPrice = " + productList[i].Price +
                                               "\tDescription = " + productList[i].Description);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nThere is some error in the program.");
            }
            finally
            {
                Console.WriteLine("\nEnd of the product list details.");
            }
        }
    }
}
