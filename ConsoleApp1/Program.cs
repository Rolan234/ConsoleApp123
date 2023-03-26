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
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(1, 81);
            }

            Console.WriteLine("Исходный массив:");
            PrintArray(array);
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < n; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
                else if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            Console.WriteLine($"Максимальный элемент: {array[maxIndex]}");
            Console.WriteLine($"Минимальный элемент: {array[minIndex]}");
            int temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;

            Console.WriteLine("Массив после обмена максимального и минимального элементов:");
            PrintArray(array);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
