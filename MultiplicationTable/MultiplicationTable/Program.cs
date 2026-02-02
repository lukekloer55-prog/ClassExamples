using System.Runtime.Serialization.Formatters;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowLength = 12;
            int colLength = 12;


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
