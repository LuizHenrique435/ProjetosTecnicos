using System;
using System.Threading;

namespace EX4LanchoneteSC
{
    class Program
    {
        static void Main(string[] args)
        {
            int CodProduto = 0 , quantidade;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("***********************");
            Console.WriteLine("**LANCHONETE DO POVÃO**");
            Console.WriteLine("***********************");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Olá Seja Muito Bem Vindo A Lanchonete do Povão !!!\n\n");
            Console.WriteLine("Sua Presença É Uma Honra !!!\n");

            Inicio:

            Console.WriteLine("Pressione ENTER Para Ter Acesso Ao Menu ! \n");
            Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Cód  ---------- Produto ---------- Valor \n");
            Console.WriteLine("100  ------ Cachorro Quente ------ 1,70  \n");
            Console.WriteLine("101  ------ Bauru Simples   ------ 2,30  \n");
            Console.WriteLine("102  ------ Bauru Com Ovo   ------ 2,60  \n");
            Console.WriteLine("103  ------ Hamburguer      ------ 2,40  \n");
            Console.WriteLine("104  ------ Cheeseburguer   ------ 2,50  \n");
            Console.WriteLine("105  ------ Refrigerante    ------ 1,00  \n");

            Console.WriteLine("Digite a quantidade que você deseja consumir !!!\n");
            quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o código do produto !");
            CodProduto = Convert.ToInt32(Console.ReadLine());

            switch (CodProduto)
            {
                case 100:
                    Console.WriteLine("O valor final é de : " + (1.70 * quantidade));
                break;
                case 101:
                    Console.WriteLine("O valor final é igual a : " + (2.30 * quantidade));
                break;
                case 102:
                    Console.WriteLine("O valor final é igual a : " + (2.60 * quantidade));
                break;
                case 103:
                    Console.WriteLine("O valor final é de : " + (2.40 * quantidade));
                break;
                case 104:
                    Console.WriteLine("O valor final é de : " + (2.50 * quantidade));
                break;
                case 105:
                    Console.WriteLine("O valor final é de : " + (1.00 * quantidade));
                break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("PRODUTO NÃO ENCONTRADO !!!");
                break;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Muito Obrigado Pela Confiança ! Esperamos Você Na Proxima !!! \n");

            Console.WriteLine("Deseja Fazer Outra Compra ? (S/N)\n\n");
            if (Console.ReadLine() == "s") goto Inicio;


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Obrigado !");

            Console.ReadKey();


        }
    }
}
