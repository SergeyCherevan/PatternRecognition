using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition.RecognitionOptionsNamespace
{
    public class OptionsOfRecognitionWithSharpBorder : RecognitionOptions
    {
        public override Type COLOUR
        {
            get => typeof(Color);
            set { }
        }

        public override MulticastDelegate ColourFunc 
        {
            get => (Func<Color, Color>)( color => color );
            set { }
        }

        public override MulticastDelegate DifBeetwinColours
        {
            get => (Predicate<(Color, Color)>)( cort => cort.Item1 != cort.Item2 );
            set { }
        }
    }
}
