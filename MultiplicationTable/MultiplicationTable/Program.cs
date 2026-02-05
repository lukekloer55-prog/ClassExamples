using System.ComponentModel.Design;
using System.Runtime.Serialization.Formatters;
using System.Text.RegularExpressions;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Multiplication Table");
            Console.WriteLine("Please choose the size of the table (e.g., 12x12 for a 12x12 table): ");
            Console.WriteLine("Do this in the format, (value x value)");
            string tableSize = Console.ReadLine();
            string[] substring = tableSize.Split('x');



            if (int.TryParse(substring[0], out int userRow) & (int.TryParse(substring[1], out int userCol))) 
            {
                Console.WriteLine($"You have chosen a {userRow}x{userCol} multiplication table.");
            }
            else
            {
                Console.WriteLine("The inputed value is in an incorrect format.");
            }
 
            for (int row =1; row <= userRow; row++)
            {
                for (int col = 1; col <= userCol; col++)
                {
                    int product = row * col;
                    Console.Write($"{product,4}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
