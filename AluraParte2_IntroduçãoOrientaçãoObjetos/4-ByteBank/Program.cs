using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaVictor = new ContaCorrente();
          


            contaVictor.titular = "Victor";
            contaVictor.agencia = 1234;
            contaVictor.numero = 565;
            contaVictor.saldo = 1000.0;

            contaVictor.Sacar(50);

            Console.WriteLine("O valor da conta é de " + contaVictor.saldo);


            Console.ReadLine();

        }
    }
}
