using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;

namespace RollTheDice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int j = 0; j < 6; j++)
            {
                   
                int[] diceoptions = { 1, 2, 3, 4, 5, 6 };

                Console.Write(diceoptions[j].ToString().PadLeft(6));
      
            }

            Console.WriteLine();
            int[] rollCount = new int [7];
            int[] rollCount2 = new int [7];

            for (int i = 1; i <= 1000; i++)
            {
                var (dice1, dice2) = RollTheDice();

                rollCount [dice1]++;    

                rollCount [dice2]++;
               
            }

            for (int j = 1; j < 7; j++)
            {
                Console.Write(rollCount[j].ToString().PadLeft(6));
            }

        }

        static (int diceroll1, int diceroll2) RollTheDice()
        {

                Random random = new Random();
                int diceRoll = random.Next(1, 7); // Simulate rolling a six-sided die
                int diceRoll2 = random.Next(1, 7); // Simulate rolling another six-sided die
            
            return (diceRoll, diceRoll2);
        }
    }
}
