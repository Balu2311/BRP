using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class trigs
    {
        public void TrignometricFunctions()
        {
            Console.WriteLine("Trignometric Function");
            double angleInDegree;
            Console.WriteLine("Enter the angle in degrees =  ");
            angleInDegree = Convert.ToInt32(Console.ReadLine());
            double angleInRadian = angleInDegree * Math.PI / 180;
            double sine = Math.Sin(angleInRadian);
            Console.WriteLine("The value of sine  {0} is {1} ", +angleInDegree, +sine);
            Console.WriteLine();
            double cos = Math.Cos(angleInRadian);
            Console.WriteLine("The value of cosine {0} is {1}  ", +angleInDegree, +cos);
            Console.ReadLine();
        }
    }
}
