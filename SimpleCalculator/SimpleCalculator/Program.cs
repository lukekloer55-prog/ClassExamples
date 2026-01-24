using System.ComponentModel.Design;
using System.Net.Security;

namespace SimpleCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
               String prompt = "Menu";
               do
               {
                   Console.Write("Choose A Number: ");
            int Firstnumber = Console.Read();
            Console.Write("Choose Another Number: "); 
            int Secondnumber = Console.Read();
            Console.WriteLine("Choose one of the following operations:");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Product");
            Console.WriteLine("3. Diffrence");
            Console.WriteLine("4. Qoutient");
            int ChosenOperation = Console.Read();


               } while (Console.ReadKey().Key != ConsoleKey.Escape);

            /*
                        bool Ent = (Console.ReadKey().Key == ConsoleKey.Enter);


                        do
                        {

                            Console.Write("Choose A Number: ");
                            int Firstnumber = Console.Read();


                            if (Ent == true)
                            {
                                Console.Write("Choose Another Number: ");
                                int Secondnumber = Console.Read();
                                Console.Clear();
                            }
                            else 
                            {
                                Console.WriteLine("Choose one of the following operations:");
                                Console.WriteLine("1. Sum");
                                Console.WriteLine("2. Product");
                                Console.WriteLine("3. Diffrence");
                                Console.WriteLine("4. Qoutient");
                                int ChosenOperation = Console.Read();
                                Console.Clear();

                            } 
                        } while (Console.ReadKey().Key != ConsoleKey.Escape); 
                        */




            //List<string> options = new List<string> { "start", "stop" };
            //Console.WriteLine("start");
            //Console.Read();


            //Console.WriteLine("Please Enter some information below!!");

            //string userinput = Console.ReadLine();

            //Console.WriteLine($"You entered \"{userinput}\" ");

            //Console.WriteLine($"You entered: " + "\"" + userinput + "\" ");

            //Console.Read();


            List<string> options = new List<string>();
            options.Add("Start");
            options.Add("Exit");
            options.Add("Beep Song");

            
            //List of Menu Options

            int indexOption = (0);

            string optionSelected = (options[indexOption]);

            

            do
            {

                bool cursorUp = Console.ReadKey().Key == ConsoleKey.UpArrow;

                bool cursorDown = Console.ReadKey().Key == ConsoleKey.DownArrow;

                if (cursorUp == true)
                {   
                    indexOption++;

                    if (indexOption > 2)
                    {
                        indexOption = 0;
                    }
                    //Does not allow the number to go over 2 as it is not a value held by the list. Rolls over to 0
                }
                //increase indexOption up with up arrow
                if (cursorDown == true)
                    
                {
                    indexOption--;

                    if (indexOption < 0)
                    {
                        indexOption = 2;
                    }
                    //Does not allow the number to go under 0 causing an error. Rolls over to 2
                }
                //decrease indexOption down with down arrow


                Console.WriteLine(indexOption);

                Console.Clear();

                string selectedOption = ((options[indexOption]));

                if (options)
                Console.WriteLine((options[0]));
                Console.WriteLine((options[1]));
                Console.WriteLine((options[2]));

                Console.WriteLine(selectedOption);




            }
            while (Console.ReadKey().Key != ConsoleKey.Enter);


            /*  Console.WriteLine("Choose the menu option");
                 
                string input = Console.ReadLine();

                 if (int.TryParse(input, out int indexOption))
                
                //Converts typed input into a int value

                 {

                     {
                           if
                           (indexOption <= 3)
                           {
                               Console.WriteLine("The Menu Option Selected is: " + (options[indexOption]));
                           }

                           //if indexoption is less than list total count then write the menu selection

                           else

                           {
                               Console.WriteLine("The Index option is out of range!!");
                               Console.ReadLine();
                           }
                      */

       }
    }
}