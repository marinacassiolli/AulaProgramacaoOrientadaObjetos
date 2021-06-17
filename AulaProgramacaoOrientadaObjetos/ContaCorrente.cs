using System;
using System.Collections.Generic;
using System.Text;

namespace AulaProgramacaoOrientadaObjetos
{
    // Herança
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string agencia)
        {
            this.Agencia = agencia;
        }

        public override double Sacar(double quantidade)
        {
            var taxa = ObterPercentualTaxa();
            var valorTaxa = quantidade * (taxa / 100);

            return this.Saldo -= (quantidade + valorTaxa);
        }

        public override double ObterPercentualTaxa()
        {
            return 5;
        }
    }
}
