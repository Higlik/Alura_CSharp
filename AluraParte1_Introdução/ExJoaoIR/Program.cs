using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExJoaoIR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 3751.0;

            if (salario >= 1900.0 && salario < 2800.0)
                Console.WriteLine("João vai deduzir R$142,00 de IR");
            else if (salario >= 2800.0 && salario < 3751.0)
                Console.WriteLine("João vai deduzir R$350 de IR");
            else if (salario >= 3751.0 && salario < 4664.0)
                Console.WriteLine("João vai deduzir R$636 de IR");
            else
                Console.WriteLine("João não irá deduzir nada");

            Console.ReadLine();

        }
    }
}
