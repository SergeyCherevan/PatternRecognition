using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition
{
    public class Pixel<COLOUR>
        where COLOUR : struct
    {
        public int x, y;

        public COLOUR color;

        public Figure<COLOUR> figure = null;
    }
}
