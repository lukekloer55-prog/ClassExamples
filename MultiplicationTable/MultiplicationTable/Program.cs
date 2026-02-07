/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
Multiplication Table Program
GitHub URL:
https://github.com/lukekloer55-prog/ClassExamples/tree/simple/MultiplicationTable */


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
            // This program will create a multiplication table based on the size the user inputs. The user will input the size in the format of (value x value).
            // The program will then split the input into two values and use those values to create a multiplication table.
            // If the user inputs an incorrect format, the program will display an error message.

            Console.WriteLine("Multiplication Table");
            Console.WriteLine("Please choose the size of the table ");
            Console.WriteLine("Do this in the format, (value x value): ");
            string tableSize = Console.ReadLine();

            // The program will check if the input contains the character "x" to ensure it is in the correct format.
            // If it does, it will split the input into two values and attempt to parse them as integers. If the parsing is successful, it will create a multiplication table based on those values.
            // If the parsing fails or if the input does not contain "x", it will display an error message.

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

                // This is the parsing of the two values, if parsing is succesful those inputs will be used.
                // If parsing fails, the program will display an error message.

                for (int row = 1; row <= userRow; row++)
                {
                    for (int col = 1; col <= userCol; col++)
                    {
                        int product = row * col;
                        Console.Write($"{product}".PadLeft(5));
                    }
                    Console.WriteLine();
                }
                // This is the creation of the multiplication table,
                // it uses nested for loops to iterate through the rows and columns and calculate the product of the current row and column.
                // The product is then printed with padding for alignment.

                Console.ReadLine();
            }

            else 

                {

                Console.WriteLine("The inputed value is in an incorrect format.");

                }
            // This is the error message that will be displayed if the input does not contain "x".
        }
    }
}
