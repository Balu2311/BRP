using System;
/*WAP to move all 0's to the end of an array. Maintain the relative order of the other (non-zero) array elements.
Before:    0  0  1  0  3  0  5  0  6                                              
After:        1  3  5  6  0  0  0  0  0 */
namespace all_Zeros_move_toEnding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("all_Zeros_move_toEnding");
            int[] array_nums = new int[] { 0, 0, 1, 0, 3, 0, 5, 0, 6 };
            int i = 0;
            Console.WriteLine("\nInput array: ");
            foreach (int n in array_nums)
                Console.Write(n + "  ");

            for (int j = 0, l = array_nums.Length; j < l;)
            {
                if (array_nums[j] == 0)
                    j++;
                else
                {
                    int temp = array_nums[i];
                    array_nums[i] = array_nums[j];
                    array_nums[j] = temp;
                    i++;
                    j++;
                }
            }
            while (i < array_nums.Length)
            {
                array_nums[i++] = 0;
            }
            Console.WriteLine("\nnAfter moving 0's to the end of the array:");
            foreach (int n in array_nums)
            {
                Console.Write(n + "  ");
            }
            
        }
    }
}
