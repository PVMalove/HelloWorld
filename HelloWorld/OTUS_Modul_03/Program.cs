using System;

namespace OTUS_Modul_03
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            int x1 = 2;
            int y1 = 3;
            char c1 = '*';

            Drow(x1, y1, c1);

            int x2 = 10;
            int y2 = 4;
            char c2 = '#';

            Drow(x2, y2, c2);

                                    
            Console.ReadLine();
        }

        static void Drow(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
