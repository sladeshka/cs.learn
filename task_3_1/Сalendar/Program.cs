﻿using System;
namespace Сalendar
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
        static void Main(string[] args) {
            start:
            try
            {
                if (!selfTest())
                {
                    throw new Exception("Self test error");
                }
                Console.Write("Please enter a day number between 1 and 365: ");
                int dayNum = int.Parse(Console.ReadLine());
                if(dayNum < 1 || dayNum > 365) {
                    throw new Exception("The value is not between 1 and 365:");
                }
                Console.WriteLine(whatDay(dayNum));
                goto start;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("Try again");
            }
        }

        private static string whatDay(int dayNum)
        {
            Date date = getDate(dayNum);

            //switch (monthNum)
            //{
            //    case 0:
            //        monthName = "January"; break;
            //    case 1:
            //        monthName = "February"; break;
            //    case 2:
            //        monthName = "March"; break;
            //    case 3:
            //        monthName = "April"; break;
            //    case 4:
            //        monthName = "May"; break;
            //    case 5:
            //        monthName = "June"; break;
            //    case 6:
            //        monthName = "July"; break;
            //    case 7:
            //        monthName = "August"; break;
            //    case 8:
            //        monthName = "September"; break;
            //    case 9:
            //        monthName = "October"; break;
            //    case 10:
            //        monthName = "November"; break;
            //    case 11:
            //        monthName = "December"; break;
            //    default: 
            //        monthName = "not done yet"; break;
            //}
            // has format error
            // return $"{dayNum} {monthName}";
            // fixed
            // return $"{monthName} {dayNum}";
            return $"{date.month} {date.day}";
        }

        private static Date getDate(int dayNum) {
            int monthNum = 0;
            //if (dayNum <= 31)
            //{ // January
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 28)
            //{ // February
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 28;
            //    monthNum++;
            //}

            //if (dayNum <= 31)
            //{ // March
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 30)
            //{ // April
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 30;
            //    monthNum++;
            //}

            //if (dayNum <= 31)
            //{ // May
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}


            //if (dayNum <= 30)
            //{ // June
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 30;
            //    monthNum++;
            //}

            //if (dayNum <= 31)
            //{ // July
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 31)
            //{ // August
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 30)
            //{ // September
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 30;
            //    monthNum++;
            //}

            //if (dayNum <= 31)
            //{ // October
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 30)
            //{ // November
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 30;
            //    monthNum++;
            //}
            //if (dayNum <= 31)
            //{ // December
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}
            //End:
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

            return result ;
        }
    }
}