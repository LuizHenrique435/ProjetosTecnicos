using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double Numero1, Numero2;
            string operacao;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("##############################");
            Console.WriteLine("####SUPER CALCULADORA 2020####");
            Console.WriteLine("##############################");
            Console.Beep();
            Console.Beep();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Por favor, informe primeiro a operação que você deseja fazer !!!");
            operacao =Console.ReadLine();
           

            Console.WriteLine("Agora informe dois números para realizarmos a operação !");
            Console.WriteLine("Informe o primeiro número da operação !");
            Numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Agora que já temos o primeiro número, informe o segundo !");
            Numero2 = Convert.ToDouble(Console.ReadLine());

            if (operacao == "adição") Console.WriteLine("O resultado é igual a : " + (Numero1 + Numero2));
           
            if (operacao == "subtração") Console.WriteLine("O resultado é igual a : " + (Numero1 - Numero2));
           
            if (operacao == "multiplicação") Console.WriteLine("O resultado é igual a : " + ((Numero1 * Numero2)));
           
            if (operacao == "divisão")
            {
                if (Numero2 == 0) Console.WriteLine("NÃO É POSSIVEL FAZER DIVISÃO POR 0 !!!");
                else
                {
                    Console.WriteLine("O valor é igual a : " + ((Numero1 / Numero2)));
                }
          
            }
           

            Console.ReadKey();

        }
    }
}
