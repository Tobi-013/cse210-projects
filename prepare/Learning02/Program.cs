using System;

class Program
{
    static void Main(string[] args)
    {
         Job j1 = new Job();
        j1._companyname = "LinkedIn";
        j1._jobtitle = "Software Engineer";
        j1._startyear = 2024; 
        j1._endyear = 2030;

        Job j2 = new Job();
        j2._companyname = "Visa";
        j2._jobtitle = "Manager";
        j2._startyear = 2025; 
        j2._endyear = 2032;
        

        Resume r1 = new Resume();
        r1._name = "John Doe";
        r1._jobs.Add(j1);
        r1._jobs.Add(j2);

        r1.Display();
    }
}