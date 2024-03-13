using System;

namespace Atividade4_NúmeroImparouPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Olá usuário, informe um número !");
            n1 = Convert.ToInt32(Console.ReadLine());

            if ((n1 / 2) == 0)
            {
                Console.WriteLine("O número :" + n1 + " é um número PAR");
            }
            else
            {
                Console.WriteLine("O número :" + n1 + " é um número IMPAR");
            }

            Console.ReadKey();

            //Não deu certo professor, queria saber qual foi o erro, já que esse exercício é opcional//
        }
    }
}
