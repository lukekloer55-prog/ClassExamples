/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
Better Calculator Program
GitHub URL:
https://github.com/lukekloer55-prog/ClassExamples/tree/main/BetterCalculator */

using System;
using static System.Net.Mime.MediaTypeNames;

namespace BetterCalculator
{
    public class BetterCalculator
    {
        static void Main(string[] args)

        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        
            returnCalculator:
               

                Console.Clear();

                Console.WriteLine("Welcome to Better Calculator, Enter Q at any time to exit the program.");
                Console.WriteLine();        
                Console.Write("Choose a First Number: ");           //This prompts the user to input the first number as well as instructions to exit the program by pressing Q.

            string firstInput = Console.ReadLine();

                if (firstInput == "q")

                {
                    Environment.Exit(0);     //This exits the program if the user presses Q.
                }

                else if (double.TryParse(firstInput, out double firstNumber))       //This checks if the input is a valid integer, and if so continues the program prompting for futher input.
                {
                    Console.Write("Choose a Second Number: ");

                    string secondInput = Console.ReadLine();

                    if (secondInput == "q")

                    {
                        Environment.Exit(0);    //This exits the program if the user presses Q.
                    }

                    else if (double.TryParse(secondInput, out double secondNumber))
                    {

                        Console.WriteLine("Choose an operator:");
                        Console.WriteLine("1. Additiion + ");
                        Console.WriteLine("2. Subtraction - ");
                        Console.WriteLine("3. Multiplication * ");          //This is the printed list of operations the user can select from
                        Console.WriteLine("4. Division / ");
                        Console.Write("Number of the operator: ");

                        string operatorChoice = Console.ReadLine();
                        
                        int operatorNumber = 0;

                        if (operatorChoice == "q")

                        {
                            Environment.Exit(0);    //This exits the program if the user presses Q.
                        }

                        else if (int.TryParse(operatorChoice, out operatorNumber))
                        {
                            switch (operatorChoice)
                            {

                                default:
                                    Console.WriteLine("Invalid Operator Error");
                                    break;
                                case "1":
                                    Console.WriteLine($"Result: " + (firstNumber + secondNumber));
                                    break;
                                case "2":
                                    Console.WriteLine($"Result: " + (firstNumber - secondNumber));
                                    break;
                                case "3":  
                                    Console.WriteLine($"Result: " + (firstNumber * secondNumber));
                                    break;
                                case "4":
                                    Console.WriteLine($"Result: " + (firstNumber / secondNumber));
                                    break;

                                            //This is an array of operations the user can select from, the user inputs the number of the operation they want to perform.
                            }
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("InvalidInput, please try again!");   //This is the error message if the user inputs an invalid operator number.
                    }

                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("InvalidInput, please try again!");   //This is the error message if the user inputs an invalid second number.
                }

                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("InvalidInput, please try again!");   //This is the error message if the user inputs an invalid first number.
            }

                Console.WriteLine();

                Console.WriteLine("Press Q to exit, or any other key to continue");     //Prompt to exit or continue

                ConsoleKeyInfo exitCalculator = Console.ReadKey();

                if (exitCalculator.Key == ConsoleKey.Q)

                {
                    Environment.Exit(0);    //This exits the program if the user presses Q.
                }

                else
                {
                    goto returnCalculator;       //This is a goto statement to return to the calculator start without exiting the program.
                } 
        }
    }
}
