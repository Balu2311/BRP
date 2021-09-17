using System;
using System.Collections;
using System.Linq;

namespace Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nOnly Duplicate elements in given array:");
            int[] arr = new int[]{20, 20, 30, 40, 50, 50, 50};
            //string[] arr = new string[] { "bcd", "abd", "jude", "bcd", "oiu", "gzw", "oiu" };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Console.Write(arr[j]+" ");

                }
            }
            Console.WriteLine("\n\nRemove Duplicate elements in given array:");
            var sList = new ArrayList();

            for (int i = 0; i < arr.Length; i++)
            {
                if (sList.Contains(arr[i]) == false)
                {
                    sList.Add(arr[i]);
                }
            }
            var sNew = sList.ToArray();
            for (int i = 0; i < sNew.Length; i++)
            {
                Console.Write(sNew[i]+" ");
            }

        }

    }
}
