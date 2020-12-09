using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    class ContaBancaria
    {
        public double Saldo { get; private set; }
        public string NumeroConta { get; private set; }
        public string NomeTitular { get; set; }



        public ContaBancaria(string numeroConta, string nome, double saldo)
        {
            NumeroConta = numeroConta;
            NomeTitular = nome;            
            Saldo = saldo;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", Titular: " + NomeTitular + ", Saldo: $ " + Saldo.ToString("F2");
        }


        //entrada de dados
        //numero da conta
        //titular
        //valor inicial s/n
        //se sim => metodo construtor com valor inicial
        //se não => metodo construtor com valor inicial

        //metodos
        //retorna dados da conta
        //deposito
        //saque


        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }




    }
}
