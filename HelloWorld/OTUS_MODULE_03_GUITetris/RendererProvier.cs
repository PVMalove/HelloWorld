using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Module_03
{
    static class RendererProvier
    {
        private static ICellsRenderer _renderer = new GUIRenderer();
        public static ICellsRenderer Renderer
        {
            get
            {
                return _renderer;
            }
        }
    }
}
