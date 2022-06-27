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

        public override void RotateFigure()
        {
            if (cells[0].axisX == cells[1].axisX)
            {
                RotateHorisontal();                
            }
            else
            {                
                RotateVertical();                
            }
        }
        
        private void RotateHorisontal()
        {
            for(int i = 0; i < cells.Length; i++)
            {
                cells[i].axisY = cells[0].axisY;
                cells[i].axisX = cells[0].axisX + i;
            }
        }
        private void RotateVertical()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i].axisY = cells[0].axisY + i;
                cells[i].axisX = cells[0].axisX;
            }
        }
    }
}
