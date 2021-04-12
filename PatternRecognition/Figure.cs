using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition
{
    public class Figure<COLOUR>
        where COLOUR : struct
    {
        public int ID;

        public COLOUR color;

        public LinkedList<Pixel<COLOUR>> pixels
            = new LinkedList<Pixel<COLOUR>>();

        public LinkedList<(Pixel<COLOUR>, Pixel<COLOUR>)> contourPixels
            = new LinkedList<(Pixel<COLOUR>, Pixel<COLOUR>)>();
    }
}
