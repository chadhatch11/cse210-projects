using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Start the Breathing Activity");
            Console.WriteLine(" 2. Start the Reflecting Activity");
            Console.WriteLine(" 3. Start the Listing Activity");
            Console.WriteLine(" 4. Quit");  
            Console.Write("\nSelect a choice from the menu: ");
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 4)
            {
                Console.WriteLine("");
                Environment.Exit(0);
            }

            Console.WriteLine("");
            Console.Write("How many seconds would you like your session to be? ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Activity activity = null;

            switch (menuChoice)
            {
                case 1:
                    activity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing", duration);
                    break;
                case 2:
                    activity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration);
                    break;
                case 3:
                    activity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 - 4");
                    break;
            } 

            activity?.Run(); 
        }
    }
}
