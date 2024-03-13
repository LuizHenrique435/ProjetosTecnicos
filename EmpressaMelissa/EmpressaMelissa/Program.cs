using System;

namespace EmpressaMelissa
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeFuncionario, departamentoFunci;
            double salarioAtual, salarioNovo;
            
            Console.WriteLine("*********************************");
            Console.WriteLine("*****SUPER CALCULADOORA 2020*****");
            Console.WriteLine("*********************************");

            Console.WriteLine("Olá ! informe o nome do funcionario (a) !");
            nomeFuncionario = Console.ReadLine();

            Console.WriteLine("Muito bem ! Agora informe o departamento do(a) " + nomeFuncionario + ":");
            departamentoFunci = Console.ReadLine();

            Console.WriteLine("Informe o salário atual do(a)" + nomeFuncionario);
            salarioAtual = Convert.ToDouble(Console.ReadLine());

            if (salarioAtual < 2000)
            {
                salarioNovo = salarioAtual * 1.10; // 10%
            }
            else
            {
                salarioNovo = salarioAtual * 1.05; // 5%
            }
            Console.WriteLine("O novo salário é de: R$ " + salarioNovo);
            Console.WriteLine("O aumento foi de R$ " + (salarioNovo - salarioAtual));
            Console.ReadKey(); // Visual Studio;
        }
    }
}
