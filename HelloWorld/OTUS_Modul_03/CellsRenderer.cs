using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    public static class CellsRenderer
    {
        public const char DEFOULT_SYMBOL = 'Ы';

        public static void DrawCells(int axisX, int axisY, char charCell = DEFOULT_SYMBOL)
        {
            Console.SetCursorPosition(axisX, axisY);
            Console.Write(charCell);
            Console.SetCursorPosition(0, 0);
        }

        public static void HideCells (int axisX, int axisY)
        {
            Console.SetCursorPosition(axisX, axisY);
            Console.Write(' ');
            Console.SetCursorPosition(0, 0);
        }
    }
}
