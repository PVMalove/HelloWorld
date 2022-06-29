using System;
using System.Threading;

namespace OTUS_Modul_03
{
    class Tetris
    {
        static FigureGenerator generator;
        static void Main()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(GameField.WindowWidth, GameField.WindowHeight);
            Console.SetBufferSize(GameField.WindowWidth, GameField.WindowHeight);
                                              
            generator = new FigureGenerator(GameField.WindowWidth/2, 0, 'Ы');
            Figure currentFigure = generator.GetNewFigure();
            while (true)
            {
               if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    ResultCollision resultHandleKey = HandleKey(currentFigure, key);
                    ProcessResult(resultHandleKey, ref currentFigure);
                }
            }
        }

        private static bool ProcessResult(ResultCollision resultHandleKey, ref Figure currentFigure)
        {
            if (resultHandleKey == ResultCollision.FigureCollision || resultHandleKey == ResultCollision.DownBorderCollision)
            {
                GameField.AddFigure(currentFigure);
                currentFigure = generator.GetNewFigure();
                return true;
            }
            else
                return false;
        }

        private static ResultCollision HandleKey(Figure currentFigure, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    return currentFigure.TryMoveFigure(DirectionMovementFigure.Left);                    
                case ConsoleKey.RightArrow:
                    return currentFigure.TryMoveFigure(DirectionMovementFigure.Right);
                case ConsoleKey.DownArrow:
                    return currentFigure.TryMoveFigure(DirectionMovementFigure.Down);
                case ConsoleKey.Spacebar:
                    return currentFigure.TryRotateFigure();
            }
            return ResultCollision.NoCollision;
        }
    }
}
