using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        delegate void Operacao(int num1, int num2);

        static void Main(string[] args)
        {
            Matematica obj = new Matematica();

            Operacao conta = null;

            conta += obj.Divisao;
            conta += obj.Subtrair;
            conta += obj.Multiplicacao;
            conta += obj.Somar;

            conta(10, 2);

            Console.WriteLine();

            conta -= obj.Divisao,;
            conta -= obj.Subtrair;

            conta(15, 3);

            Console.ReadKey();
        }
    }
}
