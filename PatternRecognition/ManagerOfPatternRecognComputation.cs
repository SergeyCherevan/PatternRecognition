using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PatternRecognition.RecognitionOptionsNamespace;

namespace PatternRecognition
{
    public class ManagerOfPatternRecognComputation
    {

        public RecognitionOptions RO { get; set; } = new OptionsOfBicolorRecognition();

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

            try
            {
                Type typeOfGenericComputationOfPatternRecognition
                    = typeof(TemplateComputationOfPatternRecognition<>);

                Type typeOfConstructedComputationOfPatternRecognition
                    = typeOfGenericComputationOfPatternRecognition.MakeGenericType(new Type[] { RO.COLOUR });

                PatternRecognResult = typeOfConstructedComputationOfPatternRecognition
                    .GetConstructor(new Type[] { typeof(RecognitionOptions) })
                    .Invoke(new object[] { RO });

                PatternRecognResult.CreatePointsArrFromImage(ImageIn);

                PatternRecognResult.CreateFreePixelsAndPixelsM();

                PatternRecognResult.GroupPixelsByFigures();

                ImageOut = PatternRecognResult.RecolorImage(NewColorsOfFigures);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nВ стеке вызовов:\n" + ex.StackTrace, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            TimeOfWork = DateTime.Now - time;

        }
    }
}
