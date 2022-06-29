using System;
using System.Threading;

namespace OTUS_Modul_03
{
    class Tetris
    {                
        static void Main()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(GameField.WindowWidth, GameField.WindowHeight);
            Console.SetBufferSize(GameField.WindowWidth, GameField.WindowHeight);
                                              
            FigureGenerator generator = new FigureGenerator(GameField.WindowWidth/2, 0, 'Ы');
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
                    currentFigure.TryMoveFigure(DirectinEnums.Left);
                    break;
                case ConsoleKey.RightArrow:
                    currentFigure.TryMoveFigure(DirectinEnums.Right);
                    break;
                case ConsoleKey.DownArrow:
                    currentFigure.TryMoveFigure(DirectinEnums.Down);
                    break;
                case ConsoleKey.Spacebar:
                    currentFigure.TryRotateFigure();
                    break;
            }
        }
    }
}
