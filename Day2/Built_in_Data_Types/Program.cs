using System;

namespace Built_in_Data_Types
{
    class Program
    {
        public static object SpecialToday { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Input operations in integer values");
            Console.WriteLine("Enter the value a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int first_operation = a + b * c;
            Console.WriteLine("first_operation: " + first_operation);
            int second_operation = a * b + c;
            Console.WriteLine("second_operation: " + second_operation);
            int Thard_operation = c + a / b;
            Console.WriteLine("Thard_operation: " + Thard_operation);
            int Fourth_operation = a % b + c;
            Console.WriteLine("Fourth_operation: " + Fourth_operation);

            Console.WriteLine();
            //Double the input value
            Console.WriteLine("Input operations in double value");
            Console.WriteLine("Enter the value a: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value b: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value c: ");
            double c1 = Convert.ToDouble(Console.ReadLine());
            double first_operation1 = a1 + b1 * c1;
            Console.WriteLine("first_operation: " + first_operation1);
            double second_operation1 = a1 * b1 + c1;
            Console.WriteLine("second_operation: " + second_operation1);
            double Thard_operation1 = c1 + a1 / b1;
            Console.WriteLine("Thard_operation: " + Thard_operation1);
            double Fourth_operation1 = a1 % b1 + c1;
            Console.WriteLine("Fourth_operation: " + Fourth_operation1);
        }
    }
}
