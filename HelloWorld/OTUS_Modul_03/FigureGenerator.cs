using System;

namespace OTUS_Modul_03
{
    class FigureGenerator
    {
        private int _axisX;
        private int _axisY;
        private const int _QOANTITY_FIGURE = 3;

        private Random _rand = new Random();

        public FigureGenerator(int x, int y)
        {
            _axisX = x;
            _axisY = y;
        }

        public Figure GetNewFigure()
        {
            if (_rand.Next(0, _QOANTITY_FIGURE) == 0)
                return new ShapeO(_axisX, _axisY);
            else if (_rand.Next(0, _QOANTITY_FIGURE) == 1)
                return new ShapeT(_axisX, _axisY);
            else
                return new ShapeI(_axisX, _axisY);
        }
    }
}