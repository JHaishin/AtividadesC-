using System;
using System.Globalization;

namespace Atividade9
{
    public class Banco
    {
        public string Nome { get; set; }
        public int Num_Conta { get; set; }
        public double Saldo { get; private set; }
        public double DepositoInicial;

       public Banco(string nome, int num_conta, double dep_inicial = 0.0) 
{
    Nome = nome;
    Num_Conta = num_conta;
    Saldo = dep_inicial;
    Deposito(dep_inicial);


}

        public double Deposito(double dep_inicial)
        {
            Saldo += dep_inicial;
            return Saldo;
        }

        public double Saque(double valor)
        {
            Saldo -= valor + 5.0;
            return Saldo;
        }

        public override string ToString()
        {
            return $"{Nome}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}, Conta: {Num_Conta}";
        }
    }
}