using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Week2Challenge
{
    public class Greeter
    {
        public string SayHello(string name)
        {
            string greetingMessage = $"Hello {name}";
            return greetingMessage;
        }

        public string SayGoodbye(string name)
        {
            string goodbyeMessage = $"Goodbye {name}";
            return goodbyeMessage;
        }

        public string TimelyGreeting(string name)
        {
            if(DateTime.Now.Hour > 4 && DateTime.Now.Hour < 12)
            {
                string timeGreet = $"Good morning {name}";
                return timeGreet;
            }
            else if(DateTime.Now.Hour < 17)
            {
                string timeGreet = $"Good afternoon {name}";
                return timeGreet;
            }
            else if(DateTime.Now.Hour < 22)
            {
                string timeGreet = $"Good evening {name}";
                return timeGreet;
            }
            else
            {
                string timeGreet = $"It's late, {name}. Good night";
                return timeGreet;
            }
        }
    }
}
