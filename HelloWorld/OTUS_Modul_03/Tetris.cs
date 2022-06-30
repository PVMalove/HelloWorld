using System;
using System.Threading;
using System.Timers;

namespace OTUS_Modul_03
{
    class Tetris
    {
        const int TIMER_INTERVL = 500;
        static System.Timers.Timer timer;

        private static Object _lockObject = new object(); 
        
        static Figure currentFigure;
        static FigureGenerator generator;
        static void Main()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(GameField.WindowWidth, GameField.WindowHeight);
            Console.SetBufferSize(GameField.WindowWidth, GameField.WindowHeight);
                                              
            generator = new FigureGenerator(GameField.WindowWidth/2, 0, CellsRenderer.DEFOULT_SYMBOL);
            currentFigure = generator.GetNewFigure();
            SetTimer();
            while (true)
            {
               if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Monitor.Enter(_lockObject);
                    ResultCollision resultHandleKey = HandleKey(currentFigure, key);
                    ProcessResult(resultHandleKey, ref currentFigure);
                    Monitor.Exit(_lockObject);
                }
            }
        }
                
        private static bool ProcessResult(ResultCollision resultHandleKey, ref Figure currentFigure)
        {
            if (resultHandleKey == ResultCollision.FigureCollision || resultHandleKey == ResultCollision.DownBorderCollision)
            {
                GameField.AddFigure(currentFigure);
                GameField.TryDeleteLines();
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

        private static void SetTimer()
        {
            timer = new System.Timers.Timer(TIMER_INTERVL);
            timer.Elapsed += OnTimerEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private static void OnTimerEvent(object sender, ElapsedEventArgs e)
        {
            Monitor.Enter(_lockObject);
            ResultCollision resultMove = currentFigure.TryMoveFigure(DirectionMovementFigure.Down);
            ProcessResult(resultMove, ref currentFigure);
            Monitor.Exit(_lockObject);
        }
    }
}
