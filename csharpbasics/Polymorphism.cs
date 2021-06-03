using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpbasics
{
    // Multiple methods with diffrent parameter
    // One thing in many forms
    public class Polymorphism
    {
        public int Add()
        {
            return 1;
        }

        public int Add(int a)
        {
            return 1 + a;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }
    }
}
