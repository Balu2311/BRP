using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Binary
    {
        public void findBinary()
        {
            int Num;
            Console.WriteLine("Enter the Decimal Number : ");
            Num = Convert.ToInt32(Console.ReadLine());
            int[] BinaryArray = new int[32];
            int i = 0;
            while (Num > 0)
            {
                BinaryArray[i] = Num % 2;
                Num = Num / 2;
                i++;
            }
            int j = 0;
            Console.WriteLine("Binary Conversion");
            for (j = i - 1; j >= 0; j--)
            {
                Console.Write(+BinaryArray[j]);
            }
            Console.ReadLine();
        }
    }
}
