﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch case
            //int escolha = 0;

            //switch (escolha)
            //{
            //    case 1:
            //        Console.WriteLine("OPÇÃO 1.");
            //        break;
            //    case 2:
            //        Console.WriteLine("OPÇÃO 2.");
            //        break;
            //    case 3:
            //        Console.WriteLine("OPÇÃO 2.");
            //        break;
            //    default:
            //        Console.WriteLine("OPÇÃO INVÁLIDA.");
            //        break;
            //}
            #endregion

            Inicio:
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (opcao)
            {
                default:
                    goto Inicio;
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1;
            }
            Console.WriteLine("Valor final: " + valor); 

            Console.ReadKey();
        }
    }
}
