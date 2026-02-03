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
           

            int rowLength = 12;
            int colLength = 5;


            for (int row =1; row <= rowLength; row++)
            {
                for (int col = 1; col <= colLength; col++)
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
