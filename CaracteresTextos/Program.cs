using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresTextos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iniciando Programa");


            char primeiraLerta = 'a';
            Console.WriteLine(primeiraLerta);

            primeiraLerta = (char)65;
            Console.WriteLine(primeiraLerta);

            primeiraLerta = (char)(primeiraLerta + 1);
            Console.WriteLine(primeiraLerta);

            string titulo = "Aprendendo sobre caracteres e textos " + 2022;

            Console.WriteLine(titulo);  


            Console.WriteLine("Fim da execução");
            Console.ReadLine();
            

        }
    }
}
