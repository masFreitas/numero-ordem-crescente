using System;

namespace NumerosOrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {

            //4) Faça um programa que leia 5 números inteiros e após escreva os números em ordem crescente.


            int[] numeros = new int[5];

            int i;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe 5 numeros");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 5; i++)
            {
                Array.Sort(numeros);
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
