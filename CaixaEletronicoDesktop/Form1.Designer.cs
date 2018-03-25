using System;

namespace CaixaEletronicoDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controladorAbas = new System.Windows.Forms.TabControl();
            this.abaMenuPrincipal = new System.Windows.Forms.TabPage();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoConsultarConta = new System.Windows.Forms.Button();
            this.botaoContaInvestimento = new System.Windows.Forms.Button();
            this.botaoContaPoupanca = new System.Windows.Forms.Button();
            this.botaoContaCorrente = new System.Windows.Forms.Button();
            this.abaCriarContas = new System.Windows.Forms.TabPage();
            this.lblCriarContaResultado = new System.Windows.Forms.Label();
            this.botaoCriarConta = new System.Windows.Forms.Button();
            this.lblContaDataNascimento = new System.Windows.Forms.Label();
            this.lblContaCPF = new System.Windows.Forms.Label();
            this.lblContaSaldo = new System.Windows.Forms.Label();
            this.lblContaRG = new System.Windows.Forms.Label();
            this.lblContaNome = new System.Windows.Forms.Label();
            this.lblContaNumero = new System.Windows.Forms.Label();
            this.txtBoxContaDataNascimento = new System.Windows.Forms.TextBox();
            this.txtBoxContaCPF = new System.Windows.Forms.TextBox();
            this.txtBoxContaSaldo = new System.Windows.Forms.TextBox();
            this.txtBoxContaRG = new System.Windows.Forms.TextBox();
            this.txtBoxContaNome = new System.Windows.Forms.TextBox();
            this.lblMenuContas = new System.Windows.Forms.Label();
            this.txtBoxContaNumero = new System.Windows.Forms.TextBox();
            this.abaMenuDaConta = new System.Windows.Forms.TabPage();
            this.botaoMenuContaSair = new System.Windows.Forms.Button();
            this.botaoMenuContaSaldo = new System.Windows.Forms.Button();
            this.botaoMenuContaTributos = new System.Windows.Forms.Button();
            this.botaoMenuContaTransferir = new System.Windows.Forms.Button();
            this.botaoMenuContaSaque = new System.Windows.Forms.Button();
            this.botaoMenuContaDeposito = new System.Windows.Forms.Button();
            this.lblMenuContaNascimento = new System.Windows.Forms.Label();
            this.lblMenuContaCPF = new System.Windows.Forms.Label();
            this.lblMenuContaCliente = new System.Windows.Forms.Label();
            this.lblMenuConta = new System.Windows.Forms.Label();
            this.abaConsultarConta = new System.Windows.Forms.TabPage();
            this.lblConsultaContaResultado = new System.Windows.Forms.Label();
            this.botaoConsultarContaConsultar = new System.Windows.Forms.Button();
            this.botaoConsultarContaVoltar = new System.Windows.Forms.Button();
            this.txtConsultarContaNumero = new System.Windows.Forms.TextBox();
            this.lblConsultarContaNumero = new System.Windows.Forms.Label();
            this.lblMenuConsultaConta = new System.Windows.Forms.Label();
            this.abaDeposito = new System.Windows.Forms.TabPage();
            this.lblDepositoRealizado = new System.Windows.Forms.Label();
            this.botaoVoltarDeposito = new System.Windows.Forms.Button();
            this.lblDepositoSaldoAtual = new System.Windows.Forms.Label();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.textValorDeposito = new System.Windows.Forms.TextBox();
            this.lblValorDeposito = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.abaSaque = new System.Windows.Forms.TabPage();
            this.lblSaqueRealizado = new System.Windows.Forms.Label();
            this.lblSaldoSaque = new System.Windows.Forms.Label();
            this.botaoVoltarSaque = new System.Windows.Forms.Button();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.txtValorSaque = new System.Windows.Forms.TextBox();
            this.lblValorSaque = new System.Windows.Forms.Label();
            this.lblSaque = new System.Windows.Forms.Label();
            this.abaTransferir = new System.Windows.Forms.TabPage();
            this.lblSaldoAtualTransferencia = new System.Windows.Forms.Label();
            this.botaoTransferenciaVoltar = new System.Windows.Forms.Button();
            this.lblResultadoValorTransferencia = new System.Windows.Forms.Label();
            this.lblResultadoContaTransferencia = new System.Windows.Forms.Label();
            this.lblResultadoTransferencia = new System.Windows.Forms.Label();
            this.botaoTransferencia = new System.Windows.Forms.Button();
            this.txtValorTransferencia = new System.Windows.Forms.TextBox();
            this.txtContaTransferencia = new System.Windows.Forms.TextBox();
            this.lblValorTransferencia = new System.Windows.Forms.Label();
            this.lblContaTransferir = new System.Windows.Forms.Label();
            this.lblTransferir = new System.Windows.Forms.Label();
            this.abaSaldo = new System.Windows.Forms.TabPage();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.botaoVoltarSaldo = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.abaTributos = new System.Windows.Forms.TabPage();
            this.lblResultadoTributos = new System.Windows.Forms.Label();
            this.lblTributos = new System.Windows.Forms.Label();
            this.botaoVoltarTributos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controladorAbas.SuspendLayout();
            this.abaMenuPrincipal.SuspendLayout();
            this.abaCriarContas.SuspendLayout();
            this.abaMenuDaConta.SuspendLayout();
            this.abaConsultarConta.SuspendLayout();
            this.abaDeposito.SuspendLayout();
            this.abaSaque.SuspendLayout();
            this.abaTransferir.SuspendLayout();
            this.abaSaldo.SuspendLayout();
            this.abaTributos.SuspendLayout();
            this.SuspendLayout();
            // 
            // controladorAbas
            // 
            this.controladorAbas.Controls.Add(this.abaMenuPrincipal);
            this.controladorAbas.Controls.Add(this.abaCriarContas);
            this.controladorAbas.Controls.Add(this.abaMenuDaConta);
            this.controladorAbas.Controls.Add(this.abaConsultarConta);
            this.controladorAbas.Controls.Add(this.abaDeposito);
            this.controladorAbas.Controls.Add(this.abaSaque);
            this.controladorAbas.Controls.Add(this.abaTransferir);
            this.controladorAbas.Controls.Add(this.abaSaldo);
            this.controladorAbas.Controls.Add(this.abaTributos);
            this.controladorAbas.Location = new System.Drawing.Point(13, 13);
            this.controladorAbas.Name = "controladorAbas";
            this.controladorAbas.SelectedIndex = 0;
            this.controladorAbas.Size = new System.Drawing.Size(871, 546);
            this.controladorAbas.TabIndex = 0;
            // 
            // abaMenuPrincipal
            // 
            this.abaMenuPrincipal.BackColor = System.Drawing.Color.DarkGray;
            this.abaMenuPrincipal.Controls.Add(this.lblMenuPrincipal);
            this.abaMenuPrincipal.Controls.Add(this.botaoSair);
            this.abaMenuPrincipal.Controls.Add(this.botaoConsultarConta);
            this.abaMenuPrincipal.Controls.Add(this.botaoContaInvestimento);
            this.abaMenuPrincipal.Controls.Add(this.botaoContaPoupanca);
            this.abaMenuPrincipal.Controls.Add(this.botaoContaCorrente);
            this.abaMenuPrincipal.Location = new System.Drawing.Point(4, 22);
            this.abaMenuPrincipal.Name = "abaMenuPrincipal";
            this.abaMenuPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.abaMenuPrincipal.Size = new System.Drawing.Size(863, 520);
            this.abaMenuPrincipal.TabIndex = 0;
            this.abaMenuPrincipal.Text = "MenuPrincipal";
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.Location = new System.Drawing.Point(42, 41);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(128, 22);
            this.lblMenuPrincipal.TabIndex = 5;
            this.lblMenuPrincipal.Text = "Menu Principal";
            // 
            // botaoSair
            // 
            this.botaoSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSair.Location = new System.Drawing.Point(701, 411);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(107, 66);
            this.botaoSair.TabIndex = 4;
            this.botaoSair.Text = "Sair";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // botaoConsultarConta
            // 
            this.botaoConsultarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoConsultarConta.Location = new System.Drawing.Point(351, 328);
            this.botaoConsultarConta.Name = "botaoConsultarConta";
            this.botaoConsultarConta.Size = new System.Drawing.Size(150, 91);
            this.botaoConsultarConta.TabIndex = 3;
            this.botaoConsultarConta.Text = "Consultar Conta";
            this.botaoConsultarConta.UseVisualStyleBackColor = true;
            this.botaoConsultarConta.Click += new System.EventHandler(this.botaoConsultarConta_Click);
            // 
            // botaoContaInvestimento
            // 
            this.botaoContaInvestimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoContaInvestimento.Location = new System.Drawing.Point(658, 168);
            this.botaoContaInvestimento.Name = "botaoContaInvestimento";
            this.botaoContaInvestimento.Size = new System.Drawing.Size(150, 91);
            this.botaoContaInvestimento.TabIndex = 2;
            this.botaoContaInvestimento.Text = "Conta Investimentos";
            this.botaoContaInvestimento.UseVisualStyleBackColor = true;
            this.botaoContaInvestimento.Click += new System.EventHandler(this.botaoContaInvestimento_Click);
            // 
            // botaoContaPoupanca
            // 
            this.botaoContaPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoContaPoupanca.Location = new System.Drawing.Point(351, 168);
            this.botaoContaPoupanca.Name = "botaoContaPoupanca";
            this.botaoContaPoupanca.Size = new System.Drawing.Size(150, 91);
            this.botaoContaPoupanca.TabIndex = 1;
            this.botaoContaPoupanca.Text = "Conta Poupança";
            this.botaoContaPoupanca.UseVisualStyleBackColor = true;
            this.botaoContaPoupanca.Click += new System.EventHandler(this.botaoContaPoupanca_Click);
            // 
            // botaoContaCorrente
            // 
            this.botaoContaCorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoContaCorrente.Location = new System.Drawing.Point(46, 168);
            this.botaoContaCorrente.Name = "botaoContaCorrente";
            this.botaoContaCorrente.Size = new System.Drawing.Size(150, 91);
            this.botaoContaCorrente.TabIndex = 0;
            this.botaoContaCorrente.Text = "Conta Corrente";
            this.botaoContaCorrente.UseVisualStyleBackColor = true;
            this.botaoContaCorrente.Click += new System.EventHandler(this.botaoContaCorrente_Click);
            // 
            // abaCriarContas
            // 
            this.abaCriarContas.BackColor = System.Drawing.Color.DarkGray;
            this.abaCriarContas.Controls.Add(this.lblCriarContaResultado);
            this.abaCriarContas.Controls.Add(this.botaoCriarConta);
            this.abaCriarContas.Controls.Add(this.lblContaDataNascimento);
            this.abaCriarContas.Controls.Add(this.lblContaCPF);
            this.abaCriarContas.Controls.Add(this.lblContaSaldo);
            this.abaCriarContas.Controls.Add(this.lblContaRG);
            this.abaCriarContas.Controls.Add(this.lblContaNome);
            this.abaCriarContas.Controls.Add(this.lblContaNumero);
            this.abaCriarContas.Controls.Add(this.txtBoxContaDataNascimento);
            this.abaCriarContas.Controls.Add(this.txtBoxContaCPF);
            this.abaCriarContas.Controls.Add(this.txtBoxContaSaldo);
            this.abaCriarContas.Controls.Add(this.txtBoxContaRG);
            this.abaCriarContas.Controls.Add(this.txtBoxContaNome);
            this.abaCriarContas.Controls.Add(this.lblMenuContas);
            this.abaCriarContas.Controls.Add(this.txtBoxContaNumero);
            this.abaCriarContas.Location = new System.Drawing.Point(4, 22);
            this.abaCriarContas.Name = "abaCriarContas";
            this.abaCriarContas.Padding = new System.Windows.Forms.Padding(3);
            this.abaCriarContas.Size = new System.Drawing.Size(863, 520);
            this.abaCriarContas.TabIndex = 1;
            this.abaCriarContas.Text = "CriarConta";
            // 
            // lblCriarContaResultado
            // 
            this.lblCriarContaResultado.AutoSize = true;
            this.lblCriarContaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarContaResultado.Location = new System.Drawing.Point(623, 468);
            this.lblCriarContaResultado.Name = "lblCriarContaResultado";
            this.lblCriarContaResultado.Size = new System.Drawing.Size(58, 22);
            this.lblCriarContaResultado.TabIndex = 14;
            this.lblCriarContaResultado.Text = "label1";
            this.lblCriarContaResultado.Click += new System.EventHandler(this.lblCriarContaResultado_Click);
            // 
            // botaoCriarConta
            // 
            this.botaoCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCriarConta.Location = new System.Drawing.Point(663, 366);
            this.botaoCriarConta.Name = "botaoCriarConta";
            this.botaoCriarConta.Size = new System.Drawing.Size(136, 77);
            this.botaoCriarConta.TabIndex = 13;
            this.botaoCriarConta.Text = "Criar Conta";
            this.botaoCriarConta.UseVisualStyleBackColor = true;
            this.botaoCriarConta.Click += new System.EventHandler(this.botaoCriarConta_Click);
            // 
            // lblContaDataNascimento
            // 
            this.lblContaDataNascimento.AutoSize = true;
            this.lblContaDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaDataNascimento.Location = new System.Drawing.Point(64, 394);
            this.lblContaDataNascimento.Name = "lblContaDataNascimento";
            this.lblContaDataNascimento.Size = new System.Drawing.Size(172, 22);
            this.lblContaDataNascimento.TabIndex = 12;
            this.lblContaDataNascimento.Text = "Data de Nascimento";
            // 
            // lblContaCPF
            // 
            this.lblContaCPF.AutoSize = true;
            this.lblContaCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaCPF.Location = new System.Drawing.Point(64, 338);
            this.lblContaCPF.Name = "lblContaCPF";
            this.lblContaCPF.Size = new System.Drawing.Size(102, 22);
            this.lblContaCPF.TabIndex = 11;
            this.lblContaCPF.Text = "CPF Titular";
            // 
            // lblContaSaldo
            // 
            this.lblContaSaldo.AutoSize = true;
            this.lblContaSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaSaldo.Location = new System.Drawing.Point(64, 280);
            this.lblContaSaldo.Name = "lblContaSaldo";
            this.lblContaSaldo.Size = new System.Drawing.Size(134, 22);
            this.lblContaSaldo.TabIndex = 10;
            this.lblContaSaldo.Text = "Saldo da Conta";
            // 
            // lblContaRG
            // 
            this.lblContaRG.AutoSize = true;
            this.lblContaRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaRG.Location = new System.Drawing.Point(64, 221);
            this.lblContaRG.Name = "lblContaRG";
            this.lblContaRG.Size = new System.Drawing.Size(93, 22);
            this.lblContaRG.TabIndex = 9;
            this.lblContaRG.Text = "RG Titular";
            // 
            // lblContaNome
            // 
            this.lblContaNome.AutoSize = true;
            this.lblContaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaNome.Location = new System.Drawing.Point(64, 163);
            this.lblContaNome.Name = "lblContaNome";
            this.lblContaNome.Size = new System.Drawing.Size(113, 22);
            this.lblContaNome.TabIndex = 8;
            this.lblContaNome.Text = "Nome Titular";
            // 
            // lblContaNumero
            // 
            this.lblContaNumero.AutoSize = true;
            this.lblContaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaNumero.Location = new System.Drawing.Point(64, 109);
            this.lblContaNumero.Name = "lblContaNumero";
            this.lblContaNumero.Size = new System.Drawing.Size(151, 22);
            this.lblContaNumero.TabIndex = 7;
            this.lblContaNumero.Text = "Numero da Conta";
            // 
            // txtBoxContaDataNascimento
            // 
            this.txtBoxContaDataNascimento.Location = new System.Drawing.Point(258, 396);
            this.txtBoxContaDataNascimento.Name = "txtBoxContaDataNascimento";
            this.txtBoxContaDataNascimento.Size = new System.Drawing.Size(300, 20);
            this.txtBoxContaDataNascimento.TabIndex = 6;
            this.txtBoxContaDataNascimento.TextChanged += new System.EventHandler(this.txtBoxContaDataNascimento_TextChanged);
            // 
            // txtBoxContaCPF
            // 
            this.txtBoxContaCPF.Location = new System.Drawing.Point(258, 340);
            this.txtBoxContaCPF.Name = "txtBoxContaCPF";
            this.txtBoxContaCPF.Size = new System.Drawing.Size(300, 20);
            this.txtBoxContaCPF.TabIndex = 5;
            this.txtBoxContaCPF.TextChanged += new System.EventHandler(this.txtBoxContaCPF_TextChanged);
            // 
            // txtBoxContaSaldo
            // 
            this.txtBoxContaSaldo.Location = new System.Drawing.Point(258, 282);
            this.txtBoxContaSaldo.Name = "txtBoxContaSaldo";
            this.txtBoxContaSaldo.Size = new System.Drawing.Size(300, 20);
            this.txtBoxContaSaldo.TabIndex = 4;
            this.txtBoxContaSaldo.TextChanged += new System.EventHandler(this.txtBoxContaSaldo_TextChanged);
            // 
            // txtBoxContaRG
            // 
            this.txtBoxContaRG.Location = new System.Drawing.Point(258, 223);
            this.txtBoxContaRG.Name = "txtBoxContaRG";
            this.txtBoxContaRG.Size = new System.Drawing.Size(300, 20);
            this.txtBoxContaRG.TabIndex = 3;
            this.txtBoxContaRG.TextChanged += new System.EventHandler(this.txtBoxContaRG_TextChanged);
            // 
            // txtBoxContaNome
            // 
            this.txtBoxContaNome.Location = new System.Drawing.Point(258, 165);
            this.txtBoxContaNome.Name = "txtBoxContaNome";
            this.txtBoxContaNome.Size = new System.Drawing.Size(300, 20);
            this.txtBoxContaNome.TabIndex = 2;
            this.txtBoxContaNome.TextChanged += new System.EventHandler(this.txtBoxContaNome_TextChanged);
            // 
            // lblMenuContas
            // 
            this.lblMenuContas.AutoSize = true;
            this.lblMenuContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuContas.Location = new System.Drawing.Point(37, 32);
            this.lblMenuContas.Name = "lblMenuContas";
            this.lblMenuContas.Size = new System.Drawing.Size(201, 22);
            this.lblMenuContas.TabIndex = 1;
            this.lblMenuContas.Text = "Criando Conta Corrente";
            // 
            // txtBoxContaNumero
            // 
            this.txtBoxContaNumero.Location = new System.Drawing.Point(258, 109);
            this.txtBoxContaNumero.Name = "txtBoxContaNumero";
            this.txtBoxContaNumero.Size = new System.Drawing.Size(300, 20);
            this.txtBoxContaNumero.TabIndex = 0;
            this.txtBoxContaNumero.TextChanged += new System.EventHandler(this.txtBoxContaNumero_TextChanged);
            // 
            // abaMenuDaConta
            // 
            this.abaMenuDaConta.BackColor = System.Drawing.Color.DarkGray;
            this.abaMenuDaConta.Controls.Add(this.botaoMenuContaSair);
            this.abaMenuDaConta.Controls.Add(this.botaoMenuContaSaldo);
            this.abaMenuDaConta.Controls.Add(this.botaoMenuContaTributos);
            this.abaMenuDaConta.Controls.Add(this.botaoMenuContaTransferir);
            this.abaMenuDaConta.Controls.Add(this.botaoMenuContaSaque);
            this.abaMenuDaConta.Controls.Add(this.botaoMenuContaDeposito);
            this.abaMenuDaConta.Controls.Add(this.lblMenuContaNascimento);
            this.abaMenuDaConta.Controls.Add(this.lblMenuContaCPF);
            this.abaMenuDaConta.Controls.Add(this.lblMenuContaCliente);
            this.abaMenuDaConta.Controls.Add(this.lblMenuConta);
            this.abaMenuDaConta.Location = new System.Drawing.Point(4, 22);
            this.abaMenuDaConta.Name = "abaMenuDaConta";
            this.abaMenuDaConta.Padding = new System.Windows.Forms.Padding(3);
            this.abaMenuDaConta.Size = new System.Drawing.Size(863, 520);
            this.abaMenuDaConta.TabIndex = 2;
            this.abaMenuDaConta.Text = "MenuDaConta";
            // 
            // botaoMenuContaSair
            // 
            this.botaoMenuContaSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMenuContaSair.Location = new System.Drawing.Point(714, 410);
            this.botaoMenuContaSair.Name = "botaoMenuContaSair";
            this.botaoMenuContaSair.Size = new System.Drawing.Size(90, 58);
            this.botaoMenuContaSair.TabIndex = 9;
            this.botaoMenuContaSair.Text = "Voltar";
            this.botaoMenuContaSair.UseVisualStyleBackColor = true;
            this.botaoMenuContaSair.Click += new System.EventHandler(this.botaoMenuContaSair_Click);
            // 
            // botaoMenuContaSaldo
            // 
            this.botaoMenuContaSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMenuContaSaldo.Location = new System.Drawing.Point(156, 377);
            this.botaoMenuContaSaldo.Name = "botaoMenuContaSaldo";
            this.botaoMenuContaSaldo.Size = new System.Drawing.Size(150, 91);
            this.botaoMenuContaSaldo.TabIndex = 8;
            this.botaoMenuContaSaldo.Text = "Ver Saldo";
            this.botaoMenuContaSaldo.UseVisualStyleBackColor = true;
            this.botaoMenuContaSaldo.Click += new System.EventHandler(this.botaoMenuContaSaldo_Click);
            // 
            // botaoMenuContaTributos
            // 
            this.botaoMenuContaTributos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMenuContaTributos.Location = new System.Drawing.Point(389, 377);
            this.botaoMenuContaTributos.Name = "botaoMenuContaTributos";
            this.botaoMenuContaTributos.Size = new System.Drawing.Size(150, 91);
            this.botaoMenuContaTributos.TabIndex = 7;
            this.botaoMenuContaTributos.Text = "Resumo Tributário";
            this.botaoMenuContaTributos.UseVisualStyleBackColor = true;
            this.botaoMenuContaTributos.Click += new System.EventHandler(this.botaoMenuContaTributos_Click);
            // 
            // botaoMenuContaTransferir
            // 
            this.botaoMenuContaTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMenuContaTransferir.Location = new System.Drawing.Point(502, 247);
            this.botaoMenuContaTransferir.Name = "botaoMenuContaTransferir";
            this.botaoMenuContaTransferir.Size = new System.Drawing.Size(150, 91);
            this.botaoMenuContaTransferir.TabIndex = 6;
            this.botaoMenuContaTransferir.Text = "Transferir";
            this.botaoMenuContaTransferir.UseVisualStyleBackColor = true;
            this.botaoMenuContaTransferir.Click += new System.EventHandler(this.botaoMenuContaTransferir_Click);
            // 
            // botaoMenuContaSaque
            // 
            this.botaoMenuContaSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMenuContaSaque.Location = new System.Drawing.Point(282, 247);
            this.botaoMenuContaSaque.Name = "botaoMenuContaSaque";
            this.botaoMenuContaSaque.Size = new System.Drawing.Size(150, 91);
            this.botaoMenuContaSaque.TabIndex = 5;
            this.botaoMenuContaSaque.Text = "Sacar";
            this.botaoMenuContaSaque.UseVisualStyleBackColor = true;
            this.botaoMenuContaSaque.Click += new System.EventHandler(this.botaoMenuContaSaque_Click);
            // 
            // botaoMenuContaDeposito
            // 
            this.botaoMenuContaDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMenuContaDeposito.Location = new System.Drawing.Point(62, 247);
            this.botaoMenuContaDeposito.Name = "botaoMenuContaDeposito";
            this.botaoMenuContaDeposito.Size = new System.Drawing.Size(150, 91);
            this.botaoMenuContaDeposito.TabIndex = 4;
            this.botaoMenuContaDeposito.Text = "Depositar";
            this.botaoMenuContaDeposito.UseVisualStyleBackColor = true;
            this.botaoMenuContaDeposito.Click += new System.EventHandler(this.botaoMenuContaDeposito_Click);
            // 
            // lblMenuContaNascimento
            // 
            this.lblMenuContaNascimento.AutoSize = true;
            this.lblMenuContaNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuContaNascimento.Location = new System.Drawing.Point(58, 172);
            this.lblMenuContaNascimento.Name = "lblMenuContaNascimento";
            this.lblMenuContaNascimento.Size = new System.Drawing.Size(58, 22);
            this.lblMenuContaNascimento.TabIndex = 3;
            this.lblMenuContaNascimento.Text = "label3";
            // 
            // lblMenuContaCPF
            // 
            this.lblMenuContaCPF.AutoSize = true;
            this.lblMenuContaCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuContaCPF.Location = new System.Drawing.Point(58, 130);
            this.lblMenuContaCPF.Name = "lblMenuContaCPF";
            this.lblMenuContaCPF.Size = new System.Drawing.Size(58, 22);
            this.lblMenuContaCPF.TabIndex = 2;
            this.lblMenuContaCPF.Text = "label2";
            // 
            // lblMenuContaCliente
            // 
            this.lblMenuContaCliente.AutoSize = true;
            this.lblMenuContaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuContaCliente.Location = new System.Drawing.Point(58, 85);
            this.lblMenuContaCliente.Name = "lblMenuContaCliente";
            this.lblMenuContaCliente.Size = new System.Drawing.Size(58, 22);
            this.lblMenuContaCliente.TabIndex = 1;
            this.lblMenuContaCliente.Text = "label1";
            // 
            // lblMenuConta
            // 
            this.lblMenuConta.AutoSize = true;
            this.lblMenuConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuConta.Location = new System.Drawing.Point(44, 35);
            this.lblMenuConta.Name = "lblMenuConta";
            this.lblMenuConta.Size = new System.Drawing.Size(132, 22);
            this.lblMenuConta.TabIndex = 0;
            this.lblMenuConta.Text = "Menu da Conta";
            // 
            // abaConsultarConta
            // 
            this.abaConsultarConta.BackColor = System.Drawing.Color.DarkGray;
            this.abaConsultarConta.Controls.Add(this.lblConsultaContaResultado);
            this.abaConsultarConta.Controls.Add(this.botaoConsultarContaConsultar);
            this.abaConsultarConta.Controls.Add(this.botaoConsultarContaVoltar);
            this.abaConsultarConta.Controls.Add(this.txtConsultarContaNumero);
            this.abaConsultarConta.Controls.Add(this.lblConsultarContaNumero);
            this.abaConsultarConta.Controls.Add(this.lblMenuConsultaConta);
            this.abaConsultarConta.Location = new System.Drawing.Point(4, 22);
            this.abaConsultarConta.Name = "abaConsultarConta";
            this.abaConsultarConta.Padding = new System.Windows.Forms.Padding(3);
            this.abaConsultarConta.Size = new System.Drawing.Size(863, 520);
            this.abaConsultarConta.TabIndex = 3;
            this.abaConsultarConta.Text = "ConsConta";
            // 
            // lblConsultaContaResultado
            // 
            this.lblConsultaContaResultado.AutoSize = true;
            this.lblConsultaContaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaContaResultado.Location = new System.Drawing.Point(566, 217);
            this.lblConsultaContaResultado.Name = "lblConsultaContaResultado";
            this.lblConsultaContaResultado.Size = new System.Drawing.Size(0, 22);
            this.lblConsultaContaResultado.TabIndex = 12;
            // 
            // botaoConsultarContaConsultar
            // 
            this.botaoConsultarContaConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoConsultarContaConsultar.Location = new System.Drawing.Point(582, 122);
            this.botaoConsultarContaConsultar.Name = "botaoConsultarContaConsultar";
            this.botaoConsultarContaConsultar.Size = new System.Drawing.Size(105, 66);
            this.botaoConsultarContaConsultar.TabIndex = 11;
            this.botaoConsultarContaConsultar.Text = "Consultar";
            this.botaoConsultarContaConsultar.UseVisualStyleBackColor = true;
            this.botaoConsultarContaConsultar.Click += new System.EventHandler(this.botaoConsultarContaConsultar_Click);
            // 
            // botaoConsultarContaVoltar
            // 
            this.botaoConsultarContaVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoConsultarContaVoltar.Location = new System.Drawing.Point(706, 390);
            this.botaoConsultarContaVoltar.Name = "botaoConsultarContaVoltar";
            this.botaoConsultarContaVoltar.Size = new System.Drawing.Size(105, 66);
            this.botaoConsultarContaVoltar.TabIndex = 10;
            this.botaoConsultarContaVoltar.Text = "Voltar";
            this.botaoConsultarContaVoltar.UseVisualStyleBackColor = true;
            this.botaoConsultarContaVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConsultarContaNumero
            // 
            this.txtConsultarContaNumero.Location = new System.Drawing.Point(338, 147);
            this.txtConsultarContaNumero.Name = "txtConsultarContaNumero";
            this.txtConsultarContaNumero.Size = new System.Drawing.Size(201, 20);
            this.txtConsultarContaNumero.TabIndex = 3;
            // 
            // lblConsultarContaNumero
            // 
            this.lblConsultarContaNumero.AutoSize = true;
            this.lblConsultarContaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarContaNumero.Location = new System.Drawing.Point(81, 145);
            this.lblConsultarContaNumero.Name = "lblConsultarContaNumero";
            this.lblConsultarContaNumero.Size = new System.Drawing.Size(232, 22);
            this.lblConsultarContaNumero.TabIndex = 2;
            this.lblConsultarContaNumero.Text = "Informe o número da Conta:";
            // 
            // lblMenuConsultaConta
            // 
            this.lblMenuConsultaConta.AutoSize = true;
            this.lblMenuConsultaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuConsultaConta.Location = new System.Drawing.Point(43, 37);
            this.lblMenuConsultaConta.Name = "lblMenuConsultaConta";
            this.lblMenuConsultaConta.Size = new System.Drawing.Size(140, 22);
            this.lblMenuConsultaConta.TabIndex = 1;
            this.lblMenuConsultaConta.Text = "Consultar Conta";
            // 
            // abaDeposito
            // 
            this.abaDeposito.BackColor = System.Drawing.Color.DarkGray;
            this.abaDeposito.Controls.Add(this.lblDepositoRealizado);
            this.abaDeposito.Controls.Add(this.botaoVoltarDeposito);
            this.abaDeposito.Controls.Add(this.lblDepositoSaldoAtual);
            this.abaDeposito.Controls.Add(this.botaoDeposito);
            this.abaDeposito.Controls.Add(this.textValorDeposito);
            this.abaDeposito.Controls.Add(this.lblValorDeposito);
            this.abaDeposito.Controls.Add(this.lblDeposito);
            this.abaDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abaDeposito.Location = new System.Drawing.Point(4, 22);
            this.abaDeposito.Name = "abaDeposito";
            this.abaDeposito.Padding = new System.Windows.Forms.Padding(3);
            this.abaDeposito.Size = new System.Drawing.Size(863, 520);
            this.abaDeposito.TabIndex = 4;
            this.abaDeposito.Text = "Deposito";
            this.abaDeposito.Click += new System.EventHandler(this.lblValorDeposito_Click);
            // 
            // lblDepositoRealizado
            // 
            this.lblDepositoRealizado.AutoSize = true;
            this.lblDepositoRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositoRealizado.Location = new System.Drawing.Point(339, 176);
            this.lblDepositoRealizado.Name = "lblDepositoRealizado";
            this.lblDepositoRealizado.Size = new System.Drawing.Size(163, 22);
            this.lblDepositoRealizado.TabIndex = 12;
            this.lblDepositoRealizado.Text = "Deposito realizado!";
            this.lblDepositoRealizado.Visible = false;
            // 
            // botaoVoltarDeposito
            // 
            this.botaoVoltarDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarDeposito.Location = new System.Drawing.Point(703, 395);
            this.botaoVoltarDeposito.Name = "botaoVoltarDeposito";
            this.botaoVoltarDeposito.Size = new System.Drawing.Size(105, 66);
            this.botaoVoltarDeposito.TabIndex = 11;
            this.botaoVoltarDeposito.Text = "Voltar";
            this.botaoVoltarDeposito.UseVisualStyleBackColor = true;
            this.botaoVoltarDeposito.Click += new System.EventHandler(this.botaoVoltarDeposito_Click);
            // 
            // lblDepositoSaldoAtual
            // 
            this.lblDepositoSaldoAtual.AutoSize = true;
            this.lblDepositoSaldoAtual.Location = new System.Drawing.Point(339, 232);
            this.lblDepositoSaldoAtual.Name = "lblDepositoSaldoAtual";
            this.lblDepositoSaldoAtual.Size = new System.Drawing.Size(0, 22);
            this.lblDepositoSaldoAtual.TabIndex = 6;
            this.lblDepositoSaldoAtual.Visible = false;
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Location = new System.Drawing.Point(519, 101);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(105, 52);
            this.botaoDeposito.TabIndex = 5;
            this.botaoDeposito.Text = "Depositar";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            this.botaoDeposito.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // textValorDeposito
            // 
            this.textValorDeposito.Location = new System.Drawing.Point(343, 117);
            this.textValorDeposito.Name = "textValorDeposito";
            this.textValorDeposito.Size = new System.Drawing.Size(142, 27);
            this.textValorDeposito.TabIndex = 4;
            // 
            // lblValorDeposito
            // 
            this.lblValorDeposito.AutoSize = true;
            this.lblValorDeposito.Location = new System.Drawing.Point(100, 117);
            this.lblValorDeposito.Name = "lblValorDeposito";
            this.lblValorDeposito.Size = new System.Drawing.Size(222, 22);
            this.lblValorDeposito.TabIndex = 3;
            this.lblValorDeposito.Text = "Informe o valor a depositar";
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(55, 33);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(81, 22);
            this.lblDeposito.TabIndex = 2;
            this.lblDeposito.Text = "Deposito";
            // 
            // abaSaque
            // 
            this.abaSaque.BackColor = System.Drawing.Color.DarkGray;
            this.abaSaque.Controls.Add(this.lblSaqueRealizado);
            this.abaSaque.Controls.Add(this.lblSaldoSaque);
            this.abaSaque.Controls.Add(this.botaoVoltarSaque);
            this.abaSaque.Controls.Add(this.botaoSaque);
            this.abaSaque.Controls.Add(this.txtValorSaque);
            this.abaSaque.Controls.Add(this.lblValorSaque);
            this.abaSaque.Controls.Add(this.lblSaque);
            this.abaSaque.Location = new System.Drawing.Point(4, 22);
            this.abaSaque.Name = "abaSaque";
            this.abaSaque.Padding = new System.Windows.Forms.Padding(3);
            this.abaSaque.Size = new System.Drawing.Size(863, 520);
            this.abaSaque.TabIndex = 5;
            this.abaSaque.Text = "Saque";
            // 
            // lblSaqueRealizado
            // 
            this.lblSaqueRealizado.AutoSize = true;
            this.lblSaqueRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaqueRealizado.Location = new System.Drawing.Point(368, 189);
            this.lblSaqueRealizado.Name = "lblSaqueRealizado";
            this.lblSaqueRealizado.Size = new System.Drawing.Size(144, 22);
            this.lblSaqueRealizado.TabIndex = 14;
            this.lblSaqueRealizado.Text = "Saque realizado!";
            this.lblSaqueRealizado.Visible = false;
            // 
            // lblSaldoSaque
            // 
            this.lblSaldoSaque.AutoSize = true;
            this.lblSaldoSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoSaque.Location = new System.Drawing.Point(368, 246);
            this.lblSaldoSaque.Name = "lblSaldoSaque";
            this.lblSaldoSaque.Size = new System.Drawing.Size(105, 22);
            this.lblSaldoSaque.TabIndex = 13;
            this.lblSaldoSaque.Text = "Saldo atual:";
            this.lblSaldoSaque.Visible = false;
            // 
            // botaoVoltarSaque
            // 
            this.botaoVoltarSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarSaque.Location = new System.Drawing.Point(705, 396);
            this.botaoVoltarSaque.Name = "botaoVoltarSaque";
            this.botaoVoltarSaque.Size = new System.Drawing.Size(105, 66);
            this.botaoVoltarSaque.TabIndex = 12;
            this.botaoVoltarSaque.Text = "Voltar";
            this.botaoVoltarSaque.UseVisualStyleBackColor = true;
            this.botaoVoltarSaque.Click += new System.EventHandler(this.botaoVoltarSaque_Click);
            // 
            // botaoSaque
            // 
            this.botaoSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSaque.Location = new System.Drawing.Point(544, 105);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(105, 52);
            this.botaoSaque.TabIndex = 6;
            this.botaoSaque.Text = "Sacar";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // txtValorSaque
            // 
            this.txtValorSaque.Location = new System.Drawing.Point(372, 122);
            this.txtValorSaque.Name = "txtValorSaque";
            this.txtValorSaque.Size = new System.Drawing.Size(142, 20);
            this.txtValorSaque.TabIndex = 5;
            // 
            // lblValorSaque
            // 
            this.lblValorSaque.AutoSize = true;
            this.lblValorSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSaque.Location = new System.Drawing.Point(102, 120);
            this.lblValorSaque.Name = "lblValorSaque";
            this.lblValorSaque.Size = new System.Drawing.Size(250, 22);
            this.lblValorSaque.TabIndex = 4;
            this.lblValorSaque.Text = "Informe um valor a ser sacado";
            // 
            // lblSaque
            // 
            this.lblSaque.AutoSize = true;
            this.lblSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaque.Location = new System.Drawing.Point(66, 38);
            this.lblSaque.Name = "lblSaque";
            this.lblSaque.Size = new System.Drawing.Size(62, 22);
            this.lblSaque.TabIndex = 3;
            this.lblSaque.Text = "Saque";
            // 
            // abaTransferir
            // 
            this.abaTransferir.BackColor = System.Drawing.Color.DarkGray;
            this.abaTransferir.Controls.Add(this.lblSaldoAtualTransferencia);
            this.abaTransferir.Controls.Add(this.botaoTransferenciaVoltar);
            this.abaTransferir.Controls.Add(this.lblResultadoValorTransferencia);
            this.abaTransferir.Controls.Add(this.lblResultadoContaTransferencia);
            this.abaTransferir.Controls.Add(this.lblResultadoTransferencia);
            this.abaTransferir.Controls.Add(this.botaoTransferencia);
            this.abaTransferir.Controls.Add(this.txtValorTransferencia);
            this.abaTransferir.Controls.Add(this.txtContaTransferencia);
            this.abaTransferir.Controls.Add(this.lblValorTransferencia);
            this.abaTransferir.Controls.Add(this.lblContaTransferir);
            this.abaTransferir.Controls.Add(this.lblTransferir);
            this.abaTransferir.Location = new System.Drawing.Point(4, 22);
            this.abaTransferir.Name = "abaTransferir";
            this.abaTransferir.Padding = new System.Windows.Forms.Padding(3);
            this.abaTransferir.Size = new System.Drawing.Size(863, 520);
            this.abaTransferir.TabIndex = 6;
            this.abaTransferir.Text = "Transferencia";
            this.abaTransferir.Click += new System.EventHandler(this.abaTransferir_Click);
            // 
            // lblSaldoAtualTransferencia
            // 
            this.lblSaldoAtualTransferencia.AutoSize = true;
            this.lblSaldoAtualTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoAtualTransferencia.Location = new System.Drawing.Point(401, 346);
            this.lblSaldoAtualTransferencia.Name = "lblSaldoAtualTransferencia";
            this.lblSaldoAtualTransferencia.Size = new System.Drawing.Size(88, 22);
            this.lblSaldoAtualTransferencia.TabIndex = 14;
            this.lblSaldoAtualTransferencia.Text = "Transferir";
            this.lblSaldoAtualTransferencia.Visible = false;
            // 
            // botaoTransferenciaVoltar
            // 
            this.botaoTransferenciaVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoTransferenciaVoltar.Location = new System.Drawing.Point(705, 398);
            this.botaoTransferenciaVoltar.Name = "botaoTransferenciaVoltar";
            this.botaoTransferenciaVoltar.Size = new System.Drawing.Size(105, 66);
            this.botaoTransferenciaVoltar.TabIndex = 13;
            this.botaoTransferenciaVoltar.Text = "Voltar";
            this.botaoTransferenciaVoltar.UseVisualStyleBackColor = true;
            this.botaoTransferenciaVoltar.Click += new System.EventHandler(this.botaoTransferenciaVoltar_Click);
            // 
            // lblResultadoValorTransferencia
            // 
            this.lblResultadoValorTransferencia.AutoSize = true;
            this.lblResultadoValorTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoValorTransferencia.Location = new System.Drawing.Point(401, 304);
            this.lblResultadoValorTransferencia.Name = "lblResultadoValorTransferencia";
            this.lblResultadoValorTransferencia.Size = new System.Drawing.Size(88, 22);
            this.lblResultadoValorTransferencia.TabIndex = 12;
            this.lblResultadoValorTransferencia.Text = "Transferir";
            this.lblResultadoValorTransferencia.Visible = false;
            // 
            // lblResultadoContaTransferencia
            // 
            this.lblResultadoContaTransferencia.AutoSize = true;
            this.lblResultadoContaTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoContaTransferencia.Location = new System.Drawing.Point(401, 148);
            this.lblResultadoContaTransferencia.Name = "lblResultadoContaTransferencia";
            this.lblResultadoContaTransferencia.Size = new System.Drawing.Size(88, 22);
            this.lblResultadoContaTransferencia.TabIndex = 11;
            this.lblResultadoContaTransferencia.Text = "Transferir";
            this.lblResultadoContaTransferencia.Visible = false;
            // 
            // lblResultadoTransferencia
            // 
            this.lblResultadoTransferencia.AutoSize = true;
            this.lblResultadoTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTransferencia.Location = new System.Drawing.Point(401, 306);
            this.lblResultadoTransferencia.Name = "lblResultadoTransferencia";
            this.lblResultadoTransferencia.Size = new System.Drawing.Size(0, 22);
            this.lblResultadoTransferencia.TabIndex = 10;
            this.lblResultadoTransferencia.Visible = false;
            // 
            // botaoTransferencia
            // 
            this.botaoTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoTransferencia.Location = new System.Drawing.Point(643, 236);
            this.botaoTransferencia.Name = "botaoTransferencia";
            this.botaoTransferencia.Size = new System.Drawing.Size(134, 67);
            this.botaoTransferencia.TabIndex = 9;
            this.botaoTransferencia.Text = "Transferir";
            this.botaoTransferencia.UseVisualStyleBackColor = true;
            this.botaoTransferencia.Click += new System.EventHandler(this.botaoTransferencia_Click);
            // 
            // txtValorTransferencia
            // 
            this.txtValorTransferencia.Location = new System.Drawing.Point(405, 261);
            this.txtValorTransferencia.Name = "txtValorTransferencia";
            this.txtValorTransferencia.Size = new System.Drawing.Size(178, 20);
            this.txtValorTransferencia.TabIndex = 8;
            // 
            // txtContaTransferencia
            // 
            this.txtContaTransferencia.Location = new System.Drawing.Point(405, 113);
            this.txtContaTransferencia.Name = "txtContaTransferencia";
            this.txtContaTransferencia.Size = new System.Drawing.Size(178, 20);
            this.txtContaTransferencia.TabIndex = 7;
            // 
            // lblValorTransferencia
            // 
            this.lblValorTransferencia.AutoSize = true;
            this.lblValorTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTransferencia.Location = new System.Drawing.Point(107, 259);
            this.lblValorTransferencia.Name = "lblValorTransferencia";
            this.lblValorTransferencia.Size = new System.Drawing.Size(263, 22);
            this.lblValorTransferencia.TabIndex = 6;
            this.lblValorTransferencia.Text = "Informe o valor a ser transferido";
            // 
            // lblContaTransferir
            // 
            this.lblContaTransferir.AutoSize = true;
            this.lblContaTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaTransferir.Location = new System.Drawing.Point(107, 111);
            this.lblContaTransferir.Name = "lblContaTransferir";
            this.lblContaTransferir.Size = new System.Drawing.Size(283, 22);
            this.lblContaTransferir.TabIndex = 5;
            this.lblContaTransferir.Text = "Informe a conta para transferencia";
            // 
            // lblTransferir
            // 
            this.lblTransferir.AutoSize = true;
            this.lblTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferir.Location = new System.Drawing.Point(58, 41);
            this.lblTransferir.Name = "lblTransferir";
            this.lblTransferir.Size = new System.Drawing.Size(88, 22);
            this.lblTransferir.TabIndex = 4;
            this.lblTransferir.Text = "Transferir";
            // 
            // abaSaldo
            // 
            this.abaSaldo.BackColor = System.Drawing.Color.DarkGray;
            this.abaSaldo.Controls.Add(this.lblSaldoAtual);
            this.abaSaldo.Controls.Add(this.botaoVoltarSaldo);
            this.abaSaldo.Controls.Add(this.lblSaldo);
            this.abaSaldo.Location = new System.Drawing.Point(4, 22);
            this.abaSaldo.Name = "abaSaldo";
            this.abaSaldo.Padding = new System.Windows.Forms.Padding(3);
            this.abaSaldo.Size = new System.Drawing.Size(863, 520);
            this.abaSaldo.TabIndex = 7;
            this.abaSaldo.Text = "Saldo";
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoAtual.Location = new System.Drawing.Point(111, 129);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(102, 22);
            this.lblSaldoAtual.TabIndex = 15;
            this.lblSaldoAtual.Text = "Saldo Atual";
            // 
            // botaoVoltarSaldo
            // 
            this.botaoVoltarSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarSaldo.Location = new System.Drawing.Point(709, 396);
            this.botaoVoltarSaldo.Name = "botaoVoltarSaldo";
            this.botaoVoltarSaldo.Size = new System.Drawing.Size(105, 66);
            this.botaoVoltarSaldo.TabIndex = 14;
            this.botaoVoltarSaldo.Text = "Voltar";
            this.botaoVoltarSaldo.UseVisualStyleBackColor = true;
            this.botaoVoltarSaldo.Click += new System.EventHandler(this.botaoVoltarSaldo_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(38, 30);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(138, 22);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Consultar Saldo";
            // 
            // abaTributos
            // 
            this.abaTributos.BackColor = System.Drawing.Color.DarkGray;
            this.abaTributos.Controls.Add(this.lblResultadoTributos);
            this.abaTributos.Controls.Add(this.lblTributos);
            this.abaTributos.Controls.Add(this.botaoVoltarTributos);
            this.abaTributos.Location = new System.Drawing.Point(4, 22);
            this.abaTributos.Name = "abaTributos";
            this.abaTributos.Padding = new System.Windows.Forms.Padding(3);
            this.abaTributos.Size = new System.Drawing.Size(863, 520);
            this.abaTributos.TabIndex = 8;
            this.abaTributos.Text = "Tributos";
            // 
            // lblResultadoTributos
            // 
            this.lblResultadoTributos.AutoSize = true;
            this.lblResultadoTributos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTributos.Location = new System.Drawing.Point(106, 128);
            this.lblResultadoTributos.Name = "lblResultadoTributos";
            this.lblResultadoTributos.Size = new System.Drawing.Size(158, 22);
            this.lblResultadoTributos.TabIndex = 17;
            this.lblResultadoTributos.Text = "Consultar Tributos";
            // 
            // lblTributos
            // 
            this.lblTributos.AutoSize = true;
            this.lblTributos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTributos.Location = new System.Drawing.Point(47, 42);
            this.lblTributos.Name = "lblTributos";
            this.lblTributos.Size = new System.Drawing.Size(158, 22);
            this.lblTributos.TabIndex = 16;
            this.lblTributos.Text = "Consultar Tributos";
            // 
            // botaoVoltarTributos
            // 
            this.botaoVoltarTributos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarTributos.Location = new System.Drawing.Point(706, 389);
            this.botaoVoltarTributos.Name = "botaoVoltarTributos";
            this.botaoVoltarTributos.Size = new System.Drawing.Size(105, 66);
            this.botaoVoltarTributos.TabIndex = 15;
            this.botaoVoltarTributos.Text = "Voltar";
            this.botaoVoltarTributos.UseVisualStyleBackColor = true;
            this.botaoVoltarTributos.Click += new System.EventHandler(this.botaoVoltarTributos_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 29);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(896, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controladorAbas);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.controladorAbas.ResumeLayout(false);
            this.abaMenuPrincipal.ResumeLayout(false);
            this.abaMenuPrincipal.PerformLayout();
            this.abaCriarContas.ResumeLayout(false);
            this.abaCriarContas.PerformLayout();
            this.abaMenuDaConta.ResumeLayout(false);
            this.abaMenuDaConta.PerformLayout();
            this.abaConsultarConta.ResumeLayout(false);
            this.abaConsultarConta.PerformLayout();
            this.abaDeposito.ResumeLayout(false);
            this.abaDeposito.PerformLayout();
            this.abaSaque.ResumeLayout(false);
            this.abaSaque.PerformLayout();
            this.abaTransferir.ResumeLayout(false);
            this.abaTransferir.PerformLayout();
            this.abaSaldo.ResumeLayout(false);
            this.abaSaldo.PerformLayout();
            this.abaTributos.ResumeLayout(false);
            this.abaTributos.PerformLayout();
            this.ResumeLayout(false);

        }

        private void lblValorDeposito_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controladorAbas.SelectTab(abaMenuPrincipal);
        }

        private void txtBoxContaNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblCriarContaResultado_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBoxContaDataNascimento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBoxContaCPF_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBoxContaSaldo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBoxContaRG_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBoxContaNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.TabControl controladorAbas;
        private System.Windows.Forms.TabPage abaMenuPrincipal;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoConsultarConta;
        private System.Windows.Forms.Button botaoContaInvestimento;
        private System.Windows.Forms.Button botaoContaPoupanca;
        private System.Windows.Forms.Button botaoContaCorrente;
        private System.Windows.Forms.TabPage abaCriarContas;
        private System.Windows.Forms.TabPage abaMenuDaConta;
        private System.Windows.Forms.Label lblMenuContas;
        private System.Windows.Forms.TextBox txtBoxContaNumero;
        private System.Windows.Forms.TextBox txtBoxContaSaldo;
        private System.Windows.Forms.TextBox txtBoxContaRG;
        private System.Windows.Forms.TextBox txtBoxContaNome;
        private System.Windows.Forms.Label lblContaNumero;
        private System.Windows.Forms.TextBox txtBoxContaDataNascimento;
        private System.Windows.Forms.TextBox txtBoxContaCPF;
        private System.Windows.Forms.Label lblContaDataNascimento;
        private System.Windows.Forms.Label lblContaCPF;
        private System.Windows.Forms.Label lblContaSaldo;
        private System.Windows.Forms.Label lblContaRG;
        private System.Windows.Forms.Label lblContaNome;
        private System.Windows.Forms.Button botaoCriarConta;
        private System.Windows.Forms.Label lblCriarContaResultado;
        private System.Windows.Forms.Label lblMenuConta;
        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Label lblMenuContaNascimento;
        private System.Windows.Forms.Label lblMenuContaCPF;
        private System.Windows.Forms.Label lblMenuContaCliente;
        private System.Windows.Forms.Button botaoMenuContaTributos;
        private System.Windows.Forms.Button botaoMenuContaTransferir;
        private System.Windows.Forms.Button botaoMenuContaSaque;
        private System.Windows.Forms.Button botaoMenuContaDeposito;
        private System.Windows.Forms.Button botaoMenuContaSair;
        private System.Windows.Forms.Button botaoMenuContaSaldo;
        private System.Windows.Forms.TabPage abaConsultarConta;
        private System.Windows.Forms.TextBox txtConsultarContaNumero;
        private System.Windows.Forms.Label lblConsultarContaNumero;
        private System.Windows.Forms.Label lblMenuConsultaConta;
        private System.Windows.Forms.Button botaoConsultarContaVoltar;
        private System.Windows.Forms.Button botaoConsultarContaConsultar;
        private System.Windows.Forms.Label lblConsultaContaResultado;
        private System.Windows.Forms.TabPage abaDeposito;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Label lblValorDeposito;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.TextBox textValorDeposito;
        private System.Windows.Forms.Label lblDepositoSaldoAtual;
        private System.Windows.Forms.Button botaoVoltarDeposito;
        private System.Windows.Forms.TabPage abaSaque;
        private System.Windows.Forms.Button botaoVoltarSaque;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.TextBox txtValorSaque;
        private System.Windows.Forms.Label lblValorSaque;
        private System.Windows.Forms.Label lblSaque;
        private System.Windows.Forms.Label lblSaldoSaque;
        private System.Windows.Forms.TabPage abaTransferir;
        private System.Windows.Forms.Button botaoTransferenciaVoltar;
        private System.Windows.Forms.Label lblResultadoValorTransferencia;
        private System.Windows.Forms.Label lblResultadoContaTransferencia;
        private System.Windows.Forms.Label lblResultadoTransferencia;
        private System.Windows.Forms.Button botaoTransferencia;
        private System.Windows.Forms.TextBox txtValorTransferencia;
        private System.Windows.Forms.TextBox txtContaTransferencia;
        private System.Windows.Forms.Label lblValorTransferencia;
        private System.Windows.Forms.Label lblContaTransferir;
        private System.Windows.Forms.Label lblTransferir;
        private System.Windows.Forms.TabPage abaSaldo;
        private System.Windows.Forms.Button botaoVoltarSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSaldoAtual;
        private System.Windows.Forms.TabPage abaTributos;
        private System.Windows.Forms.Label lblTributos;
        private System.Windows.Forms.Button botaoVoltarTributos;
        private System.Windows.Forms.Label lblResultadoTributos;
        private System.Windows.Forms.Label lblSaldoAtualTransferencia;
        private System.Windows.Forms.Label lblDepositoRealizado;
        private System.Windows.Forms.Label lblSaqueRealizado;
        private System.Windows.Forms.Panel panel1;
    }
}

