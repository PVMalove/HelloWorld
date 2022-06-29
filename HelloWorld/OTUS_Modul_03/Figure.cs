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
        public FigureCell[] cells = new FigureCell[LENGHT];

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

        public ResultCollision TryMoveFigure(DirectionMovementFigure directin)
        {
            HideFigure();
            FigureCell[] cloneFigure = CloneFigure();
            CloneMoveFigure(cloneFigure, directin);
            ResultCollision verificationResult = IsAcceptablePositionFigure(cloneFigure);
            if (verificationResult == ResultCollision.NoCollision)
                cells = cloneFigure;
            DrawFigure();
            return verificationResult;
        }
        public ResultCollision TryRotateFigure()
         {
            HideFigure();
            FigureCell[] cloneFigure = CloneFigure();
            RotateFigure(cloneFigure);
            ResultCollision verificationResult = IsAcceptablePositionFigure(cloneFigure);
            if (verificationResult == ResultCollision.NoCollision)
                cells = cloneFigure;
            DrawFigure();
            return verificationResult;
        }

        private ResultCollision IsAcceptablePositionFigure(FigureCell[] cloneCells)
        {
            foreach(FigureCell figure in cloneCells)
            {
                if (figure.AxisY >= GameField.WindowHeight)
                    return ResultCollision.DownBorderCollision;
                if (figure.AxisX >= GameField.WindowWidth || figure.AxisX < 0 || figure.AxisY < 0)
                    return ResultCollision.BorderCollision;
                if (GameField.IsCollisionFigures(figure))
                    return ResultCollision.FigureCollision;   
            }
            return ResultCollision.NoCollision;
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

        public static void CloneMoveFigure(FigureCell[] cloneCells, DirectionMovementFigure directin)
        {
            foreach (FigureCell cloneFegure in cloneCells)
            {
                cloneFegure.MoveCalls(directin);
            }            
        }
        public abstract void RotateFigure(FigureCell[] cloneCells);   
    }
}
