using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternRecognition
{
    public class ImpulseRecognitionComputation
    {
        public double k;

        public ImpulseRecognitionComputation() { k = 0.8; }
        public ImpulseRecognitionComputation(double _k) { k = _k; }

        public bool[,] Comp(double[,] imageMap)
        {
            int ylen = imageMap.GetLength(0),
                xlen = imageMap.GetLength(1);

            bool[,] result = new bool[ylen, xlen];

            try
            {
                for (int y = 0; y < ylen; y++)
                {
                    double max = -1;

                    for (int x = 0; x < xlen; x++)
                    {
                        max = Math.Max(max, imageMap[y, x]);
                    }

                    double S = 0;

                    for (int x = 0; x < xlen; x++)
                    {
                        S += imageMap[y, x];

                        if (S >= k * max)
                        {
                            S -= k * max;
                            result[y, x] = true;
                        }
                        else
                            result[y, x] = false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().Name);
            }

            return result;
        }

        public Image GetImage(bool[,] imageMap)
        {
            int ylen = imageMap.GetLength(0),
                xlen = imageMap.GetLength(1);



            Bitmap bm = new Bitmap(xlen, ylen);



            for (int y = 0; y < ylen; y++)
            {
                for (int x = 0; x < xlen; x++)
                {
                    if (!imageMap[y, x])
                        bm.SetPixel(x, y, Color.Black);
                    else
                        bm.SetPixel(x, y, Color.White);
                }
            }



            return bm;
        }
    }
}
