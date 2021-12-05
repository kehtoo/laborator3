using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            int n = 0;
            Console.Write("Enter number of elements: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Random rand = new Random();

            Console.WriteLine("Ur array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-30, 45);
                Console.Write(arr[i] + "\t");
                if (i % 10 == 0 && i != 0) { Console.WriteLine(); }
            }
            Console.WriteLine("\nNew array:");
            int count = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] >= 0) { Console.Write(arr[i] + "\t"); count++; }
                if (i % 10 == 0 && i != 0) { Console.WriteLine(); }
            }

            Console.ReadKey();

            //Задание 2

            /*int m = 7;
            int n = 7;

            int[,] arr = new int[m, n];

            int count = 1;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    arr[i, j] = count++;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(arr[i, j] + "\t");
                Console.WriteLine();
            }

            Console.WriteLine("\nПеревернутый массив: ");
            for (int j = 0; j < n; j++)
            {
                for (int i = m - 1; i >= 0; i--)

                    Console.Write(arr[i, j] + "\t");
                Console.WriteLine();
            }

            Console.ReadKey();*/

            //Задание 3

            /*int[] arr = { 0, 1, 2, 3, 4, 5 };
            int k = 0;
            Console.Write("Введите k: ");
            k = int.Parse(Console.ReadLine());
            int tmp;
            int nextInd = 0;

            Console.WriteLine(string.Join(" ", arr));

            for (int i = 0; i < arr.Length - 1; ++i)
            {
                nextInd += k;
                nextInd %= arr.Length;
                tmp = arr[nextInd];
                arr[nextInd] = arr[0];
                arr[0] = tmp;
            }

            Console.WriteLine(string.Join(" ", arr));

            Console.ReadKey();*/

            //Задание 4

            /*static double[,] f1(double[,] Ar1, double[,] Ar2, out double Avg)    //Функция Суммы:
            {
                double[,] f1 = new double[3, 3];
                Avg = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        f1[i, j] = Ar1[i, j] + Ar2[i, j];
                        Avg += f1[i, j];
                    }
                }
                Avg = Avg / 9;

                return f1;
            }
            static double[,] f2(double[,] Ar1, double[,] Ar2, out double Avg)    //Функция Разности:
            {
                double[,] f2 = new double[3, 3];
                Avg = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        f2[i, j] = Ar1[i, j] - Ar2[i, j];
                        Avg += Ar1[i, j] + Ar2[i, j];
                    }
                }
                Avg = Avg / 9;
                return f2;
            }
            double[,] Ar1 = new double[3, 3];
            double[,] Ar2 = new double[3, 3];
            Console.WriteLine("Введите значение для первого массива:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    while (!double.TryParse(Console.ReadLine(), out Ar1[i, j])) ;
                }
            }
            Console.WriteLine("Введите значения для второго массива:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    while (!double.TryParse(Console.ReadLine(), out Ar2[i, j])) ;
                }
            }
            double Avg;
            int x = 0;
            Console.WriteLine("Сумма Массивов:");
            foreach (double H in f1(Ar1, Ar2, out Avg))
            {
                if (x % 3 == 0)
                {
                    Console.Write("\n");
                    Console.Write($"{H,4}");
                }
                else
                {
                    Console.Write($"{H,4}");
                }
                x++;
            }*/
        }
    }
}
