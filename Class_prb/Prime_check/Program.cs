using System;

namespace Prime_check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int length_arr = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] arr = new int[length_arr];

            for (i = 0; i < length_arr; i++)
            {
                Console.Write("Enter your number: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (i = 0; i < length_arr; i++)
            {
                Console.WriteLine("Array values {0}", arr[i]);
            }
            Console.ReadLine();
            foreach (int items in arr)
            {
                int flag = 0;
                int m = 0;
                 m = items / 2;
                for (i = 2; i <= m; i++)
                {
                    if (m % i == 0)
                    {
                        Console.WriteLine(items+" is not prime number");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine(items+" Number is Prime Number");
                }
            }
            //Console.WriteLine("Prime Check");
            //int n, i, m = 0, flag = 0;
            //Console.WriteLine("Enter the input number: ");
            //n = Convert.ToInt32(Console.ReadLine());
            //m = n / 2;
            //for (i = 2; i <= m; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.Write("Number is not prime");
            //        flag = 1;
            //        break;
            //    }
            //}
            //if (flag == 0)
            //{
            //    Console.Write("Number is Prime");
            //}
        }
    }
}
