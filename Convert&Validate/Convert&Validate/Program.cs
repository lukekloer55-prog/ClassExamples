/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
Multiplication Table Program
GitHub URL:
https://github.com/lukekloer55-prog/ClassExamples/tree/simple/MultiplicationTable */

using Microsoft.VisualBasic;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Convert_Validate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter an integer: ");

            string input = Console.ReadLine();

            ConvertToInt(input, out int result, out bool success);
            // Validate the conversion result
        }
        static bool ConvertToInt(string input, out int result ,out bool success )
        {
            success = true;

            try { result = Convert.ToInt32(input); }

            catch { result = 0; success = false; }

            return success;
            // The method attempts to convert the input string to an integer. If the conversion is successful, it returns true and sets the result variable to the converted integer.
            // If the conversion fails, it catches the exception and returns false to indicate that the conversion was unsuccessful.
        }
    }
}
