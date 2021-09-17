using System;

namespace Euclideandistance_SumofTwoDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Euclidean distance");
            int x1, x2, y1, y2;
            Console.WriteLine("Enter the x1 value: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y1 value: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the x2 value: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y2 value: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            double dis = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("distancebetween: " + "(" + x1 + "," + y1 + ")," + "(" + x2 + "," + y2 + ")===> " + dis);

            //SumOfTwoDice
            Console.WriteLine("\nSumOfTwoDice");
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int Sum_Dice = dice1 + dice2;

            Console.WriteLine("The first die comes up: " + dice1);
            Console.WriteLine("The second die comes up: " + dice2);
            Console.WriteLine("Your total roll is: " + Sum_Dice);

            int ChosenRandom;
            Console.Write("\nChoose a number between 1-6: ");
            ChosenRandom = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int RandomNumber = 0;
            int sumNum = 0;
            for (int i = 0; i < ChosenRandom; i++)
            {
                RandomNumber = rand.Next(1, 7);
                Console.WriteLine("Random No {0} = {1}", i + 1, RandomNumber);
                sumNum += RandomNumber;
            }
            Console.WriteLine("\n\nTotal_Sum of Dices :" + sumNum);
            double avrg = sumNum / ChosenRandom;
            Console.WriteLine("\nAverage is: " + avrg);
            if (ChosenRandom > avrg)
            {
                Console.WriteLine("Numbers larger than average: " + ChosenRandom);
            }
            else
            {
                Console.WriteLine("All numbers under average.");
            }

        }
    }
}
