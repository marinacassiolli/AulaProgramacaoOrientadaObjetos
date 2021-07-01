using System;
using System.Collections.Generic;
using System.Text;

namespace AulaProgramacaoOrientadaObjetos
{
    public abstract class Conta : IConta
    {
        public Conta()
        {
            NumeroConta = Guid.NewGuid().ToString();
            DataAbertura = DateTime.Now;
        }

        public Conta(string agencia)
        {
            Agencia = agencia;
            NumeroConta = Guid.NewGuid().ToString();
            DataAbertura = DateTime.Now;
        }

        public string Agencia { get; set; }
        public string NumeroConta { get; private set; }
        public double Saldo { get; protected set; }
        public DateTime DataAbertura { get; private set; }

        public abstract double ObterPercentualTaxa();

        public virtual void Sacar(double quantidade)
        {
            if (quantidade <= 0)
            {
                Console.WriteLine("Quantidade a ser sacada deve ser maior que zero!");
            }
            else if (quantidade > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para o saque!");
            }
            else
            {
                Console.WriteLine($"Novo saldo após saque: {Saldo -= quantidade}");
            }
        }

        public void Depositar(double quantidade)
        {
            Console.WriteLine($"Novo saldo após depósito: {Saldo += quantidade}");
        }

        public override string ToString()
        {
            return $"Agência: {Agencia} | Conta: {NumeroConta} | Data de Abertura: {DataAbertura} | Saldo: {Saldo}";
        }
    }
}
