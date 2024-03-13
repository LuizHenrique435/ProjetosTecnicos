using System;
using System.CodeDom.Compiler;

namespace EX3NotaPeso
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0, nota = 0, geral = 0;

            Console.WriteLine("SUPER CALCULADORA DE MÉDIAS PONDERADAS !!!!!");
            Console.WriteLine("********************************************");

            for (int numeromedia = 1; numeromedia < 4; numeromedia = numeromedia + 1)
            {
                Console.WriteLine("Olá seja bem vindo !");
                Console.WriteLine("O peso dessa nota para o calculo da media ponderada é igual a : " + numeromedia);
                Console.WriteLine("Insira uma nota !");
                nota = Convert.ToDouble(Console.ReadLine());
                geral = geral + (nota * numeromedia);
            }

            media = geral / 6;

            Console.WriteLine("A média é igual a : " + media);

            Console.ReadKey();

        }
    }
}
