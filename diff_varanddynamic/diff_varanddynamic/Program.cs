using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diff_varanddynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using var keyword
            var a = 'f';
            var b = "Welcome";
            var c = 30.67d;
            var d = false;
            var e = 54544;

            //Using Dynamic keyword

            dynamic val1 = "John";
            dynamic val2 = 3234;
            dynamic val3 = 32.55;
            dynamic val4 = true;

            // Display the type
            Console.WriteLine("Type of 'a' is : {0} ", a.GetType());

            Console.WriteLine("Type of 'b' is : {0} ", b.GetType());

            Console.WriteLine("Type of 'c' is : {0} ", c.GetType());

            Console.WriteLine("Type of 'd' is : {0} ", d.GetType());

            Console.WriteLine("Type of 'e' is : {0} ", e.GetType());

            // dynamic variables
            // Using GetType() method
            Console.WriteLine("Get the actual type of val1: {0}",
                                      val1.GetType().ToString());

            Console.WriteLine("Get the actual type of val2: {0}",
                                      val2.GetType().ToString());

            Console.WriteLine("Get the actual type of val3: {0}",
                                      val3.GetType().ToString());

            Console.WriteLine("Get the actual type of val4: {0}",
                                      val4.GetType().ToString());

            Console.ReadLine();



        }
    }
}
