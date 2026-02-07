/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
Fortune Cookie Program
GitHub URL:
https://github.com/lukekloer55-prog/ClassExamples/tree/simple/FortuneCookie */


using System.ComponentModel;
using System.Security.Cryptography;

namespace FortuneCookie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the fortune cookie simulator!!");
            Console.WriteLine("Here is your fortune!!");
            // Create a list of fortunes
            List<string> fortunes = new List<string>();
            {
                fortunes.Add("You will have a great day!");
                fortunes.Add("Success is on the horizon.");
                fortunes.Add("Happiness is a choice.");
                fortunes.Add("Adventure awaits you.");
                fortunes.Add("Believe in yourself.");
                fortunes.Add("Something wonderful is about to happen.");
                fortunes.Add("You will make a new friend soon.");
                fortunes.Add("A thrilling time is in your immediate future.");
                fortunes.Add("Your creativity will lead you to success.");
            }

            Random rnd = new Random();
            // Generate a random index to select a fortune
            int randomFortune = rnd.Next(0, 9);
            // Display the selected fortune
            Console.WriteLine(fortunes[randomFortune]);
            // Wait for user input before closing the console
            Console.Read();
        }        
    }
}
