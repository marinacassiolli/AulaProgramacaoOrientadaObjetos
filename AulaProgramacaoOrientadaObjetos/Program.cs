using System;

namespace AulaProgramacaoOrientadaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // POO - Programação Orientada a Objetos.

            // Objeto - é uma representação de algo do mundo real. Ex.: Conta no banco.
            // Propriedades - são características do objeto. Ex.: Agencia, conta
            // Métodos - ações. Ex.: Calcular Bonus;

            // Os 4 pilares da POO:
            // - Abstração
            // - Ecanpsulamento
            // - Herança
            // - Polimorfismo

            // Conta conta = new Conta(); - Não pode ser instanciado pois é abstract

            var contaCorrente = new ContaCorrente(agencia: "0123");
            Console.WriteLine(contaCorrente.ToString());
            contaCorrente.Depositar(1000);
            Console.WriteLine(contaCorrente.ToString());
            contaCorrente.Sacar(900);
            Console.WriteLine(contaCorrente.ToString());
            contaCorrente.Sacar(100);
            Console.WriteLine(contaCorrente.ToString());

            Console.WriteLine("============================================");

            var contaPoupanca = new ContaPoupanca();
            contaPoupanca.Agencia = "0000";
            Console.WriteLine(contaPoupanca.ToString());
            contaPoupanca.Depositar(1000);
            Console.WriteLine(contaPoupanca.ToString());
            contaPoupanca.Sacar(900);
            Console.WriteLine(contaPoupanca.ToString());
            contaPoupanca.Sacar(100);
            Console.WriteLine(contaPoupanca.ToString());
            contaPoupanca.Sacar(0);
            Console.WriteLine(contaPoupanca.ToString());

            Console.ReadLine();
        }
    }
}
