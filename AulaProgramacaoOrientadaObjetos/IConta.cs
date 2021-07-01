namespace AulaProgramacaoOrientadaObjetos
{
    public interface IConta
    {
        void Sacar(double quantidade);
        void Depositar(double quantidade);
        double ObterPercentualTaxa();
    }
}
