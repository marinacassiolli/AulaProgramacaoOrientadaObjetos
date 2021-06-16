using System;
using System.Collections.Generic;
using System.Text;

namespace AulaProgramacaoOrientadaObjetos
{
    // Herança
    public class ContaPoupanca : Conta
    {
        public override double ObterPercentualTaxa()
        {
            return 3;
        }
    }
}
