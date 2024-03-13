using System;

namespace SuperSorteio
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sorteio = new Random();
            int numeroSorteado = sorteio.Next(1, 5);

            String nome;
            int numeroEscolhido;

            Console.WriteLine("**** Super Sorteio ****");
            System.Console.WriteLine("Informe seu nome");
            nome = Console.ReadLine();

            System.Console.WriteLine("Escolha um número de 1 a 4");
            numeroEscolhido = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("O número que o computador escolheu foi: " + numeroSorteado);
            
            if (numeroEscolhido == numeroSorteado)
            {
                System.Console.WriteLine("PARABENS !!!! Você Ganhou um iPhone !!!");
            }
            else
            {
                System.Console.WriteLine("Xiiii... perdeu!");
            }

            Console.ReadKey();
        }
    }
}
