/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
AccumulateMessage Program
GitHub URL:
https://github.com/lukekloer55-prog/ClassExamples/tree/simple/AccumulateMessage */

using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace AccumulateMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string answer = "";
            string newMessage = "";
            string oldMessage = "";
            string accumulatedMessage = "";
            // The program will ask the user to input a message, and it will accumulate the messages until the user decides to stop by entering "n".
            // Each message will be timestamped with the current date and time.

            do
            {
                string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Get the current date and time in a specific format
                Console.Clear();
                oldMessage = SaveMessage(newMessage, accumulatedMessage); // Save the new message to the old message variable
                Console.WriteLine("Write the message to be acumulated below: ");
                newMessage = Console.ReadLine(); // Read the new message from the user input
                accumulatedMessage = Environment.NewLine + AccumulateMessage(newMessage, oldMessage) + " " + dateTime + Environment.NewLine; 
                // Accumulate the new message with the old message and add a timestamp
                Console.WriteLine("Do you want to add another message? (y/n)");
                answer = Console.ReadLine();
                // If the user enters "y", the loop will continue and ask for another message.
                // If the user enters "n", the loop will end and the accumulated messages will be displayed.

            } while (answer != "n");

            Console.WriteLine(accumulatedMessage);

            Console.Read();
        }

        static string SaveMessage(string newMessage, string accumulatedMessage) 
        {
            
            string oldMessage = accumulatedMessage;
            
            return oldMessage;

            // This method takes the new message and the accumulated message as parameters, and it saves the new message to the old message variable.

        }

        static string AccumulateMessage(string newMessage, string oldMessage)
        {
            string accumulatedMessage = $"{oldMessage + " " + newMessage}";
            return accumulatedMessage;

            // This method takes the new message and the old message as parameters, and it accumulates the new message with the old message and returns the accumulated message.
        }
    }
}
