/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
ShuffleTheDeck Program
GitHub URL:
https://github.com/lukekloer55-prog/ClassExamples/tree/simple/Convert%26Validate */

using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace ShuffleTheDeck
{
    internal class Program
    {

        static bool[,] drawnCard = new bool[4, 13];
        //This is a 2D array that tracks if a card has been drawn. The first dimension is the suit, the second is the card number.
        //It tracks it by setting the value to true when a card is drawn. So if drawnCard[0,0] is true, it means the Ace of Spades has been drawn.
        //This allows us to easily check if a card has already been drawn by checking the corresponding value in the array.

        static void Main(string[] args)
        { 
        string userInput = "";
        int CardCount = 0;
        bool firstRun = true;
        string userPrompt = "";
        //Global Values

            do
            {
                Console.Clear();
                if (CardCount< 52 && !firstRun)
                {
                    userPrompt = "Press Enter to draw a ball\n"
                    + "Press C to start a new game\n"
                    + "Press Q to quit";
                    DrawCard();
                    CardCount++;
            //If the user has drawn less than 52 cards and it's not the first run, prompt them to draw a card, start a new game, or quit.
            //Then draw a card and increment the card count.
            }

            else if (firstRun)
                {
                    userPrompt = "Press Enter to start game";
                    firstRun = false;
                    //If it's the first run, prompt the user to start the game. Then set firstRun to false so that this block is not executed again.
                }

            else
                {
                    userPrompt = "The Deck has been exhausted!\n"
                    + "Press C to start a new game\n"
                    + "Press Q to quit";
                    //If the user has drawn 52 cards, prompt them to start a new game or quit.
                }

                Display();
                Console.WriteLine(userPrompt);
                userInput = Console.ReadLine(); 

                if (userInput == "c" || userInput == "C")
                {
                    ClearDrawnBalls();
                    CardCount = 0;
                    firstRun = true;
                    //If the user chooses to start a new game, clear the drawn cards, reset the card count, and set firstRun to true so that the user is prompted to start the game again.
                }

            } while (userInput != "Q" && userInput != "q") ;

            Console.Clear();
            Console.WriteLine("Have a nice day!");
            Console.Read();
            //Press Q to quit the game, then clear the console and display a goodbye message.
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

        string[] heading = { "Ace", "Spades", "Clubs", "Hearts" };

        foreach (string thing in heading)
        {
            Console.Write(thing.PadLeft(padding) + columnSeperator);
        }
        Console.WriteLine();

        // print the rest of the rows
        for (int cardNumber = 1; cardNumber <= 13; cardNumber++)
        {
            //Loop through each card number and suit, checking if the card has been drawn. If it hasn't, add the card number to the row.
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

                    //Switch statement to replace the numbers with their corresponding face card letters.

                    prettyNumber = replace; //This is the value that will be printed in the row. It is either the card number or the face card letter, depending on the card number.
                    currentRow += prettyNumber.ToString().PadLeft(padding) + columnSeperator; 
                }

                else
                {
                    currentRow += placeHolder.PadLeft(padding) + columnSeperator;
                }
                //if the card has been drawn, add the card number to the row, otherwise add a blank space
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
            //Keep generating random numbers for the suit and card number until we find a card that hasn't been drawn. Then mark that card as drawn in the array.
            //It does this by checking the corresponding value in the drawnCard array.
            //If it's true, it means the card has already been drawn, so we keep generating new random numbers until we find a card that hasn't been drawn.
        }
        static void ClearDrawnBalls()
        {
            drawnCard = new bool[4, 13];
        }

        static private int RandomNumberZeroTo(int max)
        {
            int range = max + 1; //make max inclusive
            Random rand = new Random();
            return rand.Next(range);
            //This method generates a random number between 0 and the specified max value (inclusive).
            //Inclusive just means that the max value can be represented in the output.
            //As typically with the random generator, the max value is -1 of the range, so we add 1 to make it inclusive.
        }
    }
}
