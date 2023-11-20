using System;
namespace Сalendar3._0
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
                Console.Write("Please enter the year: ");
                int yearNum = int.Parse(Console.ReadLine());
                bool isLeapYear = checkLeapYear(yearNum);
                int maxDayNum = isLeapYear ? 366 : 365;

                Console.Write($"Please enter a day number between 1 and {maxDayNum}: ");
                int dayNum = int.Parse(Console.ReadLine());
                if (dayNum < 1 || dayNum > maxDayNum)
                {
                    throw new ArgumentOutOfRangeException("Day out of range"); // 4 overload // 
                }
                Date date = getDate(dayNum, isLeapYear);

                Console.WriteLine($"{date.month} {date.day}");
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

        private static Date getDate(int dayNum, bool isLeapYear)
        {
            int monthNum = 0;
            System.Collections.ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (isLeapYear)
            {
                DaysInMonths = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            }
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
        private static string whatDay(int dayNum, bool isLeapYear)
        {
            Date date = getDate(dayNum, isLeapYear);

            return $"{date.month} {date.day}";
        }

        private static bool selfTest()
        {
            bool result = true;
            result = test1();
            // and
            result = test2();
            //and
            result = test3();
            return result;
        }

        private static bool test1()
        {
            bool result = true;
            result = result && (whatDay(32, false) == "February 1");
            result = result && (whatDay(60, false) == "March 1");
            result = result && (whatDay(91, false) == "April 1");
            result = result && (whatDay(186, false) == "July 5");
            result = result && (whatDay(304, false) == "October 31");
            result = result && (whatDay(309, false) == "November 5");
            result = result && (whatDay(327, false) == "November 23");
            result = result && (whatDay(359, false) == "December 25");
            return result;
        }

        private static bool test2()
        {
            bool result = true;
            result = result && checkLeapYear(1996);
            result = result && checkLeapYear(2000);
            result = result && checkLeapYear(2004);            
            //result = result && checkLeapYear(4);
            //result = result && checkLeapYear(400);
            //result = result && checkLeapYear(800);
            return result;
        }

        private static bool test3()
        {
            bool result = true;
            result = result && (whatDay(32, checkLeapYear(1999)) == "February 1");
            result = result && (whatDay(32, checkLeapYear(2000)) == "February 1");
            result = result && (whatDay(60, checkLeapYear(1999)) == "March 1");
            result = result && (whatDay(60, checkLeapYear(2000)) == "February 29");
            result = result && (whatDay(91, checkLeapYear(1999)) == "April 1");
            result = result && (whatDay(91, checkLeapYear(2000)) == "March 31");
            result = result && (whatDay(186, checkLeapYear(1999)) == "July 5");
            result = result && (whatDay(186, checkLeapYear(2000)) == "July 4");
            result = result && (whatDay(304, checkLeapYear(1999)) == "October 31");
            result = result && (whatDay(304, checkLeapYear(2000)) == "October 30");
            result = result && (whatDay(309, checkLeapYear(1999)) == "November 5");
            result = result && (whatDay(309, checkLeapYear(2000)) == "November 4");
            result = result && (whatDay(327, checkLeapYear(1999)) == "November 23");
            result = result && (whatDay(327, checkLeapYear(2000)) == "November 22");
            return result;
        }

        private static bool checkLeapYear(int yearNum)
        {
            return (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);
        }
    }
}