using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tama, suma = 0;

            Console.WriteLine("De que tamaño deseas generar la matriz:");
            tama = int.Parse(Console.ReadLine());
            int[,] alum = new int[tama, tama];
            Console.WriteLine("Empezemos el Llenado");
            Console.WriteLine("--------------------------------------------------");

            for (int i = 0; i < tama; i++)
            {
                for (int j = 0; j < tama; j++)
                {
                    Console.WriteLine($"Cual es el valor de {i}-{j}");
                    alum[i, j] = int.Parse(Console.ReadLine());

                    if (i == j)
                    {
                        suma += alum[i, j];
                    }

                }
            }

            Console.WriteLine("Llenado Finalizado");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("La Suma De Su Diagonal es: {0}", suma);

            Console.ReadKey();
        }
    }
}
