using System;
using System.Threading;

namespace OTUS_Modul_03
{
    class Tetris
    {        
        public static int windowWidth = 40;
        public static int windowHeight = 30;
        static void Main()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(windowWidth, windowHeight);
            Console.SetBufferSize(windowWidth, windowHeight);
                      
            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figure currentFigure = generator.GetNewFigure();
            while (true)
            {
               if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    HandleKey(currentFigure, key);
                }
            }
        }

        private static void HandleKey(Figure currentFigure, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    currentFigure.MoveFigure(DirectinEnums.Left);
                    break;
                case ConsoleKey.RightArrow:
                    currentFigure.MoveFigure(DirectinEnums.Right);
                    break;
                case ConsoleKey.DownArrow:
                    currentFigure.MoveFigure(DirectinEnums.Down);
                    break;
                case ConsoleKey.Spacebar:
                    currentFigure.HideFigure();
                    currentFigure.RotateFigure();
                    currentFigure.DrawFigure();
                    break;
            }
        }
    }
}
