using System;

namespace Lines_Pettran
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            Console.WriteLine("Line Pettran\n");
            for (row = 0; row < 5; row++)
            {
                for (column = 0; column <= 9; column++)
                {   
                        Console.Write("-");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
