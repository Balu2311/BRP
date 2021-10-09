using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class temp_convertion
    {
        public void convertTemperature()
        {

            Console.WriteLine("Temperature Conversion");
            int temperature;
            Console.WriteLine("Enter Temperature = ");
            temperature = Convert.ToInt32(Console.ReadLine());
            int input;
            Console.WriteLine("Enter which conversion do you want to perform\n " +
                "1.Celcius To farenheit \n" +
                "2.Fareenheit to Celcius");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    int celciusToFarenheit = (temperature * 9 / 5) + 32;
                    Console.WriteLine("Temperature conversion of celcius to farenheit is " + celciusToFarenheit + " F.");
                    break;

                case 2:
                    int farenheitToCelcius = (temperature - 32) * 5 / 9;
                    Console.WriteLine("Temperature conversion of farenheit to celcius is " + farenheitToCelcius + " C.");
                    break;

                default:
                    Console.WriteLine("Enter proper input");
                    convertTemperature();
                    break;
            }
            Console.ReadLine();
        }
    }
}
