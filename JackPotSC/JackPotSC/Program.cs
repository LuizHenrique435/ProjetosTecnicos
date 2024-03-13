using System;

namespace JackPotSC
{
    class Program
    {
        static void Main(string[] args)
        {
            int combinacao1, combinacao2, combinacao3;
            int premio = 0;

        Start:

            premio = 0;

            Random sorteio = new Random();
            combinacao1 = sorteio.Next(1,4);
            combinacao2 = sorteio.Next(1,4);
            combinacao3 = sorteio.Next(1,4);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("************************");
            Console.WriteLine("**JACKPOT DAS GALÁXIAS**");
            Console.WriteLine("************************");
       

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Boa Sorte, Será Que Você Conseguiu Combinar Os Números ?");
            Console.WriteLine("Estes Foram os Números do computador !");

            Console.WriteLine("JACKPOT : " + combinacao1 + combinacao2 + combinacao3);

            if (combinacao1 == 1 && combinacao2 == 1 && combinacao3 == 1) premio = 1;
            if (combinacao1 == 2 && combinacao2 == 2 && combinacao3 == 2) premio = 2;
            if (combinacao1 == 3 && combinacao2 == 3 && combinacao3 == 3) premio = 3;

            switch (premio)
            {
                case 1:
                    Console.WriteLine("Você ganhou um Fiat Uno 147 !!");
                break;

                case 2:
                    Console.WriteLine("Você ganhou um Celta !!");
                break;

                case 3:
                    Console.WriteLine("Você Ganhou uma ferrari !!");
                break;

                default:
                    Console.WriteLine("Você não ganhou nada !!");
                break;
            }

            Console.WriteLine("Quer Jogar Novamente ? Pressione S");
            if (Console.ReadLine() == "s") goto Start;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Obrigado por Jogar ! Tchau Brigado !!");

        }
    }
}
