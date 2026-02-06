/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
Multiplication Table Program
GitHub URL:
https://github.com/lukekloer55-prog/ClassExamples/tree/main/BetterCalculator */


using System.ComponentModel.Design;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Multiplication Table");
            Console.WriteLine("Please choose the size of the table ");
            Console.WriteLine("Do this in the format, (value x value): ");
            string tableSize = Console.ReadLine();

            if (tableSize.Contains("x"))
            {
            string[] substring = tableSize.Split('x');

                if (int.TryParse(substring[0], out int userRow) & (int.TryParse(substring[1], out int userCol)))
                {
                    Console.WriteLine($"You have chosen a {userRow}x{userCol} multiplication table.");

                }
                else
                {
                    Console.WriteLine("The inputed value is in an incorrect format.");

                }

                for (int row = 1; row <= userRow; row++)
                {
                    for (int col = 1; col <= userCol; col++)
                    {
                        int product = row * col;
                        Console.Write($"{product}".PadLeft(5));
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();

            }

            else 

                {

                Console.WriteLine("The inputed value is in an incorrect format.");

                }

        }
    }
}
