using System;

namespace EX1Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, numFibonacci = 1;

            Console.WriteLine("FIBONACCI");

            while (numFibonacci <= 4181)
            {
                Console.WriteLine("num : " + num + " numFibonacci : " + numFibonacci);


                num = num + numFibonacci;
                numFibonacci = numFibonacci + num;
            }


        }
    }
}
