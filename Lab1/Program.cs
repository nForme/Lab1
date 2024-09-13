using System;

using Lab1;

class Program
{
    static void Main(String[] args)
    {
        //First method
        Console.WriteLine("First method");
        Date date = new Date(2022, 11, 10);
        date.PrintDate();
        //Second method
        Console.WriteLine("Second method");
        int daysLeftInYear = date.CalculateDaysLeftInYear(date);
        Console.WriteLine(daysLeftInYear);
        //Tasks
        Console.WriteLine("Tasks");
        List<Date> dates = new List<Date>();

        Date date1 = new Date(2001, 5, 1);
        Date date2 = new Date(2001, 2, 5);
        Date date3 = new Date(2002, 7, 13);
        dates.Add(date1);
        dates.Add(date2);
        dates.Add(date3);
        foreach (Date d in dates)
        {
            d.PrintDate();
        }

        TimeSpan timeDifference = date2.Subtract(date1);
        int daysDifference = (int)timeDifference.TotalDays;
        Console.WriteLine(daysDifference);   
    }
}