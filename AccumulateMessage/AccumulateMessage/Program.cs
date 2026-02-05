namespace AccumulateMessage
{
    internal class Program
    {
        static void Main(string[] args)
    
        {
            do
            {
                
               
                    do
                    {

                        Console.Clear();
                        Console.WriteLine("Press ");
                        Console.WriteLine("Enter User Input to be accumulated: ");
                        string userInput = Console.ReadLine();
                        
                    } while (Console.ReadKey().Key != ConsoleKey.Enter);
               

                static string accumulation(string userInput)
                {
                    string accumulationMessage = userInput + accumulation;
                }
                
                
                Console.WriteLine(accumulation);


                Console.ReadLine();


            } while (Console.ReadKey().Key != ConsoleKey.Enter);
        }
    }
}
