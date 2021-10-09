using System;
using System.Collections.Generic;
using System.Text;

namespace Count_Even_odd_in_array
{
    class CountEvenOdd
    {
        public void countEvenOdd()
        {
            Console.WriteLine("Counting of even or odd in array");
            int length;
            Console.WriteLine("Enter the lenth of array: ");
            length = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[length];
            Console.WriteLine("Enter the elements of array: ");
            for (int i = 0; i < length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            int countEven = 0;
            int countOdd = 0;
            foreach(var items in number)
            {
                if (items % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }
            Console.WriteLine("Even number of elements = " + countEven);
            Console.WriteLine("Even number of elements = " + countOdd);
        }
    }
}
