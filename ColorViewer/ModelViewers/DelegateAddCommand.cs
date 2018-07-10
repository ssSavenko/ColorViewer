using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ColorViewer.Models;

namespace ColorViewer.ModelViewers
{
    internal class DelegateAddCommand : Command
    {

        private MyColorWithId currentColor;
        private ObservableCollection<MyColorWithId> savedColors;

        public DelegateAddCommand(ref MyColorWithId currentColor,ref ObservableCollection<MyColorWithId> savedColors)
        {
            this.currentColor = currentColor;
            this.savedColors = savedColors;
        }

        public override void Execute()
        {
            savedColors.Add(currentColor);
        }
    }
}
