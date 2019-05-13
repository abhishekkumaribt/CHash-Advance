using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBusinessLayer
{
    public class InvalidPhoneNumberException:Exception
    {
        public InvalidPhoneNumberException(string message) : base(message)
        {

        }
    }
}
