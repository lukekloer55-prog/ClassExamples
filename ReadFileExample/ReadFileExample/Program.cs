namespace ReadFileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "..\\..\\..\\email.txt";
            string[,] customerInfo;
            customerInfo = FileToArray(path);
            DisplayData(customerInfo);
            Console.Read();
        }

        static string[,] FileToArray(string filePath)
        {
            string[,] customerData = new string[4, CountOfLinesIn(filePath)];
            string[] temp;
            int counter = 0;

            using (StreamReader testFile = new StreamReader(filePath))

            {
                do
                {
                    temp = testFile.ReadLine().Split(",");
                    if (temp.Length == 5) //This is to prevent an out of bounds error if there are less than 5 columns in the data.
                    {

                        temp[0] = temp[0].Replace("\"$$", ""); //This removes the dirty data from the first column.
                        temp[3] = temp[3].Replace("\"", ""); //This removes the dirty data from the email list column.
                        customerData[0, counter] = temp[0];
                        customerData[1, counter] = temp[1];
                        customerData[2, counter] = temp[2];
                        customerData[3, counter] = temp[3];
                    }
                    counter++;
                } while (!testFile.EndOfStream);
            }
            return customerData;
        }

        static int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    testFile.ReadLine();
                    count++;
                } while (!testFile.EndOfStream);
            }
            return count;
        }

        static void DisplayData(string[,] data)
        { 
            string formattedRow = "";


            for (int row = 0; row < data.GetLength(1); row++)
            {
                formattedRow = "";

                for (int column = 0; column < data.GetLength(0); column++)
                {
                    if (data[column, row] != null) //This is to prevent a null reference exception if there are less than 5 columns in the data.
                    {
                        formattedRow += (data[column, row].PadRight(25));
                    }
                }
                if (formattedRow != "") //This is to prevent printing empty rows if there are less than 5 columns in the data.
                {
                    Console.WriteLine(formattedRow);
                }
            }
            return; 
        }

    }
}
