using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelLoopforBreak
{
    public class Anonymous
    {
        public delegate string GreetDelegate(string name);
        /*public static string Greet(string name)
        {
            return "Hello" + name;
        }*/
        static void Main8(string[] args)
        {
            String Message = "Hey";
            //GreetDelegate gd = new GreetDelegate(Anonymous.Greet);
            GreetDelegate gd = delegate (string name)
              {
                  return "Hello" + name + Message;
              };
            Console.WriteLine(gd.Invoke("JAHNAVI"));
        }
    }
}
