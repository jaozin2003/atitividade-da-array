using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_impares_pares
{ // crie um programa que armazene 20 numeros e separe-os em
  // dois arrays: um com numeros
  // pares e outro com numeros impares
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            int[] pares = new int[20];
            int[] impares = new int[20];
            int p = 0, i = 0;

            for (int j = 0; j < 20; j++)

            {
                Console.Write($"Digite o número {j + 1}: ");
                numeros[j] = int.Parse(Console.ReadLine());

                if (numeros[j] % 2 == 0)
                    pares[p++] = numeros[j];
                else impares[i++] = numeros[j];

            }
            Console.WriteLine("\nPares: ");
            for (int j = 0; j < p; j++) Console.Write(pares[j] + " ");

            Console.WriteLine("\nImpares:");
            for (int j = 0; j < i; j++) Console.Write(impares[j] + " ");


        }
    }
}
