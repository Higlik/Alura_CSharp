using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inicia prgrama");

            int idade = 16;
            int idade1 = 25;

            if (idade1 < 18)
            {
                Console.WriteLine("João tem " + idade1 + " anos e ganha desconto");
            }
            else if (idade1 > 23)
            {
                Console.WriteLine("João tem " + idade1 + " anos e não ganha desconto");
            }
            else
            {
                Console.WriteLine("João não possui  mais de 18 anos");
            }


            Console.ReadLine();

        }
    }
}
