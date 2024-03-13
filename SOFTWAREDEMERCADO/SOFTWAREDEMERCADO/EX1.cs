using System;

namespace SOFTWAREDEMERCADO
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] CodBarra = new int[10];
            int[] PrecoP = new int[10];
            string[] Nproduto = new string[10];
            int respostaCliente = 0;
            int verificaCodigo = 0;




            Console.WriteLine("SOFTWARE DE MERCADO");

            for (int cont = 0; cont < 10; cont++)
            {


                Console.WriteLine("\n\n\nInsira o código do produto:");
                CodBarra[cont] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nInsira o Nome do respectivo produto:");
                Nproduto[cont] = Console.ReadLine();


                Console.WriteLine("\nInsira o preço do respectivo produto $$ :");
                PrecoP[cont] = Convert.ToInt32(Console.ReadLine());


            }

            Console.WriteLine("\n\nAgora, insira o código do produto desejado:");
            respostaCliente = Convert.ToInt32(Console.ReadLine());


            for (int contador = 0; contador < 10; contador++)
            {
                if (respostaCliente == CodBarra[contador])
                {
                    Console.WriteLine("O Nome do seu produto é:" + Nproduto[contador]);
                    Console.WriteLine("O preço do seu produto é:" + PrecoP[contador]);
                    verificaCodigo++;


                }
                else
                {
                    Console.WriteLine("Pesquisando...");
                }
            }

            if (verificaCodigo < 1)
            {
                Console.WriteLine("Produto não encontrado!");
            }

            Console.ReadLine();
        }
    }
}
