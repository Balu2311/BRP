using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Enter input \n" +
                "1.Temperature Conversion \n" +
                "2.Square root of a non -negative c\n" +
                "3.Harmoic series \n" +
                "4.Trignometric function");

            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            switch (input)
            {

                case 1:
                    temp_convertion t = new temp_convertion();
                    t.convertTemperature();
                    break;

                case 2:
                    sqrt s = new sqrt();
                    s.caculateSquareRoot();
                    break;

                case 3:
                    Harmonic h = new Harmonic();
                    h.findHarmonicSeries();
                    break;

                case 4:
                   trigs T = new trigs();
                    T.TrignometricFunctions();
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.ReadLine();
        }
    }
}
