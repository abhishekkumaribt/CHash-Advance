using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickKartBusinessLayer
{
    public class Customer
    {
        private static int counter;
        private string emailId;
        private string phonenumber;
        public string Address { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailId { get { return emailId; }
            set
            {
                if(value.Length>6 && value.Count(x=>x=='@')==1 && value.StartsWith("@")==false && value.EndsWith(".com"))
                {
                    emailId = value;
                }
                else
                {
                    emailId = "NA";
                    throw new InvalidEmailIdException(value + " doesn't met email id formate");
                }
            }
        }
        public char Gender { get; set; }
        public string Password { get; set; }
        public string PhoneNumber
        {
            get
            {
                return phonenumber;
            }
            set
            {
                if(value.Length==10 && value.StartsWith("0") == false)
                    phonenumber = value;
                else
                    throw new InvalidPhoneNumberException(value + " is an invalid phone number");
            }
        }
        static Customer()
        {
            counter = 1000;
        }
        public Customer()
        {
            CustomerId = ++counter;
        }
    }
}
