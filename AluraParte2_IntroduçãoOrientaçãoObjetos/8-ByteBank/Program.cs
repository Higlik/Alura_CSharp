using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaVictor = new ContaCorrente(876, 12345);
            Cliente cliente = new Cliente();

            cliente.Nome = "Victor";
            cliente.Profissao = "Dev";
            cliente.CPF = "123123123-32";

            ContaVictor.Titular = cliente;

            ContaVictor.Saldo = 1500;

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(ContaVictor.Saldo);

            Console.ReadLine();


        }
    }
}
