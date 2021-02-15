using System;

namespace w3exercises
{
    class Exercise14
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the amount of celsius: ");
            int celsius = int.Parse(Console.ReadLine());
            int kelvin = celsius + 273;
            int fahrenheit = celsius * 18 / 10 + 32;

            Console.WriteLine($"Kelvin = {kelvin}");
            Console.WriteLine($"Fahrenheit = {fahrenheit}");


            Console.ReadLine();
        }
    }
}
