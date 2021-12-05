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
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(-10, 10);
            }
            int count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) > 5) { count++; }
                }
                //Console.WriteLine("Count:" + count);
            }
            Console.WriteLine("Ur arr:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine("\nCount:" + count);
            Console.ReadKey();
        }
    }
}
