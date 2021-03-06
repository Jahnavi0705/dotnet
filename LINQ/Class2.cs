using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemos
{
    //oftype
    class Class2
    {
        static void Main()
        {
            IList sampleList = new ArrayList();
            sampleList.Add(0);
            sampleList.Add("One");
            sampleList.Add("Two");
            sampleList.Add(3);
            sampleList.Add(new student() { StudentId = 1, StudentName = "Vikash" });

            var stringResult = from s in sampleList.OfType<string>() select s;
            var intResult = from s in sampleList.OfType<int>() select s;
            foreach (var item in stringResult)
            {
                Console.WriteLine(item);
            }
            foreach (var item in intResult)
            {
                Console.WriteLine(item);
            }

        }
    }
}