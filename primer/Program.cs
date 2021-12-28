using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            try
            {
                Console.WriteLine("Программа работает с числами! \nПожалуйста введите число.");
                Random ran = new Random();
                Console.Write("Введите кол-во элементов массива: ");
                int value = int.Parse(Console.ReadLine());


                int[] mas = new int[value];
                Console.WriteLine("массив: ");
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = ran.Next(-30, 45);
                }

                for (int i = 0; i < mas.Length; i++)
                {
                    if (i % 10 == 0)
                    {
                        Console.WriteLine("\n");
                    }
                    Console.Write(mas[i] + "\t");
                }
                Console.WriteLine("\nЭлементы массива в обратном направлении без отрицательных чисел: ");
                Array.Reverse(mas);
                int count = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] >= 0)
                    {
                        if (count % 10 == 0)
                        {
                            Console.WriteLine("\n");
                        }
                        Console.Write(mas[i] + "\t");
                        count++;
                    }



                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Вы ввели не число!");
            }

            //Задание 2

            /*int[,] mas = new int[7, 7];
            Random ran = new Random();
            //ввод массива рандомными числами и его вывод
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    mas[i, j] = ran.Next(100);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            //поворот массива 
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < Math.Floor(Convert.ToDouble(7) / 2); i++)
                {
                    for (int j = 0; j < Math.Ceiling(Convert.ToDouble(7) / 2); j++)
                    {
                        int rotate = mas[i, j];
                        mas[i, j] = mas[j, 7 - 1 - i];
                        mas[j, 7 - 1 - i] = mas[7 - 1 - i, 7 - 1 - j];
                        mas[7 - 1 - i, 7 - 1 - j] = mas[7 - 1 - j, i];
                        mas[7 - 1 - j, i] = rotate;
                    }
                }
            }
            //вывод повернутого массива
            Console.WriteLine("Повернутый массив:");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
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
