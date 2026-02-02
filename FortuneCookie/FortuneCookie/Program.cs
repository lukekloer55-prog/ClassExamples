using System.ComponentModel;
using System.Security.Cryptography;

namespace FortuneCookie
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            int randomFortune = rnd.Next(0, 9);

            Console.WriteLine(fortunes[randomFortune]);
        }        
    }
}
