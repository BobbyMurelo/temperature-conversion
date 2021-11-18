using System;

namespace temperature_conversion
{

    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            Console.Write("Enter Fahrenheit temperature : ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius temperature is" + celsius);
            Console.ReadLine();


            
            Console.Write("Enter Celcius temperature : ");
            double celcius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (celcius * 9)/5 + 32;
            Console.WriteLine("Celsius temperature is" + celsius);
            Console.ReadLine();

            if (celcius > fahrenheit)
                Console.WriteLine("Celcius is bigger");
            else
                Console.WriteLine("fahrenheit is bigger");
        }
    }

}
