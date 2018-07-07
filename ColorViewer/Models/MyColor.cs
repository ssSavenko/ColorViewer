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
        private int red;
        private int green;
        private int blue;

        public int Alpha
        {
            get { return alpha; }
            set
            {
                if (0 < value && value <= 255)
                {
                    alpha = value;
                }
            }
        }
    }
}
