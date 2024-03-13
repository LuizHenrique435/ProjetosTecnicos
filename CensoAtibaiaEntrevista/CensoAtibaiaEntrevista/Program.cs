using System;

namespace CensoAtibaiaEntrevista
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, filhos = 0;
            double renda = 0;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("*************");
            Console.WriteLine("Censo Atibaia");
            Console.WriteLine("*************");
            int entrevista = 1;

            while (entrevista <= 10)
            {
                Console.WriteLine("\n\nEntrevista" + entrevista + "\n");

                Console.WriteLine("1. Qual a sua idade?\n");
                idade = idade + Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("2. Qual a sua renda mensal?\n");
                renda = renda + Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("3. Quantos filhos você possui?\n");
                filhos = filhos + Convert.ToInt16(Console.ReadLine());

                entrevista++;  //entrevista = entrevista + 1;
            }
            Console.WriteLine("Média de idade: " + (idade / 10));
            Console.WriteLine("Média de renda: " + (renda / 10));
            Console.WriteLine("Média de filhos: " + (filhos / 10));
        }
    }
}
