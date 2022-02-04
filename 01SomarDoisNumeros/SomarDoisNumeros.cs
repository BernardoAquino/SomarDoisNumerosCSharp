using System;

namespace _01SomarDoisNumeros
{
    class SomarDoisNumeros
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;

            Console.WriteLine("Digite um número:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine("Soma: " + soma);
        }
    }
}
