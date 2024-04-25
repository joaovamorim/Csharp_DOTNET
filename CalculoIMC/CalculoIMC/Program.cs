using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura em Metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("\nSeu IMC é " + valorIMC + ", você está ABAIXO DO PESO.");
            }
            else if ((valorIMC >= 20) && (valorIMC <= 24))
            {
                Console.WriteLine("\nSeu IMC é " + valorIMC + ", você está no seu PESO NORMAL.");
            }
            else if ((valorIMC >= 25) && (valorIMC <= 29))
            {
                Console.WriteLine("\n Seu IMC é " + valorIMC + ", você está ACIMA DO PESO.");
            }
            else if ((valorIMC >= 30) && (valorIMC <= 34))
            {
                Console.WriteLine("\nSeu IMC é " + valorIMC + ", você está OBESO(A).");
            }
            else
            {
                Console.WriteLine("\nSeu IMC é " + valorIMC + ", você está com OBESIDADE GRAVE.");
            }

            Console.ReadKey();
        }
    }
}
