/*Luke Kloer
Rcet 2265
Semester 3
RCET
https://github.com/lukekloer55-prog/HelloWorld.git*/

using System.Diagnostics;

namespace SayMyName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name below.");
            string Name = Console.ReadLine();
            Console.WriteLine($"Hello {Name} it's nice to see you today!");
        }
    }
}