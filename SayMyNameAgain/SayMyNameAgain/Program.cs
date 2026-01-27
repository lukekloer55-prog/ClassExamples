/*Luke Kloer
Rcet 2265
Semester 3
RCET
https://github.com/lukekloer55-prog/HelloWorld.git*/

namespace SayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Please enter your name: ");
                string userName = Console.ReadLine();
                const string Emily = "Emily";
                const String Joe = "Joe";
                const String Luke = "Luke";
                const String Tim = "Tim";
                switch (userName)
                {

                    case Emily:
                        Console.WriteLine("Hello, Emily how are you?");
                        break;

                    case Joe:
                        Console.WriteLine("Hello, Joe how are you?");
                        break;

                    case Luke:
                        Console.WriteLine("What is up gangsta!!");
                        break;

                    case Tim:
                        Console.WriteLine("Hey Tim, my fellow vim yanker.");
                        break;

                    default:
                        Console.WriteLine("Your name is very generic sorry! ;(");
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Enter);

        }
    }
}
