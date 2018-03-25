using CaixaEletronico.Class;
using CaixaEletronico.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.ArquivoTexto;

namespace CaixaEletronico.Base
{
    public abstract class Conta: ITributavel
    {

        private int numero;
        private Cliente titular;
        public double saldo { get; private set; }
        private double cpf;
        private string datanascimento;
        private static StringBuilder comp = new StringBuilder();
        private static GravadorArquivo gravador = new GravadorArquivo();
        private static string caminhoLogs = "C:\\Users\\FeiLie\\Desktop\\Coding Dojo\\CaixaEletronico_Desktop\\Logs.txt";
        private static string caminhoComprovantes = "C:\\Users\\FeiLie\\Desktop\\Coding Dojo\\CaixaEletronico_Desktop\\Comprovantes.txt";

        public Conta(int numero, Cliente titular, double saldo, double cpf, string datanascimento)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
            this.cpf = cpf;
            this.datanascimento = datanascimento;
        }

        private void AdicionaComprovante(string acao, double valor, Conta contaDestino = null)
        {
            acao = acao.ToUpper();
            comp.AppendLine("*************"+ acao +"*************");
            comp.AppendLine("");
            switch (acao)
            {
                case "DEPOSITO":
                    comp.AppendLine(String.Format("CONTA: {0}", this.ExibirNumero()));
                    comp.AppendLine(String.Format("CORRENTISTA: {0}", this.ExibirTitular()));
                    comp.AppendLine(String.Format("VALOR: R${0}", valor));
                    break;

                case "SAQUE":
                    comp.AppendLine(String.Format("CONTA: {0}", this.ExibirNumero()));
                    comp.AppendLine(String.Format("CORRENTISTA: {0}", this.ExibirTitular()));
                    comp.AppendLine(String.Format("VALOR: R${0}", valor));
                    break;

                case "TRANSFERENCIA":
                    comp.AppendLine(String.Format("CONTA SAQUE: {0}", this.ExibirNumero()));
                    comp.AppendLine(String.Format("CORRENTISTA SAQUE: {0}", this.ExibirTitular()));
                    comp.AppendLine("");
                    comp.AppendLine(String.Format("CONTA DEPOSITO: {0}", contaDestino.ExibirNumero()));
                    comp.AppendLine(String.Format("CORRENTISTA DEPOSITO: {0}", contaDestino.ExibirTitular()));
                    comp.AppendLine("");
                    comp.AppendLine(String.Format("VALOR: R${0}", valor));
                    break;

                case "SALDO":
                    comp.AppendLine(String.Format("CONTA: {0}", this.ExibirNumero()));
                    comp.AppendLine(String.Format("CORRENTISTA: {0}", this.ExibirTitular()));
                    comp.Append(String.Format("VALOR BRUTO: R${0}", this.saldo));
                    comp.AppendLine("");
                    comp.AppendLine(String.Format("TRIBUTOS: R${0}", this.CalcularTributo()));
                    comp.AppendLine("");
                    comp.AppendLine(String.Format("SALDO DISPONIVEL: R${0}", (this.saldo - this.CalcularTributo())));
                    break;

                case "TRIBUTOS":
                    comp.AppendLine(String.Format("CONTA: {0}", this.ExibirNumero()));
                    comp.AppendLine(String.Format("CORRENTISTA: {0}", this.ExibirTitular()));
                    comp.AppendLine(String.Format("TRIBUTOS: R${0}", this.CalcularTributo()));
                    break;
                default:
                    break;
            }
            comp.AppendLine("");
            comp.AppendLine(String.Format("feito em: {0}", DateTime.Now));
            comp.AppendLine("*********************************");
            comp.AppendLine("");
            gravador.EscreverArquivo(caminhoComprovantes, comp.ToString());
            comp.Clear();
        }

        protected static void AdicionaLog(string acao)
        {
            string log = "OPERAÇÃO {0} FEITA EM: {1}";
            log = String.Format(log, acao, DateTime.Now).ToUpper();            
            gravador.EscreverArquivo(caminhoLogs, log);
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
            AdicionaLog("deposito");
            this.AdicionaComprovante("deposito", valor);
        }

        public void Sacar(double valor)
        {
            if (valor > this.saldo)
                throw new SaldoInsuficienteException();
            this.saldo -= valor;
            AdicionaLog("saque");
            this.AdicionaComprovante("saque", valor);      
        }


        public void Transferir(Conta destino, double valor)
        {
            this.saldo -= valor;
            destino.saldo += valor;
            AdicionaLog("transferencia");
            this.AdicionaComprovante("transferencia", valor, destino);
        }

        public double RetornarSaldo()
        {
            this.AdicionaComprovante("saldo", this.saldo);
            Conta.AdicionaLog("saldo");
            return this.saldo;
        }

        public void MostrarTributos()
        {
            this.AdicionaComprovante("tributos", this.CalcularTributo());
            AdicionaLog("tributos");
        }

        public double MostrarTributos2()
        {
            this.AdicionaComprovante("tributos", this.CalcularTributo());
            AdicionaLog("tributos");
            return this.CalcularTributo();
        }

        public string ExibirTitular()
        {
            return this.titular.Nome;
        }

        public double ExibirCpf()
        {
            return this.titular.CPF;
        }

        public string ExibirDataNascimento()
        {
            return this.titular.DataNascimento;
        }

        public int ExibirNumero()
        {
            return this.numero;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Conta))
                return false;

            Conta conta = obj as Conta;
            return conta.ExibirNumero() == ExibirNumero();
        }

        public override int GetHashCode()
        {
            return ExibirNumero().GetHashCode();
        }

        public abstract double CalcularTributo();
    }
}
