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
            var (suit, cardNumber) = GetCard();
            int[,] Cards = CardArray();
            Console.WriteLine(Cards[suit, cardNumber]);


            //Console.WriteLine(suit);
            //Console.WriteLine(cardNumber);
        }

        static int[,] CardArray()
        {
            int[,] cards = new int[4,12];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    cards[i,j] = i+j*12;
                }
            }

            return cards;
        }

        static (int Suit, int cardNumber) GetCard()
        {
            Random rnd = new Random();
            int suit = rnd.Next(0,3);
            int cardNumber = rnd.Next(0,12);
            return (suit, cardNumber);
        }
    }
}
