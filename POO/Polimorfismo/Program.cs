﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forma a = new Forma();
            Forma b = new Triangulo();
            Forma c = new Circulo();
            Forma d = new Retangulo();

            //Console.WriteLine("\nForma:");
            //a.Desenhar();
            Console.WriteLine("\nTriangulo:");
            b.Desenhar();      
            Console.WriteLine("\nCirculo:");
            c.Desenhar();      
            Console.WriteLine("\nRetangulo:");
            d.Desenhar();

            Console.ReadKey();
        }
    }
}
