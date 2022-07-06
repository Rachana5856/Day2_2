using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //number of generation in garbage collection
            Console.WriteLine("The number of generations are: " +
                                           GC.MaxGeneration);

            /*This method returns the generation number of the target object.
            It requires a single parameter i.e. the target object for which the 
            generation number is required.*/
            Program obj = new Program();
            Console.WriteLine("The generation number of object obj is: "
                                              + GC.GetGeneration(obj));

            //GC.Collect() method
            GC.Collect(0);
            Console.WriteLine("Garbage Collection in Generation 0 is: "
                                              + GC.CollectionCount(0));
            Console.ReadLine();
        }
    }
}
