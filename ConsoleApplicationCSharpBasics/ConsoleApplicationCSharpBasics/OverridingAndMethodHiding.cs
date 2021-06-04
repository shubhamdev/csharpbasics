using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationCSharpBasics
{
    // In method overrinding a base class reference variable pointing to a child class object
    // will invoke the overridden method in the child class.
    class OverridingAndMethodHiding
    {

        
    }

    // Method overriding
    public  class Base
    {
        public virtual void Print()
        {
            Console.WriteLine("Base class");
        }
    }

    public class ChildClass: Base
    {
        public override void Print()
        {
            Console.WriteLine("Child class");
        }
    }
    //


    // Method Hiding
    // In method hiding a base class reference variable pointing to a derived/base class object, will invoke the hidden method in the base class
    // Using the new key word inside MethodHidingDerivedClass  
    public class MethodHidingBaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Base class");
        }
    }

    public class MethodHidingDerivedClass : MethodHidingBaseClass
    {
        public new void Print()
        {
            Console.WriteLine("Child class");
        }
    }


}
