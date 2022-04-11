using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando programa");

            double valorInvestido = 1000.0;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *=  1.0036;
                Console.WriteLine("Após "+contadorMes+" meses, você terá o valor de R$ "+ valorInvestido);
            }

            Console.ReadLine();


        }
    }
}
