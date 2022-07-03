using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    class ShapeI : Figure
    {      
        public ShapeI(int x, int y)
        {
            cells[0] = new FigureCell(x, y);
            cells[1] = new FigureCell(x, y + 1);
            cells[2] = new FigureCell(x, y + 2);
            cells[3] = new FigureCell(x, y + 3);            
            DrawFigure();
        }

        public override void RotateFigure()
        {
            if (cells[0].AxisX == cells[1].AxisX)
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
                cells[i].AxisY = cells[0].AxisY;
                cells[i].AxisX = cells[0].AxisX + i;
            }
        }
        private void RotateVertical()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i].AxisY = cells[0].AxisY + i;
                cells[i].AxisX = cells[0].AxisX;
            }
        }
    }
}
