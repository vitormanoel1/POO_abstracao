using System;
using POO_Abstracao.Classes;

namespace POO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();

            Credito credito = new Credito();

            Debito debito = new Debito();

            boleto.valores = 5000;

            boleto.parcelas = 5;

            credito.bandeira = "MasterCard";

            credito.cvv = "65397";

            credito.limite = 6000;

            credito.parcelas = 12;

            credito.valores = 7000;
        }
    }
}
