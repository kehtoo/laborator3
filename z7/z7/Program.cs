using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static void Main()
        {
            Console.WriteLine("Введите n-ый номер ряда Фибоначчи: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"" + n + "-oe число:" + Fibonachi(n));
            Console.ReadKey();
        }
    }
}
