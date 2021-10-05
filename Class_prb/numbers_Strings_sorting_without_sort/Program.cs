using System;

namespace numbers_Strings_sorting_without_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers and Strings sorting without sort function");
            Console.WriteLine("Enter the size of array: ");
            int length_arr = Convert.ToInt32(Console.ReadLine());
            int i;
            int temp = 0;
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
            for (i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in asscending order");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            // sorting string
            Console.WriteLine("String sorting");
            int Length_arry;
            Console.WriteLine("Enter the array length: ");
            Length_arry = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[Length_arry];
            Console.WriteLine("Enter the words: ");
            for ( i = 0; i < Length_arry; i++)
            {
                words[i] = Console.ReadLine();
            }
            for (i = 0; i < Length_arry; i++)
            {
                for (int j = 0; j < Length_arry - 1; j++)
                {
                    if (words[j].CompareTo(words[j + 1]) > 0)
                    {
                        string temps = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temps;
                    }
                }
            }
            Console.WriteLine("\nSorting string\n");
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

    }
 }

