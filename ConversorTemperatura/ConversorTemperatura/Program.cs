using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit, kelvin;

            Console.WriteLine("=== CONVERSOR DE TEMPERATURAS ===");
            // Celsius
            Console.Write("Digite a temperatura em Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------");

            // Calculo Celsius >> Fahrenheit: (celsius * 9 / 5) + 32
            fahrenheit = (celsius * 9 / 5) + 32;

            // Calculo Celsius >> Fahrenheit: celsius * 273,15
            kelvin = celsius + 273.15;

            Console.WriteLine(celsius + "° Celsius = " + fahrenheit + "° Fahrenheit");
            Console.WriteLine(celsius + "° Celsius = " + kelvin + "° Kelvin");

            Console.WriteLine("---------------------------------");
            Console.ReadKey();
        }
    }
}
