using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBusinessLayer
{
    public class InvalidEmailIdException : Exception
    {
        public InvalidEmailIdException(string message):base(message)
        {

        }
    }
}
