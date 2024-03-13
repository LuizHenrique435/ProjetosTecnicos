using System;

namespace Atividade6_LucrodoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            double ValorProduto;

            Console.Beep();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Olá cliente, informe o valor do produto comprado !");
            ValorProduto = Convert.ToDouble(Console.ReadLine());

            Console.Beep();

            if(ValorProduto < 20.00)
            {
                Console.WriteLine("O valor de venda é igual a:" + (ValorProduto * 1.45));
            }
            else
            {
                if(ValorProduto >= 20.00)
                {
                    Console.WriteLine("Caso contrário o valor de venda é igual a:" +(ValorProduto * 1.30));
                }

                Console.ReadKey();
            }
        }
    }
}
