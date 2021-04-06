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
                if (tcpr.IsPixel(p.y, p.x - 1) && p.figure != tcpr.pixelsM[p.y, p.x - 1].figure)

                    return tcpr.pixelsM[p.y, p.x - 1];
                else
                if (tcpr.IsPixel(p.y - 1, p.x) && p.figure != tcpr.pixelsM[p.y - 1, p.x].figure)

                    return tcpr.pixelsM[p.y - 1, p.x];
                else
                if (tcpr.IsPixel(p.y, p.x + 1) && p.figure != tcpr.pixelsM[p.y, p.x + 1].figure)

                    return tcpr.pixelsM[p.y, p.x + 1];
                else
                if (tcpr.IsPixel(p.y + 1, p.x) && p.figure != tcpr.pixelsM[p.y + 1, p.x].figure)

                    return tcpr.pixelsM[p.y + 1, p.x];


                return null;
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
