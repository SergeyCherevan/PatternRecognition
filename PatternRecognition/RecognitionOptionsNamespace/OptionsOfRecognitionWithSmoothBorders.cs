using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition.RecognitionOptionsNamespace
{
    public class OptionsOfRecognitionWithSmoothBorders : RecognitionOptions
    {
        public OptionsOfRecognitionWithSmoothBorders()
        {
            _COLOUR = typeof(Color);
            _ColourFunc = (Func<Color, Color>)(color => color);
        }
    }
}
