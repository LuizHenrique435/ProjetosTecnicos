using System;

namespace CodigoProdutoSC
{
    class Program
    {
        static void Main(string[] args)
        {
            int produto = 0;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Olá, Seja Bem Vindo Ao Mercado Do Povo");


        inicio:

            produto = 0;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*********************");
            Console.WriteLine("***MERCADO DO POVO***");
            Console.WriteLine("*********************");

            Console.WriteLine("informe um número do produto que você deseja !!");
            produto = Convert.ToInt32(Console.ReadLine());

            switch (produto)
            {
                case int x when x == 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ALIMENTO NÃO PERECÍVEL !");
                    break;

                case int x when x >= 2 && x <= 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ALIMENTO PERECÍVEL !");
                    break;

                case int x when x >= 5 && x <= 6:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VESTUÁRIO !");
                    break;

                case 7:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("HIGIENE PESSOAL !");
                    break;

                case int x when x >= 8 && x <= 15:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("LIMPEZA E UTENSÍLIOS DOMÉSTICOS !");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CÓDIGO INVÁLIDO !!!");
                    break;
            }

            Console.WriteLine("Quer Jogar Novamente ? (s/n)");
            if (Console.ReadLine() == "s") goto inicio;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Obrigado Por Pesquisar ! Tchau Brigado !!");

            Console.ReadKey();
        }
    }
}
