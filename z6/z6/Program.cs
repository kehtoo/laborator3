using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine(sumIterative(array));
            Console.WriteLine(sumRecursive(array));
            Console.WriteLine(minRecursive(array, array.Length));
            Console.WriteLine(minIterative(array));
            Console.ReadKey();
        }

        static int sumIterative(int[] array)
        {
            int sum = default;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            return sum;
        }

        static int sumRecursive(int[] array, int i = 0) => i == array.Length - 1 ? array[i] : array[i] + sumRecursive(array, ++i);
        static int minRecursive(int[] a, int n)
        {
            if (n == 1)
            {
                return a[0];
            }
            var newAr = new int[n - 1];
            Array.Copy(a, 1, newAr, 0, n - 1);
            var min = Math.Min(a[0], a[1]);
            newAr[0] = min;
            return minRecursive(newAr, n - 1);
        }
        static int minIterative(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
    }
}
