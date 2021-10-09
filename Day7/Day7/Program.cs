using System;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day7 Programs");
            PrimeFactors primeFactors = new PrimeFactors();
            primeFactors.findPrimeFactors();

            SecondLargestAndSmallest secondLargest = new SecondLargestAndSmallest();
            secondLargest.FindSecondLargest();


            Binary binary = new Binary();
            binary.findBinary();
        }
    }
}
