using System;

namespace EX3NumOperacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, operacao,resultado;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Olá usuário, seja muito bem vindo !\n\n");
            Console.WriteLine("Aperte a tecla ENTER e digite 2 números !\n\n");
            Console.ReadLine();

        inicio:

            Console.WriteLine("Primeiro Número !");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo Número !");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Aperte ENTER !");
            Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("*************");
            Console.WriteLine("**OPERAÇÕES**");
            Console.WriteLine("*************");

            Console.WriteLine("1 ---- Média entre os Números !");
            Console.WriteLine("2 ----   Diferença entre os números !");
            Console.WriteLine("3 ---- Produto entre os números ");
            Console.WriteLine("4 ---- Divisão do primeiro número pelo segundo !\n\n");
            Console.WriteLine("ENTER");
            Console.ReadLine();


            Console.WriteLine("Agora Informe A Operação Que Será Realizada No Sistema !");
            operacao = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    Console.WriteLine("A Média É De : " + (n1 + n2) /2);
                break;
                case 2:
                    Console.WriteLine("A Diferença Entre os Números é De : " + (n1 - n2));
                break;
                case 3:
                    Console.WriteLine("O Produto Entre : " + n1 + " E " + n2 + " É Igual A : " + (n1 * n2));
                    break;
                case 4:
                    Console.WriteLine("O Resultado Entre : " + n1 + " e : " + n2 + " É Igual A : " + (n1/n2));
                break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("OPERAÇÃO NÃO ENCONTRADA !");
                break;
            }

            Console.WriteLine("Deseja Fazer Outra Operação ? (s/n)");
            if (Console.ReadLine() == "s") goto inicio;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Obrigado por Jogar ! Tchau Brigado !!");

        }
    }
}
