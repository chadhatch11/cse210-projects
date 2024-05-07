using System;

public class Program
{
    static void Main(string[] args)
    {
        int userOption = 0;        
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        while(userOption != 5)
        {
            Console.WriteLine("");
            Console.WriteLine("Choose one of the following options for your Journal:");
            Console.WriteLine("");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine(" ");
            Console.Write("What would you like to do? Please choose a number 1 - 5");
            Console.WriteLine("");
            userOption = int.Parse(Console.ReadLine());
            if (userOption == 1)
            {
                string randomPrompt = promptGenerator.Display();
                Console.Write("Your Response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                journal.AddEntry(new Entry(randomPrompt, response, date));
            }
            else if (userOption == 2)
            {
                journal.Display();             
            }
            else if (userOption == 3)
            {
                Console.Write("Enter the filename: ");                 
                string filename = Console.ReadLine();
                journal.Save(filename);             
            }
            else if (userOption == 4)
            {
                Console.Write("Enter the filename: ");                 
                string filename = Console.ReadLine();                 
                journal.Load(filename);             
            }
            else if (userOption == 5)
            {                
                break;             
            }
            else
            {
                Console.WriteLine("Input is invalid. Please insert a number from 1 - 5");
            }
        }
    }
}
