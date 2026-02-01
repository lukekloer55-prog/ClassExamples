/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
SayMyNameAgain Program
GitHub URL:
https://github.com/lukekloer55-prog/ClassExamples/tree/main/SayMyNameAgain */

namespace SayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //The program will ask the user for their name and respond with a unique message for certain names.
            //It does this using a switch statement to compare the input against constants for each name.
            //If the name is not one of the constants it will respond with a generic message.


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Sets the console colors

         returnsaymyName: //Refrence point for goto statement

            do
            {
                Console.Clear();
                Console.Write("Please enter your name: ");
                string userName = Console.ReadLine();

                const String Emily = "Emily";
                const String Joe = "Joe";   
                const String Luke = "Luke";
                const String Tim = "Tim";
                //Constants for the names to be compared against

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
                        //Case statements for each name constant and a default for anything else.
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
