/*Luke Kloer
Rcet 2265
Semester 3
RCET
https://github.com/lukekloer55-prog/ClassExamples/tree/main/SimpleCalculator */

using System;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Net.Security;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

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
                                                            //List of Menu Options that will be displayed in the main menu.
                                                            //More menu items can be added by adding more lines here. 
            string menuList = (options[indexOption]);
            string selectedOption = ("");


            int projectIndex = (0);                         //This is the index value for the project list menu.

            List<string> projects = new List<string>();
            projects.Add("Simple Calculator Project");
            projects.Add("name holder1");
            projects.Add("name holder2");                   //This is the list of projects that will be displayed in the project list menu. 
            projects.Add("name holder3");                   //More projects can be added by adding more lines here. 
            projects.Add("Exit");

            string projectList = (projects[projectIndex]);

            string projectSelection = (projects[projectIndex]);

            //This whole area is the global variables that are used throughout the program. 
            //These variables are used to store the index values, menu options, project list and project selection.
            //They had to be global to be accessed in different areas of the program without the error saying they are not "defined in the current context."

            {

                {

                menuList:    //This is a label for the goto statement to return to the main menu.

                    Console.Clear();

                    for (int i = 0; i < options.Count; i++)
                    {

                        if (menuList == options[i])

                        {
                            Console.ForegroundColor = ConsoleColor.Black;   //This is the options list menu where intially prints the list of options with the first project highlighted.
                            Console.BackgroundColor = ConsoleColor.White;   //If this was not here nothing would appear on the screen until the user pressed up or down arrow.
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
                                indexOption = options.Count -1;
                            }
                            //Does not allow the number to go over 2 as it is not a value held by the list. Rolls over to 0
                        }
                        //increase indexOption up with up arrow


                        if (Console.ReadKey().Key == ConsoleKey.DownArrow)

                        {
                            indexOption++;

                            if (indexOption >= options.Count)
                            {
                                indexOption = 0;
                            }
                            //Does not allow the number to go under 0 causing an error. Rolls over to 2
                        }
                        //decrease indexOption down with down arrow


                        Console.Clear();


                        selectedOption = (options[indexOption]);

                        for (int i = 0; i < options.Count; i++)    //This is a for loop to print the options list menu each time the do list is recalled, it also applies the new index value.
                        {



                            if (selectedOption == options[i])

                            {
                                Console.ForegroundColor = ConsoleColor.Black;    //This is the options list menu where the user selects which option to run, the selected project is highlighted.
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


                    Console.Clear();  //Clears the console for the next menu


                    if (selectedOption == "Start")

                    {
                    projectListCall:    //This is a label for the goto statement to return to the project list menu.

                        Console.Clear();

                        for (int i = 0; i < projects.Count; i++)

                        {

                            if (projectList == projects[i])

                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;   //This is the project list menu where intially prints the list of projects with the first project highlighted.
                                Console.WriteLine(">" + (projects[i]) + "<");   //If this was not here nothing would appear on the screen until the user pressed up or down arrow.
                                Console.ResetColor();
                            }

                            else

                            {
                                Console.WriteLine(" " + (projects[i]) + " ");
                            }

                        }


                        do
                        {
                            if (Console.ReadKey().Key == ConsoleKey.UpArrow)
                            {
                                projectIndex--;

                                if (projectIndex < 0)
                                {
                                    projectIndex = projects.Count - 1;
                                }
                                        //Does not allow the number to go under the value 0 as it is not a value held by the list and will cause a compile error.
                                        //Rolls over to the projects.count which is the count of itmems in the list minus 1 as the index starts at 0.
                            }
                                    //Increase indexOption up with up arrow.


                            if (Console.ReadKey().Key == ConsoleKey.DownArrow)

                            {
                                projectIndex++;

                                if (projectIndex >= projects.Count)
                                {
                                    projectIndex = 0;
                                }
                                        //Does not allow the number to go over the index value of the item causing an error.
                                        //Rolls over to the projects.count which is the count of itmems in the list minus 1 as the index starts at 0.
                            }
                                    //Decrease indexOption down with down arrow.

                            Console.Clear();


                            projectSelection = (projects[projectIndex]);


                            for (int i = 0; i < projects.Count; i++)
                            {

                                if (projectSelection == projects[i])

                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.WriteLine(">" + (projects[i]) + "<");    //This is the project list menu where the user selects which project to run, the selected project is highlighted.
                                    Console.ResetColor();
                                }

                                else

                                {
                                    Console.WriteLine(" " + (projects[i]) + " ");    //This is the project list menu where the user selects which project to run, the selected project is highlighted.
                                }

                            }

                        } while (Console.ReadKey().Key != ConsoleKey.Enter);

                            
                            if (projectSelection == "Exit")
                            {
                            goto menuList;   //Exits to the menu selection if exit is selected from the project list menu.
                            }
                        
                        do
                        {
                            if (projectSelection == "Simple Calculator Project")   //This is the selected calculayor project from the project list menu, the code for the calculator starts here.

                                do
                                {

                                returnCalculator:

                                    Console.Clear();

                                    Console.Write("Choose a Number: ");
                                    string firstInput = Console.ReadLine();
                                    if (int.TryParse(firstInput, out int firstNumber))  //This checks if the input is a valid integer, and if so continues the program prompting for futher input.
                                    {
                                        Console.Write("Choose a Second Number: ");
                                        string secondInput = Console.ReadLine();

                                        if (int.TryParse(secondInput, out int secondNumber))
                                        {

                                            Console.WriteLine("Choose an operator:");
                                            Console.WriteLine("1. Additiion + ");
                                            Console.WriteLine("2. Subtraction - ");
                                            Console.WriteLine("3. Multiplication * ");          //This is the printed list of operations the user can select from
                                            Console.WriteLine("4. Division / ");
                                            Console.Write("Number of the operator: ");

                                            string operatorChoice = Console.ReadLine();
                                            int operatorNumber = 0;

                                            if (int.TryParse(operatorChoice, out operatorNumber))
                                            {
                                                switch (operatorChoice)
                                                {
                                                    default:
                                                        Console.WriteLine("Invalid Operator Error");
                                                        break;

                                                    case "1":
                                                        Console.WriteLine($"Result: " + (firstNumber + secondNumber));
                                                        break;
                                                    case "2":
                                                        Console.WriteLine($"Result: " + (firstNumber - secondNumber));
                                                        break;
                                                    case "3":
                                                        Console.WriteLine($"Result: " + (firstNumber * secondNumber));
                                                        break;
                                                    case "4":
                                                        Console.WriteLine($"Result: " + (firstNumber / secondNumber));  
                                                        break;

                                                        //This is an array of operations the user can select from, the user inputs the number of the operation they want to perform.
                                                }
                                            }
                                        }

                                    }


                                    else
                                    {
                                        Console.WriteLine("InvalidInput");
                                    }

                                    Console.WriteLine();

                                    Console.WriteLine("Press X to exit to project menu or any other key to continue"); //Prompt to exit or continue

                                    ConsoleKeyInfo exitCalculator = Console.ReadKey();


                                    if (exitCalculator.Key == ConsoleKey.X)

                                    {
                                        selectedOption = "Exit";

                                        if (selectedOption == "Exit")

                                        {
                                            goto projectListCall;    //This is a goto statement to return to the project list menu, allows the user to return to the project list without exiting the program.

                                        }
                                    }

                                    else
                                    {
                                        goto returnCalculator;    //This is a goto statement to return to the calculator start without exiting the program.
                                    }



                                } while (Console.ReadKey().Key != ConsoleKey.Enter);


                        } while (Console.ReadKey().Key != ConsoleKey.Enter);


                        if (selectedOption == "Exit")

                        {
                          Environment.Exit(0);
                        }

                    }
                }
            }
        }
    }
}