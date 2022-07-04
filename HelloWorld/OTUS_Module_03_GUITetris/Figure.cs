using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Module_03
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
            MoveFigure(directin);
            ResultCollision verificationResult = IsAcceptablePositionFigure();
            if (verificationResult != ResultCollision.NoCollision)
                MoveFigure(ReverseMove(directin));
            DrawFigure();
            return verificationResult;
        }

        private DirectionMovementFigure ReverseMove(DirectionMovementFigure directin)
        {
            switch (directin)
            {
                case DirectionMovementFigure.Left:
                    return DirectionMovementFigure.Right;
                case DirectionMovementFigure.Right:
                    return DirectionMovementFigure.Left;
                case DirectionMovementFigure.Down:
                    return DirectionMovementFigure.Up;
                case DirectionMovementFigure.Up:
                    return DirectionMovementFigure.Down;
            }
            return directin;
        }

        private void MoveFigure(DirectionMovementFigure direction)
        {
            foreach(FigureCell figure in cells)
            {
                figure.MoveCalls(direction);
            }
        }

        public ResultCollision TryRotateFigure()
         {
            HideFigure();           
            RotateFigure();
            ResultCollision verificationResult = IsAcceptablePositionFigure();
            if (verificationResult != ResultCollision.NoCollision)
                RotateFigure();
            DrawFigure();
            return verificationResult;
        }

        private ResultCollision IsAcceptablePositionFigure()
        {
            foreach(FigureCell figure in cells)
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

        internal bool IsOnTop()
        {
            return cells[0].AxisY == 0;
        }

        public abstract void RotateFigure();   
    }
}
