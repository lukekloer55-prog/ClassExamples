using System.ComponentModel.Design;
using System.Dynamic;
using System.Net.Security;

namespace SimpleCalculator
{
    internal class Program
    {
 

        public static void Main(string[] args)

        {

            int indexOption = (0);

            List<string> options = new List<string>();
            options.Add("Start");
            options.Add("Exit");
            options.Add("Beep Song");
            //List of Menu Options

            string menuSelection = (options[indexOption]);



            for (int i = 0; i < 3; i++)
             {

                if (menuSelection == options[i])

                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(">" + (options[i]) + "<");
                    Console.ResetColor();
                }

                else

                {
                    Console.WriteLine(" " + (options[i]) + " ");
                }
            }

                do
            {
                    


                    if (Console.ReadKey().Key == ConsoleKey.UpArrow)
                        {
                            indexOption--;

                            if (indexOption < 0)

                            {
                                indexOption = 2;
                            }
                            //Does not allow the number to go over 2 as it is not a value held by the list. Rolls over to 0
                        }
                        //increase indexOption up with up arrow


                        if (Console.ReadKey().Key == ConsoleKey.DownArrow)

                        {
                            indexOption++;

                            if (indexOption > 2)
                            {
                                indexOption = 0;
                            }
                            //Does not allow the number to go under 0 causing an error. Rolls over to 2
                        }
                        //decrease indexOption down with down arrow

                        string option1 = ((options[0]));
                        string option2 = ((options[1]));
                        string option3 = ((options[2]));

                        Console.Clear();

                        string selectedOption = ((options[indexOption]));
                
                        for (int i = 0; i < 3; i++)
                        {

                  

                        if (selectedOption == options[i])

                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.WriteLine(">" + (options[i]) + "<");
                                Console.ResetColor();
                            }

                            else

                            {
                                Console.WriteLine(" " + (options[i]) + " ");
                            }

                        }

             } while (Console.ReadKey().Key != ConsoleKey.Enter);
            //This is the user menu selection for the front page options : Start and Stop

            Console.Clear();
            Console.WriteLine(menuSelection);
            Console.Read();

        }

    }

}