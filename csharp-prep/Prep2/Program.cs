using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int x = int.Parse(percentage);
        string letter = "";
        if(x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if ( x >= 70)
        {
            letter = "C";
        }
        else if ( x >= 60)
        {
            letter = "D";
        }
        else if ( x < 60)
        {
           letter = "F";
        }
        if (x>=70)
        {
            Console.WriteLine($"Your grade is, {letter}");
            Console.Write("Congratulations you passed!");
        }
        else 
        {   Console.WriteLine($"Your grade is, {letter}");
            Console.Write("You Failed, Try again next time.");
        }

    }
}