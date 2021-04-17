using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition
{
    public class Symbol
    {
        public Figure<bool> figure;

        int H { get; set; }

        int W { get; set; }

        public double[,] Areas()
        {
            int width = figure.maxX - figure.minX;
            int height = figure.maxY - figure.minY;

            int[,] _S = new int[H, W];

            foreach (Pixel<bool> p in figure.pixels)
            {
                int _y = -1, _x = -1;

                for (int y = 0; y < H; ++y)
                {
                    if (y*height/H <= p.y && p.y < (y+1)*height/H)
                    {
                        _y = y;
                    }
                }

                for (int x = 0; x < W; ++x)
                {
                    if (x*width/W <= p.x && p.x < (x+1)*width/W)
                    {
                        _x = x;
                    }
                }

                ++_S[_y, _x];
            }


            double[,] areas = new double[H, W];

            for (int y = 0; y < H; ++y)
            {
                for (int x = 0; x < W; ++x)
                {
                    areas[y, x] = _S[y, x] / (width/W) / (height/H);
                }
            }

            return areas;
        }
    }
}
