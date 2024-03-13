using System;

namespace Ex2ValorFinalEInicial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num2,num3,num4,num5,num6,num7,num8,num9,numI,numF, restoDaDiv2, restoDaDiv3, restoDaDiv4, restoDaDiv5, restoDaDiv6, restoDaDiv7, restoDaDiv8 ,restoDaDiv9;
           

            Console.WriteLine("Informe 10 números :");
            Console.WriteLine("Informe o primeiro !");
            numI = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o segundo número !");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o terceiro número !");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o quarto número !");
            num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o quinto número !");
            num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o sexto número !");
            num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o sétimo número !");
            num7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o oitavo número !");
            num8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o nono número !");
            num9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o décimo número !");
            numF = Convert.ToInt32(Console.ReadLine());


            restoDaDiv2 = num2 % 2; // Retorna o resto da Divisão por 2;
            restoDaDiv3 = num3 % 2; // Retorna o resto da Divisão por 2;
            restoDaDiv4 = num4 % 2; // Retorna o resto da Divisão por 2;
            restoDaDiv5 = num5 % 2; // Retorna o resto da Divisão por 2;
            restoDaDiv6 = num6 % 2; // Retorna o resto da Divisão por 2;
            restoDaDiv7 = num7 % 2; // Retorna o resto da Divisão por 2;
            restoDaDiv8 = num8 % 2; // Retorna o resto da Divisão por 2;
            restoDaDiv9 = num9 % 2; // Retorna o resto da Divisão por 2;

            if (restoDaDiv2 == 0) Console.WriteLine("O NÚMERO É PAR");
            if (restoDaDiv2 != 0) Console.WriteLine("O NÚMERO É ÍMPAR");
            if (restoDaDiv3 == 0) Console.WriteLine("O NÚMERO É PAR");
            if (restoDaDiv3 != 0) Console.WriteLine("O NÚMERO É ÍMPAR");
            if (restoDaDiv4 == 0) Console.WriteLine("O NÚMERO É PAR");
            if (restoDaDiv4 != 0) Console.WriteLine("O NÚMERO É ÍMPAR");
            if (restoDaDiv5 == 0) Console.WriteLine("O NÚMERO É PAR");
            if (restoDaDiv5 != 0) Console.WriteLine("O NÚMERO É ÍMPAR");
            if (restoDaDiv6 == 0) Console.WriteLine("O NÚMERO É PAR");
            if (restoDaDiv6 != 0) Console.WriteLine("O NÚMERO É ÍMPAR");
            if (restoDaDiv7 == 0) Console.WriteLine("O NÚMERO É PAR");
            if (restoDaDiv7 != 0) Console.WriteLine("O NÚMERO É ÍMPAR");
            if (restoDaDiv8 == 0) Console.WriteLine("O NÚMERO É PAR");
            if (restoDaDiv8 != 0) Console.WriteLine("O NÚMERO É ÍMPAR");
            if (restoDaDiv9 == 0) Console.WriteLine("O NÚMERO É PAR");
            if (restoDaDiv9 != 0) Console.WriteLine("O NÚMERO É ÍMPAR");

        }
    }
}
