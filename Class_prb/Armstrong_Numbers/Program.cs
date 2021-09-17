using System;

namespace Armstrong_Numbers
{
    class Program
    {
        delegate int cubes(int nums);
        static void Main(string[] args)
        {
            Console.WriteLine("Armstrong_Numbers");
            int num, r, sum, temp;
            int stno, enno;
            Console.WriteLine("Enter the starting number: ");
            stno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending number: ");
            enno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nArmstrong_Numbers");
            for (num = stno; num <= enno; num++)
            {
                temp = num;
                sum = 0;
                while (temp != 0)
                {
                    r = temp % 10;
                    temp = temp / 10;
                    sum = sum + (r * r * r);
                }
                if (sum == num)
                    Console.Write("{0} ", num);
            }
            //Lambda using
            Console.WriteLine("\n\nArmstrong_Numbers Using Lambda");
            for (num = stno; num <= enno; num++)
            {
                temp = num;
                sum = 0;
                while (temp != 0)
                {
                    r = temp % 10;
                    temp = temp / 10;
                    cubes result = r => r * r * r;
                    int s = result(r);
                    sum = sum  + s;
                }
                if (sum == num)
                    Console.Write("{0} ", num);
            }
        }
    }
}

