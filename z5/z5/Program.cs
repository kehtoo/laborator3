using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static double[,] umn(double[,] arr1, double[,] arr2, int a1, int b1, int b2)
        {
            double[,] Mass = new double[a1, a1];
            double sum = 0;
            for (int i = 0; i < a1; i++)
            {
                for (int j = 0; j < b2; j++)
                {
                    for (int r = 0; r < b1; r++)
                    {
                        sum = sum + arr1[i, r] * arr2[r, j];
                    }
                    Mass[i, j] = sum;
                    sum = 0;
                }
            }
            return Mass;

        }

        static void Main(string[] args)
        {
            int a = 5, b = 5, c = 5;
            double[,] mass1 = new double[a, b];
            double[,] mass2 = new double[b, c];
            Console.WriteLine("Arr1: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    mass1[i, j] = i + 1 + j;
                    Console.Write(mass1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nArr2: ");
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    mass2[i, j] = i + 1 + j;
                    Console.Write(mass2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nFinal arr:");
            double[,] Mass = umn(mass1, mass2, a, b, c);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(Mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
