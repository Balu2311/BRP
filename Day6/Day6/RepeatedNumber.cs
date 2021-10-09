using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class RepeatedNumber
    {
        public void FindRepeatedNumber()
        {
            int length;
            Console.WriteLine("Enter size of an array = ");
            length = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[length];
            Console.WriteLine("Enter Numbers = ");
            for (int i = 0; i < length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Repeated elements are ");
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        Console.WriteLine(numbers[j]);
                        break;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
