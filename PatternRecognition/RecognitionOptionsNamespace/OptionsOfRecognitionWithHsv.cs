using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition.RecognitionOptionsNamespace
{
    public class OptionsOfRecognitionWithHsv : OptionsOfRecognitionWithSmoothBorders
    {
        public decimal MaxDifH { get; set; }
        public decimal MaxDifS { get; set; }
        public decimal MaxDifV { get; set; }
        public int MinCountOfChannels { get; set; }


        public new delegate Pixel<HSV> WhichPixelUnionWithDelegate
            (Pixel<HSV> p, TemplateComputationOfPatternRecognition<HSV> tcpr);

        public OptionsOfRecognitionWithHsv()
        {
            _COLOUR = typeof(HSV);

            _WhichPixelUnionWith = (WhichPixelUnionWithDelegate)((p, tcpr) =>
            {
                List<Pixel<HSV>> pixelsList = new List<Pixel<HSV>>(4);



                if (tcpr.IsPixel(p.y, p.x - 1) && p.figure != tcpr.pixelsM[p.y, p.x - 1].figure)

                    pixelsList.Add(tcpr.pixelsM[p.y, p.x - 1]);


                if (tcpr.IsPixel(p.y - 1, p.x) && p.figure != tcpr.pixelsM[p.y - 1, p.x].figure)

                    pixelsList.Add(tcpr.pixelsM[p.y - 1, p.x]);


                if (tcpr.IsPixel(p.y, p.x + 1) && p.figure != tcpr.pixelsM[p.y, p.x + 1].figure)

                    pixelsList.Add(tcpr.pixelsM[p.y, p.x + 1]);


                if (tcpr.IsPixel(p.y + 1, p.x) && p.figure != tcpr.pixelsM[p.y + 1, p.x].figure)

                    pixelsList.Add(tcpr.pixelsM[p.y + 1, p.x]);


                if (pixelsList.Count == 0) return null;

                pixelsList.Sort((p1, p2) => (int)(
                                          Math.Sqrt(
                                                  Math.Pow((double)(p1.color.H - p.color.H), 2) +
                                                  Math.Pow((double)(p1.color.S - p.color.S), 2) +
                                                  Math.Pow((double)(p1.color.V - p.color.V), 2)
                                              )
                                        - Math.Sqrt(
                                                  Math.Pow((double)(p2.color.H - p.color.H), 2) +
                                                  Math.Pow((double)(p2.color.S - p.color.S), 2) +
                                                  Math.Pow((double)(p2.color.V - p.color.V), 2)
                                              )
                                          )
                       );

                return pixelsList[0];
            });
        }

        public override Type COLOUR
        {
            get => typeof(HSV);
            set { }
        }

        public override MulticastDelegate ColourFunc
        {
            get => (Func<Color, HSV>)( color => new HSV(color) );
            set { }
        }

        public override MulticastDelegate DifBeetwinColours
        {
            get => (Predicate<(HSV, HSV)>)(cort =>
            {
                int isDifH = Math.Abs(cort.Item1.H - cort.Item2.H) > MaxDifH ? 1 : 0;
                int isDifS = Math.Abs(cort.Item1.S - cort.Item2.S) > MaxDifS ? 1 : 0;
                int isDifV = Math.Abs(cort.Item1.V - cort.Item2.V) > MaxDifV ? 1 : 0;

                return isDifH + isDifS + isDifV >= MinCountOfChannels;
            }
                                            );
            set { }
        }
    }
}
