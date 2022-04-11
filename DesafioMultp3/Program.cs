using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioMultp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // metodo 1
            for (int numero = 0; numero <= 100; numero++)
            {
                if ( numero % 3 == 0)
                  Console.WriteLine("O número " + numero + " é multiplo de 3");
            }

            Console.WriteLine();
            Console.WriteLine("Exemplo 2 : \n");
            //metedo 2
            for (int numero = 0; numero <= 100; numero += 3)
            {
                if (numero % 3 == 0)
                    Console.WriteLine("O número " + numero + " é multiplo de 3");
            }

            Console.ReadLine();

        }
    }
}
