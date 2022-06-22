using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    class ShapeO
    {
        FigureCell[] cellsSquare = new FigureCell[4];
        
        public ShapeO(int x, int y, char symbol)
        {
            cellsSquare[0] = new FigureCell(x, y, symbol);
            cellsSquare[1] = new FigureCell(x+1, y, symbol);
            cellsSquare[2] = new FigureCell(x, y+1, symbol);
            cellsSquare[3] = new FigureCell(x+1, y+1, symbol);            
        }

        public void DrawShapeO()
        {
            foreach(FigureCell cell in cellsSquare)
            {
                cell.DrawFigure();
            }
        }        
    }
}
