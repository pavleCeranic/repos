using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Dog : Animal, IDomesticated
    {
        public Dog(Boolean isAlive, int w) : base(isAlive, w)
        {

        }
        public void Talk()
        {
            Console.WriteLine("bark bark bark");
        }

        public void Sing()
        {
            Console.WriteLine("awoooooo");
        }

        public void Fetch(string thing)
        {
            Console.WriteLine($"Hello here is your {thing}, That was fun lets do it again.");
        }

        public void TouchMe()
        {
            Console.WriteLine("Please scratch me behind my ears");
        }

        public void FeedMe()
        {
            Console.WriteLine("Suppertime! The very best time of day");
        }
    }
}
