using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestockingFee
{
    public class ColorGenerator
    {
        public static Color GenerateColor(double timeElapsed, double timeLimit, bool successed)
        {
            Color generatedColor = Color.White;
            if (timeElapsed < timeLimit)
            {
                timeElapsed /= timeLimit;
                timeElapsed *= 128;
                int variableColor = 127 + (int)timeElapsed;

                if (successed)
                    generatedColor = Color.FromArgb(variableColor, 255, variableColor);
                else
                    generatedColor = Color.FromArgb(255, variableColor, variableColor);
            }
            return generatedColor;
        }
    }
}
