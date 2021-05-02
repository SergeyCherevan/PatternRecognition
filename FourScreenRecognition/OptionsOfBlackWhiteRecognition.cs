using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition.RecognitionOptionsNamespace
{
    public class OptionsOfBlackWhiteRecognition : RecognitionOptions
    {
        public double MaxLen { get; set; }

        public delegate Pixel<double> WhichPixelUnionWithDelegate
            (Pixel<double> p, TemplateComputationOfPatternRecognition<double> tcpr);

        public override Type COLOUR
        {
            get => typeof(double);
            set { }
        }

        public override MulticastDelegate ColourFunc
        {
            get => (Func<Color, double>)(color => (double)(color.R + color.G + color.B) / 3);
            set { }
        }

        public override MulticastDelegate DifBeetwinColours
        {
            get => (Predicate<(double, double)>)(cort => Math.Abs(cort.Item1 - cort.Item2) > MaxLen
                                            );
            set { }
        }

        public override MulticastDelegate WhichPixelUnionWith
        {
            get => (WhichPixelUnionWithDelegate)((p, tcpr) =>
            {
                List<Pixel<double>> pixelsList = new List<Pixel<double>>(4);



                if (tcpr.IsPixel(p.y, p.x - 1) && p.figure != tcpr.pixelsM[p.y, p.x - 1].figure)

                    pixelsList.Add(tcpr.pixelsM[p.y, p.x - 1]);


                if (tcpr.IsPixel(p.y - 1, p.x) && p.figure != tcpr.pixelsM[p.y - 1, p.x].figure)

                    pixelsList.Add(tcpr.pixelsM[p.y - 1, p.x]);


                if (tcpr.IsPixel(p.y, p.x + 1) && p.figure != tcpr.pixelsM[p.y, p.x + 1].figure)

                    pixelsList.Add(tcpr.pixelsM[p.y, p.x + 1]);


                if (tcpr.IsPixel(p.y + 1, p.x) && p.figure != tcpr.pixelsM[p.y + 1, p.x].figure)

                    pixelsList.Add(tcpr.pixelsM[p.y + 1, p.x]);


                if (pixelsList.Count == 0) return null;

                pixelsList.Sort((p1, p2) => Math.Abs(p1.color - p.color) > Math.Abs(p2.color - p.color) ? 1 :
                                            Math.Abs(p1.color - p.color) < Math.Abs(p2.color - p.color) ? -1 : 0
                               );

                return pixelsList[0];
            });

            set { }        
        }


    }
}
