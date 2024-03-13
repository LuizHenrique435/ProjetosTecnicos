using System;

namespace BancoDoBrasileiro
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCorrentista;
            int NumeroConta;
            double Saldo = 0;
            string operacao;
            double valor;

            Console.Beep();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
          
            Console.WriteLine("///////////////////////////");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("////BANCO DO BRASILEIRO////");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("///////////////////////////");

            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine("Olá Sr.Correntista, por favor informe seu nome !");
            nomeCorrentista = Console.ReadLine();

            Console.WriteLine("Agora Sr  " + nomeCorrentista + " Informe o número da sua conta !(5 digítos)");
            NumeroConta = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Bom Sr " + nomeCorrentista + " o número da sua conta é : " + NumeroConta + " e o seu saldo é igual a : " + Saldo);
            Console.Beep();
            Console.WriteLine("////////////////////////////////////////////////");

            Console.WriteLine("informe por favor um valor que o Sr deseja sacar ou depositar na sua conta !");
            valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("///////////////////////////////////////////////");

            Console.WriteLine("Tudo certo, agora com todos os dados corretos, informe qual a operação que o Sr deseja fazer !");
            operacao = Console.ReadLine();


            if (operacao == "sacar") Console.WriteLine("O saldo atual é igual a : " + (Saldo - valor));
          
            if (operacao == "depositar") Console.WriteLine("O saldo atual é igual a : " + (Saldo + valor));


            Console.ReadKey();
        }
    }
}
