using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        
        public int Year 
        { get { return _year; } set { _year = value; } }

        public int Month
        { get { return _month; } set { _month = value; } }
        
        public int Day
        { get { return _day; } set { _day = value; } }

        public void PrintDate() => Console.WriteLine($"{Day:00}/{Month:00}/{Year:0000}");

        public int CalculateDaysLeftInYear(Date date)
        {
            DateTime currentDate = new DateTime(date.Year, date.Month, date.Day);
            DateTime endOfYear = new DateTime(date.Year, 12, 31);

            int daysLeftInYear = (int)(endOfYear - currentDate).TotalDays;

            return daysLeftInYear;
        }

        public TimeSpan Subtract(Date other)
        {
            DateTime date1 = new DateTime(Year,  Month, Day);
            DateTime date2 = new DateTime(other.Year, other.Month, other.Day);

            return date2 - date1;
        }
    }
}
