using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternRecognition
{
    public class ManagerOfPatternRecognComputation
    {
        public string ColorPalette { get; set; } = "white/black";

        public Image ImageIn { get; set; } = null;

        public List<Color> NewColorsOfFigures { get; set; } = null;

        /*-----------------*/

        public dynamic PatternRecognResult { get; private set; } = null;

        public Image ImageOut { get; private set; } = null;

        public TimeSpan TimeOfWork { get; private set; } = default;

        /*-----------------*/

        public void Computate()
        {
            DateTime time = DateTime.Now;

            switch (ColorPalette)
            {
                case "white/black":
                    {
                        PatternRecognResult

                            = new TemplateComputationOfPatternRecognition<bool>(
                                color => ((color.ToArgb() & 0xFFFFFF) >= 0x888888),
                                cort => (cort.Item1 != cort.Item2)
                            );
                    }
                    break;


                case "multycolor":
                    {
                        PatternRecognResult

                            = new TemplateComputationOfPatternRecognition<Color>(
                                color => color,
                                cort => (cort.Item1 != cort.Item2)
                            );
                    }
                    break;


                case "multycolor with smooth border":
                    {
                        PatternRecognResult

                            = new TemplateComputationOfPatternRecognition<Color>(
                                color => color,
                                cort => (
                                            Math.Abs(cort.Item1.R - cort.Item2.R) > 30 ||
                                            Math.Abs(cort.Item1.G - cort.Item2.G) > 30 ||
                                            Math.Abs(cort.Item1.B - cort.Item2.B) > 30
                                        )
                            );
                    }
                    break;

                default:
                    {
                        var rightValueOfColorPalette = new List<string>
                        {
                            "white/black",
                            "multycolor",
                            "multycolor with smooth border"
                        };

                        throw new ArgumentException($"\"{ColorPalette}\" is invalid value for argument. \n" +
                            "There are right values of this property: \n" + String.Join("\n", rightValueOfColorPalette));
                    }
            }


            PatternRecognResult.CreatePointsArrFromImage(ImageIn);

            PatternRecognResult.CreateFreePixelsAndPixelsM();

            PatternRecognResult.GroupPixelsByFigures();

            ImageOut = PatternRecognResult.RecolorImage(NewColorsOfFigures);

            TimeOfWork = DateTime.Now - time;

        }
    }
}
