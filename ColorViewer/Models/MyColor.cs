using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorViewer.Models
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

        public MyColor(MyColor color)
        {
            alpha = color.Alpha;
            blue = color.Blue;
            green = color.Green;
            red = color.Red;
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

        public string ColorInHex
        {
            get
            {
                StringBuilder hexValue = new StringBuilder("#");
                string[] colorsInfo ={
                    alpha.ToString("X"),
                    red.ToString("X"),
                    green.ToString("X"),
                    blue.ToString("X")
                };

                for (int i = 0; i < colorsInfo.Length; i++)
                {

                    if (colorsInfo[i].Length < 2)
                    {
                        hexValue.Insert(hexValue.Length, "0");
                    }
                    hexValue.Insert(hexValue.Length, colorsInfo[i]);
                }
                return hexValue.ToString();
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
    }
}