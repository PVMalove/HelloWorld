using System;

namespace OTUS_Modul_03
{
    class Tetris
    {
        static void Main()
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            ShapeO square = new ShapeO(10, 14, 'Ы');
            square.DrawShapeO();

            ShapeI stick = new ShapeI(2, 3, 'Ы');
            stick.DrawShapeI();
                    
            Console.ReadLine();
            
            
        }


    }
}
