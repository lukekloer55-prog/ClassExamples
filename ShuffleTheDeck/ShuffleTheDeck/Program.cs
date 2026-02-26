//Write a program that deals a card from a standard deck of 52 playing cards.
//The card should be a random suit (spades, clubs, hearts, diamonds) and value (2-10, J, Q, K, A).
//Use a multidimensional array to track if the card has already been dealt. If so, draw another random card.
//Shuffle the deck when there are no more cards left or anytime the user chooses.
//Remember to include the standard program information header in your code.

using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace ShuffleTheDeck
{
    internal class Program
    {

        static void Main(string[] args)

        {
            int[,] Cardarray = CardArray();
            GetCard();
            Console.WriteLine(Cardarray[1, 3]);
            
        }

        static int[,] CardArray()
        {
            int[,] Cardarray = new int[4, 13];
            return Cardarray;
        }

        static void GetCard()
        {
            Random rnd = new Random();
            int suit = rnd.Next(0,3);
            int cardNumber = rnd.Next(0,12);
            Console.WriteLine("Your card is: " + suit + cardNumber);
            return 
        }
    }
}
