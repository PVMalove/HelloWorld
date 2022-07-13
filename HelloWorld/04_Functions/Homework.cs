using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Functions
{
    class Homework
    {
        /* 
         * Задача 01:
         * Реализуйте метод Shuffle, который перемешивает элементы 
         * массива в случайном порядке.
         */
        public static void HomeWork01()
        {
            int[] array = new int[5];
            FillArray(array);
            Console.WriteLine("Исходный массив:");
            OutputArray(array);
            ShuffleArray(array);
            Console.WriteLine("\nПеремешанный массив:");
            OutputArray(array);
        }
        private static void FillArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10, 100);
            }
        }
        private static void OutputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        private static void ShuffleArray(int[] array)
        {
            Random rand = new Random();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int randomItem = rand.Next(i);
                int shuffledElement = array[randomItem];
                array[randomItem] = array[i];
                array[i] = shuffledElement;
            }
        }
    }
}
