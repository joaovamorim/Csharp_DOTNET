using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region while
            //int valor = 11;

            //while (valor < 10)
            //{
            //    Console.WriteLine("O valor é: " + valor);
            //    valor++;
            //}
            #endregion

            #region do-while
            //int valor = 8;

            //do
            //{
            //    Console.WriteLine("O valor é: " + valor);
            //    valor++;
            //} while (valor < 10);
            #endregion

            #region for
            //for (int i = 0, c = 10; i < 10; i++, c--)
            //{
            //    Console.WriteLine("i: [" + i + "]" + " c: [" + c + "]");
            //}
            #endregion

            string[] nomes = { "João", "Paulo", "Emerson", "Vinicius" };

            foreach (string item in nomes)
            {
                Console.WriteLine("Nome: " + item);
            }

            Console.ReadKey();
        }
    }
}
