using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste obj = new Teste();

            obj.Nome = "João";
            obj.Idade = 21;

            Console.WriteLine(obj.Nome + " " + obj.Sobrenome);
            Console.WriteLine(obj.Idade);

            Console.ReadKey();
        }
    }
}
