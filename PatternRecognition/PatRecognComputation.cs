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
    public class PatRecognComputation
    {

        static public Image Computate(Image image)
        {
            DateTime time = DateTime.Now;

            TemplatePatternRecognition<bool> patRec
                = new TemplatePatternRecognition<bool>(
                        color => ((color.ToArgb() & 0xFFFFFF) >= 0x888888),
                        cort => (cort.Item1 != cort.Item2)
                    );

            patRec.CreatePointsArrFromImage(image);

            patRec.CreateFreePixelsAndPixelsM();

            patRec.GroupPixelsByFigures();

            MessageBox.Show($"Count of figures on Image without background: {patRec.figList.Count - 1} \n\n" +
                $"Image size: {image.Width}x{image.Height} \n\n" +
                $"Time: {Math.Round((DateTime.Now - time).TotalSeconds, 2)} seconds");

            return null;
        }
    }
}
