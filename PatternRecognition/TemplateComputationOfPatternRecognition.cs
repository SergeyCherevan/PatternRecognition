using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PatternRecognition.RecognitionOptionsNamespace;

namespace PatternRecognition
{
    public class TemplateComputationOfPatternRecognition<COLOUR>
        where COLOUR : struct
    {
        Func<Color, COLOUR> ColourFunc;
        Predicate<(COLOUR, COLOUR)> DifBeetwinColours;

        delegate Pixel<COLOUR> WhichPixelUnionWithDelegate
            (Pixel<COLOUR> p, TemplateComputationOfPatternRecognition<COLOUR> tcpr);

        WhichPixelUnionWithDelegate WhichPixelUnionWith;

        int CountOfNoiseSuppression;

        bool isContourRecognition;

        public TemplateComputationOfPatternRecognition(RecognitionOptions ro)
        {
            try
            {
                ColourFunc = (Func<Color, COLOUR>)ro.ColourFunc;
            }
            catch (InvalidCastException)
            {
                throw new ArgumentException
                    ($"Type of ColourFunc is not {typeof(Func<Color, COLOUR>)}." +
                    $" Type of ColourFunc is {ro.ColourFunc?.GetType()}");
            }


            try
            {
                DifBeetwinColours = (Predicate<(COLOUR, COLOUR)>)ro.DifBeetwinColours;
            }
            catch (InvalidCastException)
            {
                throw new ArgumentException
                    ($"Type of DifBeetwinColours is not {typeof(Func<Color, COLOUR>)}. " +
                     $"Type of DifBeetwinColours is {ro.DifBeetwinColours?.GetType()}");
            }



            CountOfNoiseSuppression = ro.CountOfNoiseSuppression;

            if (CountOfNoiseSuppression > 0)
                try
                {
                        WhichPixelUnionWith = (p, tcpr) => (Pixel<COLOUR>)ro.WhichPixelUnionWith.DynamicInvoke(p, tcpr);
                }
                catch (InvalidCastException)
                {
                    throw new ArgumentException
                        ($"Type of WhichPixelUnionWith is not {typeof(WhichPixelUnionWithDelegate)}. " +
                         $"Type of WhichPixelUnionWith is {ro.WhichPixelUnionWith?.GetType()}");
                }

            isContourRecognition = ro.isContourRecognition;
        }

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

        public class CountVariableLocker { public volatile int counter; }
        public CountVariableLocker locker = new CountVariableLocker();

        FreePixels freePixels;

        public void GroupPixelsByFigures()
        {
            freePixels = new FreePixels(this);

            lock (locker) locker.counter = 0;

            foreach (Pixel<COLOUR> p in freePixels)
            {
                Figure<COLOUR> currFig = new Figure<COLOUR> {
                    color = p.color,
                    ID = figureList.Count
                };

                figureList.AddLast(currFig);

                FindAllPixelsOfFigure(p, currFig);                
            }
        }

        public class FreePixels
        {
            public TemplateComputationOfPatternRecognition<COLOUR> envClass { get; private set; }

            public FreePixels(TemplateComputationOfPatternRecognition<COLOUR> envClass) {

                this.envClass = envClass;
            }

            public int x { get; private set; }

            public int y { get; private set; }

            public IEnumerator<Pixel<COLOUR>> GetEnumerator()
            {
                for (y = 0; y < envClass.pixelsM.GetLength(0); y++)
                {
                    for (x = 0; x < envClass.pixelsM.GetLength(1); x++)
                    {
                        Pixel<COLOUR> pixel = envClass.pixelsM[y, x];

                        if (pixel.figure == null) yield return pixel;
                    }
                }

                yield break;
            }
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

                fig.sumOfX += p.x;
                fig.sumOfY += p.y;

                ++fig.countOfPixels;

                lock (locker) ++locker.counter;



                AddPixelToTurnOrContour(p.y, p.x + 1);

                AddPixelToTurnOrContour(p.y + 1, p.x);

                AddPixelToTurnOrContour(p.y, p.x - 1);

                AddPixelToTurnOrContour(p.y - 1, p.x);
            }

            return;



            bool MustWeAddPixelToTurn(int y, int x)
            {
                return  IsPixel(y, x) &&
                        pixelsM[y, x].figure == null &&
                        ! DifBeetwinColours((p.color, pixelsM[y, x].color));
            }

            bool MustWeAddPixelToContour(int y, int x)
            {
                return IsPixel(y, x) &&
                       DifBeetwinColours((p.color, pixelsM[y, x].color));
            }

            void AddPixelToTurn(int y, int x)
            {
                pixelsTurn.AddLast(pixelsM[y, x]);

                pixelsM[y, x].figure = fig;
            }

            void AddPixelToContour(int y, int x)
            {
                p.figure.contourPixels.AddLast( (p, pixelsM[y, x]) );

                AddInformOfMinMax(p);
            }

            void AddInformOfMinMax(Pixel<COLOUR> pixel)
            {
                fig.minX = Math.Min(fig.minX, pixel.x);
                fig.minY = Math.Min(fig.minY, pixel.y);
                fig.maxX = Math.Max(fig.maxX, pixel.x);
                fig.maxY = Math.Max(fig.maxY, pixel.y);
            }

            void AddPixelToTurnOrContour(int y, int x)
            {
                if ( MustWeAddPixelToTurn(y, x) )
                {
                    AddPixelToTurn(y, x);
                }
                else if ( MustWeAddPixelToContour(y, x) )
                {
                    AddPixelToContour(y, x);
                }
            }
        }

        /*-----------------------------------------------------*/

        public bool IsPixel(int y, int x)
        {
            return x >= 0 && y >= 0 && x < pixelsM.GetLength(1) && y < pixelsM.GetLength(0);
        }

        /*-----------------------------------------------------*/

        public void ClearFromNoise()
        {
            if (CountOfNoiseSuppression == 0)
                return;

            // int oldCount = locker.counter;

            // locker.counter = locker.counter;


            LinkedListNode<Figure<COLOUR>> figureNode, nextFigureNode;

            for (
                    figureNode = figureList.First;
                    figureNode != null;
                    figureNode = nextFigureNode
                )
            {
                Figure<COLOUR> figure = figureNode.Value;

                nextFigureNode = figureNode.Next;

                LinkedList<(Pixel<COLOUR>, Figure<COLOUR>)> distributedPixels
                                                            = MapOfDistributedPixelsOrNull(figure);

                if (distributedPixels != null)
                {
                    foreach ( (Pixel<COLOUR> pixel, Figure<COLOUR> newFigure) in distributedPixels )
                    {
                        pixel.figure = newFigure;
                        newFigure.pixels.AddLast(pixel);
                    }

                    figureList.Remove(figureNode);
                }
            }

            // locker.counter = locker.counter;
        }

        public LinkedList<(Pixel<COLOUR>, Figure<COLOUR>)> MapOfDistributedPixelsOrNull(Figure<COLOUR> figure)
        {
            LinkedList<(Pixel<COLOUR>, Figure<COLOUR>)> resultList = new LinkedList<(Pixel<COLOUR>, Figure<COLOUR>)>();

            if (figure.countOfPixels > CountOfNoiseSuppression)
                return null;

            foreach (Pixel<COLOUR> pixel in figure.pixels)
            {
                Pixel<COLOUR> neighbourPixel = WhichPixelUnionWith(pixel, this);

                if (neighbourPixel == null)
                    return null;

                resultList.AddLast((pixel, neighbourPixel.figure));
            }

            return resultList;
        }

        /*-----------------------------------------------------*/

        public Image RecolorImage(List<Color> colors)
        {
            if (isContourRecognition)
            {
                return RecolorImageWithContours();
            }
            else
            {
                return RecolorImageWithFigure(colors);
            }
        }

        public Image RecolorImageWithContours()
        {
            bitmapOut = bitmapIn.Clone() as Bitmap;

            for(int y = 0; y < bitmapOut.Height; y++)
            {
                for (int x = 0; x < bitmapOut.Width; x++)
                {
                    bitmapOut.SetPixel(x, y, Color.White);
                }
            }

            foreach (Figure<COLOUR> figure in figureList)
            {
                foreach (var (pixel, _) in figure.contourPixels)
                {
                    bitmapOut.SetPixel(pixel.x, pixel.y, Color.Black);
                }
            }

            return bitmapOut;
        }

        public Image RecolorImageWithFigure(List<Color> colors)
        {
            colors = SetColors(colors);

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

        public List<Color> SetColors(List<Color> colors)
        {
            if (colors != null)
                return null;

            Random r = new Random();

            int size = 50 + r.Next(50);

            colors = new List<Color>(size);

            for (int i = 0; i < size; i++)
            {
                colors.Add(Color.FromArgb(0xff, r.Next(0, 0x100), r.Next(0, 0x100), r.Next(0, 0x100)));
            }

            return colors;
        }
    }
}
