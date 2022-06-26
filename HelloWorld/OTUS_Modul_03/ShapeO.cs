using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    class ShapeO : Figure
    {
        public ShapeO(int x, int y, char symbol)
        {
            cells[0] = new FigureCell(x, y, symbol);
            cells[1] = new FigureCell(x+1, y, symbol);
            cells[2] = new FigureCell(x, y+1, symbol);
            cells[3] = new FigureCell(x+1, y+1, symbol);            
        }

        public override void RotateFigure()
        {            
        }

    }
}
