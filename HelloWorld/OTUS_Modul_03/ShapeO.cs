using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    class ShapeO : Figure
    {
        public ShapeO(int x, int y)
        {
            cells[0] = new FigureCell(x, y);
            cells[1] = new FigureCell(x+1, y);
            cells[2] = new FigureCell(x, y+1);
            cells[3] = new FigureCell(x+1, y+1);
            DrawFigure();
        }

        public override void RotateFigure()
        {            
        }

    }
}
