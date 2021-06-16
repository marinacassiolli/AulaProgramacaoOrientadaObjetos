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

        public virtual double Sacar(double quantidade)
        {
            return Saldo -= quantidade;
        }

        public double Depositar(double quantidade)
        {
            return Saldo += quantidade;
        }
    }
}
