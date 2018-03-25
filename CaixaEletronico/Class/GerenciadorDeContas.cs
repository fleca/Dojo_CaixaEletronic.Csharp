using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CaixaEletronico.Class
{
    using Base;
    using Exceptions;

    public class GerenciadorDeContas
    {
        public GerenciadorDeContas()
        {
            this.Contas = new List<Conta>();
        }

        public IList<Conta> Contas { get; protected set; }

        public void AdicionarConta(Conta cc)
        {
            if (!this.Contas.Contains(cc))
            {
                this.Contas.Add(cc);
            }
            else
            {
                throw new ContaExistenteException();
            }
        }

        public bool ContaValidaParaCriacao(int numero)
        {
            return this.Contas.All(c => c.ExibirNumero() != numero);
        }

        public bool ExisteContaPorNumero(int numero)
        {
            return this.Contas.Any(c => c.ExibirNumero() == numero);
        }


        public bool Transferir(int numeroContaDeSaque, int numeroContaDeDeposito, double valorTransferencia)
        {
            var contaSaque = this.Contas.FirstOrDefault(c => c.ExibirNumero() == numeroContaDeSaque);
            var contaDeposito = this.Contas.FirstOrDefault(c => c.ExibirNumero() == numeroContaDeDeposito);
            if (contaSaque == contaDeposito)
                throw new ContaIdenticaException();
            if (contaSaque == null || contaDeposito == null)
                throw new ContaInexistenteException();
            if (valorTransferencia > contaDeposito.saldo)
                throw new SaldoInsuficienteException();

            contaSaque.Transferir(ConsultarContaPorNumero(numeroContaDeDeposito), valorTransferencia);
   //         contaSaque.Sacar(valorTransferencia);
       //     contaDeposito.Depositar(valorTransferencia);

            //TODO: validar operacao
            return true;
        }

        public Conta ConsultarContaPorNumero(int numero)
        {
            var conta = this.Contas.FirstOrDefault(c => c.ExibirNumero() == numero);
            if (conta == null)
                throw new ContaInexistenteException();
            return conta;
        }

        public Conta ConsultarContaPorNumero2(int numero)
        {
            var conta = this.Contas.FirstOrDefault(c => c.ExibirNumero() == numero);
            return conta;
        }
    }
}
