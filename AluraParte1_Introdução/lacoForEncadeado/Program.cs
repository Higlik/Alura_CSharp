using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lacoForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inicio do programa");

            double valorInvestido = 1000.0;
            double fatorRendimento = 1.0036;


            for(int contAno = 1; contAno <= 5; contAno++)
            {
                for(int contMes = 1; contMes <= 12; contMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao termino do investimento você terá R$" + valorInvestido);
            Console.ReadLine();


        }
    }
}
