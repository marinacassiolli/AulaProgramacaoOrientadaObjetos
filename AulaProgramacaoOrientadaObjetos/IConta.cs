namespace AulaProgramacaoOrientadaObjetos
{
    public interface IConta
    {
        double Sacar(double quantidade);
        double Depositar(double quantidade);
        double ObterPercentualTaxa();
    }
}
