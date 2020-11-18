using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_ThursdayChallenge
{
    [TestClass]
    public class ThursChal
    {
        [TestMethod]
        public void SuperCal()
        {
            string longWord = "Supercalifragilisticexpialidocious";
            int letterCount = longWord.Length;

            foreach (char letter in longWord)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else if (letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i or an L");
                }
                
            }

            Console.WriteLine(letterCount);
        }

        [TestMethod]
        public void Variables()
        {
            string firstName = "Kendra";
            string lastName = "Joseph";
            int myAge = 32;

            string[] holidayMovies = { "Nightmare Before Christmas", "A Muppet Christmas Carol", "How the Grinch Stole Christmas", "8 Crazy Nights" };
            DateTime now = DateTime.Now;
            DateTime birthDate = new DateTime(1988, 9, 16);
            List<DateTime> listOfDates = new List<DateTime>();
            listOfDates.Add(now);
            listOfDates.Add(birthDate);
            
            foreach (DateTime date in listOfDates)
            {
                Console.WriteLine(date);
            }
        }

        [TestMethod]
        public void Operators()
        {
            int myAge = 32;

            int sum = myAge + 7;
            int diff = myAge - 7;
            int prod = myAge * 7;
            int quot = myAge / 7;
            int remain = myAge % 7;

            Console.WriteLine(sum);
            Console.WriteLine(diff);
            Console.WriteLine(prod);
            Console.WriteLine(quot);
            Console.WriteLine(remain);
        }

        [TestMethod]
        public void Sleep()
        {
            Console.WriteLine("How many hours of sleep did you get?");
            int sleepHours = 2;

            if (sleepHours >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (sleepHours >= 8)
            {
                Console.WriteLine("You should be pretty rested.");
            }
            else if (sleepHours >= 4)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
        }

        [TestMethod]
        public void HowYouDoin()
        {
            string mood = ":("; //assign an int to inputs to reduce user
            switch (mood)
            {
                case "Great":
                    Console.WriteLine("That's fantastic!");
                    break;
                case "Good":
                    Console.WriteLine("Glad to hear that");
                    break;
                case "Okay":
                    Console.WriteLine("I feel you");
                    break;
                case "Bad":
                    Console.WriteLine("Oh no! What happened?");
                    break;
                case ":(":
                    Console.WriteLine(":c");
                    break;
                default:
                    Console.WriteLine("I don't understand. Try typing 'Great', 'Good', 'Okay', 'Bad', or ':('");
                    break;
            }
        }
    }
}
