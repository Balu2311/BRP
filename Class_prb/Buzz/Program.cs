using System;
//A number is said to be Buzz number if it ends with 7 or is divisible by 7

namespace Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buzz number checking");
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 10 == 7 || number % 7 == 0)
            {
                Console.WriteLine(number + " is a Buzz number.");
            }
            else
            {
                Console.WriteLine(number + " is a not Buzz number.");
            }
        }
    }
}
