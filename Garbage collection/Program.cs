using System;

namespace Garbage_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the generation are " + GC.GetTotalMemory(true));
            Program p = new Program();
            Console.WriteLine("generation are "+GC.MaxGeneration);
            Console.WriteLine("generation are " + GC.GetGeneration(p));
            Console.WriteLine("generation are " + GC.GetTotalMemory(true));

            //for collection of garbage GC.Collect()

            GC.Collect();
            Console.WriteLine("GC in generation 0  " + GC.CollectionCount(0));
            finally
            {

            }
        }
    }
}
