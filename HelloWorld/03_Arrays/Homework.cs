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
        /* 
         * Задача 02:
         * Найти наибольший элемент матрицы A(10,10) и записать ноль в ту ячейку, где он находится.
         * Вывести наибольший элемент, исходную и полученную матрицу.
         * Массив под измененную версию не нужен.
         */
        private static int _valueMax;
        public static void HomeWork02()
        {
            int[,] array = new int[10, 10];
            Random rand = new Random();
            Console.WriteLine("Исходная матрица: \n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10, 100);
                    Console.Write(array[i, j] + " ");
                    if (_valueMax < array[i, j])
                        _valueMax = array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nНаибольший элемент матрицы: {_valueMax}\n");
            Console.WriteLine("Измененая матрица: \n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == _valueMax)
                    {
                        array[i, j] = 0;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        /* 
         * Задача 03:
         * Дан двумерный массив.
         * Вычислить сумму второй строки и произведение первого 
         * столбца. Вывести исходную матрицу и результаты вычислений.
         */
        private static int _lineSecondSum;
        private static int _columnFirstMultiplication = 1;
        public static void HomeWork03()
        {
            int[,] array = new int[10, 10];
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1, 3);
                    Console.Write(array[i, j] + " ");
                    if (i == 1)
                        _lineSecondSum += array[i, j];
                    if (j == 0)
                        _columnFirstMultiplication *= array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nСумма второй стороки: {_lineSecondSum}");
            Console.WriteLine($"Произведение первого столбца: {_columnFirstMultiplication}");
        }
    }
}
