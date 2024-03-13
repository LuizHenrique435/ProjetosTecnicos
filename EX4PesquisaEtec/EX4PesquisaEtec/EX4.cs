using System;

namespace EX4PesquisaEtec
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pergunta1, Soma1 = 0;
            double Pergunta2, Soma2 = 0;
            double Pergunta3, Soma3 = 0;
            double Pergunta4, Soma4 = 0;

            Console.WriteLine("**************************************");
            Console.WriteLine("*****SUPER PESQUISA DE SATISFACAO*****");
            Console.WriteLine("**************************************");

            for(int candidatos = 1; candidatos <= 10; candidatos++)
            {
                Console.WriteLine(candidatos + " Candidato\n");
                Console.WriteLine("\n1. De 1 a 10, você está feliz estudando on-line? (Peso 2)\n");
                Pergunta1 = Convert.ToDouble(Console.ReadLine());
                Soma1 = Soma1 + Pergunta1;


                Console.WriteLine("\n2. De 1 a 10, Você gostaria de voltar as aulas presenciais? (Peso 1)\n");
                Pergunta2 = Convert.ToDouble(Console.ReadLine());
                Soma2 = Soma2 + Pergunta2;


                Console.WriteLine("\n3. De 1 a 10, Seus pais apoiam os estudos online? (Peso 3)\n");
                Pergunta3 = Convert.ToDouble(Console.ReadLine());
                Soma3 = Soma3 + Pergunta3;


                Console.WriteLine("\n4. De 1 a 10, No geral, os professores são bons? (Peso 3)\n");
                Pergunta4 = Convert.ToDouble(Console.ReadLine());
                Soma4 = Soma4 + Pergunta4;

            }

            Console.WriteLine("1. De 1 a 10, você está feliz estudando on-line? (Peso 2)\n");
            Console.WriteLine("a media de todas as respostas é de: " + Soma1 / 10 + "\n");

            Console.WriteLine("2. De 1 a 10, Você gostaria de voltar as aulas presenciais? (Peso 1)\n");
            Console.WriteLine("a media de todas as respostas é de: " + Soma2 / 10 + "\n");

            Console.WriteLine("3. De 1 a 10, Seus pais apoiam os estudos online? (Peso 3)\n");
            Console.WriteLine("a media de todas as respostas é de: " + Soma3 / 10 + "\n");

            Console.WriteLine("4. De 1 a 10, No geral, os professores são bons? (Peso 3)\n");
            Console.WriteLine("a media de todas as respostas é de: " + Soma4 / 10 + "\n");

            Console.WriteLine("A média total geral é de:" + ((((Soma1 / 10) * 2) + ((Soma2 / 10) * 1) + ((Soma3 / 10) * 3) + ((Soma4 / 10) * 3)) / 6));


            Console.ReadKey();

        }
    }
}
