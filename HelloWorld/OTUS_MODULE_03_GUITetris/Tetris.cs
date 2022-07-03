using System;
using System.Threading;
using System.Timers;
using Microsoft.SmallBasic.Library;

namespace OTUS_Modul_03
{
    class Tetris
    {
        const int TIMER_INTERVL = 500;
        static System.Timers.Timer timer;
        static bool gameOver = false;

        private static Object _lockObject = new object(); 
        
        static Figure currentFigure;
        static FigureGenerator generator;

        static void Main()
        {
            RendererProvier.Renderer.SizeGameField();
            SetTimer();
            generator = new FigureGenerator(GameField.WindowWidth/2, 0);
            currentFigure = generator.GetNewFigure();
            currentFigure.DrawFigure();
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
             
        }

        private static void GraphicsWindow_KeyDown()
        {
            Monitor.Enter(_lockObject);
            var result = HandleKey(currentFigure, GraphicsWindow.LastKey);
            if (GraphicsWindow.LastKey == "Down")
                gameOver = ProcessResult(result, ref currentFigure);
            Monitor.Exit(_lockObject);

        }

        private static bool ProcessResult(ResultCollision resultHandleKey, ref Figure currentFigure)
        {
            if (resultHandleKey == ResultCollision.FigureCollision || resultHandleKey == ResultCollision.DownBorderCollision)
            {
                GameField.AddFigure(currentFigure);
                GameField.TryDeleteLines();
                if (currentFigure.IsOnTop())
                {
                    RendererProvier.Renderer.WriteGameOver();
                    timer.Elapsed -= OnTimerEvent;
                    return true;
                }
                else
                {
                    currentFigure = generator.GetNewFigure();
                    return false;
                }                
            }
            else
                return false;
        }

        private static ResultCollision HandleKey(Figure currentFigure, String key)
        {
            switch (key)
            {
                case "Left":
                    return currentFigure.TryMoveFigure(DirectionMovementFigure.Left);                    
                case "Right":
                    return currentFigure.TryMoveFigure(DirectionMovementFigure.Right);
                case "Down":
                    return currentFigure.TryMoveFigure(DirectionMovementFigure.Down);
                case "Space":
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
