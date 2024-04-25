using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos n = new Metodos();
            //n.Cumprimentar();
            //n.Somar(10, 5);
            //n.Apresentar("João", 21);

            //int valor1 = 100;
            //int valor2 = 100;

            //n.AumentarValor(valor1);
            //n.AumentarRef(ref valor2);

            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);


            //string nomeCompleto = n.MontaNome("João", "Amorim");
            //int codeChar = n.CodigoChar('j');
            //double pi = n.ValorPI();

            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(codeChar);
            //Console.WriteLine(pi);

            n.Cumprimentar();
            n.Cumprimentar("João");
            n.Cumprimentar("João", 9);

            bool res1 = n.Comparar(100, 50 * 2);
            bool res2 = n.Comparar("João", "joão");

            Console.WriteLine(res1);
            Console.WriteLine(res2);

            Console.ReadKey();
        }
    }
}
