using System;

namespace Intervalo10e20
{
    class Program
    {
        static void Main(string[] args)
        {
          int Numrecebido = 0;
            string Lista10e20 = " ";
            string ListaFora = " ";
            int contDentro = 0;
            int contFora = 0;

        Console.WriteLine("Intervalo entre 10 e 20 !!!!!");

            for (int contador = 0; contador <= 10; contador = contador+1)
            {

              Console.WriteLine("Informe dez números:");
              Numrecebido = Convert.ToInt32(Console.ReadLine());

                if (Numrecebido >= 10 && Numrecebido <= 20 ) 
                {
                    Lista10e20 = Lista10e20 + " " + Numrecebido;
                    contDentro++;
                }
                else 
                {
                    ListaFora = ListaFora + " " + Numrecebido;
                    contFora++;
                }

            }

            Console.WriteLine("Números entre 10 e 20 são : " + Lista10e20 + " a quantidade é igual a : " + contDentro + " números ");
            Console.WriteLine("Números fora do intervalo são " + ListaFora + " a quantidade é igual a : " + contFora + " números ");
        }
        }
    }

