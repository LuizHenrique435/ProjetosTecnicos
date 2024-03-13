using System;

namespace JackPot
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int combinacao1, combinacao2, combinacao3;

            Random sorteio = new Random();
            combinacao1 = sorteio.Next(1, 4);
            combinacao2 = sorteio.Next(1, 4);
            combinacao3 = sorteio.Next(1, 4);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("*****BEM VINDO AO*****");
            Console.WriteLine("******JACKPOT*********");
            Console.WriteLine("******BOA SORTE*******");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Olá seja muito bem vindo !");
            Console.WriteLine("Informe seu nome !");
            nome = Console.ReadLine();
          
            Console.WriteLine("insira uma moeda !!");
            Console.WriteLine("****************************");
            Console.WriteLine("**MOEDA INSERIDA BOA SORTE**");
            Console.WriteLine("****************************");

            Console.WriteLine("JACKPOT : " + combinacao1 + combinacao2 + combinacao3);

            if (combinacao1 == combinacao2 && combinacao2 == combinacao3) 
            {
                Console.WriteLine("\nPARABÉNS VOCÊ GANHOU!!!!");
                if (combinacao1 == 1) Console.WriteLine("\nSeu prêmio foi um tiro de borracha OBS: COLOQUE O COLETE QUE ESTÁ NO CHÃO PARA NÃO SE MACHUCAR !");
                if (combinacao1 == 2) Console.WriteLine("\nSeu prêmio é R$ 1,00");
                if (combinacao1 == 3) Console.WriteLine("\nSeu prêmio é de R$ 1.000.000,00");
            }

            Console.ReadKey();
          
        }
    }
}
