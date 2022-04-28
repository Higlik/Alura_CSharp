using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inicio do programa - Lendo quanto nossa poupança rende");


            double valorInvestido = 1000;

            // 0.36% = 0.0036
          //  valorInvestido = valorInvestido + valorInvestido * 0.0036;
          //  Console.WriteLine("Após 1 mês, você terá " + valorInvestido);

            int contadorMes = 1;
            
            while (contadorMes <= 12) {

                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " você terá o valor de " + valorInvestido);
                contadorMes++;

            }



            Console.ReadLine(); 

        }
    }
}
