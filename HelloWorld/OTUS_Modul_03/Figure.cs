using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    abstract class Figure
    {
        const int LENGHT = 4;
        protected FigureCell[] cells = new FigureCell[LENGHT];

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

        public void TryMoveFigure(DirectinEnums directin)
        {
            HideFigure();
            FigureCell[] cloneFigure = CloneFigure();
            CloneMoveFigure(cloneFigure, directin);
            if (VerifyPositionFigure(cloneFigure))
                cells = cloneFigure;
            DrawFigure();
        }
        public void TryRotateFigure()
         {
            HideFigure();
            FigureCell[] cloneFigure = CloneFigure();
            RotateFigure(cloneFigure);
            if (VerifyPositionFigure(cloneFigure))
                cells = cloneFigure;
            DrawFigure();
        }

        private bool VerifyPositionFigure(FigureCell[] cloneCells)
        {
            foreach(FigureCell figure in cloneCells)
            {
                if (figure.axisX < 0 || figure.axisY < 0 || figure.axisX >= GameField.windowWidth || figure.axisY >= GameField.windowHeight)
                    return false;
            }
            return true;
        }

        private FigureCell[] CloneFigure()
        {
            FigureCell[] cloneCells = new FigureCell[LENGHT];
            for(int i = 0; i < LENGHT; i++)
            {
                cloneCells[i] = new FigureCell(cells[i]);
            }
            return cloneCells;
        }

        public void CloneMoveFigure(FigureCell[] cloneCells, DirectinEnums directin)
        {
            foreach (FigureCell cloneFegure in cloneCells)
            {
                cloneFegure.MoveCalls(directin);
            }            
        }
        public abstract void RotateFigure(FigureCell[] cloneCells);   
    }
}
