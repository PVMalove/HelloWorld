using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    class ShapeI
    {
        FigureCell[] cellsStick = new FigureCell[4];

        public ShapeI(int x, int y, char symbol)
        {
            cellsStick[0] = new FigureCell(x, y, symbol);
            cellsStick[1] = new FigureCell(x, y + 1, symbol);
            cellsStick[2] = new FigureCell(x, y + 2, symbol);
            cellsStick[3] = new FigureCell(x, y + 3, symbol);
        }

        public void DrawShapeI()
        {
            foreach(FigureCell cell in cellsStick)
            {
                cell.DrawFigure();
            }
        }
    }
}
