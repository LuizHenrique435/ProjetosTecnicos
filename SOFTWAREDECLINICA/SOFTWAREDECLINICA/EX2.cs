using System;

namespace SOFTWAREDECLINICA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Horarios = new int[11] { 08, 09, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            int MenuInicio = 0;
            Boolean[] HrsLivres = new bool[11];

            int HorarioSelect = 0;
            int HorarioDelete = 0;


            Console.WriteLine("SOFTWARE DE CLINICA");
        Menu:
            Console.WriteLine("\n\n Temos os melhores horários para você das 08 as 18 hrs");
            Console.WriteLine("\n Qual o serviço que precisa ?");
            Console.WriteLine("\n1:ME MOSTRE OS HORÁRIOS DISPONÍVEIS;\n2:AGENDAR UM HORÁRIO;\n3:EXCLUIR AGENDAMENTOS ;");
            Console.WriteLine("\nInsira o numero correspondente a ação que você deseja realizar:");

            MenuInicio = Convert.ToInt32(Console.ReadLine());

            if (MenuInicio > 3 || MenuInicio < 1)
            {
                Console.WriteLine("Ação não correspondente, tente novamente...");
                goto Menu;
            }

            if (MenuInicio == 1)
            {
                for (int cont = 0; cont < 11; cont++)
                {

                    if (HrsLivres[cont] == false)
                    {
                        Console.WriteLine("\n" + Horarios[cont] + "h");
                    }
                }
                goto Menu;
            }

            if (MenuInicio == 2)
            {
                Console.WriteLine("Insira o horário desejado:");

                HorarioSelect = Convert.ToInt32(Console.ReadLine());
                for (int contador = 0; contador < 11; contador = contador + 1)
                {
                    if (HorarioSelect == Horarios[contador])
                    {

                        Console.WriteLine("HORÁRIO AGENDADO COM SUCESSO!");
                        Console.ReadLine();
                        HrsLivres[contador] = true;
                    }

                    if (HorarioSelect != Horarios[contador] && HrsLivres[contador] == false)
                    {
                        HrsLivres[contador] = false;
                    }

                }
                goto Menu;

            }

            if (MenuInicio == 3)
            {
                Console.WriteLine("Insira o horário que você deseja excluir:");
                HorarioDelete = Convert.ToInt32(Console.ReadLine());


                for (int contador2 = 0; contador2 < 11; contador2 = contador2 + 1)
                {
                    if (HorarioDelete == Horarios[contador2])
                    {

                        Console.WriteLine("HORÁRIO MARCADO EXCLUÍDO COM SUCESSO!");
                        HrsLivres[contador2] = false;
                    }

                    if (HorarioSelect != Horarios[contador2] && HrsLivres[contador2] == true)
                    {
                        HrsLivres[contador2] = true;
                    }

                }

                goto Menu;
            }

            Console.ReadLine();
        }
    }
}
        