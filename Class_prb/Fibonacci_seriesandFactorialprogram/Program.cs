using System;

namespace Fibonacci_seriesandFactorialprogram
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci seriesand Factorial programs Iterative Approach and Recursion");

            Console.WriteLine("\nFactorial");
            //Factorial Iterative Approach
            int i1, fact = 1, number1;
            Console.Write("Enter any Number: ");
            number1 = int.Parse(Console.ReadLine());
            for (i1 = 1; i1 <= number1; i1++)
            {
                fact = fact * i1;
            }
            Console.Write("Factorial of " + number1 + " is: " + fact);

            //Recursion
            long fact1 = GetFactorial(number1);
            Console.WriteLine("\nRecursion factorial of {0}  is {1}", number1, fact1);
            Console.ReadKey();

            Console.WriteLine("\nFibonacci_series");
            //Iterative Approach
            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("\nEnter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i <= number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

            //Recursion
            Console.Write("\n\nFibonacci_series in Recursion {0} th value: ", number);
            Console.Write(Fib(number));
            Console.WriteLine("\n\nFibonacci_series in Recursion values: ");
            for (i = 0; i <= number; i++)
            {
                Console.Write("{0} ", Fib(i));
            }
        }
        private static int Fib(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            else
            {
                return Fib(number - 1) + Fib(number - 2);
            }
        }
        private static long GetFactorial(int number1)
        {
            if (number1 == 0)
            {
                return 1;
            }

            return number1 * GetFactorial(number1 - 1);
        }
    }
}
