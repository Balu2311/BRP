using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class sqrt
    {
        public void caculateSquareRoot()
        {

            Console.WriteLine("Finding the square root of non-negative number");
            double C;
            Console.WriteLine("Enter the input C");
            C = Convert.ToDouble(Console.ReadLine());
            double t = C;
            double epsilon = 1e-15;
            while (Math.Abs(t - C / t) > epsilon * t)
            {
                t = (C / t + t) / 2.0;
            }
            Console.WriteLine("The value of t is : " + t);
            Console.ReadLine();

        }
    }
}
