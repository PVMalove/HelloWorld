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
        /* 
         * Задача 03:
         * Разработайте функцию, которая рисует некий бар(Healthbar, Manabar)
         * в определённой позиции. Она также принимает некий закрашенный процент.
         * При 40% бар выглядит так:
         * [####_____]
         */
        private static double _health = 1;
        private static int _lengthBar = 10;
        private static double _mana = 1;
        public static void HomeWork03()
        {
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Введите процент текущего здоровья: ");
                _health = double.Parse(Console.ReadLine());
                Console.Write("Введите процент текущего количества мана: ");
                _mana = double.Parse(Console.ReadLine());
                DrawBar(_health, _lengthBar, ConsoleColor.Red, 2, "Healthbar");
                DrawBar(_mana, _lengthBar, ConsoleColor.Blue, 3, "Manabar");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private static void DrawBar(double value, int lengthBar, ConsoleColor color, int position, string text)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            if (value >= 0 && value <= 100)
            {
                int currentValue = (int)Math.Round(lengthBar * (value / 100));
                string bar = "";
                for (int i = 0; i < currentValue; i++)
                {
                    bar += "#";
                }
                Console.SetCursorPosition(0, position);
                Console.Write('[');
                Console.BackgroundColor = color;
                Console.Write(bar);
                Console.BackgroundColor = defaultColor;
                bar = "";
                for (int i = currentValue; i < lengthBar; i++)
                {
                    bar += "_";
                }
                Console.Write(bar + ']');
                Console.Write(" "+ text);
            }
        }            
    }
}
