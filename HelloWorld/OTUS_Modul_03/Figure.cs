using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    abstract class Figure
    {
        protected FigureCell[] cells = new FigureCell[4];

        public void DrawFigure()
        {
            foreach(FigureCell figure in cells)
            {
                figure.DrawFigureCells();
            }
        }
        public void HideFigure()
        {
            foreach (FigureCell figure in cells)
            {
                figure.HideFigureCells();
            }
        }

        public void MoveFigure(DirectinEnums directin)
        {
            foreach (FigureCell figure in cells)
            {
                figure.MoveCalls(directin);
            }
        }
        public abstract void RotateFigure();   
    }
}
