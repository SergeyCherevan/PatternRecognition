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



        public delegate Pixel<Color> WhichPixelUnionWithDelegate
            (Pixel<Color> p, TemplateComputationOfPatternRecognition<Color> tcpr);

        public OptionsOfRecognitionWithSharpBorder()
        {
            _WhichPixelUnionWith = (WhichPixelUnionWithDelegate)( (p, tcpr) =>
                                                                  {
                                                                      if (tcpr.IsPixel(p.y, p.x - 1))
                                                                          return tcpr.pixelsM[p.y, p.x - 1];
                                                                      else
                                                                          return tcpr.pixelsM[p.y, p.x + 1];
                                                                  } );
        }
    }
}
