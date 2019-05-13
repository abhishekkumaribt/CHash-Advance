using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBusinessLayer
{
    public class Airlines
    {
        public int AirlineId { get; set; }
        public string AirlineName { get; set; }
        public double BaseFare { get; set; }
        public double CalculateFare(AirlineCustomer obj)
        {
            int age = obj.CalculateAge();
            try
            {
                if (age > 0 && age < 100)
                {
                    switch (obj.ClassOfTravel)
                    {
                        case "Business":
                            BaseFare = 10000.0;
                            break;
                        case "Premium":
                            BaseFare = 5000.0;
                            break;
                        case "Economy":
                            BaseFare = 1200.0;
                            break;
                        default:
                            throw new InvalidTravelClassException();
                    }
                }
                else
                {
                    throw new InvalidAgeException();
                }
            }
            catch(InvalidTravelClassException ex)
            {
                BaseFare = 0;
            }
            catch(InvalidAgeException ex)
            {
                BaseFare = 0;
            }
            return BaseFare + CalculateServiceCharges(BaseFare) + CalculateTax(BaseFare);
        }
        public double CalculateServiceCharges(double baseFare)
        {
            return baseFare * 1.05;
        }
        public double CalculateTax(double baseFare)
        {
            return baseFare * 1.15;
        }
    }
}
