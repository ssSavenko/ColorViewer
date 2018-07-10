using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorViewer.Models
{
    internal class MyColorWithId : MyColor
    {
        private readonly int id;

        public MyColorWithId(int id)
        {
            this.id = id;
        }

        public MyColorWithId(int id, MyColor color) : base(color)
        {
            this.id = id;
        }

        public int ID
        {
            get { return id; }
        }

        public bool Equals(MyColorWithId color)
        {
            bool isEqual = false;
            if (this.ColorInHex.Equals(color.ColorInHex))
            {
                isEqual = true;
            }
            return isEqual;
        }
    }
}
