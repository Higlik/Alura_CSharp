using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaVictor = new ContaCorrente();
            ContaCorrente contaFranca = new ContaCorrente();
            
            contaVictor.titular = "Victor";
            contaFranca.titular = "França";

            Console.WriteLine("Saldo Victor: " + contaVictor.saldo);
            Console.WriteLine("Saldo Franca: " + contaFranca.saldo);

            contaVictor.saldo += 700;

            contaVictor.Transferir(200, contaFranca);

            Console.WriteLine("Saldo Victor: " + contaVictor.saldo);
            Console.WriteLine("Saldo Franca: " + contaFranca.saldo);

            Console.ReadLine();
        }
    }
}
