using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente victor = new Cliente();

            victor.nome = "Victor";
            victor.profissao = "Dev";
            victor.cpf = "132.333.444-15";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = victor;
            conta.agencia = 12345;
            conta.numero = 54321;
            conta.saldo = 1000;

            Console.WriteLine(victor.nome); 
            Console.WriteLine(conta.titular.nome);



            Console.ReadLine();
        }
    }
}
