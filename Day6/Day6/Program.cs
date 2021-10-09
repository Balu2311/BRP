using System;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day6 Pregrams");
            Console.WriteLine("Prime Numbers");
            PrimeNumber p = new PrimeNumber();
            p.PrintPrimeNumber();

            Console.WriteLine("\nRollDie");
            RollDie roll = new RollDie();
            roll.findMaximum();
            Console.WriteLine("\nRepeated number");
            RepeatedNumber repeatedNumber = new RepeatedNumber();
            repeatedNumber.FindRepeatedNumber();
        }
    }
}
