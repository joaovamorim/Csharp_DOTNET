using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta cliente = new Conta();

            cliente.Cliente = "Castro";

            //  Operação de Deposito
            double valor = 100;
            cliente.Depositar(valor);

            // Operação de Saque
            double valor2 = 50;
            cliente.Sacar(valor2);

            // Saldo atual
            Console.WriteLine("Cliente: " + cliente.Cliente);
            Console.WriteLine("Saldo: " + cliente.Saldo);

            Console.ReadKey();
        }
    }
}
