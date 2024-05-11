using System;

namespace ScriptureMemorizingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Scripture Memorizing Program!");
            Reference reference = new Reference("John", 3, 16);

            Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
            Console.WriteLine(scripture.GetDisplayText());

            while (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                scripture.HideRandomWords(2);
                Console.WriteLine(scripture.GetDisplayText());
            }

            Console.WriteLine("Program ended. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
