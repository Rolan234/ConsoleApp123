using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[12];
            Console.WriteLine("Введите 12 элементов массива:");
            for (int i = 0; i < 12; i++)
            {
                array [i] = double.Parse(Console.ReadLine()); 
            }

            Array.Sort(arr, Comparer<double>.Create((x, y) => y.CompareTo(x)));

            Console.WriteLine("Массив, отсортированный в порядке убывания:");
            foreach (double element in arr)
            {
                Console.Write(element + " ");
            }

            double max = arr[0];
            double min = arr[arr.Length - 1];

            Console.WriteLine($"\nМаксимальный элемент: {max}");
            Console.WriteLine($"Минимальный элемент: {min}");
            Console.WriteLine($"Сумма максимального и минимального элементов: {max + min}");
        }
    }
}
