using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

         ContaCorrente contaVictor = new ContaCorrente();

            contaVictor.titular = "Victor";
            contaVictor.agencia = 1234;
            contaVictor.numero = 666;
            contaVictor.saldo = 1000.00;

            Console.WriteLine("Nome do titular da conta: "+contaVictor.titular);
            Console.WriteLine("Número da agência: "+contaVictor.agencia);
            Console.WriteLine("Número da conta: "+contaVictor.numero);
            Console.WriteLine("Saldo na conta: "+contaVictor.saldo);

            contaVictor.saldo += 200;

            Console.WriteLine("Deposito de R$200,00. O saldo da conta agora está no valor de R$"+contaVictor.saldo);




            Console.ReadLine();

        }
    }
}
