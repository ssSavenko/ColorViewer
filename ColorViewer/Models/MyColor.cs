using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorViewer.ModelViewers
{
    internal class MyColor
    {
        private int alpha;
        private int blue;
        private int green;
        private int red;

        public MyColor()
        {
            alpha = 0;
            blue = 0;
            green = 0;
            red = 0;
        }

        public int Alpha
        {
            get { return alpha; }
            set
            {
                if (0 <= value && value <= 255)
                {
                    alpha = value;
                }
            }
        }

        public int Blue
        {
            get { return blue; }
            set
            {
                if (0 <= value && value <= 255)
                {
                    blue = value;
                }
            }
        }

        public int Green
        {
            get { return green; }
            set
            {
                if (0 <= value && value <= 255)
                {
                    green = value;
                }
            }
        }

        public int Red
        {
            get { return red; }
            set
            {
                if (0 <= value && value <= 255)
                {
                    red = value;
                }
            }
        }

        public string ColorInHex
        {
            get
            {
                string hexValue = "#";
                string alphaValue = alpha.ToString("X");

                if(alphaValue.Length < 2)
                {
                    hexValue += "0";
                }
                hexValue += alphaValue;

                string redValue = red.ToString("X");
                if (redValue.Length < 2)
                {
                    hexValue += "0";
                }
                hexValue += redValue;

                string greenValue = green.ToString("X");
                if (greenValue.Length < 2)
                {
                    hexValue += "0";
                }
                hexValue += greenValue;

                string blueValue = blue.ToString("X");
                if (blueValue.Length < 2)
                {
                    hexValue += "0";
                }
                hexValue += blueValue;
                return hexValue;
            }
        }
    }
}