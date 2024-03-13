using System;

namespace EntrevistaWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 0, filhos = 0;
            double renda = 0;
            Console.WriteLine("Censo Atibaia");
            int entrevista = 1;

            while (entrevista <= 3)
            {
                Console.WriteLine("\n\nEntrevista" + entrevista + "\n");
                Console.WriteLine("1. Qual a sua idade?");
                idade = idade + Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("2. Qual a sua renda mensal?");
                renda = renda + Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("3. Quantos filhos você possui?");
                filhos = filhos + Convert.ToInt16(Console.ReadLine());
                entrevista++;  //entrevista = entrevista + 1;
            }
            Console.WriteLine("Média de idade: " + (idade / 3));
            Console.WriteLine("Média de renda: " + (renda / 3));
            Console.WriteLine("Média de filhos: " + (filhos / 3));
        }
    }
}
