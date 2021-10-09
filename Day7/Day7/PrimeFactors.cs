using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class PrimeFactors
    {
        public void findPrimeFactors()
        {
            int Num;
            Console.WriteLine("Enter Number of which you want to print factors =");
            Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime factors are ");
            for (int i = 2; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
