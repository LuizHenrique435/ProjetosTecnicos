using System;

namespace Atividade2_OrderDosNúmeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4aux = 0;

            Console.ForegroundColor = ConsoleColor.White;

            Console.Beep();

            Console.WriteLine("Olá usuário, informe o primeiro número !");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Beep();

            Console.WriteLine("Por favor, informe o segundo número !");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Beep();

            Console.WriteLine("Agora finalmente, informe o último número !");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.Beep();

            if(n1 > n2)
            {
                n4aux = n1;
                n1 = n2;
                n2 = n4aux;
            }

            if (n1 > n3)
            {
                n4aux = n1;
                n1 = n3;
                n3 = n4aux;
            }
            if (n2 > n3)
            {
                n4aux = n2;
                n2 = n3;
                n3 = n4aux;
            }

            Console.WriteLine("Então, a ordem dos números em ordem crescente é: " + n1 + " , " + n2 + " , " + n3);

            Console.Beep();
            Console.ReadKey();
        }
    }
}
