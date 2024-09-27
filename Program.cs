using System;

namespace Fibonacci
{
    class Program
    {
        static bool PertenceFibonacci(int num)
        {
            int a = 0, b = 1;

            while (b < num)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }

            return b == num;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (PertenceFibonacci(numero))
            {
                Console.WriteLine("O numero " + numero + " pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine("O numero " + numero + " não pertence à sequência de Fibonacci.");

            }
        }
    }
}