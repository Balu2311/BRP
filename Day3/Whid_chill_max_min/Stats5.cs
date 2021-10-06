using System;
using System.Collections.Generic;
using System.Text;

namespace Whid_chill_max_min
{
    class Stats5
    {
        public void CalulateAverage()
        {
            Console.WriteLine("Calculating the average and finding minimum and maximum \n");
            int n = 5;
            double[] array = new double[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.NextDouble();
            }
            double sum = 0.0;
            foreach (var items in array)
            {
                sum = sum + items;
            }
            Console.WriteLine("sum of five random numbers =" + sum);
            double averge = sum / 5;
            Console.WriteLine("average of five random number = " + averge);
            Array.Sort(array);
            Console.WriteLine("Elements in sorted order are = ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
            double max = array[n - 1];
            Console.WriteLine("Maximum= " + max);
            double min = array[0];
            Console.WriteLine("Minimum= " + min);
        }
    }
}
