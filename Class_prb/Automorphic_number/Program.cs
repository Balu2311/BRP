using System;
/*An Automorphic number is a number whose square ends in the same digits as the number itself
    Example 5*5=25 ,6*6,25*25=625*/
namespace Automorphic_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sqrt ends");
            int div = 10;
            for (int num = 1; num <= 100; num++)
            {
                if (div >= num)
                {
                    if ((num * num) % div == num)
                        Console.WriteLine(num);
                }
                else if (div <= num)
                {
                    div *= 10;
                    if ((num * num) % div == num)
                        Console.WriteLine(num);
                }
            }
        }
    }
}
