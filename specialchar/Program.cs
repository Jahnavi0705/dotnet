using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class CharIsSpecial : Exception
    {
        public CharIsSpecial(string message) : base(message)
        {

        }
    }
    class ExceptionHandling2
    {
        string Character = Console.ReadLine();
        string Special = "!@#$%^&*?";
        int c = 0;
        public void TestChar()
        {
            for (int i = 0; i < Character.Length; i++)
            {
                for (int j = 0; j < Special.Length; j++)
                {
                    if (Character[i] == Special[j])
                    {
                        c = 1;
                    }
                }
            }
            if (c == 1)
            {
                throw (new CharIsSpecial("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("No special elements are there");
            }

        }
        static void Main(string[] args)
        {
            ExceptionHandling2 Exp = new ExceptionHandling2();
            try
            {
                Exp.TestChar();
            }
            catch (CharIsSpecial ex)
            {
                Console.WriteLine("Custom execption is {0}", ex.Message);
            }
        }
    }
}