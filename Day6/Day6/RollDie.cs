using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class RollDie
    {
        public void findMaximum()
        {

            int Num;
            Console.WriteLine("Enter Number = ");
            Num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0;
            while (i <= Num)
            {
                Random random = new Random();
                int roll = random.Next(1, 7);
                if (roll == 1)
                {
                    count1++;
                }
                else if (roll == 2)
                {
                    count2++;
                }
                else if (roll == 3)
                {
                    count3++;

                }
                else if (roll == 4)
                {
                    count4++;
                }
                else if (roll == 5)
                {
                    count5++;
                }
                else if (roll == 6)
                {
                    count6++;
                }
                i++;
            }
            if (count1 > count2 && count1 > count3 && count1 > count4 && count1 > count5 && count1 > count6)
            {
                Console.WriteLine("Maximum roll die of side  1 = " + count1);
            }
            else if (count2 > count1 && count2 > count3 && count2 > count4 && count2 > count5 && count2 > count6)
            {
                Console.WriteLine("Maximum roll die of side  2 = " + count1);
            }
            else if (count3 > count1 && count3 > count2 && count3 > count4 && count3 > count5 && count3 > count6)
            {
                Console.WriteLine("Maximum roll die of side 3 = " + count1);
            }
            if (count4 > count1 && count4 > count2 && count4 > count3 && count4 > count5 && count4 > count6)
            {
                Console.WriteLine("Maximum roll die of side 4 = " + count1);
            }
            else if (count5 > count1 && count5 > count2 && count5 > count4 && count5 > count3 && count5 > count6)
            {
                Console.WriteLine("Maximum roll die of side 5 = " + count5);
            }
            else
            {
                Console.WriteLine("Maximu roll die of side 6 = " + count6);
            }
            Console.ReadLine();
        }
    }
}
