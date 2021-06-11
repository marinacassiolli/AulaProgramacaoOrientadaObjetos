using System;
using System.Collections.Generic;
using System.Text;

namespace AulaProgramacaoOrientadaObjetos
{
    // Abstração
    public abstract class Conta
    {
        public Conta()
        {
            NumeroConta = Guid.NewGuid().ToString();
            DataAbertura = DateTime.Now;
        }

        public string Agencia { get; set; }
        // Encapsulamento
        public string NumeroConta { get; private set; }
        public double Saldo { get; protected set; }
        public DateTime DataAbertura { get; private set; }

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
