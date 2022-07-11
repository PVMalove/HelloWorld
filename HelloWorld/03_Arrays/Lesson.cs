using System;

namespace _03_Arrays
{
    class Lesson
    {
        static void Main()
        {
            //ArraysLesson01();
            //ArraysPractice01();
            //ArraysPractice02();
            //ArraysPractice03();
            //Homework.HomeWork01();
            //TwoDimensionalArrayLesson01();
            //TwoDimensionalArrayLesson02();
            //TwoDimensionalArrayLesson03();
            //Homework.HomeWork02();

            Console.ReadKey();
        }

        static void ArraysLesson01()
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void ArraysPractice01()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
        static void ArraysPractice02()
        {
            int[] array = { 1, 7, 3, 4, 5 };
            int maxElement = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxElement < array[i])
                    maxElement = array[i];
            }
            Console.WriteLine(maxElement);
        }
        static void ArraysPractice03()
        {
            bool isOpen = true;
            int[] tables = { 5, 6, 8, 9, 1, 5, 3, 4 };

            while (isOpen)
            {
                Console.SetCursorPosition(0, 14);
                Console.WriteLine("Наличие мест для бронирования:");
                for (int i = 0; i < tables.Length; i++)
                {
                    Console.WriteLine($"За столом {i + 1} свободно {tables[i]} мест");
                }
                Console.SetCursorPosition(4, 0);
                Console.WriteLine("Администрирование кафе.");
                Console.WriteLine("\n1 - Забронировать столик.\n2 - Выход из программы.");
                Console.Write("\nВведите номер команды: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userTable, userPlace;
                        Console.Write("Столик для бронирования: ");
                        userTable = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (tables.Length <= userTable || userTable < 0)
                        {
                            Console.WriteLine("Такого стала нет!");
                            break;
                        }
                        Console.Write("Количество мест для бронирования: ");
                        userPlace = Convert.ToInt32(Console.ReadLine());
                        if (tables[userTable] < userPlace)
                        {
                            Console.WriteLine("Не достаточно мест!");
                            break;
                        }
                        else if (userPlace <= 0)
                        {
                            Console.WriteLine("Не коректное значение!");
                            break;
                        }
                        tables[userTable] -= userPlace;
                        Console.WriteLine("Забронировано!");
                        break;
                    case 2:
                        isOpen = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void TwoDimensionalArrayLesson01()

        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void TwoDimensionalArrayLesson02()
        {
            int[,] array = new int[6, 6];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(0, 2);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void TwoDimensionalArrayLesson03()
        {
            int rows;
            int cols;
            string author;
            bool isOpen = true;
            bool authorIsFind = false;
            string[,] books = {
                { "Пушкин","Лермотов","Достаевский" },
                { "Стивен Кинг","Говард Лавкрафт","Чак Паланик" },
                { "Донцова","Алена Карр","Игорь Прокопенко" } };
            while (isOpen)
            {
                Console.WriteLine("Библеотека.");
                Console.WriteLine("\n 1 - Найти книгу по индексу.\n 2 - Найти книгу по автору. \n 3 - Вывести все книги. \n 4 - Выход.\n");
                Console.Write("Введите номер команды: ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.Write("Введите номер полки: ");
                        rows = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("Введите номер книги: ");
                        cols = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("\n Это книга - " + books[rows, cols] + "\n");
                        break;
                    case 2:
                        Console.Write("Введите нужного автора: ");
                        author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i, j].ToLower())
                                {
                                    Console.Write("Автор - " + books[i, j] + ", находится на полке: " + (i + 1) + "\n");
                                    authorIsFind = true;
                                }
                            }
                        }
                        if (!authorIsFind)
                            Console.WriteLine("Такого автора нет!");
                        break;
                    case 3:
                        Console.WriteLine("Список авторов: ");
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                Console.WriteLine(books[i, j]);
                            }
                        }
                        break;
                    case 4:
                        isOpen = false;
                        break;
                }
                Console.Write("Нажмите любую клавищу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }


        }
    }
}
