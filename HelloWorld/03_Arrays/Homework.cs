using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays
{
    class Homework
    {
        /* 
         * Задача 01:
         * Дан массив целых чисел из 30 элементов.
         * Найдите все локальные максимумы и вывести их. 
         * (Элемент является локальным максимумом, если он не имеет соседей, больших, чем он сам)
         * Крайние элементы являются локальными максимумами если не имеют соседа большего, чем они сами.
         * Программа должна работать с массивом любого размера.
         * Массив всех локальных максимумов не нужен.
         */
        private static int _arraySize = 30;

        public static void HomeWork01()
        {
            Console.WriteLine($"Программа по поиску локальных максимумов в массиве их {_arraySize} элементов:\n");
            Random rand = new Random();
            int[] array = new int[_arraySize];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, _arraySize * 10);
            }
            if (array[0] > array[1])
                Console.WriteLine($"Первый элемент являются локальным максимумом - {array[0]}");
            if (array[array.Length - 1] > array[array.Length - 2])
                Console.WriteLine($"Последний элемент являются локальным максимумом - {array[array.Length - 1]}");
            Console.WriteLine($"\nСписок локальных максимумов:");
            for (int i = 1; i < _arraySize - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i] > array[i + 1])
                {
                    Console.WriteLine($"Элемент массива № {i}) - {array[i]}");
                }
            }
        }
    }
}
