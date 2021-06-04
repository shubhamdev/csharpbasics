using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplicationCSharpBasics
{

    //1. Why Inheritance

    // * It will help you to remove the duplicate code from the application 
    // * Move all the duplicate code in to the common/base class

    //2. Advantages of inheritance

    // *  Code reusability, Becasue of code reusability the amount of error within the code is also get reduced
    // *  Save lot of time
    // *  Less number of erros
    // *  inheritance pramote reusability

    //3. Inheritance Syntax

    // ChildClass : ParentClass
    // C# supports only single class inheritance
    // C# supports multi-level class inheritance
    // C# supports multiple interface inheritance
    // Child class is a specialization of base class
    // Base classes are automatically instantiated before derived classes
    // Parent class constructor excutes before child class constructor

    //4. Inheritance Concepts


    // Derived class is the specialization of your bases class
    // If you want to understand polymorphism you need to understand inheritance properly
    public class Inheritance
    {

    }

    public class Student
    {
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }

        public void PrintFullName()
        {

        }
    }

    public class FullTimeStudent : Student
    {
        public float YearlyFee { get; set; }
    }

    public class PartTimeStudent : Student
    {
        public float HourlyFee { get; set; }
    }


    ////
    ///
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent constructor called.");
        }

        public Parent(string Message)
        {
            Console.WriteLine(Message);
        }
    }

    public class Child : Parent
    {
        public Child() : base("test")
        {
            Console.WriteLine("Child constructor");
        }
    }


}
