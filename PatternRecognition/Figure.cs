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

        public int minX = 0xFFFFFFF,
                   minY = 0xFFFFFFF,
                   maxX = 0,
                   maxY = 0;

        public int sumOfX = 0, sumOfY = 0;

        public int countOfPixels = 0;

        public int CenterX { get => sumOfX / countOfPixels; }
        public int CenterY { get => sumOfY / countOfPixels; }
    }
}
