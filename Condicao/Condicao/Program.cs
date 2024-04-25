using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Condições Simples e Encadeadas.
            //int valor = 21;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição VERDADEIRA.");
            //}
            //else if (valor >= 5 && valor < 10)
            //{
            //    Console.WriteLine("Condição ALTERNATIVA 1.");
            //}
            //else if (valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("Condição ALTERNATIVA 2.");
            //}
            //else
            //{
            //    Console.WriteLine("Condição ALTERNATIVA FINAL.");
            //}
            #endregion

            #region Condições Aninhadas
            //int numero = 3;

            //if (numero > 5)
            //{
            //    Console.Write("O número é maior que 5");

            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine(" e também é PAR.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" mas não é PAR"); 
            //    }
            //}
            #endregion

            #region Operador Ternário
            int numero = 2;
            //string msg = "";
            string msg = numero > 5 ? "Maior que 5." : "Menor que 5.";

            
            // condição ? true : false;
            //msg = numero > 5 ? "Maior que 5." : "Menor que 5.";

            //if (numero > 5)
            //{
            //    msg = "Maior que 5.";
            //}
            //else
            //{
            //    msg = "Menor que 5.";
            //}
            #endregion

            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
