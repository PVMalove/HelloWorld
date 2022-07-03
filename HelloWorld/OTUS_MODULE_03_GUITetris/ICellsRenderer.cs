using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    interface ICellsRenderer
    {
        void DrawCells(int axisX, int axisY);
        void HideCells(int axisX, int axisY);
        void WriteGameOver();
        void SizeGameField();
    }
}
