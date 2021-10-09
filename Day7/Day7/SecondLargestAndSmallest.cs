using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class SecondLargestAndSmallest
    {
        public void FindSecondLargest()
        {
            int size;
            Console.WriteLine("Enter size of an array = ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] Numbers = new int[size];
            Console.WriteLine("Enter elements = ");
            for (int i = 0; i < size; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int largest = 0;
            int secondLargest = 0;
            for (int i = 0; i < size; i++)
            {
                if (largest < Numbers[i])
                {
                    secondLargest = largest;
                    largest = Numbers[i];
                }
                if (secondLargest < Numbers[i] && Numbers[i] < largest)
                {
                    secondLargest = Numbers[i];
                }
            }
            Console.WriteLine("Second largest element = " + secondLargest);
            int smallest = 0;
            int secondSmallest = 0;
            for (int j = 0; j < size; j++)
            {
                if (smallest > Numbers[j])
                {
                    secondSmallest = smallest;
                    smallest = Numbers[j];
                }
                if (Numbers[j] > smallest && secondSmallest > Numbers[j])
                {
                    secondSmallest = Numbers[j];
                }
            }
            Console.WriteLine("Second smallest element = " + secondSmallest);
        }
    }
}
