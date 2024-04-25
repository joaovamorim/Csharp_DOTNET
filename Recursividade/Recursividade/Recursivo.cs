using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Recursivo
    {
        public void Executar(string menssagem, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(menssagem);
            }
        }

        public void ExecutarRecursivo(string menssagem, int n)
        {
            if(n > 0)
            {
                Console.WriteLine(menssagem);
                ExecutarRecursivo(menssagem, n - 1);
            }
        }
    }
}
