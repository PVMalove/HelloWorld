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
        /* 
         * Задача 02:
         * Написать функцию, которая запрашивает число у пользователя (с помощью метода Console.ReadLine())
         * и пытается сконвертировать его в тип int (с помощью int.TryParse())
         * Если конвертация не удалась у пользователя запрашивается число повторно 
         * до тех пор, пока не будет введено верно. 
         * После ввода, который удалось преобразовать в число, число возвращается.    
         */
        public static void HomeWork02()
        {
            InputUser();
        }
        private static void InputUser()
        {
            int number;
            while (true)
            {
                Console.Write("Введите число: ");
                string inputUser = Console.ReadLine();
                if (int.TryParse(inputUser, out number))
                {
                    Console.WriteLine($"\nВы ввели число: {number}");
                    break;
                }
                else
                    Console.WriteLine($"Вы ввели не число, Try again!");
                Console.Write("Press any key...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
