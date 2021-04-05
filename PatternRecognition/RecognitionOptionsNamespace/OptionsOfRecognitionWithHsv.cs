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

        public OptionsOfRecognitionWithHsv()
        {
            _COLOUR = typeof(HSV);
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
