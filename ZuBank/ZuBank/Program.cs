using System;

namespace ZuBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string correntista;
            int mesesInvestidos;
            double valorInvestido;
            double valorTotal;

            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine("===============");
            Console.WriteLine("====ZUBANK=====");
            Console.WriteLine("===============");

            Console.WriteLine("Olá, bom dia, bem vindo ao ZuBank");
            Console.WriteLine("Por favor, informe o nome do correntista !!");
            correntista = Console.ReadLine();

            Console.WriteLine("Olá Sr." + correntista + "por favor informe o total de meses que serão investidos !!");
            mesesInvestidos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Então Sr" + correntista + "o lucro por cada mes investido será de 0,03");
            Console.WriteLine("Por favor, informe o valor que será investido !!");
            valorInvestido = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O lucro será de :" + (valorTotal = (1 + 0.03) * mesesInvestidos * valorInvestido));

        }
    }
}
