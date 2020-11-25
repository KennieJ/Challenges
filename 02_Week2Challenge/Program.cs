using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Week2Challenge
{
    public class Program
    {

        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();
            Console.WriteLine("What is your name?:");
            
            string name = Console.ReadLine();
            string heyThere = greeter.SayHello(name);
            Console.WriteLine(heyThere);

            string farewell = greeter.SayGoodbye(name);
            Console.WriteLine(farewell);

            string timeGreet = greeter.TimelyGreeting(name);
            Console.WriteLine(timeGreet);
            Console.ReadKey();
        }
    }
}
