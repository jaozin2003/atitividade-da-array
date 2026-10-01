using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperaturas_diarias
{//crie um algoritmo que armazene as temepraturas
 //diarias de uma cidade deurante uma semana
 //informe o dia mais quente e o mais frio
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperatura = new double[7];
            string[] dias = { "segunda   ", "terça   ", "quarta   ", "quinta     ", "sexta    ", "sabado   ", "domingo   " };
            double max = double.MinValue, min = double.MaxValue;
                int diamax = 0, diamin = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"temperatura de {dias[i]}: ");
                temperatura[i] = double.Parse( Console.ReadLine() );

                if (temperatura[i] > max) { max = temperatura[i]; diamax = i; }
                    if (temperatura[i] < min) { min = temperatura[i]; diamin = i; }

            }
            Console.WriteLine($"Dia mais quente: {dias[diamax]} ({max}) °C)");
            Console.WriteLine($"Dia mais frio: {dias[diamin]} ({min}) °C)");

            }




        
    }
}
