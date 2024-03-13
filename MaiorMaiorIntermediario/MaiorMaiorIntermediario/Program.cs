using System;

namespace MaiorMaiorIntermediario
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, maior = 0, menor = 0, intermediario = 0;


            Console.WriteLine("Informe um número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe um número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe um número: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3) maior = n1;
            if (n2 > n1 && n2 > n3) maior = n2;
            if (n3 > n1 && n3 > n2) maior = n3;
            Console.WriteLine("Maior: " + maior);

            if (n1 < n2 && n1 < n3) menor = n1;
            if (n2 < n1 && n2 < n3) menor = n2;
            if (n3 < n1 && n3 < n2) menor = n3;
            Console.WriteLine("Menor: " + menor);

            if (maior == n1 & menor == n2) intermediario = n3;
            if (maior == n1 & menor == n3) intermediario = n2;
            if (maior == n2 & menor == n1) intermediario = n3;
            if (maior == n2 & menor == n3) intermediario = n1;
            if (maior == n3 & menor == n1) intermediario = n2;
            if (maior == n3 & menor == n2) intermediario = n1;
            Console.WriteLine("Intermediário: " + intermediario);
        }
    }
}
