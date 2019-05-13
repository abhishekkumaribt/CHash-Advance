using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBusinessLayer
{
    public class InvalidTravelClassException:Exception
    {
        public InvalidTravelClassException()
        {
            Console.WriteLine("Only 'Business','Premium' and 'Economy' are valid Travel Class");
        }
    }
    public class InvalidAgeException:Exception
    {
        public InvalidAgeException()
        {
            Console.WriteLine("Age should be between 0 to 100(Exclusive)");
        }
    }
}
