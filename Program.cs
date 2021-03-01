using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {

        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {      

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    ListarContas();
                    case "2":
                    InserirConta();
                    case "3":
                    Transferir();
                    case "4":
                    Sacar();
                    case "5":
                    Depositar();
                    case "C":
                    Console.Clear();

                    default: throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Vai se foder");
            Console.ReadLine();

           Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Álvaro Paulo");
           Console.WriteLine(minhaConta.ToString());
        }

        private static void Depositar(double valorDeposito)
        {
           
        }

        private static void Transferir()
        {
           Console.WriteLine("Digite o número da conta de origem: ");
           int indiceContaOrigem = int.Parse(Console.ReadLine());

           Console.WriteLine("Digite o número da conta de destino: ");
           int indiceContaDestino = int.Parse(Console.ReadLine());

           Console.WriteLine("Digite o valor a ser transferido: ");
           double valorTransferencia = double.Parse(Console.ReadLine());

           listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static void Sacar()
        {
           Console.WriteLine("Digite o número da conta: ");
           int indiceConta = int.Parse(Console.ReadLine());

           Console.WriteLine("Digite o número da conta: ");
           double valorDeposito = double.Parse(Console.ReadLine());

           listContas[indiceConta].Sacar(valorDeposito);
        }

        private static void ListarContas()
        {
            if (listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta encontrada.");
                return;
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} . ", i);
                Console.WriteLine(conta);
            }
        }

        private static void InserirConta()
        {
           Console.WriteLine("Inserir nova conta");           

           Console.Write("Digite 1 para Conta Pessoa Física ou 2 para Conta Pessoa Jurídica: ");
           int entradaTipoConta = int.Parse(Console.ReadLine());

           Console.Write("Digite o nome do Cliente: ");
           string entradaNome = (Console.ReadLine());

           Console.Write("Digite o saldo inicial: ");
           double entradaSaldo = double.Parse(Console.ReadLine());

           Console.Write("Digite o crédito: ");
           double entradaCredito = double.Parse(Console.ReadLine());

           Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
           saldo: entradaSaldo,
           credito: entradaCredito,
           nome: entradaNome);

           listContas.Add(novaConta);
        }

        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("Meu cu");
            Console.WriteLine("Informe a porra da opção:");

            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
