using System;
using System.Collections.Generic;
using System.Text;

namespace AulaProgramacaoOrientadaObjetos
{
    // Herança
    public class ContaCorrente : Conta
    {
        // Polimorfismo
        public override double Sacar(double quantidade)
        {
            int taxaSaque = 5;
            double valorTotalSaque = quantidade + taxaSaque;

            return Saldo -= valorTotalSaque;
        }
    }
}
