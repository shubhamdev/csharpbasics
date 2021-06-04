using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplicationCSharpBasics
{
    /* 
     Multiple methods with diffrent parameter
     One thing in many forms

     https://www.youtube.com/watch?v=4a_iTOtGhM8&ab_channel=kudvenkat
     1. Overriding virtual methods
     2. Polymorphism
        2.1. Polymorphism will help you to run overriden method from the child class to be invoked at runtme and that's
             nothing but a Polymorphism
        2.2. Polymorphism basically enables you to invoke derive class methods using a base class refrence variable at
             runtime. 
     */
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

    public class Employee
    {
        public string FullName { get; set; }
        public string FirstName = "Shubham";
        public string LastName = "Chaturvedi";
        public string EmailId { get; set; }


        // virtual key word will help other child class to override this method from.
        // Basically child will override parent class method
        // Any derived class can override this method

        // Code run overview -------
        //1. Base class we marked method as virtual and the respective derived classes we are overriding the implimentation 
        //2. so if we run this program
        //3. The reference variable of type parent at runtime they will check what kind of object do i have 
        //   and then they will override the method at run time
        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + "PartTime");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + "FullTime");
        }
    }

    public class TempTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + "Temp");
        }
    }
}
