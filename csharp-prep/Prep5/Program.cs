using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
         DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favourite number? ");
        int FavNum = int.Parse(Console.ReadLine());

        return FavNum;
    }

    static int SquareNumber(int FavNum)
    {
        int square = FavNum * FavNum;

         return square;
    }
    static void DisplayResult(string name,int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}   