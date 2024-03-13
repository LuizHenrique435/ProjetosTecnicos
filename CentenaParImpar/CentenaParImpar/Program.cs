using System;

namespace CentenaParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int U = 0, C = 0, D = 0;

            Console.WriteLine("Olá, informe um número seguindo as casas decimais !!!");
            Console.WriteLine("Informe primeiro a centena !");
            C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Agora informe a dezena !");
            D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe por ultimo a unidade !!!");
            U = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O número informado foi " + C + D + U);

            Console.WriteLine("Agora iremos informar seguindo as casas decimais quais números dentro de cada casa é par ou impar !");

            if (C % 2 == 0)
            {
                Console.WriteLine("A casa da centena é PAR !!!");
            }
            else
            {
                Console.WriteLine("A casa da centena é IMPAR !!");
            }
            if (D % 2 == 0)
            {
                Console.WriteLine("A casa da dezena é PAR !!!");
            }
            else
            {
                Console.WriteLine("A casa da dezena é IMPAR !!");
            }
            if (U % 2 == 0)
            {
                Console.WriteLine("A casa da unidade é PAR !!!");
            }
            else
            {
                Console.WriteLine("A casa da unidade é IMPAR !!");
            }
        }
    }
}
