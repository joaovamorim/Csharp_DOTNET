using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Aritimeticos
            //int num1 = 10;
            //int num2 = 2;
            //int resultado = num1 + num2;
            #endregion

            #region Precedencia de Operadores
            //double num1 = 100;
            //double num2 = 10;
            //double num3 = 5;

            //double resultado = (num1 + num2) * (num3 / 3);
            #endregion

            #region Incremento e Decremento
            //int num1 = 10;

            //num1++;
            //++num1;
            //num1--;
            //--num1;
            #endregion

            #region Concatenação
            //string nome = "João ";
            //string sobrenome = "Amorim";
            //string nomeCompleto = nome + sobrenome;
            #endregion

            #region Operadores de Atribuição
            //int num1 = 10;
            //num1+= 20;
            #endregion

            #region Operadores Igualdade
            //bool resultado = 100 == 50;
            //bool res = 51 != 69;
            #endregion

            #region Operadores Lógicos
            bool res1 = 100 < 50;
            bool res2 = 50 != 50;

            bool final = res1 && res2;
            bool final2 = res1 || res2;
            #endregion

            Console.WriteLine(final2);
            Console.ReadKey();
        }
    }
}
