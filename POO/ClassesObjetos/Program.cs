using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse objeto2 = null;

            //OutraClasse outroObj = new OutraClasse();
            //OutraClasse outroObj2 = outroObj;
            #endregion

            Pessoa Pessoa1 = new Pessoa();
            Pessoa1.nome = "João";
            Pessoa1.sobrenome = "Amorim";
            Pessoa1.anoNascimento = 2003;

            Pessoa Pessoa2 = new Pessoa()
            {
                nome = "Paulo",
                sobrenome = "Amorim",
                anoNascimento = 1999
            };

            Pessoa1.nome = "Vinicius";

            // Pessoa1
            Console.WriteLine("Pessoa #1: " + Pessoa1.nome);
            Console.WriteLine("Pessoa #1: " + Pessoa1.sobrenome);
            Console.WriteLine("Pessoa #1: " + Pessoa1.anoNascimento);
            Pessoa1.Cumprimentar();

            // Pessoa2
            Console.WriteLine("\nPessoa #2: " + Pessoa2.nome);
            Console.WriteLine("Pessoa #2: " + Pessoa2.sobrenome);
            Console.WriteLine("Pessoa #2: " + Pessoa2.anoNascimento);
            Pessoa2.Cumprimentar();

            Console.ReadKey();
        }
    }

    class MinhaClasse
    {

    }

}
