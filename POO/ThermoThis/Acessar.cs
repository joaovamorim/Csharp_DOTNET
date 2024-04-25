using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermoThis
{
    internal class Acessar
    {
        string senha = "negaoDObalao";

        public bool Login(string senha)
        {
            return this.senha == senha;
        }
    }
}
