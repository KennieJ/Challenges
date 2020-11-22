using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Week2Challenge
{
    class Greeter
    {
        public void SayHello()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }

        public void SayGoodbye()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Goodbye {name}");
        }

        public void timelyGreeting()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            if(DateTime.Now.Hour > 4 && DateTime.Now.Hour < 12)
            {
                Console.WriteLine($"Good morning {name}");
            }
            else if(DateTime.Now.Hour < 5)
            {
                Console.WriteLine($"Good afternoon {name}");
            }
            else if(DateTime.Now.Hour < 10)
            {
                Console.WriteLine($"Good evening {name}");
            }
            else
            {
                Console.WriteLine($"It's late, {name}. Good night");
            }
        }
    }
}
