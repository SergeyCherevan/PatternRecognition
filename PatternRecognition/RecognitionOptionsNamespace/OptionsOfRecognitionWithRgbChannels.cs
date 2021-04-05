using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition.RecognitionOptionsNamespace
{
    public class OptionsOfRecognitionWithRgbChannels : OptionsOfRecognitionWithSmoothBorders
    {
        public int MaxDifR { get; set; }
        public int MaxDifG { get; set; }
        public int MaxDifB { get; set; }
        public int MinCountOfChannels { get; set; }

        public override Type COLOUR
        {
            get => typeof(Color);
            set { }
        }

        public override MulticastDelegate ColourFunc
        {
            get => (Func<Color, Color>)(color => color);
            set { }
        }

        public override MulticastDelegate DifBeetwinColours
        {
            get => (Predicate<(Color, Color)>)(cort =>
                                                        {
                                                            int isDifR = Math.Abs(cort.Item1.R - cort.Item2.R) > MaxDifR ? 1 : 0;
                                                            int isDifG = Math.Abs(cort.Item1.G - cort.Item2.G) > MaxDifG ? 1 : 0;
                                                            int isDifB = Math.Abs(cort.Item1.B - cort.Item2.B) > MaxDifB ? 1 : 0;

                                                            return isDifR + isDifG + isDifB >= MinCountOfChannels;
                                                        }
                                            );
            set { }
        }
    }
}
