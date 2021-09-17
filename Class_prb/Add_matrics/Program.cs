using System;
/*WAP  to add two matrices of the same size. (Java Array: Exercise-19) - Naveen

Input number of rows of matrix: 2                                                                                                
Input number of columns of matrix: 2                                                                                                
Input elements of first matrix: 1 2 3 4                                                                                                
Input the elements of second matrix:  5 6 7 8                                                                                                
Sum of the matrices:- 6 8 10 12*/

namespace Add_matrics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of Matrics");
            int i,j,m, n;
            Console.WriteLine("Enter the matrix size: ");
            n = Convert.ToInt16(Console.ReadLine());
            m = Convert.ToInt16(Console.ReadLine());
            int[,] arr1 = new int[m, n];
            int[,] arr2 = new int[m, n];
            int[,] arr3 = new int[m, n];
            Console.WriteLine("Enter the first matrix values: ");
            for (i = 0; i< m; i++)
            {
                for (j =0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the second matrix values: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nfirst matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nsecond matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
                Console.WriteLine();

            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nAdding two matrics:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(arr3[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
    }
}
