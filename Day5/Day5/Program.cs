using System;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day5 progras");
            FlipCoin f = new FlipCoin();
            f.calculatePercentage();

            PowerOFTwo p = new PowerOFTwo();
            p.printPowerOfTwo();


            GamblingSimulator gamblingSimulator = new GamblingSimulator();
            gamblingSimulator.findNumberOfWin();

            Console.ReadLine();
        }
    }
}
