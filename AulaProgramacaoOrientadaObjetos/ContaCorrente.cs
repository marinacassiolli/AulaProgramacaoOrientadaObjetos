using System;
using System.Collections.Generic;
using System.Text;

namespace AulaProgramacaoOrientadaObjetos
{
    // Herança
    public sealed class ContaCorrente : Conta
    {
        public ContaCorrente(string agencia) : base(agencia)
        {
            
        }

        public override void Sacar(double quantidade)
        {
            var taxa = ObterPercentualTaxa();
            var valorTaxa = quantidade * (taxa / 100);
            var valorTotalSaque = quantidade + valorTaxa;

            if (quantidade <= 0)
            {
                Console.WriteLine("Quantidade a ser sacada deve ser maior que zero!");
            }
            else if (valorTotalSaque > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para o saque!");
            }
            else
            {
                Console.WriteLine($"Novo saldo após saque: {Saldo -= valorTotalSaque}");
            }
        }

        public override double ObterPercentualTaxa()
        {
            return 1;
        }
    }
}
