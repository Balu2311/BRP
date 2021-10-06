using System;
using System.Collections.Generic;
using System.Text;

namespace Whid_chill_max_min
{
    class CarLoan
    {
        public void CalculateLoan()
        {

            Console.WriteLine("Calculating the monthly payment\n");

            double year, Rate, Principal;

            Console.WriteLine("Enter Principal loan amount = ");
            Principal = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter years = ");
            year = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rate percent = ");
            Rate = Convert.ToDouble(Console.ReadLine());


            double n = 12 * year;   //number of months
            double r = Rate / (12 * 100);  //interest rate

            double Monthlypayment = (Principal * r * Math.Pow(1 + r, n)) / (Math.Pow(1 + r, n) - 1);

            Console.WriteLine("Monthly payments is   : " + Monthlypayment);
            Console.ReadLine();

        }
    }
}
