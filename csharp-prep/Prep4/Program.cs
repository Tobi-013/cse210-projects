using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int number = -1;
        List<int> ListOfNumbers = new List<int>();
    while  (number != 0)
    {
        Console.WriteLine("Enter number: ");
        string x = Console.ReadLine(); 
        number = int.Parse(x);

        ListOfNumbers.Add(number);

    }
    int sum = 0 ;
     int largestNum = ListOfNumbers[0];
    foreach (int num in ListOfNumbers)
    {
        if(num > largestNum)
    {
        largestNum = num;
    } 
        sum += num;
    }
    int length =ListOfNumbers.Count;
        float average = sum/length;

    Console.WriteLine($"The sum is: {sum}");
    Console.WriteLine($"The average is: {average}");
    Console.WriteLine($"The largest number: {largestNum}");
     
    }
        
}