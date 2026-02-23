/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
RollTheDice
GitHub URL:
https://github.com/lukekloer55-prog/ClassExamples/tree/simple/RollTheDice */


using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;

namespace RollTheDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roll of the Dice");
            Console.WriteLine("________________________________________");
            Console.WriteLine();
            Console.WriteLine("Number of faces: ");
            Console.WriteLine("________________________________________");
            for (int j = 0; j < 6; j++)
            {
                   
                int[] diceoptions = { 1, 2, 3, 4, 5, 6 };

                Console.Write(diceoptions[j].ToString().PadLeft(6));
                //Writes the numbers 1-6 to represent the faces of the die. 
            }

            Console.WriteLine();
            Console.WriteLine("________________________________________");
            Console.WriteLine();
            Console.WriteLine("Resulting Counts:");
            Console.WriteLine("________________________________________");

            Console.WriteLine();

            int[] rollCount = new int [7];
            int[] rollCount2 = new int [7];// Initializes two integer arrays to count the occurrences of each face for both dice.

            for (int i = 1; i <= 1000; i++)
            {
                var (dice1, dice2) = RollTheDice();

                rollCount [dice1]++;    

                rollCount [dice2]++;
                // Calls the RollTheDice method 1000 times and counts the occurrences of each face for both dice.
            }

            for (int j = 1; j < 7; j++)
            {
                Console.Write(rollCount[j].ToString().PadLeft(6));              
                // Writes the count of occurrences for each face of the die, formatted to align with the numbers above.
            }

            Console.WriteLine();

            Console.WriteLine("________________________________________");

        }

        static (int diceroll1, int diceroll2) RollTheDice()
        {

                Random random = new Random();
                int diceRoll = random.Next(1, 7);  // Simulate rolling a six-sided die
                int diceRoll2 = random.Next(1, 7); // Simulate rolling another six-sided die
                                                   // Return the results as a tuple
                                                   // A tuple is a way to hold and use multiple outputs within a class, instead of using out methods. 
                                                   // It can be found microsoft documentation online. 
            return (diceRoll, diceRoll2);
        }
    }
}
