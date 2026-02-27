/*
* TODO:
* [x] Track bingo balls drawn in a two dimensional array
* [x] Display status of all balls on the console
* [x] Clear all drawn balls to start a new game
* [x] Let the user quit
* [x] Draw a random ball
* [x] get a random number to determine ball letter
* [x] get a random number to determine ball number
* [x] check if ball has already been drawn. no: mark as drawn, yes: draw another
* [ ] usability
* [ ] fix intro, wait to draw first ball
*/


using System.Data;
using System.Globalization;

namespace BingoGame
{
    internal class Program
    {
        //make this global so it can be accessed by all methods
        static bool[,] drawnCard = new bool[4, 13];
        static void Main(string[] args)
        {
            string userInput = "";
            int CardCount = 0;
            bool firstRun = true;
            string userPrompt = "";
            do
            {
                Console.Clear();
                if (CardCount < 52 && !firstRun)
                {
                    userPrompt = "Press Enter to draw a ball\n"
                    + "Press C to start a new game\n"
                    + "Press Q to quit";
                    DrawCard();
                    CardCount++;
                }
                else if (firstRun)
                {
                    userPrompt = "Press Enter to start game";
                    firstRun = false;
                }
                else
                {
                    userPrompt = "The Deck has been exhausted!\n"
                    + "Press C to start a new game\n"
                    + "Press Q to quit";
                }
                Display();
                Console.WriteLine(userPrompt);
                userInput = Console.ReadLine(); //fixed double draw
                if (userInput == "c" || userInput == "C")
                {
                    ClearDrawnBalls();
                    CardCount = 0;
                    firstRun = true;
                }
            } while (userInput != "Q" && userInput != "q");
            Console.Clear();
            Console.WriteLine("Have a nice day!");
            //pause
            Console.Read();
        }
        static void Display()
        {
            int padding = 6;
            string prettyNumber = "";
            string placeHolder = "";
            string columnSeperator = " |";
            string currentRow = "";
            string replace = "";
            //print heading row
            string[] heading = { "Ace", "Spades", "Clubs", "Hearts"};

            foreach (string thing in heading)
            {
                Console.Write(thing.PadLeft(padding) + columnSeperator);
            }
            Console.WriteLine();

            // print the rest of the rows
            for (int cardNumber = 1; cardNumber <= 13; cardNumber++)
            {
                //assemble the row
                for (int suit = 0; suit < 4; suit++)
                {
                    if (drawnCard[suit, cardNumber - 1])
                    {
                        switch (cardNumber)
                        {
                            case 1:
                                replace = "A";
                                break;
                            case 11:
                                replace = "J";
                                break;
                            case 12:
                                replace = "Q";
                                break;
                            case 13:
                                replace = "K";
                                break;
                            default:
                                replace = cardNumber.ToString();
                                break;
                        }
                        prettyNumber = replace; //offset the number by the letter column
                        currentRow += prettyNumber.ToString().PadLeft(padding) + columnSeperator;
                    }
                    else
                    {
                        currentRow += placeHolder.PadLeft(padding) + columnSeperator;
                    }
                }
                Console.WriteLine(currentRow);
                currentRow = ""; //reset 
            }
        }
        static void DrawCard()
        {
            int letter = 0, number = 0;
            do
            {
                letter = RandomNumberZeroTo(3);
                number = RandomNumberZeroTo(12);
            } while (drawnCard[letter, number]);

            drawnCard[letter, number] = true;

        }
        static void ClearDrawnBalls()
        {
            drawnCard = new bool[4, 13];
        }
        /// <summary>
        /// Get a random integer from 0 to max inclusive.
        /// </summary>
        /// <param name="max"></param>
        /// <returns>integer</returns>
        static private int RandomNumberZeroTo(int max)
        {
            int range = max + 1; //make max inclusive
            Random rand = new Random();
            return rand.Next(range);
        }

    }
}