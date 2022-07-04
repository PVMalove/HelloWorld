using System;

namespace OTUS_Module_03
{
    static class GameField 
    {
        private static int _windowWidth = 30;
        private static int _windowHeight = 20;

        public static int WindowWidth
        {
            get
            {
                return _windowWidth;
            }
            set
            {
                _windowWidth = value;
                Console.SetWindowSize(_windowWidth, GameField.WindowHeight);
                Console.SetBufferSize(_windowWidth, GameField.WindowHeight);
            }
        }

        public static int WindowHeight
        {
            get
            {
                return _windowHeight;
            }
            set
            {
                _windowHeight = value;
                Console.SetWindowSize(GameField.WindowWidth, _windowHeight);
                Console.SetBufferSize(GameField.WindowWidth, _windowHeight);
            }
        }

        private static bool [][] _isCellFigureCellField;
        static GameField()
        {
            _isCellFigureCellField = new bool[WindowHeight][];
            for(int i = 0; i < WindowHeight; i++)
            {
                _isCellFigureCellField[i] = new bool[WindowWidth];
            }           
        }
                
        public static void AddFigure(Figure addFigure)
        {
            foreach(var figure in addFigure.cells)
            {
                _isCellFigureCellField[figure.AxisY][figure.AxisX] = true;
            }
        }
        internal static void TryDeleteLines()
        {
             for(int h = 0; h < WindowHeight; h++)
            {
                int cellCounter = 0;
                for (int w = 0; w < WindowWidth; w++)
                {
                    if (_isCellFigureCellField[h][w])
                        cellCounter++;
                }
                if(cellCounter == WindowWidth)
                {
                    DeleteLine(h);
                    RedrawGameField();
                }
            }
        }

        private static void DeleteLine(int line)
        {
            for(int h = line; h >= 0; h--)
            {
                for(int i = 0; i < WindowWidth; i++)
                {
                    if (h == 0)
                        _isCellFigureCellField[h][i] = false;
                    else
                        _isCellFigureCellField[h][i] = _isCellFigureCellField[h - 1][i];
                }
            }
        }
        private static void RedrawGameField()
        {
            for(int h = 0; h < WindowHeight; h++)
            {
                for(int i = 0; i < WindowWidth; i++)
                {
                    if (_isCellFigureCellField[h][i])
                        RendererProvier.Renderer.DrawCells(i, h);
                    else
                        RendererProvier.Renderer.HideCells(i, h);
                }
            }    
        }        

        public static bool IsCollisionFigures(FigureCell cell)
        {
            return _isCellFigureCellField[cell.AxisY][cell.AxisX];
        }
    }
}
