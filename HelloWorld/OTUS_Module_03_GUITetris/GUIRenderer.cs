using Microsoft.SmallBasic.Library;

namespace OTUS_Module_03
{
    class GUIRenderer : ICellsRenderer
    {
        private const int SIZE = 20;
        public void DrawCells(int axisX, int axisY)
        {
            GraphicsWindow.PenColor = "DarkGreen";
            GraphicsWindow.PenWidth = 2;
            GraphicsWindow.DrawRectangle(axisX * SIZE, axisY * SIZE, SIZE, SIZE);
        }

        public void HideCells(int axisX, int axisY)
        {
            GraphicsWindow.PenColor = "LightGreen";
            GraphicsWindow.PenWidth = 3;
            GraphicsWindow.DrawRectangle(axisX * SIZE, axisY * SIZE, SIZE, SIZE);
        }

        public void SizeGameField()
        {
            GraphicsWindow.BackgroundColor = "LightGreen";
            GraphicsWindow.Width = GameField.WindowWidth * SIZE;
            GraphicsWindow.Height = GameField.WindowHeight * SIZE;
        }

        public void WriteGameOver()
        {
            string gameOver = "G A M E   O V E R";
            GraphicsWindow.Clear();
            GraphicsWindow.BrushColor = "DarkGreen";
            GraphicsWindow.FontSize = 20;            
            GraphicsWindow.DrawText((GameField.WindowWidth / 2 - 4) * SIZE, (GameField.WindowHeight / 2) * SIZE, gameOver);            
        }
    }
}
