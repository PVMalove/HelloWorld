using System;

namespace OTUS_Modul_03
{
    class Tetris
    {
        static void Main()
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure[] figures = new Figure[2];
            figures[0] = new ShapeO(2, 3, 'Ы');
            figures[1] = new ShapeI(6, 6, 'Ы');

            foreach (Figure show in figures)
            {
                show.DrawFigure();
            }

            Console.ReadLine();
            
            
        }


    }
}
