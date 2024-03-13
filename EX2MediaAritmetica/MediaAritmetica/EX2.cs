using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2;

            Console.WriteLine("Olá, Informe A Primeira Nota !\n\n");
            N1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Agora Faça O Favor De Informar A Segunda Nota !\n\n");
            N2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A Média Do Estudante é : " + ( N1 + N2)  /2);

            switch ((N1 + N2) /2)
            {
                case double x when x <= 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("REPROVADO !!!");
                    break;

                case  double x when x >= 4.1 && x <= 7:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("EXAME !!!");
                    break;

                case double x when x >= 7.1 && x <= 10:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("APROVADO !!!!");
                    break;

            }
            Console.ReadKey();
            
        }
    }
}
