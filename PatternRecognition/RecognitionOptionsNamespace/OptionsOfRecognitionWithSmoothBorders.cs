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
        public delegate Pixel<Color> WhichPixelUnionWithDelegate
            (Pixel<Color> p, TemplateComputationOfPatternRecognition<Color> tcpr);
        public OptionsOfRecognitionWithSmoothBorders()
        {
            _COLOUR = typeof(Color);
            _ColourFunc = (Func<Color, Color>)(color => color);

            _WhichPixelUnionWith = (WhichPixelUnionWithDelegate)((p, tcpr) =>
            {
                if (tcpr.IsPixel(p.y, p.x - 1))
                    return tcpr.pixelsM[p.y, p.x - 1];
                else
                    return tcpr.pixelsM[p.y, p.x + 1];
            });
        }
    }
}
