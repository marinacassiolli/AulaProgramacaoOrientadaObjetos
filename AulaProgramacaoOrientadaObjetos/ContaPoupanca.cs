namespace AulaProgramacaoOrientadaObjetos
{
    // Herança
    public sealed class ContaPoupanca : Conta
    {
        public override double ObterPercentualTaxa()
        {
            return 3;
        }
    }
}
