using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaVictor = new ContaCorrente();

            contaVictor.titular = "Victor";
            contaVictor.saldo += 1000.0;

            Console.WriteLine(contaVictor.titular);
            Console.WriteLine(contaVictor.saldo);

            Console.ReadLine();
        }
    }
}
