using System;


namespace Projects2026Library
{
    public class SimpleCalculator
    {
         public static void Run()
        {
        
            do
            {
            returnCalculator:

                Console.Clear();

                Console.Write("Choose a Number: ");
                string firstInput = Console.ReadLine();
                if (int.TryParse(firstInput, out int firstNumber))
                {
                    Console.Write("Choose a Second Number: ");
                    string secondInput = Console.ReadLine();

                    if (int.TryParse(secondInput, out int secondNumber))
                    {
                        Console.WriteLine("Choose an operator:");
                        Console.WriteLine("1. Additiion + ");
                        Console.WriteLine("2. Subtraction - ");
                        Console.WriteLine("3. Multiplication * ");
                        Console.WriteLine("4. Division / ");
                        Console.Write("Number of the operator: ");

                        string operatorChoice = Console.ReadLine();
                        int operatorNumber = 0;

                        if (int.TryParse(operatorChoice, out operatorNumber))
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
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("InvalidInput");
                }

                Console.WriteLine();
                Console.WriteLine("Press X to exit to project menu or any other key to continue");

                ConsoleKeyInfo exitCalculator = Console.ReadKey();

               

            } while (true);
        }
    }
}
