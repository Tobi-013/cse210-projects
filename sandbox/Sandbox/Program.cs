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

        

        j1.Display();
    }
}