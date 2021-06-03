using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpbasics
{
    // Abstraction
    // For this paricular order class we have three properties and three methods/functions
    // What is required for any module/class/application, the essential part we need to expose that is called abstraction
    public class Order
    {
        public string OrderName { get; set; }
        public string OrderValue { get; set; }
        public string OrderCountry { get; set; }

        public string CreateOrder()
        {
            return "Order Created";
        }

        public bool ValidateOrderValue()
        {
            // Implimentation will go here
            return true;
        }
        public bool ValidateOrderCountry()
        {
            // Implimentation will go here
            return true;
        }

    }
}
