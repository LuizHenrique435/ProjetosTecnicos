using System;

namespace Ex3VerificaPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, primo, contador = 0;

            Console.WriteLine("Informe um número.");
            num = Convert.ToInt32(Console.ReadLine());

        for (primo = num; primo > 0; primo--)
        {
            if (num % primo == 0)
            {
                contador++;
            }
        }

        if (contador == 2)
        {
                Console.WriteLine("O número " + num + " é um número primo.");
        }
        else 
        {
                Console.WriteLine("Não é um número primo.");
        }



        }
    }
}
