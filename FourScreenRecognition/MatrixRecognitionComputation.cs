using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternRecognition
{
    public class MatrixRecognitionComputation
    {
        public double[,] matrix;
        public int y, x;
        

        public MatrixRecognitionComputation(double[,] m, int y, int x)
        {
            if (y < 0 || y > m.GetLength(0)) 
                throw new ArgumentOutOfRangeException($"y = {y} is not included in the gap [0, { m.GetLength(0) })");

            if (x < 0 || y > m.GetLength(1))
                throw new ArgumentOutOfRangeException($"x = {x} is not included in the gap [0, { m.GetLength(1) })");

            matrix = m;

            this.y = y;
            this.x = x;
        }

        public double[,] Comp(double[,] imageMap)
        {
            int ylen = imageMap.GetLength(0),
                xlen = imageMap.GetLength(1),
                ymlen = matrix.GetLength(0),
                xmlen = matrix.GetLength(1);

            double[,] result = new double[ylen, xlen];

            try
            {
                for (int iy = 0; iy < ylen; iy++)
                {
                    for (int ix = 0; ix < xlen; ix++)
                    {
                        result[iy, ix] = 0;

                        for (int _y = 0; _y < ymlen; _y++)
                        {
                            for (int _x = 0; _x < xmlen; _x++)
                            {
                                int Y = iy - y + _y,
                                    X = ix - x + _x;

                                if (Y < 0) Y = 0;
                                if (Y >= ylen) Y = ylen - 1;

                                if (X < 0) X = 0;
                                if (X >= xlen) X = xlen - 1;

                                result[iy, ix] += imageMap[Y, X] * matrix[_y, _x];
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().Name);
            }

            return result;
        }

        public Image GetImage(double[,] imageMap, double bias)
        {
            int ylen = imageMap.GetLength(0),
                xlen = imageMap.GetLength(1);



            double eMax = 0, eMin = 0;
            foreach (double e in matrix)
            {
                if (e > 0) eMax += e;
                else eMin += e;
            }



            Bitmap bm = new Bitmap(xlen, ylen);

            for (int y = 0; y < ylen; y++)
            {
                for (int x = 0; x < xlen; x++)
                {
                    int grayColor = (int) ((imageMap[y, x]/255 - eMin) / (eMax - eMin) * 255);

                    if (grayColor >= 256 * 1/2 + bias)
                        bm.SetPixel(x, y, Color.Black);
                    else                    
                        bm.SetPixel(x, y, Color.White);
                }
            }

            return bm;
        }
    }
}
