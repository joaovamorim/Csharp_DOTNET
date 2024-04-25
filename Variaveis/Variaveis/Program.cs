using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        //enum notas
        //{
        //    Minimo = 0,
        //    Media = 5,
        //    Maxima = 10
        //}

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        static void Main(string[] args)
        {
            #region Numeros inteiros
            // Integral assinado - aceitam numeros negativos
            //sbyte num1 = 10;
            //short num2 = 20;
            //int num3 = 30;
            //long num4 = 40L;

            // Integal sem sinal
            //byte num5 = 10;
            //ushort num6 = 20;
            //uint num7 = 30;
            //ulong num8 = 40L;


            //sbyte num = -120;
            //int numero;
            //num2 = 51;
            #endregion

            #region Numeros decimais
            //float real1 = 100.20f;
            //double real2 = 575.200;
            //decimal real3 = 600.452m;
            #endregion

            #region Tipo de Caractere
            // char letra = 'J';
            #endregion

            #region Tipo Booleano
            //bool verificar = false;
            //verificar = true;
            #endregion

            #region Tipo String
            //string texto = "João Victor Amorim";
            //string mensagem = null;
            //mensagem = texto;
            #endregion

            #region Tipo Var
            /*var valor = 100*/;
            #endregion

            #region Tipo Object
            //object obj = 10;
            //obj = "João";
            #endregion

            #region Tipo Constantes
            //const double pi = 3.1415;
            #endregion

            #region Tipo Enumerações
            //notas NotasAlunos = notas.Media;
            #endregion

            #region Tipo Estrturas
            Pessoa p1 = new Pessoa();
            p1.nome = "João";
            p1.idade = 21;
            p1.altura = 1.70;

            Pessoa p2 = new Pessoa()
            {
                nome = "Vinicius",
                idade = 24,
                altura = 1.49
            };

            p1.nome = "Paulo";
            #endregion

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.altura);
            Console.ReadKey();
        }
    }
}
