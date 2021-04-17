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
            _WhichPixelUnionWith = (WhichPixelUnionWithDelegate)((p, tcpr) =>
            {
                List<Pixel<Color>> pixelsList = new List<Pixel<Color>>(4);



                if (tcpr.IsPixel(p.y, p.x - 1) && p.figure != tcpr.pixelsM[p.y, p.x - 1].figure)

                    pixelsList.Add(tcpr.pixelsM[p.y, p.x - 1]);


                if (tcpr.IsPixel(p.y - 1, p.x) && p.figure != tcpr.pixelsM[p.y - 1, p.x].figure)

                    pixelsList.Add(tcpr.pixelsM[p.y - 1, p.x]);


                if (tcpr.IsPixel(p.y, p.x + 1) && p.figure != tcpr.pixelsM[p.y, p.x + 1].figure)

                    pixelsList.Add(tcpr.pixelsM[p.y, p.x + 1]);


                if (tcpr.IsPixel(p.y + 1, p.x) && p.figure != tcpr.pixelsM[p.y + 1, p.x].figure)

                    pixelsList.Add(tcpr.pixelsM[p.y + 1, p.x]);


                if (pixelsList.Count == 0) return null;

                pixelsList.Sort((p1, p2) => (int)(
                                          Math.Sqrt(
                                                  Math.Pow(p1.color.R - p.color.R, 2) +
                                                  Math.Pow(p1.color.G - p.color.G, 2) +
                                                  Math.Pow(p1.color.B - p.color.B, 2)
                                              )
                                        - Math.Sqrt(
                                                  Math.Pow(p2.color.R - p.color.R, 2) +
                                                  Math.Pow(p2.color.G - p.color.G, 2) +
                                                  Math.Pow(p2.color.B - p.color.B, 2)
                                              )
                                          )
                       );

                return pixelsList[0];
            });
        }
    }
}
