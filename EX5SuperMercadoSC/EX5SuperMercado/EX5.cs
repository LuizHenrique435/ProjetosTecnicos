using System;

namespace EX5SuperMercado
{
    class Program
    {

     static double valorDisponivel;  //variável pública !


          // Método
         // Parametro -> Valor que você passa para o método poder trabalhar.
        static void Calculo(double valor)//<------------------- METODO COM PARAMETRO
        {
            if (valorDisponivel >= valor)
            {
                valorDisponivel = valorDisponivel - valor;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Item não disponível");
            }
        }
        static void Main(string[] args)
        {
         

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("***********************");
            Console.WriteLine("***MERCADO DO MARCÃO***");
            Console.WriteLine("***********************\n\n");

            Console.WriteLine("Qual valor você possui para gastar?");
            valorDisponivel = Convert.ToDouble(Console.ReadLine());

        inicio:
            if (valorDisponivel >= 10) Console.WriteLine("1 – Arroz, R$ 10,00");
            if (valorDisponivel >= 15) Console.WriteLine("2 – Feijão, R$ 15,00");
            if (valorDisponivel >= 4.5) Console.WriteLine("3 – Macarrão, R$ 4,50");
            if (valorDisponivel >= 2.5) Console.WriteLine("4 - Miojo, R$ 2,50");
            if (valorDisponivel >= 5) Console.WriteLine("5 - Mortadela, R$ 5,00");
            if (valorDisponivel >= 9) Console.WriteLine("6 - Pão de Forma, R$ 9,00 ");
            if (valorDisponivel >= 7) Console.WriteLine("7 - Presunto, R$ 7,00");
            if (valorDisponivel >= 2) Console.WriteLine("8 - Bolacha, R$ 2,00");
            if (valorDisponivel >= 2) Console.WriteLine("9 - Biscoito, R$ 2,00");
            if (valorDisponivel >= 2) Console.WriteLine("10 - Iogurte, R$ 2,00");
            if (valorDisponivel >= 10) Console.WriteLine("11 - Coca-cola , R$ 10,00");
            if (valorDisponivel >= 1) Console.WriteLine("12 - Suco Tang, R$ 1,00");
            if (valorDisponivel >= 8) Console.WriteLine("13 - Goaibada, R$ 8,00");
            if (valorDisponivel >= 13) Console.WriteLine("14 - Queijo Branco, R$ 13,00");
            if (valorDisponivel >= 5) Console.WriteLine("15 - Farofa, R$ 5,00");
            if (valorDisponivel >= 9) Console.WriteLine("16 - Café, R$ 9,00");
            if (valorDisponivel >= 12) Console.WriteLine("17 - Álcool em Gel, R$ 12,00");
            if (valorDisponivel >= 3) Console.WriteLine("18 - Papel Toalha, R$ 3,00");
            if (valorDisponivel >= 25) Console.WriteLine("19 - Nutella, R$ 25,00");
            if (valorDisponivel >= 2) Console.WriteLine("20 – Molho de Tomate, 2,00\n");

            Console.WriteLine("Escolha um dos itens disponíveis para compra:");
            int escolha = Convert.ToInt16(Console.ReadLine()); // INT16 serve para números pequenos
            switch (escolha)
            {
                case 1:
                    Calculo(10);
                    break;

                case 2:
                    Calculo(15);
                    break;

                case 3:
                    Calculo(4.5);
                    break;

                case 4:
                    Calculo(2.5);
                    break;

                case 5:
                    Calculo(5);
                    break;

                case 6:
                    Calculo(9);
                    break;

                case 7:
                    Calculo(7);
                    break;

                case 8:
                    Calculo(2);
                    break;

                case 9:
                    Calculo(2);
                    break;

                case 10:
                    Calculo(2);
                    break;

                case 11:
                    Calculo(10);
                    break;

                case 12:
                    Calculo(1);
                    break;

                case 13:
                    Calculo(8);
                    break;

                case 14:
                    Calculo(13);
                    break;

                case 15:
                    Calculo(5);
                    break;

                case 16:
                    Calculo(9);
                    break;

                case 17:
                    Calculo(12);
                    break;

                case 18:
                    Calculo(3);
                    break;

                case 19:
                    Calculo(25);
                    break;

                case 20:
                    Calculo(2);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cód. não existente");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Seu saldo atual é: " + valorDisponivel);

            if (valorDisponivel >= 1) // 1 é o menor valor da lista de produtos
            {
                Console.WriteLine("Deseja continuar a compra? [s/n]");
                String resposta = Console.ReadLine();
                if (resposta == "s") goto inicio;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Obrigado pela sua compra"); // FIM
        }
    }
}
