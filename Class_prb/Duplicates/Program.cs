using System;
using System.Collections;
using System.Linq;

namespace Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("\nOnly Duplicate elements in given array:");
            //int[] arr = new int[]{20, 20, 30, 40, 50, 50, 50};
            ////string[] arr = new string[] { "bcd", "abd", "jude", "bcd", "oiu", "gzw", "oiu" };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //            Console.Write(arr[j]+" ");
            //    }
            //}
            //Console.WriteLine("\n\nRemove Duplicate elements in given array:");
            //var sList = new ArrayList();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (sList.Contains(arr[i]) == false)
            //    {
            //        sList.Add(arr[i]);
            //    }
            //}
            //var sNew = sList.ToArray();
            //for (int i = 0; i < sNew.Length; i++)
            //{
            //    Console.Write(sNew[i]+" ");
            //}

            //Enter type array
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
            var sList = new ArrayList();

            for ( i = 0; i < length_arr; i++)
            {
                if (sList.Contains(arr[i]) == false)
                {
                    sList.Add(arr[i]);
                }
            }
            var sNew = sList.ToArray();
            for ( i = 0; i < sNew.Length; i++)
            {
                Console.Write(sNew[i] + " ");
            }

        }

    }
}
