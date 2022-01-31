using System;
using System.Collections.Generic;
using System.Text;

namespace first
{
    class Class1
    {
    }
    class Class2
    { 
    }
    class ISAndAs
    {
        public static void Test(object Obj)
        {
            Class1 a;
            Class2 b;
            Class1 c;
            if (Obj is Class1)
            {
                Console.WriteLine("Object is of class 1");

            }
            else if (Obj is Class2)
            {
                Console.WriteLine("Object is of class 2");
            }
            else
            {
                Console.WriteLine("Obj is neither class 1 nor class 2"); ;
            }
        }
    }

}
