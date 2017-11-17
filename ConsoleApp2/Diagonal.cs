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
            int mat, suma = 0;

            Console.WriteLine("Tamaño deseado para la Matriz:");
            mat = int.Parse(Console.ReadLine());
            int[,] val = new int[mat, mat];
            Console.WriteLine("Llenando");
            Console.WriteLine("--------------------------------------------------");

            for (int r = 0; r < mat; r++)
            {
                for (int c = 0; c < mat; c++)
                {
                    Console.WriteLine($"Cual es el valor de [{r},{c}]");
                    val[r, c] = int.Parse(Console.ReadLine());

                    if (r == c)
                    {
                        suma += val[r, c];
                    }

                }
            }

            Console.WriteLine("Hemos terminado");
            Console.WriteLine("-----------------");
            Console.WriteLine("La Matriz queda de la sigiente manera: ");
            for(int m=0; m<mat ;m++ )
            {
                Console.Write("[");
                for (int n=0;n<mat ;n++ )
                {
                    Console.Write("{0}",val[m,n]);  
                }
                Console.WriteLine("]");
            }
            Console.WriteLine("La Suma De Su Diagonal es: {0}", suma);

            Console.ReadKey();
        }
    }
}
