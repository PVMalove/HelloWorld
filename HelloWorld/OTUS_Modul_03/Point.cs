using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    class Point
    {
        public int posX;
        public int posY;
        public char outputСhar;

        public void Draw()
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(outputСhar);
        }

        public Point(int a,  int b, char sym)
        {
            posX = a;
            posY = b;
            outputСhar = sym;
        }


    }
}
