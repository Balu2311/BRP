using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*WAP  to create all possible permutations of a given array of distinct integers.
Input :
nums1 = {1, 2, 3}
Output:
Possible permutations of the said array:
[1, 2, 3]
[1, 3, 2]
[2, 1, 3]
[2, 3, 1]
[3, 2, 1]
[3, 1, 2]*/
namespace Permutations
{
    class Per_array
    {
        static void Main(string[] args)
        {
            PrintResult(
                Permute(new int[] { 1, 2, 3 })
            );
        }

        static IList<IList<int>> Permute(int[] nums)
        {
            var list = new List<IList<int>>();
            return DoPermute(nums, 0, nums.Length - 1, list);
        }

        static IList<IList<int>> DoPermute(int[] nums, int start, int end, IList<IList<int>> list)
        {
            if (start == end)
            {
                // We have one of our possible n! solutions,
                // add it to the list.
                list.Add(new List<int>(nums));
            }
            else
            {
                for (var i = start; i <= end; i++)
                {
                    Swap(ref nums[start], ref nums[i]);
                    DoPermute(nums, start + 1, end, list);
                    Swap(ref nums[start], ref nums[i]);
                }
            }

            return list;
        }

        static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        static void PrintResult(IList<IList<int>> lists)
        {
            //Console.WriteLine("[");
            foreach (var list in lists)
            {
                Console.WriteLine($"    [{string.Join(',', list)}]");
            }
            //Console.WriteLine("]");
        }
    }
}

