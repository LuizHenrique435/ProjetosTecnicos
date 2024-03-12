using System;

namespace _10Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, maiorvalor;

            Console.WriteLine("Olá, Seja muito bem vindo");
         
            Console.WriteLine("Insira 10 números ");

            Console.WriteLine("Insira o 1º valor: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            maiorvalor = n1;

            Console.WriteLine("Insira o 2º valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            while (n2 > maiorvalor)
            {
                maiorvalor = n2;
            }

            Console.WriteLine("Insira o 3º valor: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            while (n3 > maiorvalor)
            {
                maiorvalor = n3;
            }

            Console.WriteLine("Insira o 4º valor: ");
            n4 = Convert.ToInt32(Console.ReadLine());
            while (n4 > maiorvalor)
            {
                maiorvalor = n4;
            }

            Console.WriteLine("Insira o 5º valor: ");
            n5 = Convert.ToInt32(Console.ReadLine());
            while (n5 > maiorvalor)
            {
                maiorvalor = n5;
            }

            Console.WriteLine("Insira o 6º valor: ");
            n6 = Convert.ToInt32(Console.ReadLine());
            while (n6 > maiorvalor)
            {
                maiorvalor = n6;
            }
            Console.WriteLine("Insira o 7º valor: ");
            n7 = Convert.ToInt32(Console.ReadLine());
            while (n7 > maiorvalor)
            {
                maiorvalor = n7;
            }
            Console.WriteLine("Insira o 8º valor: ");
            n8 = Convert.ToInt32(Console.ReadLine());
            while (n8 > maiorvalor)
            {
                maiorvalor = n8;
            }
            Console.WriteLine("Insira o 9º valor: ");
            n9 = Convert.ToInt32(Console.ReadLine());
            while (n9 > maiorvalor)
            {
                maiorvalor = n9;
            }
            Console.WriteLine("Insira o 10º valor: ");
            n10 = Convert.ToInt32(Console.ReadLine());
            while (n10 > maiorvalor)
            {
                maiorvalor = n10;
            }
            Console.WriteLine("O maior valor inserido é: " + maiorvalor);
        }
    }
}
