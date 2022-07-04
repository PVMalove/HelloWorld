using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Module_03
{
    class ConsoleRenderer : ICellsRenderer
    {
        public const char DEFOULT_SYMBOL = 'Ы';
        public void DrawCells(int axisX, int axisY)
        {
            Console.SetCursorPosition(axisX, axisY);
            Console.Write(DEFOULT_SYMBOL);
            Console.SetCursorPosition(0, 0);
        }

        public void HideCells(int axisX, int axisY)
        {
            Console.SetCursorPosition(axisX, axisY);
            Console.Write(' ');
            Console.SetCursorPosition(0, 0);
        }

        public void WriteGameOver()
        {
            string gameOver = "G A M E   O V E R";
            Console.Clear();
            Console.SetCursorPosition(GameField.WindowWidth / 2 - gameOver.Length / 2, GameField.WindowHeight / 2);
            Console.WriteLine(gameOver);
        }

        public void SizeGameField()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(GameField.WindowWidth, GameField.WindowHeight);
            Console.SetBufferSize(GameField.WindowWidth, GameField.WindowHeight);
        }
    }
}
