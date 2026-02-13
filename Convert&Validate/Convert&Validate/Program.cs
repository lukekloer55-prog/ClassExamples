using Microsoft.VisualBasic;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Convert_Validate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Take two arguments: a string value to be converted, and an out integer variable to store the result.
            //Return a boolean indicating if the conversion was successful.
            //If successful, update the out integer variable with the converted value.
            //If not, do not update the integer variable.


            Console.WriteLine("Please enter an integer: ");

            string input = Console.ReadLine();

            ConvertToInt(input, out int result, out bool success);
            
        
        }
        static bool ConvertToInt(string input, out int result ,out bool success )
        {
            success = true;

            try { result = Convert.ToInt32(input); }

            catch { result = 0; success = false; }

            return success;
        }
    }
}
