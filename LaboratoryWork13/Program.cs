using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork13
{
    class Program
    {
        static int randArrEl;
        static void Main()
        {
            Random Random1 = new Random();
            int[] Array1 = new int[100];

            for (int i = 1; i < Array1.Length; i++)
            {
                Array1[i] = Random1.Next(1, 100);
            }

            randArrEl = Array1[Random1.Next(0, 99)];
            var count = 0;
            foreach (var el in Array1)
            {
                count += 1;
                if (el == randArrEl)
                {
                    break;
                }
            }

            Console.WriteLine("Количество итераций: {0}", count);

            QuickSort(ref Array1, Array1[0], Array1[99]);

            BinarySearch(Array1, Array1[49]);

            Console.ReadKey();
        }

        private static int BinarySearch(int[] arr, int val)
        {
            Array.Sort(arr);

            int right = arr.Length - 1;
            int left = 0;

            if (arr[left] > val) return -1;
            if (arr[right] < val) return -1;

            var count = 0;

            while (left < right)
            {
                count += 1;
                int mid = left + (right - left) / 2;
                if (val <= arr[mid]) right = mid;
                else if (val > arr[mid]) left = mid + 1;
                else return mid;
            }
            Console.WriteLine("Количество итераций: {0}", count);
            return -1;
        }

        static void QuickSort(ref int[] Array, int Left, int Right)
        {
            // i и j - индексы границ разделяемого массива
            int i = Left;
            int j = Right;
            // x - индекс опорного элемента
            int x = Array[(Left + Right) / 2];
            do
            {
                // Ищем элемент слева, который больше опорного
                while (Array[i] < x)
                    ++i;
                // Ищем элемент справа, который меньше опорного
                while (Array[j] > x)
                    --j;
                // Если индексы не поменялись местами, то обмениваем элементы
                if (i <= j)
                {
                    int t = Array[i];
                    Array[i] = Array[j];
                    Array[j] = t;
                    i++;
                    j--;
                }
            } while (i <= j);
            // Рекурсивно выполняем быструю сортировку для массивов слева и справа
            if (Left < j)
                QuickSort(ref Array, Left, j);
            if (i < Right)
                QuickSort(ref Array, i, Right);
        }
    }
}