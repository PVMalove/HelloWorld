using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    class Square
    {
        Point[] pointSquare = new Point[4];
        
        public Square(int x, int y, char symbol)
        {
            pointSquare[0] = new Point(x, y, symbol);
            pointSquare[1] = new Point(x+1, y, symbol);
            pointSquare[2] = new Point(x, y+1, symbol);
            pointSquare[3] = new Point(x+1, y+1, symbol);            
        }

        public void Draw()
        {
            foreach(Point p in pointSquare)
            {
                p.Draw();
            }
        }        
    }
}
