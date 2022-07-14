using System;
using System.Collections.Generic;
using System.IO;
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
            //Homework.HomeWork01();
            //Homework.HomeWork02();
            //Homework.HomeWork03();
            FunctionsGamePacManLesson05();
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

        static void FunctionsGamePacManLesson05()
        {
            Console.CursorVisible = false;
            Random rand = new Random();
            bool isPlaing = true;
            bool isLive = true;
            int packmanX, packmanY;
            int packmanDX = 0, packmanDY = 1;
            int ghostX, ghostY;
            int ghostDX = 0, ghostDY = -1;
            int allDots = 0, collectDots = 0;
            char[,] level = ReadMap("Level_01", out packmanX, out packmanY, out ghostX, out ghostY, ref allDots);
            DrawMap(level);
            while (isPlaing)
            {
                Console.SetCursorPosition(0, 12);
                Console.WriteLine($"Собрано: {collectDots}/{allDots}");
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    ChangeDirection(key, ref packmanDX, ref packmanDY);
                }
                if (level[packmanX + packmanDX, packmanY + packmanDY] != '#')
                {
                    CollectDots(level, ref packmanX, ref packmanY, ref collectDots);
                    Move(level, '<', '>', ref packmanX, ref packmanY, packmanDX, packmanDY);
                }
                if (level[ghostX + ghostDX, ghostY + ghostDY] != '#')
                {
                    Move(level, '@', '@', ref ghostX, ref ghostY, ghostDX, ghostDY);
                }
                else
                {
                    ChangeDirection(rand, ref ghostDX, ref ghostDY);
                }
                if (ghostX == packmanX && ghostY == packmanY)
                {
                    isLive = false;
                }
                System.Threading.Thread.Sleep(5);
                if (collectDots == allDots || !isLive)
                {
                    isPlaing = false;
                }
            }
            if (collectDots == allDots)
            {
                Console.Clear();
                Console.SetCursorPosition(5, 4);
                Console.WriteLine("Вы победили!");
            }
            else if (!isLive)
            {
                Console.Clear();
                Console.SetCursorPosition(5, 4);
                Console.WriteLine("Вы проиграли!");
            }

        }
        private static void ChangeDirection(ConsoleKeyInfo key, ref int DX, ref int DY)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    DX = 0; DY = -1;
                    break;
                case ConsoleKey.UpArrow:
                    DX = -1; DY = 0;
                    break;
                case ConsoleKey.RightArrow:
                    DX = 0; DY = 1;
                    break;
                case ConsoleKey.DownArrow:
                    DX = 1; DY = 0;
                    break;
            }
        }
        private static void ChangeDirection(Random random, ref int DX, ref int DY)
        {
            int ghostDir = random.Next(1, 5);
            switch (ghostDir)
            {
                case 3:
                    DX = 0; DY = -1;
                    break;
                case 1:
                    DX = -1; DY = 0;
                    break;
                case 4:
                    DX = 0; DY = 1;
                    break;
                case 2:
                    DX = 1; DY = 0;
                    break;
            }
        }
        private static void Move(char[,] level, char symbol, char sym, ref int X, ref int Y, int DX, int DY)
        {
            Console.SetCursorPosition(Y, X);
            Console.Write(level[X, Y]);
            X += DX;
            Y += DY;
            Console.SetCursorPosition(Y, X);
            if (DY < 0)
                Console.Write(symbol);
            else
                Console.Write(sym);
        }
        private static void CollectDots(char[,] level, ref int x, ref int y, ref int collectDots)
        {
            if (level[x, y] == '.')
            {
                collectDots++;
                level[x, y] = ' ';
            }
        }
        private static void DrawMap(char[,] level)
        {
            for (int i = 0; i < level.GetLength(0); i++)
            {
                for (int j = 0; j < level.GetLength(1); j++)
                {
                    Console.Write(level[i, j]);
                }
                Console.WriteLine();
            }
        }
        private static char[,] ReadMap(string levelName, out int packmanX, out int packmanY, out int ghostX, out int ghostY, ref int allDots)
        {
            packmanX = 0;
            packmanY = 0;
            ghostX = 0;
            ghostY = 0;
            string[] newFile = File.ReadAllLines($"Maps/{levelName}.txt");
            char[,] level = new char[newFile.Length, newFile[0].Length];
            for (int i = 0; i < level.GetLength(0); i++)
            {
                for (int j = 0; j < level.GetLength(1); j++)
                {
                    level[i, j] = newFile[i][j];
                    if (level[i, j] == '<')
                    {
                        packmanX = i;
                        packmanY = j;
                        level[i, j] = '.';
                    }
                    else if (level[i, j] == '$')
                    {
                        ghostX = i;
                        ghostY = j;
                        level[i, j] = '.';
                    }
                    else if (level[i, j] == ' ')
                    {
                        level[i, j] = '.';
                        allDots++;
                    }
                }
            }
            return level;
        }
    }
}
