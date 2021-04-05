using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition
{
    public struct HSV
    {
        public decimal H;
        public decimal S;
        public decimal V;
        public HSV(decimal h, decimal s, decimal v)
        {
            if (h > 1 || h < 0)
                throw new ArgumentOutOfRangeException($"h does not belong to the interval [0, 1]");

            if (s > 1 || s < 0)
                throw new ArgumentOutOfRangeException($"s does not belong to the interval [0, 1]");

            if (v > 1 || v < 0)
                throw new ArgumentOutOfRangeException($"v does not belong to the interval [0, 1]");

            H = h; S = s; V = v;
        }

        public HSV(Color c)
        {
            decimal var_R = (c.R / 255);
            decimal var_G = (c.G / 255);
            decimal var_B = (c.B / 255);

            decimal var_Min = Math.Min(var_R, Math.Min(var_G, var_B));    //Min. value of RGB
            decimal var_Max = Math.Max(var_R, Math.Max(var_G, var_B));    //Max. value of RGB
            decimal del_Max = var_Max - var_Min;             //Delta RGB value

            V = var_Max;

            if (del_Max == 0)                     //This is a gray, no chroma...
            {
                H = 0;
                S = 0;
            }
            else                                    //Chromatic data...
            {
                S = del_Max / var_Max;

                decimal del_R = (((var_Max - var_R) / 6) + (del_Max / 2)) / del_Max;
                decimal del_G = (((var_Max - var_G) / 6) + (del_Max / 2)) / del_Max;
                decimal del_B = (((var_Max - var_B) / 6) + (del_Max / 2)) / del_Max;

                if (var_R == var_Max) H = del_B - del_G;
                else if (var_G == var_Max) H = (1 / 3) + del_R - del_B;
                else /*if (var_B == var_Max)*/ H = (2 / 3) + del_G - del_R;

                if (H < 0) H += 1;
                if (H > 1) H -= 1;
            }
        }

        public Color toColor()
        {
            int R, G, B;

            if (S == 0)
            {
                R = (int)(V * 255);
                G = (int)(V * 255);
                B = (int)(V * 255);
}
            else
            {
                int var_h = (int)(H * 6);
                if (var_h == 6) var_h = 0;      //H must be < 1
                int var_i = (int)var_h;             //Or ... var_i = floor( var_h )
                int var_1 = (int)( V * (1 - S) );
                int var_2 = (int)( V * (1 - S * (var_h - var_i)) );
                int var_3 = (int)( V * (1 - S * (1 - (var_h - var_i))) );

                int var_r, var_g, var_b;
            
                if (var_i == 0) { var_r = (int) V; var_g = var_3; var_b = var_1; }
                else if (var_i == 1) { var_r = var_2; var_g = (int) V; var_b = var_1; }
                else if (var_i == 2) { var_r = var_1; var_g = (int) V; var_b = var_3; }
                else if (var_i == 3) { var_r = var_1; var_g = var_2; var_b = (int) V; }
                else if (var_i == 4) { var_r = var_3; var_g = var_1; var_b = (int) V; }
                else { var_r = (int) V; var_g = var_1; var_b = var_2; }

                R = var_r * 255;
                G = var_g * 255;
                B = var_b * 255;
            }

            return Color.FromArgb(R, G, B);
        }
    }
}
