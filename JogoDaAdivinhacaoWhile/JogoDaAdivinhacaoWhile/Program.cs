using System;

namespace JogoDaAdivinhacaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sorteio = new Random();
            int NumSorteiado = sorteio.Next(1, 11);
            Console.WriteLine(" JOGO DA ADIVINHAÇÃO ");
            Console.WriteLine(" ------------------- ");
            Console.WriteLine("Este computador é mágico!!!\nEle escolheu um número e se você acertar você ganhará 1 milhão de reais");
            Console.WriteLine("Você tem 5 tentativas para adivinhar o número escolhido pelo computador.");
            Console.WriteLine(" ------------------- ");
            int tentativas = 1;
            while (tentativas <= 5)
            {
                Console.WriteLine("Qual o número que o computador escolheu? ");
                int aposta = Convert.ToInt32(Console.ReadLine());
                if (aposta == NumSorteiado)
                {
                    System.Console.WriteLine("Ganhouuuuu!!! Parabéns... retire seu prêmio na casa do Marcelo!!!");
                    break; // Para a execução do While
                }
                else
                {
                    System.Console.WriteLine("Erouuuuu!!!! Tente mais uma vez, você é bom nisso!!!!");
                }
                tentativas = tentativas + 1; // acumulador, controla o while
            }
            Console.WriteLine("O número sa sorte é o " + NumSorteiado);
        }
    }
}
