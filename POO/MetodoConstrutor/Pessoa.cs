using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Pessoa
    {
        public string nome;
        public string sobreNome;
        public int anoNascimento;
        public int idade;

        public Pessoa()
        {
            nome = "Desconhecido";
            sobreNome = "Nenhum";
            anoNascimento = 0;
            idade = 0;
        }

        public Pessoa(string nome, string sobreNome, int anoNascimento)
        {
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.anoNascimento = anoNascimento;
            this.idade = Idade();
        }

        public Pessoa(string nome, string sobreNome)
        {
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.anoNascimento = 2005;
            this.idade = Idade();
        }

        private int Idade()
        {
            return 2024 - anoNascimento;
        }
    }
}
