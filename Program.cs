using System;

namespace _Introdução_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1o Número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2o Número: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 + n2;

            Console.Write("O resultado de " + n1 + " + " + n2 + " é igual a " + resultado );
        }
    }
}
