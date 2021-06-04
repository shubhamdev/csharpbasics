using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationCSharpBasics
{

    /* 
       Constructor is the special method in the class which we use to instantiate some value or instantiate some methods./
       constructor don't return anything./
       constructor initalized automatically whenever you create instance of a class./
       What is instantiation or initalization?
      Use
        1. It is use to initalized variable/values in your class.
       When ever you declear/create a class c-sharp will create a constructor and destructor for you even if you don't define a 
       constructor and destructor by your self 
    */

    /*
      Destructor
       1. destructor defined using tild (~) sign 
       2. It is getting called when your object goes out of scope.
     */
    class ConstructorAndDestructor
    {
        public double l, b, h;
        public ConstructorAndDestructor(double la, double br, double hi)
        {
            this.l = la;
            this.b = br;
            this.h = hi;
            Console.WriteLine("ConstructorAndDestructor: Constructor initalized automatically.");
        }
        ~ConstructorAndDestructor()
        {
            Console.WriteLine("ConstructorAndDestructor: Destructor called.");
        }
    }
}
