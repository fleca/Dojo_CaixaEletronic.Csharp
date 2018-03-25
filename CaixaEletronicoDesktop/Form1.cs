using CaixaEletronico.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaixaEletronico.Base;
using CaixaEletronico.Exceptions;
using Util;

namespace CaixaEletronicoDesktop
{
    public partial class Form1 : Form
    {
        public static GerenciadorDeContas GerenciadorDeContasBanco { get; set; }
        public Conta contaAtiva = null;

        public Form1()
        {
            InitializeComponent();
            GerenciadorDeContasBanco = new GerenciadorDeContas();
            lblCriarContaResultado.Visible = false;
        }

        private void botaoContaCorrente_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaCriarContas);
            lblMenuContas.Text = "Criando Conta Corrente";
        }

        private void botaoContaPoupanca_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaCriarContas);
            lblMenuContas.Text = "Criando Conta Poupança";
        }

        private void botaoContaInvestimento_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaCriarContas);
            lblMenuContas.Text = "Criando Conta Investimento";
        }

        private void botaoConsultarConta_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaConsultarConta);
            //   var conta = GerenciadorDeContasBanco.ConsultarContaPorNumero(numero);
        }

        private static T CriarContas<T>(int numero, string nome, string rg, double saldo, double cpf, string datanascimento, Cliente titular) where T : Conta
        {
            T conta = (T)Activator.CreateInstance(typeof(T), new object[] { numero, titular, saldo, cpf, datanascimento });
            GerenciadorDeContasBanco.AdicionarConta(conta);
            return conta;
        }

        private void botaoCriarConta_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtBoxContaNumero.Text);
            if (GerenciadorDeContasBanco.ContaValidaParaCriacao(numero))
            {
                string nome = Convert.ToString(txtBoxContaNome.Text);
                string rg = Convert.ToString(txtBoxContaRG.Text);
                double saldo = Convert.ToDouble(Convert.ToInt32(txtBoxContaSaldo.Text));
                double cpf = Convert.ToDouble(Convert.ToInt64(txtBoxContaCPF.Text));
                string datanascimento = Convert.ToString(txtBoxContaDataNascimento.Text);
                var titular = new Cliente(nome, rg, cpf, datanascimento);
                switch (lblMenuContas.Text)
                {
                    case "Criando Conta Corrente":
                        var cc = CriarContas<ContaCorrente>(numero, nome, rg, saldo, cpf, datanascimento, titular);
                        controladorAbas.SelectTab(abaMenuDaConta);
                        contaAtiva = cc;
                        lblMenuContaCliente.Text = "Cliente: " + nome;
                        lblMenuContaCPF.Text = "CPF: " + cpf;
                        lblMenuContaNascimento.Text = "Data de Nascimento: " + datanascimento;
                        break;
                    case "Criando Conta Poupança":
                        var cp = CriarContas<ContaPoupanca>(numero, nome, rg, saldo, cpf, datanascimento, titular);
                        controladorAbas.SelectTab(abaMenuDaConta);
                        contaAtiva = cp;
                        lblMenuContaCliente.Text = "Cliente: " + nome;
                        lblMenuContaCPF.Text = "CPF: " + cpf;
                        lblMenuContaNascimento.Text = "Data de Nascimento: " + datanascimento;
                        break;
                    case "Criando Conta Investimento":
                        var ci = CriarContas<ContaInvestimento>(numero, nome, rg, saldo, cpf, datanascimento, titular);
                        controladorAbas.SelectTab(abaMenuDaConta);
                        contaAtiva = ci;
                        lblMenuContaCliente.Text = "Cliente: " + nome;
                        lblMenuContaCPF.Text = "CPF: " + cpf;
                        lblMenuContaNascimento.Text = "Data de Nascimento: " + datanascimento;
                        break;
                    default:
                        break;
                }
                txtBoxContaNumero.Text = "";
                txtBoxContaNome.Text = "";
                txtBoxContaRG.Text = "";
                txtBoxContaSaldo.Text = "";
                txtBoxContaCPF.Text = "";
                txtBoxContaDataNascimento.Text = "";
            }
            else
            {
                lblCriarContaResultado.Visible = true;
                lblCriarContaResultado.Text = "Conta Existente!";
            }
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botaoMenuContaSair_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaMenuPrincipal);
        }

        private void botaoConsultarContaConsultar_Click(object sender, EventArgs e)
        {
            if (GerenciadorDeContasBanco.ConsultarContaPorNumero2(Convert.ToInt32(txtConsultarContaNumero.Text)) == null)
            {
                lblConsultaContaResultado.Text = "Conta inexistente!";
            }

            else
            {
                contaAtiva = GerenciadorDeContasBanco.ConsultarContaPorNumero(Convert.ToInt32(txtConsultarContaNumero.Text));
                controladorAbas.SelectTab(abaMenuDaConta);
                lblMenuContaCliente.Text = "Cliente: " + contaAtiva.ExibirTitular();
                lblMenuContaCPF.Text = "CPF: " + contaAtiva.ExibirCpf();
                lblMenuContaNascimento.Text = "Data de Nascimento: " + contaAtiva.ExibirDataNascimento();
            }
        }

        private void botaoMenuContaDeposito_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaDeposito);
        }

        private void botaoMenuContaSaque_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaSaque);
        }

        private void botaoMenuContaTransferir_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaTransferir);
        }

        private void botaoMenuContaSaldo_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaSaldo);
            lblSaldoAtual.Visible = true;
            lblSaldoAtual.Text = "Saldo atual: R$" + contaAtiva.saldo;
            contaAtiva.RetornarSaldo();
        }

        private void botaoMenuContaTributos_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaTributos);
            lblResultadoTributos.Visible = true;
            lblResultadoTributos.Text = "Total de tributos: R$" + contaAtiva.MostrarTributos2();
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(textValorDeposito.Text);
            contaAtiva.Depositar(valor);
            lblDepositoRealizado.Visible = true;
            lblDepositoSaldoAtual.Visible = true;
            lblDepositoSaldoAtual.Text = "Saldo atual: R$" + contaAtiva.saldo;
        }

        private void botaoVoltarDeposito_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaMenuDaConta);
            textValorDeposito.Text = "";
            lblDepositoSaldoAtual.Visible = false;
            lblDepositoRealizado.Visible = false;
            lblMenuContaCliente.Text = "Cliente: " + contaAtiva.ExibirTitular();
            lblMenuContaCPF.Text = "CPF: " + contaAtiva.ExibirCpf();
            lblMenuContaNascimento.Text = "Data de Nascimento: " + contaAtiva.ExibirDataNascimento();
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txtValorSaque.Text);
            if (contaAtiva.saldo < valor)
            {
                lblSaldoSaque.Visible = true;
                lblSaldoSaque.Text = "Saldo insuficiente!";
            }
            else
            {
                contaAtiva.Sacar(valor);
                lblSaqueRealizado.Visible = true;
                lblSaldoSaque.Visible = true;
                lblSaldoSaque.Text = "Saldo atual: R$" + contaAtiva.saldo;
            }
        }

        private void botaoVoltarSaque_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaMenuDaConta);
            txtValorSaque.Text = "";
            lblSaldoSaque.Visible = false;
            lblSaqueRealizado.Visible = false;
            lblMenuContaCliente.Text = "Cliente: " + contaAtiva.ExibirTitular();
            lblMenuContaCPF.Text = "CPF: " + contaAtiva.ExibirCpf();
            lblMenuContaNascimento.Text = "Data de Nascimento: " + contaAtiva.ExibirDataNascimento();
        }

        private void botaoTransferencia_Click(object sender, EventArgs e)
        {
            if (GerenciadorDeContasBanco.ConsultarContaPorNumero2(Convert.ToInt32(txtContaTransferencia.Text)) == null)
            {
                lblResultadoContaTransferencia.Visible = true;
                lblResultadoContaTransferencia.Text = "Conta inexistente!";
            }
            else
            {
                if (txtValorTransferencia.Text != "" && txtValorTransferencia.Text != null && Convert.ToInt32(txtValorTransferencia.Text) > 0)
                {
                    lblResultadoContaTransferencia.Visible = false;
                    var contaDestino = GerenciadorDeContasBanco.ConsultarContaPorNumero2(Convert.ToInt32(txtContaTransferencia.Text));
                    int valor = Convert.ToInt32(txtValorTransferencia.Text);
                    if (contaAtiva.saldo < valor)
                    {
                        lblResultadoValorTransferencia.Visible = true;
                        lblResultadoValorTransferencia.Text = "Saldo insuficiente!";
                    }
                    else
                    {
                        lblResultadoValorTransferencia.Visible = false;
                        contaAtiva.Transferir(contaDestino, valor);
                        lblResultadoTransferencia.Visible = true;
                        lblResultadoTransferencia.Text = "Transferencia realizada!";
                        lblSaldoAtualTransferencia.Visible = true;
                        lblSaldoAtualTransferencia.Text = "Saldo atual: " + contaAtiva.saldo;
                    }
                }
                else
                {
                    lblResultadoValorTransferencia.Visible = true;
                    lblResultadoValorTransferencia.Text = "Valor de transferencia inválido!";
                }
            }
        }

        private void botaoTransferenciaVoltar_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaMenuDaConta);
            lblResultadoTransferencia.Visible = false;
            lblResultadoValorTransferencia.Visible = false;
            lblResultadoContaTransferencia.Visible = false;
            lblSaldoAtualTransferencia.Visible = false;
            txtContaTransferencia.Text = "";
            txtValorTransferencia.Text = "";
            lblMenuContaCliente.Text = "Cliente: " + contaAtiva.ExibirTitular();
            lblMenuContaCPF.Text = "CPF: " + contaAtiva.ExibirCpf();
            lblMenuContaNascimento.Text = "Data de Nascimento: " + contaAtiva.ExibirDataNascimento();
        }

        private void abaTransferir_Click(object sender, EventArgs e)
        {

        }

        private void botaoVoltarSaldo_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaMenuDaConta);
            lblMenuContaCliente.Text = "Cliente: " + contaAtiva.ExibirTitular();
            lblMenuContaCPF.Text = "CPF: " + contaAtiva.ExibirCpf();
            lblMenuContaNascimento.Text = "Data de Nascimento: " + contaAtiva.ExibirDataNascimento();
        }

        private void botaoVoltarTributos_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaMenuDaConta);
            lblMenuContaCliente.Text = "Cliente: " + contaAtiva.ExibirTitular();
            lblMenuContaCPF.Text = "CPF: " + contaAtiva.ExibirCpf();
            lblMenuContaNascimento.Text = "Data de Nascimento: " + contaAtiva.ExibirDataNascimento();
        }
    }
}