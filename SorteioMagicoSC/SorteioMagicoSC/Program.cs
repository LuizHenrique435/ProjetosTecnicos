using System;

namespace SorteioMagicoSC
{
    class Program
    {
        static void Main(string[] args)
        {
            int aposta;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("********************************");
            Console.WriteLine("******Sorteio Mágico************");
            Console.WriteLine("********************************\n\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Vamos ver se você está com sorte hoje. Pressione ENTER se você estiver pronto!");
            Console.ReadLine();
            System.Console.WriteLine("\n\nOk, vamos começar!!\n\n");
            System.Console.WriteLine("Temos alguns números premiados, vamos ver se você é bão\n\n");

            inicio:
            System.Console.WriteLine("Qual o número que você quer apostar?");
            aposta = Convert.ToInt32(Console.ReadLine()); // usário um número.
            // if (aposta == numSorteado) System.Console.WriteLine("Ganhou um iPhone");
            switch (aposta)
            {
                case int x when x >= 7 && x <= 10:
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("\n\nVocê ganhou um tiro no peito, Boa Sorte!");
                    break;
                case int x when x >=13 && x <= 17:
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("\n\nVocê Ganhou Um Iphone !");
                    break;
                case int x when x >= 20 && x <= 25:
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("\n\nVocê Ganhou Uma lamborghini !");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("\n\nVocê não ganhou nada!!!");
                    break;
            }

            Console.WriteLine("Deseja Jogar Novamente ? (s/n)");
            if (Console.ReadLine() == "s") goto inicio;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Obrigado por Jogar ! Tchau Brigado !!");

            Console.ReadKey();
        }
    }
}
