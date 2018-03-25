using CaixaEletronico.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Class
{
    public class ContaInvestimento : Conta, ITributavel
    {

        private const double TAXA_TRIBUTARIA = 0.20;

        public ContaInvestimento(int numero, Cliente titular, double saldo, double cpf, string datanascimento) : base(numero, titular, saldo, cpf, datanascimento)
        {
        }

        public override double CalcularTributo()
        {
            return (base.saldo * TAXA_TRIBUTARIA);
        }
    }
}
