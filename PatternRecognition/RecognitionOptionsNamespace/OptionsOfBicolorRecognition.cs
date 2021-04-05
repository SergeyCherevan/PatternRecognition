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
        public delegate Pixel<bool> WhichPixelUnionWithDelegate
            (Pixel<bool> p, TemplateComputationOfPatternRecognition<bool> tcpr);
        public OptionsOfBicolorRecognition()
        {
            _ColourFunc = (Func<Color, bool>)(color => (color.ToArgb() & 0xFFFFFF) >= 0x888888);

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
