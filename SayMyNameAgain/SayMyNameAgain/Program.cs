/*Luke Kloer
Rcet 2265
Semester 3
RCET
https://github.com/lukekloer55-prog/ClassExamples/tree/main/SayMyNameAgain */

namespace SayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            returnsaymyName:

            do
            {
                Console.Clear();
                Console.Write("Please enter your name: ");
                string userName = Console.ReadLine();

                const String Emily = "Emily";
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

            Console.WriteLine("Press Q to exit, or any other key to continue");     //Prompt to exit or continue

            ConsoleKeyInfo exitCalculator = Console.ReadKey();

            if (exitCalculator.Key == ConsoleKey.Q)

            {
                Environment.Exit(0);        //This exits the program if the user presses Q.
            }

            else
            {
                goto returnsaymyName;       //This is a goto statement to return to the calculator start without exiting the program.
            }

        }
    }
}
