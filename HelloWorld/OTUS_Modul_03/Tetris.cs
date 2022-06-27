using System;
using System.Threading;

namespace OTUS_Modul_03
{
    class Tetris
    {
        static void Main()
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
                      
            FigureGenerator generator = new FigureGenerator(20, 0, 'Ы');
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
            }
        }
    }
}
