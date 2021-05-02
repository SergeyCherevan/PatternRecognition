using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternRecognition
{
    public class ContourRecognitionComputation
    {
        public double maxLen;

        public ContourRecognitionComputation() { maxLen = 5.0; }
        public ContourRecognitionComputation(double MaxLen) { maxLen = MaxLen; }

        public bool[,] Comp(double[,] imageMap)
        {
            int ylen = imageMap.GetLength(0),
                xlen = imageMap.GetLength(1);

            bool[,] result = new bool[ylen, xlen];

            try
            {
                for (int y = 0; y < ylen; y++)
                {
                    for (int x = 0; x < xlen; x++)
                    {
                        result[y, x] = false;

                        result[y, x] |= IsContour(y, x + 1);

                        result[y, x] |= IsContour(y + 1, x);

                        result[y, x] |= IsContour(y, x - 1);

                        result[y, x] |= IsContour(y - 1, x);


                        bool IsContour(int _y, int _x)
                        {
                            return IsPixel(_y, _x) &&
                                   DifBeetwinColours(imageMap[_y, _x], imageMap[y, x]);
                        }

                        bool IsPixel(int _y, int _x)
                        {
                            return _x >= 0 && _y >= 0 && _x < imageMap.GetLength(1) && _y < imageMap.GetLength(0);
                        }

                        bool DifBeetwinColours(double c1, double c2)
                        {
                            return Math.Abs(c1 - c2) >= maxLen;
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

        public Image GetImage(bool[,] imageMap)
        {
            int ylen = imageMap.GetLength(0),
                xlen = imageMap.GetLength(1);



            Bitmap bm = new Bitmap(xlen, ylen);



            for (int y = 0; y < ylen; y++)
            {
                for (int x = 0; x < xlen; x++)
                {
                    if (imageMap[y, x])
                        bm.SetPixel(x, y, Color.Black);
                    else
                        bm.SetPixel(x, y, Color.White);
                }
            }



            return bm;
        }
    }
}
