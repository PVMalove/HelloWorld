using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    class FigureCell
    {
        public int AxisX { get; set; }
        public int AxisY { get; set; }
        public char CharCell { get; set; }

        public void DrawFigureCells()
        {
            Console.SetCursorPosition(AxisX, AxisY);
            Console.Write(CharCell);
            Console.SetCursorPosition(0, 0);
        }
        public void HideFigureCells()
        {
            Console.SetCursorPosition(AxisX, AxisY);
            Console.Write(' ');
        }

        public FigureCell(FigureCell cloneCell)
        {
            AxisX = cloneCell.AxisX;
            AxisY = cloneCell.AxisY;
            CharCell = cloneCell.CharCell;
        }

        public FigureCell(int a,  int b, char symbol)
        {
            AxisX = a;
            AxisY = b;
            CharCell = symbol;
        }

        public void MoveCalls(DirectionMovementFigure directin)
        {
            switch (directin)
            {
                case DirectionMovementFigure.Down:
                    AxisY += 1;
                    break;
                case DirectionMovementFigure.Left:
                    AxisX -= 1;
                    break;
                case DirectionMovementFigure.Right:
                    AxisX += 1;
                    break;              
            }
        }        
    }
}
