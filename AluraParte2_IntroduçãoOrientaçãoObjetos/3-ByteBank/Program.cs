using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaVictor = new ContaCorrente();
            ContaCorrente contaFranca = new ContaCorrente();


            contaVictor.titular = "Victor";
            contaVictor.agencia = 1234;
            contaVictor.numero = 565;
            contaVictor.saldo = 1000.0;

            contaFranca.titular = "Franca";
            contaFranca.agencia = 1234;
            contaFranca.numero = 565;
            contaFranca.saldo = 1000.0;


            Console.WriteLine("Igualdade do tipo de referência: "+ (contaVictor == contaFranca));

            int idade = 23;
            int idade1 = 23;

            Console.WriteLine("Igualdade do tipo de valor: "+ (idade == idade1));


            contaVictor = contaFranca;
            Console.WriteLine("Igualdade do tipo de referência: " + (contaVictor == contaFranca));



            Console.ReadLine();
        }
    }
}
