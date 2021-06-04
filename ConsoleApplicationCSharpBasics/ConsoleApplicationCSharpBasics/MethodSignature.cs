using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationCSharpBasics
{

    // Return type is not part of the method signature in C#. Only the method name and its parameters types 
    // (but not the parameter names) are part of the signature. You cannot, 
    // for example, have these two methods

    //int DoSomething(int a, int b);
    //string DoSomething(int a, int b);


    class MethodSignature
    {
        public int DoSomething(int a, int b)
        {
            return 0;
        }
        //public string DoSomething(int a, int b)
        //{
        //    return "";
        //}
    }

}
