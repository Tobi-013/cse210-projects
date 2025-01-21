using System;

class Program
{
    static void Main(string[] args)
    {
        
Random randomGenerator = new Random();
int magicNum = randomGenerator.Next(1, 100);

       
         int guess = 0;
    while (guess != magicNum)
    {
 Console.Write("What is your guess? ");
         guess = int.Parse(Console.ReadLine());

        if (guess < magicNum)
        {
            Console.WriteLine("Higher ");
        }
        else if (guess > magicNum)
        {
            Console.WriteLine("Lower ");
        }
        else
        {
            Console.WriteLine("You guessed it! ");
        }
        
    }
    }
}