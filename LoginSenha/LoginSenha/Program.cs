using System;

namespace LoginSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario, senha;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔═════════════════════════════════════════════════════╗");
            Console.WriteLine("║░░░░░░░░░░░░░  MEGA LOGIN DAS GALÁXIAS ░░░░░░░░░░░░░░║ ");
            Console.WriteLine("╚═════════════════════════════════════════════════════╝\n\n");

            Console.WriteLine("informe o usuário !");
            usuario = Console.ReadLine();

            Console.WriteLine("informe a senha !");
            senha = Console.ReadLine();

            if (usuario == "sergio")
            {
                if (senha == "etec")
                {
                    Console.WriteLine("Bem Vindo Usuário Sergio !");
                }
                else
                {
                    Console.WriteLine("usuário desconhecido !");
                }
            }
            else
            {
                Console.WriteLine("usuário desconhecido !");
            }

            Console.ReadKey();

        }
    }
}
