using System;

namespace Ex2PositivosNegativosOuZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            for(int cont = 1; cont < 6; cont++)
            {
                Console.WriteLine("Informe um número !!! ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 0) Console.WriteLine("Esse número é igual a zero !!!!!");
                if (num > 1) Console.WriteLine("Esse número certamente é positivo !!!");
                if (num < -1) Console.WriteLine("Esse número certeza que é negativo !!!");
            }
        }
    }
}
