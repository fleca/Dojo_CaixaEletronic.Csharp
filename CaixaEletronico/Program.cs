using CaixaEletronico.Base;
using CaixaEletronico.Class;
using CaixaEletronico.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.ArquivoTexto;

namespace CaixaEletronico
{
    class Program
    {
        public static GerenciadorDeContas GerenciadorDeContasBanco { get; set; }

        static void Main(string[] args)
        {

            GerenciadorDeContasBanco = new GerenciadorDeContas();
            var key = "";

            while (key.ToUpper() != "Q")
            {

                Console.Clear();

                Console.WriteLine("1 - Criar uma Conta Corrente.");
                Console.WriteLine("2 - Criar uma Conta Poupança.");
                Console.WriteLine("3 - Criar uma Conta Investimento.");
                Console.WriteLine("4 - Consultar Conta");
                Console.WriteLine("Q - Para Sair");

                Console.WriteLine();
                Console.Write("Informe um valor: "); 
                key = Convert.ToString(Console.ReadLine());

                try
                {
                    switch (key)
                    {
                        case "1":
                            var cc = CriarContas<ContaCorrente>();
                            MenuDaConta(cc, cc);
                            break;

                        case "2":
                            var cp = CriarContas<ContaPoupanca>();
                            MenuDaConta(cp, cp);
                            break;
                        case "3":
                            var ci = CriarContas<ContaInvestimento>();
                            MenuDaConta(ci, ci);
                            break;
                        case "4":
                            Console.Write("Informe o número da Conta: ");
                            int numero = Convert.ToInt32(Console.ReadLine());
                            var conta = GerenciadorDeContasBanco.ConsultarContaPorNumero(numero);
                            MenuDaConta(conta, null);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    key = PressioneParaContinuar();
                }
            }
        }

        //Exemplo clássico generico
        private static T CriarContas<T>() where T : Conta
        {
            Console.Clear();

            Console.Write("Informe o número da Conta: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (GerenciadorDeContasBanco.ContaValidaParaCriacao(numero))
            {
                Console.Write("Informe o nome do titular: ");
                string nome = Convert.ToString(Console.ReadLine());

                Console.Write("Informe o rg do titular: ");
                string rg = Convert.ToString(Console.ReadLine());

                Console.Write("Informe o saldo da conta: ");
                double saldo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe o CPF do titular (apenas numeros): ");
                double cpf = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe a data de nascimento do titular (formato: dd/mm/aa): ");
                string datanascimento = Convert.ToString(Console.ReadLine());

                var titular = new Cliente(nome, rg, cpf, datanascimento);

                // Cria um instancia generica, conforme o tipo!
                T conta = (T)Activator.CreateInstance(typeof(T), new object[] { numero, titular, saldo, cpf, datanascimento });

                GerenciadorDeContasBanco.AdicionarConta(conta);
                return conta;
            }

            throw new ContaExistenteException();
        }

        private static void MenuDaConta(Conta conta, ITributavel tributo = null)
        {
            string key = "";
            StringBuilder comp = new StringBuilder();
            double valor = 0;
            var caminhoComprovantes = "D:\\Users\\314171\\Desktop\\CodingDojo C#\\CaixaEletronico_Exemplo\\Comprovantes.txt";
            var caminhoLogs = "D:\\Users\\314171\\Desktop\\CodingDojo C#\\CaixaEletronico_Exemplo\\Logs.txt";
            var leitor = new LeitorArquivo();
            var gravador = new GravadorArquivo();
            var retornoComprovantes = leitor.LerLinhasArquivo(caminhoComprovantes);
            var retornoLogs = leitor.LerLinhasArquivo(caminhoLogs);

            while (key.ToUpper() != "Q")
            {
                Console.Clear();

                Console.WriteLine("Cliente: {0}!", conta.ExibirTitular());
                Console.WriteLine("CPF: {0}", conta.ExibirCpf());
                Console.WriteLine("Data de Nascimento: {0}\n", conta.ExibirDataNascimento());
                Console.WriteLine("1 - Depositar.");
                Console.WriteLine("2 - Sacar."); 
                Console.WriteLine("3 - Transferir.");
                Console.WriteLine("4 - Ver Saldo.");
                Console.WriteLine("5 - Resumo Tributário.");
                Console.WriteLine("Q - Para Sair");

                Console.WriteLine();
                Console.Write("Informe um valor: ");
                key = Convert.ToString(Console.ReadLine());

                switch (key)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Informe o valor a depositar: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        conta.Depositar(valor);
                        Console.WriteLine();                        
                        Console.WriteLine("Saldo Atual: {0}", conta.saldo);              
                        key = PressioneParaContinuar();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Informe o valor a sacar: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        conta.Sacar(valor);
                        Console.WriteLine();
                        Console.WriteLine("Saldo Atual: {0}", conta.saldo);
                        key = PressioneParaContinuar();
                        break;

                    case "3":
                        Console.Clear();

                        if (GerenciadorDeContasBanco.ExisteContaPorNumero(conta.ExibirNumero()))
                        {
                            Console.Write("Informe o número da Conta de Depósito: ");
                            int numeroContaDeDeposito = Convert.ToInt32(Console.ReadLine());
                            if (GerenciadorDeContasBanco.ExisteContaPorNumero(numeroContaDeDeposito))
                            {
                                Console.Write("Informe o valor da transferência: ");
                                var valorTransferencia = Convert.ToDouble(Console.ReadLine());
                                string msgOperacao = "Transferência feita com sucesso!";
                                if (!GerenciadorDeContasBanco.Transferir(conta.ExibirNumero(), numeroContaDeDeposito, valorTransferencia))
                                {
                                    msgOperacao = "Transferência não foi realizada com sucesso. Tente novamente";
                                }
                                Console.WriteLine(msgOperacao);
                            }
                            else
                            {
                                throw new ContaInexistenteException();
                            }
                        }
                        else
                        {
                            throw new ContaInexistenteException();
                        }

                        key = PressioneParaContinuar();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Saldo Atual: " + conta.RetornarSaldo());
                        key = PressioneParaContinuar();
                        break;

                    case "5":
                        if (tributo != null)
                        {
                            Console.Clear();
                            Console.WriteLine("Conta: " + conta.ExibirNumero());
                            Console.WriteLine("Titular: " + conta.ExibirTitular());
                            Console.WriteLine("Total de Tributos: " + tributo.CalcularTributo());
                            conta.MostrarTributos();
                        }
                        else
                        {
                            Console.WriteLine("Função inexistente");
                        }

                        key = PressioneParaContinuar();
                        break;

                    default:
                        break;
                }
            }
        }

        private static string PressioneParaContinuar()
        {
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para continuar...");
            return Convert.ToString(Console.ReadLine());
        }
    }
}
