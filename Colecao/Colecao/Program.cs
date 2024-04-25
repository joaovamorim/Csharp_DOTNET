using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            //int[] numeros = new int[5];

            // numeros[0] = 10;
            // numeros[1] = 20;
            // numeros[2] = 30;
            // numeros[3] = 40;
            // numeros[4] = 50;

            // numeros[3] = 51;

            // Vetor Strings

            //string[] nomes = new string[3];

            //nomes[0] = "Emerson";
            //nomes[1] = "Paulo";
            //nomes[2] = "João";

            //string[] nomes = { "Emerson", "Paulo", "João" };
            #endregion

            #region Matrizes
            int[,] numeros = new int[2, 3];

            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;

            Console.Write("[" + numeros[0, 0] + "]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.WriteLine("[" + numeros[0, 2] + "]");

            
            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.WriteLine("[" + numeros[1, 2] + "]");

            string[,] nomes =
            {
                { "Emerson", "Paulo", "João" },
                { "Felipe", "Fernando", "Fabio" }
            };
            #endregion

            Console.WriteLine(nomes[0, 1]);

            Console.ReadKey();

        }
    }
}
