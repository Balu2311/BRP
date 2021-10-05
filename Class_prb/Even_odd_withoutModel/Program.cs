using System;

namespace Even_odd_withoutModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int numb = Convert.ToInt32(Console.ReadLine());
            if (numb % 2 == 0)
                Console.WriteLine(numb + " is Even Number");
            else
                Console.WriteLine(numb + " is Odd Number");

            // without module divider
            Console.Write("\nWithout module and dive operation : ");
            if (isEven(numb))
            {
                Console.Write(numb+" is Even Number\n");
            }
            else
                Console.Write(numb+" is Odd Number\n");
        }
        private static bool isEven(int numb)
        {
            bool isEven = true;

            for (int i = 1; i <= numb; i++)
                isEven = !isEven;

            return isEven;
        }
    }
}
