using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Add new job ");
        Console.WriteLine("2. Display Resume ");
        Console.WriteLine("3. Quit ");
    }
    static void Main(string[] args)
    {
        Resume theresume = new Resume();
        bool keepRunnung = true;
        while (keepRunnung)
        {
            Console.Write("Enter Choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("What is the name of the company? ");
                string company = Console.ReadLine();

                Console.Write("What was your position? ");
                string position = Console.ReadLine();

                Job newjob1= new Job();
                newjob1._companyname= company;
                newjob1._jobtitle= position;
                newjob1._startyear = 2010;
                newjob1._endyear = 2019;

                theresume._jobs.Add(newjob1);

            }
            else if (choice == "2")
            {
                //DISPLAY THE RESUME
                theresume.Display();
                
            }
            else if (choice == "3")
            {
                //Quit
                keepRunnung = false;
            }
            else
            {
                // unexpected input 
                Console.WriteLine("Sorry that is invalid. try again. ");
            }
        }





        //  Job j1 = new Job();
        // j1._companyname = "LinkedIn";
        // j1._jobtitle = "Software Engineer";
        // j1._startyear = 2024; 
        // j1._endyear = 2030;

        // Job j2 = new Job();
        // j2._companyname = "Visa";
        // j2._jobtitle = "Manager";
        // j2._startyear = 2025; 
        // j2._endyear = 2032;
        

        // Resume r1 = new Resume();
        // r1._name = "John Doe";
        // r1._jobs.Add(j1);
        // r1._jobs.Add(j2);

        // r1.Display();
    }
}