﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.nome = "João";

            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.sobreNome);
            Console.WriteLine(p1.anoNascimento);

            Console.WriteLine();

            Pessoa p2 = new Pessoa("João", "Amorim", 2003);

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.sobreNome);
            Console.WriteLine(p2.anoNascimento);
            Console.WriteLine(p2.idade);

            Console.WriteLine();

            Pessoa p3 = new Pessoa("Vinicius", "Amorim");

            Console.WriteLine(p3.nome);
            Console.WriteLine(p3.sobreNome);
            Console.WriteLine(p3.anoNascimento);
            Console.WriteLine(p3.idade);

            Console.ReadLine();
        }
    }
}
