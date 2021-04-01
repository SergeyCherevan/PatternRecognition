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
        public enum VariantOfPatternRecognition
        {
            White_Black,
            Multycolor,
            MultycolorWithSmoothBorder,
        }

        public VariantOfPatternRecognition Variant { get; set; } = VariantOfPatternRecognition.White_Black;

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

            switch (Variant)
            {
                case VariantOfPatternRecognition.White_Black:
                    {
                        PatternRecognResult

                            = new TemplateComputationOfPatternRecognition<bool>(
                                color => ((color.ToArgb() & 0xFFFFFF) >= 0x888888),
                                cort => (cort.Item1 != cort.Item2)
                            );
                    }
                    break;


                case VariantOfPatternRecognition.Multycolor:
                    {
                        PatternRecognResult

                            = new TemplateComputationOfPatternRecognition<Color>(
                                color => color,
                                cort => (cort.Item1 != cort.Item2)
                            );
                    }
                    break;


                case VariantOfPatternRecognition.MultycolorWithSmoothBorder:
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

                        throw new Exception($"\"Method Computate() can not processed value {Variant} as variant of pattern recognition.");
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
