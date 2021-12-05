using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int m = n / 2 + n % 2,
                len = n,
                count = 1;
            Console.WriteLine("Матрица " + n + " на " + n);
            for (int i = 0; i < m; i++)
            {
                // Верх
                for (int j = 0; j < len; j++) matrix[i, i + j] = count++;
                // Право
                for (int j = 1; j < len; j++) matrix[i + j, n - i - 1] = count++;
                len -= 2;
                // Низ
                for (int j = len; j >= 0; j--) matrix[n - i - 1, i + j] = count++;
                // Лево
                for (int j = len; j >= 1; j--) matrix[i + j, i] = count++;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
