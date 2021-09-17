using System;

namespace Target_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int length_arr = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] arr = new int[length_arr];
            // Accepting value from user 
            for (i = 0; i < length_arr; i++)
            {
                Console.Write("Enter your number: ");
                //Storing value in an array
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            //Printing the value on console
            for (i = 0; i < length_arr; i++)
            {
                Console.WriteLine("Array values {0}", arr[i]);
            }
            Console.ReadLine();
            Console.WriteLine("Enter the target number: ");
            int target_num = Convert.ToInt32(Console.ReadLine());
            foreach(int items in arr)
            {
                //Console.WriteLine(items);
                int output = items% target_num;

                if (output == 0)
                {
                    Console.WriteLine("Target values: " + items);
                }
            }
        }
    }
}
