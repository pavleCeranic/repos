using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    abstract class Animal
    {
        Boolean isAlive {get; set;}
        int Weight { get; set; }


        public Animal(Boolean isAlive, int w)
        {
            isAlive = isAlive;
            this.Weight = w; 

            Console.WriteLine("Animal Constructor");
        }
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }

        public void Greet()
        {
            Console.WriteLine("Animal says hello");
        }
        public void Talk()
        {
            Console.WriteLine("Animal is talking");
        }
        public void Sing()
        {
            Console.WriteLine("Animal is singing");
        }

        public string ToString()
        {
            return "Status " + isAlive + " Weight: " + Weight;
        }
    }
}
