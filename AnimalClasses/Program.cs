using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Program
    {

        
        static void Main(string[] args)
        {

            

            Dog fide = new Dog( false, 25);

            fide.Greet();
            fide.Talk();
            fide.Talk();
            fide.Fetch("ball");

            fide.TouchMe();
            fide.FeedMe();

            Console.WriteLine(fide.ToString());


            Robin red = new Robin();
            red.Talk();
            red.Sing();

            Console.ReadLine();

        }
    }
}
