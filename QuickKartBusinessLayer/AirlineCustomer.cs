using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBusinessLayer
{
    public class AirlineCustomer
    {
        public string ClassOfTravel { get; set; }
        public int CustId { get; set; }
        public string CustName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CalculateAge()
        {
            DateTime zero = new DateTime(1, 1, 1);
            return (zero + (DateTime.Now - DateOfBirth)).Year - 1;
        }
    }
}
