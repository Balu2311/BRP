using System;
using System.Collections.Generic;
using System.Text;

namespace Whid_chill_max_min
{
    class windchile
    {
        public void CalculateWindChill()
        {
            double Temperature;
            Console.WriteLine("Enter temperature in fareheit= ");
            Temperature = Convert.ToDouble(Console.ReadLine());
            double WindSpeed;
            Console.WriteLine("Enter the wind speed V = ");
            WindSpeed = Convert.ToDouble(Console.ReadLine());
            if (Temperature < 50 && (WindSpeed >= 3 && WindSpeed < 120))
            {
                double v = Math.Pow(WindSpeed, 0.16);
                double WindChill = 35.74 + 0.6215 * Temperature + (0.4275 * Temperature - 35.75) * v;
                Console.WriteLine("Windchill  = " + WindChill);
            }
            else
            {
                Console.WriteLine("Input is invalid");
                CalculateWindChill();
            }
            Console.ReadLine();
        }
    }
}
