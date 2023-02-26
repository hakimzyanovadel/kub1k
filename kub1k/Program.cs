using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace kub1k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в одномерном массиве");
            int n = int.Parse(Console.ReadLine());
            int k;
            Console.WriteLine("Введите число для поиска");
            k = int.Parse(Console.ReadLine());
            bool founded = false;
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(0, n);
                Console.Write(mas[i] + " "); ;
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (mas[i] == k)
                {
                    Console.WriteLine("Индекс k= " + i);
                    founded = true;
                    break;
                }
            }
            if (!founded)
            {
                Console.WriteLine("Результаты поиска плачевны");
            }
            for (int i = 0; i < n; i++)
            {
                for (int b = 0; b < n - 1; b++)
                {
                    int sort;
                    if (mas[b] > mas[b + 1])
                    {
                        sort = mas[b];
                        mas[b] = mas[b + 1];
                        mas[b + 1] = sort;
                    }
                }
            }
            for (int i=0;i<n;i++)
            {
                Console.Write(mas[i] + " ");
            }
        }
    }
}