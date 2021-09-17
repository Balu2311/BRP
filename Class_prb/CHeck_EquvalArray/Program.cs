using System;
// How To Check The Equality Of Two Arrays 
namespace CHeck_EquvalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check Equal_array");
            Boolean isArrayEqual = true;
            Console.WriteLine("Enter the size of array1: ");
            int length_arr1 = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] arr1 = new int[length_arr1];
            // Accepting value from user 
            for (i = 0; i < length_arr1; i++)
            {
                Console.Write("Enter your number: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            //Printing the value on console
            for (i = 0; i < length_arr1; i++)
            {
                Console.WriteLine("Array values {0}", arr1[i]);
            }
            Console.ReadLine();
            Console.WriteLine("Enter the size of array2: ");
            int length_arr2 = Convert.ToInt32(Console.ReadLine());
            //int i;
            int[] arr2 = new int[length_arr2];
            // Accepting value from user 
            for (i = 0; i < length_arr2; i++)
            {
                Console.Write("Enter your number: ");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            //Printing the value on console
            for (i = 0; i < length_arr2; i++)
            {
                Console.WriteLine("Array values {0}", arr2[i]);
            }
            Console.ReadLine();
            if (arr1.Length == arr2.Length)
            {
                //each element
                for ( i = 0; i < arr2.Length; i++)
                {
                    //elements of arrays are equal
                    if (arr2[i] != arr1[i])
                    {
                        isArrayEqual = false;
                    }
                }
            }
            else
            {
                isArrayEqual = false;
            }
            //the result if both arrays are equal or not
            if (isArrayEqual)
            {
                Console.WriteLine("Both arrays are equal");
            }
            else
            {
                Console.WriteLine("Both arrays are not equals");
            }
        }
    }
}