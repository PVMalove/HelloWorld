using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    class ShapeT : Figure
    {
        public ShapeT(int x, int y)
        {
            cells[0] = new FigureCell(x, y + 1);
            cells[1] = new FigureCell(x + 1, y + 1);
            cells[2] = new FigureCell(x + 1, y + 2);
            cells[3] = new FigureCell(x + 2, y + 1);            
            DrawFigure();
        }

        public override void RotateFigure()
        {
            if (cells[1].AxisY == cells[3].AxisY)
                RotateFirst();
            else if (cells[1].AxisX == cells[2].AxisX)
                RotateSecond();
            else if (cells[0].AxisY == cells[1].AxisY && cells[1].AxisY == cells[2].AxisY)
                RotateThird();
            else  if (cells[0].AxisX == cells[3].AxisX)
                Rotatefourth();
        }

        
        private void RotateFirst()
        {
            cells[3].AxisX = cells[3].AxisX - 1;
            cells[3].AxisY = cells[3].AxisY - 1;
        }
        private void RotateSecond()
        {
            cells[2].AxisX = cells[2].AxisX + 1;
            cells[2].AxisY = cells[2].AxisY - 1; 
        }
        private void RotateThird()
        {
            cells[0].AxisX = cells[0].AxisX + 1;
            cells[0].AxisY = cells[0].AxisY + 1;
        }
        private void Rotatefourth()
        {
            cells[0].AxisY = cells[0].AxisY - 1;
            cells[0].AxisX = cells[0].AxisX - 1;
            cells[2].AxisY = cells[2].AxisY + 1;
            cells[2].AxisX = cells[2].AxisX - 1;
            cells[3].AxisX = cells[3].AxisX + 1;
            cells[3].AxisY = cells[3].AxisY + 1;
        }
    } 
}
