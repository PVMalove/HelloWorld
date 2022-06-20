using System;

namespace OTUS_Modul_03
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
          
            Point point1 = new Point(2, 3, '*');
            point1.Draw();
            Point point2 = new Point(3, 4, '#');
            point2.Draw();



            
                                    
            Console.ReadLine();
        }

    }
}
