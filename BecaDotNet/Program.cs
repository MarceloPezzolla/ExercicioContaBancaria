using System;
using System.Globalization;

namespace BecaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            LeituraDados();
            Console.ReadLine();
        }

        private static void LeituraDados()
        {
            Console.WriteLine("Digite o número da conta: ");
            string conta = Console.ReadLine();

            Console.WriteLine("Digite o nome do titular: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (S/N)? ");
            string escolhaDepositoInicial = Console.ReadLine();

            double deposito = 0.0;

            if (escolhaDepositoInicial.ToLower() == "s")
            {
                Console.WriteLine("Digite o valor do depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            CriarConta(conta, nome, deposito);
        }


        private static void CriarConta(string conta, string nome, double deposito)
        {
            ContaBancaria contaBancaria = new ContaBancaria(conta, nome, deposito);
            RetornaDadosIniciais(contaBancaria);
        }

        public static void RetornaDadosIniciais(ContaBancaria contaBancaria)
        {
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaBancaria.ToString());
            Deposito(contaBancaria);
        }

        public static void Deposito(ContaBancaria contaBancaria)
        {
            Console.WriteLine("Entre um valor para o depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria.ToString());
            Saque(contaBancaria);
        }

        public static void Saque(ContaBancaria contaBancaria)
        {
            Console.WriteLine("Entre um valor para saque:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria.ToString());
        }

    }
}
