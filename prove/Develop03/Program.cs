using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureRef = new Reference("Proverbs", 3, 5, 3, 6);
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";

        Scripture scripture = new Scripture(scriptureRef, scriptureText);

        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture();
            
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Well done!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(2); 
        }
    }
}