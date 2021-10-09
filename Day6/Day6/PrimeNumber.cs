using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class PrimeNumber
    {
        public void PrintPrimeNumber()
        {
            int firstRange;
            Console.WriteLine("Enter first range = ");
            firstRange = Convert.ToInt32(Console.ReadLine());
            int secondRange;
            Console.WriteLine("Enter second range = ");
            secondRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime number between " + firstRange + "and " + secondRange + " are :");
            while (firstRange < secondRange)
            {
                int flag = 0;
                int i = 2;
                while (i < firstRange)
                {
                    if (firstRange % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                    i++;
                }
                if (flag == 0 && firstRange != 1 && firstRange != 0)
                {
                    Console.WriteLine(firstRange);
                }
                firstRange++;
            }
            Console.ReadLine();
        }
    }
}
