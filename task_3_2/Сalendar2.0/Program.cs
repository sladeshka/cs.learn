using System;
namespace Сalendar2._0
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    public struct Date
    {
        public Date(string month, int day)
        {
            this.month = month;
            this.day = day;
        }
        public string month;
        public int day;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            try
            {
                if (!selfTest())
                {
                    throw new Exception("Self test error");
                }
                Console.Write("Please enter a day number between 1 and 365: ");
                int dayNum = int.Parse(Console.ReadLine());
                if (dayNum < 1 || dayNum > 365)
                {
                    throw new ArgumentOutOfRangeException("Day out of range"); // 4 overload // 
                }
                Console.WriteLine(whatDay(dayNum));
                goto start;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Try again");
            }
        }

        private static string whatDay(int dayNum)
        {
            Date date = getDate(dayNum);

            return $"{date.month} {date.day}";
        }

        private static Date getDate(int dayNum)
        {
            int monthNum = 0;

            foreach (int daysInMonth in DaysInMonths)
            {
                if (dayNum <= daysInMonth)
                {
                    break;
                }
                else
                {
                    dayNum -= daysInMonth;
                    monthNum++;
                }
            }
            string monthName = ((MonthName)monthNum).ToString();
            return new Date(monthName, dayNum);
        }
        static System.Collections.ICollection DaysInMonths
            = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private static bool selfTest()
        {
            bool result = true;
            result = result && (whatDay(32) == "February 1");
            result = result && (whatDay(60) == "March 1");
            result = result && (whatDay(91) == "April 1");
            result = result && (whatDay(186) == "July 5");
            result = result && (whatDay(304) == "October 31");
            result = result && (whatDay(309) == "November 5");
            result = result && (whatDay(327) == "November 23");
            result = result && (whatDay(359) == "December 25");

            return result;
        }
    }
}