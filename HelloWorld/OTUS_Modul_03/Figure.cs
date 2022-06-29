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
            if (IsAcceptablePositionFigure(cloneFigure))
                cells = cloneFigure;
            DrawFigure();
        }
        public void TryRotateFigure()
         {
            HideFigure();
            FigureCell[] cloneFigure = CloneFigure();
            RotateFigure(cloneFigure);
            if (IsAcceptablePositionFigure(cloneFigure))
                cells = cloneFigure;
            DrawFigure();
        }

        private static bool IsAcceptablePositionFigure(FigureCell[] cloneCells)
        {
            foreach(FigureCell figure in cloneCells)
            {
                if (figure.AxisX < 0 || figure.AxisY < 0 || figure.AxisX >= GameField.WindowWidth || figure.AxisY >= GameField.WindowHeight)
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

        public static void CloneMoveFigure(FigureCell[] cloneCells, DirectinEnums directin)
        {
            foreach (FigureCell cloneFegure in cloneCells)
            {
                cloneFegure.MoveCalls(directin);
            }            
        }
        public abstract void RotateFigure(FigureCell[] cloneCells);   
    }
}
