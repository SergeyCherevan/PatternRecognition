using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition
{
    public class TemplateComputationOfPatternRecognition<COLOUR>
        where COLOUR : struct
    {
        Func<Color, COLOUR> ColourFunc;
        Predicate<(COLOUR, COLOUR)> DifBeetwinColours;

        public TemplateComputationOfPatternRecognition(
                    Func<Color, COLOUR> F, Predicate<(COLOUR, COLOUR)> P
            ) { ColourFunc = F; DifBeetwinColours = P; }

        /*-----------------------------------------------------*/

        COLOUR[,] pointsM;

        Bitmap bitmapIn = null;

        Bitmap bitmapOut = null;

        public void CreatePointsArrFromImage(Image image)
        {
            bitmapIn = new Bitmap(image);

            pointsM = new COLOUR[bitmapIn.Height, bitmapIn.Width];

            for (int y = 0; y < bitmapIn.Height; y++)
                for (int x = 0; x < bitmapIn.Width; x++)
                {
                    Color color = bitmapIn.GetPixel(x, y);
                    pointsM[y, x] = ColourFunc(color);
                }
        }

        /*-----------------------------------------------------*/

        public Pixel<COLOUR>[,] pixelsM;

        public LinkedList<Figure<COLOUR>> figureList = new LinkedList<Figure<COLOUR>>();

        public void CreateFreePixelsAndPixelsM()
        {
            pixelsM = new Pixel<COLOUR>[pointsM.GetLength(0), pointsM.GetLength(1)];

            for(int _y = 0; _y < pointsM.GetLength(0); _y++)
            {
                for (int _x = 0; _x < pointsM.GetLength(1); _x++)
                {
                    Pixel<COLOUR> p = new Pixel<COLOUR>
                        { color = pointsM[_y, _x], x = _x, y = _y };

                    pixelsM[_y, _x] = p;
                }
            }
        }

        /*-----------------------------------------------------*/

        public volatile int countOfProcessedPixels;

        public void GroupPixelsByFigures()
        {
            Pixel<COLOUR> p;

            lock (this) countOfProcessedPixels = 0;

            while ( (p = NextFreePixel()) != null)
            {
                lock (this) countOfProcessedPixels++;

                Figure<COLOUR> currFig = new Figure<COLOUR> {
                    color = p.color,
                    ID = figureList.Count
                };

                figureList.AddLast(currFig);

                FindAllPixelsOfFigure(p, currFig);                
            }
        }

        public Pixel<COLOUR> NextFreePixel()
        {
            for (int y = 0; y < pixelsM.GetLength(0); y++)
            {
                for (int x = 0; x < pixelsM.GetLength(1); x++)
                {
                    Pixel<COLOUR> pixel = pixelsM[y, x];

                    if (pixel.figure == null) return pixel;
                }
            }

            return null;
        }

        public void FindAllPixelsOfFigure(Pixel<COLOUR> p, Figure<COLOUR> fig)
        {
            LinkedList<Pixel<COLOUR>> pixelsTurn = new LinkedList<Pixel<COLOUR>>();

            pixelsTurn.AddLast(p);
            p.figure = fig;

            while (pixelsTurn.Any())
            {
                p = pixelsTurn.First.Value;
                pixelsTurn.RemoveFirst();

                fig.pixels.AddLast(p);

                lock (this) countOfProcessedPixels++;



                IfWeMustThenAddPixelToTurn(p.y, p.x + 1);

                IfWeMustThenAddPixelToTurn(p.y + 1, p.x);

                IfWeMustThenAddPixelToTurn(p.y, p.x - 1);

                IfWeMustThenAddPixelToTurn(p.y - 1, p.x);
            }

            return;



            bool MustWeAddPixelToTurn(int y, int x)
            {
                return  IsPixel(y, x) &&
                        pixelsM[y, x].figure == null &&
                        ! DifBeetwinColours((p.color, pixelsM[y, x].color));
            }

            void AddPixelToTurn(int y, int x)
            {
                pixelsTurn.AddLast(pixelsM[y, x]);

                pixelsM[y, x].figure = fig;
            }

            void IfWeMustThenAddPixelToTurn(int y, int x)
            {
                if (MustWeAddPixelToTurn(y, x))
                {
                    AddPixelToTurn(y, x);
                }
            }
        }

        /*-----------------------------------------------------*/

        public bool IsPixel(int y, int x)
        {
            return x >= 0 && y >= 0 && x < pixelsM.GetLength(1) && y < pixelsM.GetLength(0);
        }

        public Image RecolorImage(List<Color> colors)
        {
            if (colors == null)
            {
                Random r = new Random();

                int size = 10 + r.Next(10);

                colors = new List<Color>(size);

                for(int i = 0; i < size; i++)
                {
                    colors.Add(Color.FromArgb(0xff, r.Next(0, 0x100), r.Next(0, 0x100), r.Next(0, 0x100)));
                }
            }

            bitmapOut = bitmapIn.Clone() as Bitmap;

            var colorEnumenator = colors.GetEnumerator();

            foreach (Figure<COLOUR> figure in figureList)
            {
                /* Вызываем colorEnumenator.MoveNext() - инкрементируем перечислитель.
                 * Теперь в его colorEnumenator.Current хранится новый цвет.
                 * Если бобик сдох, то закадываем в него начало коллекции. */

                if (!colorEnumenator.MoveNext())
                {
                    colorEnumenator = colors.GetEnumerator();
                    colorEnumenator.MoveNext();
                }

                foreach (Pixel<COLOUR> pixel in figure.pixels)
                {
                    bitmapOut.SetPixel(pixel.x, pixel.y, colorEnumenator.Current);
                }
            }

            return bitmapOut;
        }
    }
}
