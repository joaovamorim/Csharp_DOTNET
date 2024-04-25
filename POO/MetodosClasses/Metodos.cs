using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosClasses
{
    internal class Metodos
    {
        // Métodos Simples
        public void Cumprimentar()
        {
            #region
            Console.WriteLine("Olá, seja Bem-Vindo!");
            #endregion
        }

        // Métodos com Parâmetros
        public void Somar(int num1, int num2)
        {
            #region
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: " + resultado);
            #endregion
        }

        public void Apresentar(string nome, int idade)
        {
            #region
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos.");
            #endregion
        }

        // Métodos de passagem por Valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor): " + valor);
        }
        
        // Métodos de passagem por Referência
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por referência): " + valor);
        }

        // Métodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            //string nomeCompleto = nome + " " + sobrenome;
            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere)
        {
            //int code = caractere;
            return caractere;
        }

        public double ValorPI()
        {
            return 3.1415;
        }

        // Sobrecarga de métodos
        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }

        public void Cumprimentar(string nome, int hora)
        {
            string msg = hora < 12 ? "Bom dia " + nome : "Boa tarde " + nome;
            Console.WriteLine(msg);
        }

        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;
        }

        public bool Comparar(string texto1, string texto2)
        {
            return texto1 == texto2;
        }
    }
}
