using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicita
            //byte num1 = 100;
            //ushort num2;

            //num2 = num1;

            //float num3 = 51;
            //double num4 = num3;
            #endregion

            #region Explicita
            //ushort num1 = 100;
            //byte num2 = (byte)num1;

            //float num3 = 2500;
            //int num4 = (int)num3;
            #endregion

            #region Metodo Parse
            //string txtnumero = "198a";

            //int numero = int.Parse(txtnumero);

            //byte num1 = byte.Parse("120");

            //double num2 = double.Parse("125623,57");

            //float num3 = float.Parse("457,75");
            #endregion

            #region Metodo Convert
            string texto = Convert.ToString(2500);

            double num1 = Convert.ToDouble(false);

            int num2 = Convert.ToInt32('C');
            #endregion

            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}
