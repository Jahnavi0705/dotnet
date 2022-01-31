using System;

namespace coparrissionequals
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "jahnavi";
            string Myname = name;

            var doubleeql = (name == Myname);//true
            var eql = name.Equals(Myname);//true
            Console.WriteLine(doubleeql);
            Console.WriteLine(eql);
            Console.WriteLine("====================");

            object nameObj = "jahnavi";
            char[] values = { 'j', 'a', 'h', 'n', 'a', 'v', 'i' };
            object myName = new string(values);
            var doubleeql2 = (nameObj == myName);//false
            var eql2 = nameObj.Equals(myName);//true
            Console.WriteLine(doubleeql2);
            Console.WriteLine(eql2);

        }
    }
}
