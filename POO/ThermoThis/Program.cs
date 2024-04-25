using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar a = new Acessar();

            if (a.Login("negaoDObalao"))
            {
                Console.WriteLine("Olá, Seja bem-vido!");
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
            }

            Console.ReadKey();
        }
    }
}
