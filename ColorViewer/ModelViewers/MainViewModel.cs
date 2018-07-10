using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ColorViewer.ModelViewers
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private MyColor currentColor;
        private bool isAlphaSliderEnable;
        private bool isBlueSliderEnable;
        private bool isGreenSliderEnable;
        private bool isRedSliderEnable;
        private ObservableCollection<MyColor> SavedColors;

        public MainViewModel()
        {
            currentColor = new MyColor();
            currentColor.Alpha = 255;
            SavedColors = new ObservableCollection<MyColor>();
            SavedColors.Add(currentColor);
        }

        public bool IsAlphaSliderEnable
        {
            get { return !isAlphaSliderEnable; }
            set { isAlphaSliderEnable = value;
                OnPropertyChanged(new PropertyChangedEventArgs (nameof(IsAlphaSliderEnable)));
            }
        }

        public bool IsBlueSliderEnable
        {
            get { return !isBlueSliderEnable; }
            set
            {
                isBlueSliderEnable = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(IsBlueSliderEnable)));
            }
        }

        public bool IsGreenSliderEnable
        {
            get { return !isGreenSliderEnable; }
            set
            {
                isGreenSliderEnable = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(IsGreenSliderEnable)));
            }
        }

        public bool IsRedSliderEnable
        {
            get { return !isRedSliderEnable; }
            set
            {
                isRedSliderEnable = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(IsRedSliderEnable)));
            }
        }

        public int CurrentAlpha
        {
            get { return currentColor.Alpha; }
            set
            {
                currentColor.Alpha = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentAlpha)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(currentColor)));
                string mu = currentColor.ColorInHex;
            }
        }

        public int CurrentBlueColor
        {
            get { return currentColor.Blue; }
            set
            {
                currentColor.Blue = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentBlueColor)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(currentColor)));
            }
        }

        public string CurrentColor
        {
            get { return currentColor.ColorInHex; }
        }

        public int CurrentGreenColor
        {
            get { return currentColor.Green; }
            set
            {
                currentColor.Green = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentGreenColor)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(currentColor)));
            }
        }

        public int CurrentRedColor
        {
            get { return currentColor.Red; }
            set
            {
                currentColor.Red = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentRedColor)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(currentColor)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
