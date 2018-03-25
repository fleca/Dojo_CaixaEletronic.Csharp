using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Class
{
    public class Cliente
    {

        public string Nome { get; private set; }
        public string RG { get; private set; }
        public double CPF { get; private set; }
        public string DataNascimento { get; private set; }

        public Cliente(string nome, string rg, double cpf, string datanascimento)
        {
            this.Nome = nome;
            this.RG = rg;
            this.CPF = cpf;
            this.DataNascimento = datanascimento;
        }

    }
}
