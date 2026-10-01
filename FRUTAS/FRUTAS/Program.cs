using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRUTAS
{/*implemente um sistema que armazene as quantidades
   de 5 tipos de fritas em 3 cestas e calcule o total de 
   frutas de cada tipo
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] frutas = new int[5, 3];
            string[] tipos = { "Maçã", "Banana", "Laranja", "Uva", "Pera" };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\n{tipos[i]}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Cesta {j + 1}:");
                   frutas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nTotal de Cada Fruta:");
            for (int i = 0; i < 5; i++)
            {
                int total = frutas[i, 0] + frutas[i, 1] + frutas[i, 2];
                Console.WriteLine($"{tipos[i]}: {total}");
            }

        }
    }
}


