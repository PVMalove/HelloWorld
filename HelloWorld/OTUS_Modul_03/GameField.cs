using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    static class GameField
    {
        private static int _windowWidth = 40;
        private static int _windowHeight = 30;

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

    }
}
