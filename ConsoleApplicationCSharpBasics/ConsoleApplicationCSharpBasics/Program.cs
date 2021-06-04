using System;


namespace ConsoleApplicationCSharpBasics
{

    //    1. Classes and Objects  
    //    2. Constructor and Destructor  ---- ConstructorAndDestructor
    //    3. Function Overloading
    //    4. Encapsulation -
    //    5. Inheritance - Interface
    //    6. Interface
    //    7. Polymorphism - Polymorphism
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //ConstructorAndDestructor

            // Creating instance of the class
            ConstructorAndDestructor constructorAndDestructor = new ConstructorAndDestructor(10, 10, 10);

            //

            // Polymorphism

            Employee[] employee = new Employee[4];
            employee[0] = new Employee();
            employee[1] = new FullTimeEmployee();
            employee[2] = new PartTimeEmployee();
            employee[3] = new TempTimeEmployee();

            foreach (var item in employee)
            {
                item.PrintFullName();
            }

            //
        }
    }
}
