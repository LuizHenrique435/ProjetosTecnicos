using System;

namespace EX1QtdPessoasMuseu
{
    class Program
    {
        static void Main(string[] args)
        {
            int homem = 0;
            int mulher = 0;
            string resposta;

            for(int cont = 1; cont < 50; cont++)
            {
                Console.WriteLine("Qual o seu gênero ?");
                resposta = Console.ReadLine();

                if (resposta == "homem")
                {
                    homem++;
                }
                else
                {
                    if (resposta == "mulher")
                    {
                        mulher++;
                    }
                    else
                    {
                        Console.WriteLine("Não identificado ! ");
                    }
                }
               
            }

            Console.WriteLine("A quantidade de homens é de : " + homem);
            Console.WriteLine("A quantidade de mulheres é de : " + mulher);
        }
    }
}
