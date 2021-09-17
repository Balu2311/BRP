using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutations
{
    class Program
    {
        //Function for swapping the characters at position I with character at position j  
        public static String swapString(String a, int i, int j)
        {
            char[] b = a.ToCharArray();
            char ch;
            ch = b[i];
            b[i] = b[j];
            b[j] = ch;
            //Converting characters from array into single string  
            return string.Join("", b);
        }
        //Function for generating different permutations of the string  
        public static void generatePermutation(String str, int start, int end)
        {
            //Prints the permutations  
            if (start == end - 1)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i < end; i++)
                {
                    //Swapping the string by fixing a character  
                    str = swapString(str, start, i);
                    //Recursively calling function generatePermutation() for rest of the characters   
                    generatePermutation(str, start + 1, end);
                    //Backtracking and swapping the characters again.  
                    str = swapString(str, start, i);
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Permutations");
            Console.WriteLine("Enter values: ");
            String str = Convert.ToString(Console.ReadLine());
            int len = str.Length;
            Console.WriteLine("All the permutations of the string are: ");
            generatePermutation(str, 0, len);

        }
    }
}
