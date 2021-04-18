using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternRecognition
{
    public class Symbol
    {
        public Figure<bool> figure;

        int H { get; set; }

        int W { get; set; }

        public Symbol()
        {
            H = W = 3;

            figure = null;
        }

        public Symbol(Figure<bool> f, int h = 3, int w = 3)
        {
            figure = f;

            H = h; W = w;
        }

        public double[,] GetAreas()
        {
            int width = figure.maxX - figure.minX + 1;
            int height = figure.maxY - figure.minY + 1;

            int[,] _S = new int[H, W];

            for (int y = 0; y < H; ++y)
                for (int x = 0; x < W; ++x)
                    _S[y, x] = 0;

            foreach (Pixel<bool> p in figure.pixels)
            {
                int _y = -1, _x = -1;

                for (int y = 0; y < H; ++y)
                {
                    if (figure.minY + y*height/H <= p.y && p.y < figure.minY + (y +1)*height/H)
                    {
                        _y = y;
                    }
                }

                for (int x = 0; x < W; ++x)
                {
                    if (figure.minX + x * width/W <= p.x && p.x < figure.minX + (x+1)*width/W)
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
                    areas[y, x] = (double)_S[y, x] / (width/W) / (height/H);
                }
            }

            return areas;
        }
    }
}
