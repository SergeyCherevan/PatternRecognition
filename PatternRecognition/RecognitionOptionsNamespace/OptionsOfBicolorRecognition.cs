using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition.RecognitionOptionsNamespace
{
    public class OptionsOfBicolorRecognition : RecognitionOptions
    {
        public OptionsOfBicolorRecognition()
        {
            _ColourFunc = (Func<Color, bool>)(color => (color.ToArgb() & 0xFFFFFF) >= 0x888888);
        }


        public override Type COLOUR
        {
            get => typeof(bool);
            set { }
        }

        public override MulticastDelegate DifBeetwinColours
        {
            get => (Predicate<(bool, bool)>)( cort => cort.Item1 != cort.Item2 );
            set { }
        }
    }
}
