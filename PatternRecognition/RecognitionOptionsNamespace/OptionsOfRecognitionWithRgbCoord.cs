using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition.RecognitionOptionsNamespace
{
    public class OptionsOfRecognitionWithRgbCoord : OptionsOfRecognitionWithSmoothBorders
    {
        public int MaxLen { get; set; }

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
            get => (Predicate<(Color, Color)>)(cort => Math.Sqrt(
                                                                    Math.Pow(cort.Item1.R - cort.Item2.R, 2) +
                                                                    Math.Pow(cort.Item1.G - cort.Item2.G, 2) +
                                                                    Math.Pow(cort.Item1.B - cort.Item2.B, 2)
                                                                ) > MaxLen
                                            );
            set { }
        }
    }
}
