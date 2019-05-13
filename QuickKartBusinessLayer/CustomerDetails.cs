using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBusinessLayer
{
    public class CustomerDetails
    {
        private int indexNumber;
        private Customer[] listOfCustomers;
        public CustomerDetails()
        {
            indexNumber = 0;
            listOfCustomers = new Customer[10];
        }
        public bool AddCustomer(Customer customer)
        {
            if (indexNumber < 10 && customer != null)
            {
                listOfCustomers[++indexNumber] = customer;
                return true;
            }
            else
                return false;
        }
    }
}
