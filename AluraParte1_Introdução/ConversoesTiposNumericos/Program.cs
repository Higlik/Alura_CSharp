using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Programa");

            double salario = 1200.50;


            int salarioInteiro = (int)salario;
            //O nome dessa operação de conversão é casting, deixando claro que o resultado não será exato

            Console.WriteLine(salarioInteiro);

            //Tipos de números 
            // long 64 bits
            // int 32 bits
            // short 16 bits

            float ex1 = 1.80f; // necessário colocar o "f" no final para identificar que se trata de um float

            // double
            // float  

            

            Console.WriteLine("Fim da execução");
            Console.ReadLine();


        }
    }
}
