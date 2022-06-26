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

            //Figure[] figures = new Figure[2];
            //figures[0] = new ShapeO(2, 3, 'Ы');
            //figures[1] = new ShapeI(6, 6, 'Ы');

            //foreach (Figure show in figures)
            //{
            //    show.DrawFigure();
            //}

            FigureGenerator generator = new FigureGenerator(20, 0, 'Ы');
            Figure shape;
            while (true)
            {
                FigureFall(out shape, generator);
                shape.DrawFigure();
            }

            //Figure s = new ShapeI(20, 3, '#');
            //s.DrawFigure();
            //Thread.Sleep(500);
            //s.HideFigure();
            //s.RotateFigure();
            //s.DrawFigure();
            //Console.ReadLine();
        }

        private static void FigureFall(out Figure shape, FigureGenerator generator)
        {
            shape = generator.GetNewFigure();
            shape.DrawFigure();
            for(int i = 0; i < 15; i++)
            {
                shape.HideFigure();
                shape.MoveFigure(DirectinEnums.Down);
                shape.DrawFigure();
                Thread.Sleep(100);
            }
        }
    }
}
