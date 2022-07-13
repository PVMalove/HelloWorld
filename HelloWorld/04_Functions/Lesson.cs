using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Functions
{
    class Lesson
    {
        static void Main()
        {
            //FunctionsLesson01();
            //FunctionsWithReturnValuesLesson02();
            //TransferringDataToFunctionLesson03();
            //OverloadingLesson04();
            Homework.HomeWork01();
            Console.ReadKey();
        }

        static void FunctionsLesson01()
        {
            Console.WriteLine("Привет!");
            WriteError("Ошибка! Интернет соединение отсутствует.", str: " ^.^");
            Console.WriteLine("Проверка.");
            WriteError("Готово!", ConsoleColor.Green);
        }
        private static void WriteError(string text, ConsoleColor color = ConsoleColor.Red, string str = " ^.o")
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text + str);
            Console.ForegroundColor = defaultColor;
        }
        static void FunctionsWithReturnValuesLesson02()
        {
            Console.WriteLine($"Сумма: {Amount(10, 11)}");
        }
        private static int Amount(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        static void TransferringDataToFunctionLesson03()
        {
            int[] box = new int[3];
            box = EditArray(box, 2, 4);
            Console.WriteLine(box[2]);
        }
        private static int[] EditArray(int[] array, int index, int value)
        {
            array = new int[6];
            array[index] = value;
            return array;
        }
        static void OverloadingLesson04()
        {
            int[] bag = new int[4];
            int[,] box = new int[5, 5];
            bag = Resize(bag, 10);
            foreach (int arrey in bag)
            {
                Console.Write(arrey + " ");
            }
            Console.WriteLine("\n");
            box = Resize(box, 10, 10);
            for (int i = 0; i < box.GetLength(0); i++)
            {
                for (int j = 0; j < box.GetLength(1); j++)
                {
                    Console.Write(box[i, j]);
                }
                Console.WriteLine();
            }
        }
        private static int[] Resize(int[] array, int size)
        {
            int[] tempArrey = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                tempArrey[i] = array[i];
            }
            array = tempArrey;
            return array;
        }
        private static int[,] Resize(int[,] array, int x, int y)
        {
            int[,] tempArrey = new int[x, y];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    tempArrey[i, j] = array[i, j];
                }
            }
            array = tempArrey;
            return array;
        }
    }
}
