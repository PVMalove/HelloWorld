using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Module_03
{
    class FigureCell
    {
        public int AxisX { get; set; }
        public int AxisY { get; set; }

        public void DrawFigureCells()
        {
            RendererProvier.Renderer.DrawCells(AxisX, AxisY);
        }
        public void HideFigureCells()
        {
            RendererProvier.Renderer.HideCells(AxisX, AxisY);
        }

        public FigureCell(int a,  int b)
        {
            AxisX = a;
            AxisY = b;
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
                case DirectionMovementFigure.Up:
                    AxisY -= 1;
                    break;
            }
        }        
    }
}
