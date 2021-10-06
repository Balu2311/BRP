using System;
using System.Collections.Generic;
using System.Text;

namespace Whid_chill_max_min
{
    class DayofWeek
    {
        public void FindDayOfWeek()
        {

            Console.WriteLine("Finding the day of week\n");
            int date;
            Console.Write("Enter the day date : \n ");
            date = Convert.ToInt32(Console.ReadLine());
            int month;
            Console.Write("Enter the Month: \n  ");
            month = Convert.ToInt32(Console.ReadLine());

            if ((date >= 1 && date <= 31) && (month >= 1 && month <= 12))
            {

                int year;
                Console.Write("Enter the Year : \n");
                year = int.Parse(Console.ReadLine());

                int year1 = (year - (14 - month) / 12);
                int x = (year1 + year1 / 4 - year1 / 100 + year1 / 400);  //checking leap or not 
                int month1 = (month + 12 * ((14 - month) / 12) - 2);

                int day = ((date + x + 31 * month1 / 12) % 7);

                switch (day)
                {
                    case 0:
                        Console.WriteLine("Sunday");
                        break;

                    case 1:
                        Console.WriteLine("Monday");
                        break;

                    case 2:
                        Console.WriteLine("Tuesday");
                        break;

                    case 3:
                        Console.WriteLine("Wednesday");
                        break;

                    case 4:
                        Console.WriteLine("Thursday");
                        break;

                    case 5:
                        Console.WriteLine("Friday");
                        break;

                    case 6:
                        Console.WriteLine("Saturday");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Input is not valid");
                FindDayOfWeek();
            }
            Console.ReadLine();
        }
    }
}
