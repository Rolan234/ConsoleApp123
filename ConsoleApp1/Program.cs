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
            double[] arr = new double[14] { 2.8, 1.7, 3.4, 7.3, 6.3, 4.3, 5.1, 9.0, 8.4, 10.2, 12.5, 11.3, 13.2, 15.1 };
            for (int i = 0; i < 6; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < 7; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                double temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            for (int i = 7; i < 13; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < 14; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                double temp = arr[i];
                arr[i] = arr[maxIndex];
                arr[maxIndex] = temp;
            }
            for (int i = 0; i < 14; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            double min = arr[0];
            double max = arr[13];
            double sum = min + max;
            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Максимальный элемент: " + max);
            Console.WriteLine("Сумма максимального и минимального элементов: " + sum);
        }
    }
}
