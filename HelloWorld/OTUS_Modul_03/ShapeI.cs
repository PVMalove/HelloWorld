using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    class ShapeI : Figure
    {      
        public ShapeI(int x, int y, char symbol)
        {
            cells[0] = new FigureCell(x, y, symbol);
            cells[1] = new FigureCell(x, y + 1, symbol);
            cells[2] = new FigureCell(x, y + 2, symbol);
            cells[3] = new FigureCell(x, y + 3, symbol);
            DrawFigure();
        }

        public override void RotateFigure(FigureCell[] cloneCells)
        {
            if (cloneCells[0].axisX == cloneCells[1].axisX)
            {
                RotateHorisontal(cloneCells);                
            }
            else
            {                
                RotateVertical(cloneCells);                
            }
        }
        
        private void RotateHorisontal(FigureCell[] cloneCells)
        {
            for(int i = 0; i < cloneCells.Length; i++)
            {
                cloneCells[i].axisY = cloneCells[0].axisY;
                cloneCells[i].axisX = cloneCells[0].axisX + i;
            }
        }
        private void RotateVertical(FigureCell[] cloneCells)
        {
            for (int i = 0; i < cloneCells.Length; i++)
            {
                cloneCells[i].axisY = cloneCells[0].axisY + i;
                cloneCells[i].axisX = cloneCells[0].axisX;
            }
        }
    }
}
