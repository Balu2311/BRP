using System;

namespace Count_Even_odd_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count_Even_odd_in_array");
            //int[] numb = new int[] { 20, 20, 30, 40, 50, 50, 50 };
            Console.WriteLine("Enter the size of array: ");
            int length_arr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length_arr];
            int sum = 0;
            for (int i = 0; i < length_arr; i++)
            {
                //Console.Write("Enter your number: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
            }

            Console.WriteLine("sum of the array: "+sum);
            CountEvenOdd count = new CountEvenOdd();
            count.countEvenOdd();
            
        }
    }
}
