﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3._1_WhatDay1
{
    class WhatDay1
    {
        //enum MonthName
        //{
        //    January, February, March, April, May, June, July, August, September, October, November, December
        //
        //}
        static void Main(string[] args)
        {
            Console.Write("Please enter a day number between 1 and 365: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);

            int monthNum = 0;

            if (dayNum <= 31)  //January
            {
                goto End;
            }
            else
            {
                dayNum = dayNum - 31;
                monthNum++;
            }

            if (dayNum <= 28)  //February
            {
                goto End;
            }
            else
            {
                dayNum = dayNum - 28;
                monthNum++;
            }

            if (dayNum <= 31)  //March
            {
                goto End;
            }
            else
            {
                dayNum = dayNum - 31;
                monthNum++;
            }

            if (dayNum <= 30)  //April
            {
                goto End;
            }
            else
            {
                dayNum = dayNum - 30;
                monthNum++;
            }

            if (dayNum <= 31)  //May
            {
                goto End;
            }
            else
            {
                dayNum = dayNum - 31;
                monthNum++;
            }

            if (dayNum <= 30)  //June
            {
                goto End;
            }
            else
            {
                dayNum = dayNum - 30;
                monthNum++;
            }

            if (dayNum <= 31)  //July
            {
                goto End;
            }
            else
            {
                dayNum = dayNum - 31;
                monthNum++;
            }

            if (dayNum <= 31)  //August
            {
                goto End;
            }
            else
            {
                dayNum = dayNum - 31;
                monthNum++;
            }

            if (dayNum <= 30)  //September
            {
                goto End;
            }
            else
            {
                dayNum = dayNum - 30;
                monthNum++;
            }

            if (dayNum <= 31)  //October
            {
                goto End;
            }
            else
            {
                dayNum = dayNum - 31;
                monthNum++;
            }

            if (dayNum <= 30)  //November
            {
                goto End;
            }
            else
            {
                dayNum = dayNum - 30;
                monthNum++;
            }

            if (dayNum <= 31)  //December
            {
                goto End;
            }
            else
            {
                dayNum = dayNum - 31;
                monthNum++;
            }

        End:

            string monthName;
            switch (monthNum)
            {
                case 0:
                    monthName = "January"; break;
                case 1:
                    monthName = "February"; break;
                case 2:
                    monthName = "March"; break;
                case 3:
                    monthName = "April"; break;
                case 4:
                    monthName = "May"; break;
                case 5:
                    monthName = "June"; break;
                case 6:
                    monthName = "July"; break;
                case 7:
                    monthName = "August"; break;
                case 8:
                    monthName = "September"; break;
                case 9:
                    monthName = "October"; break;
                case 10:
                    monthName = "November"; break;
                case 11:
                    monthName = "December"; break;
                default:
                    monthName = "not done yet"; break;
            }

            Console.WriteLine("{0} {1}", dayNum, monthName);

            Console.ReadKey();
        }
    }
}
