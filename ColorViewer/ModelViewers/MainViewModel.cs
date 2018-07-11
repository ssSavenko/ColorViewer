using ColorViewer.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace ColorViewer.ModelViewers
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private Command addNewListElement;
        private MyColorWithId currentColor;
        private bool isAlphaSliderEnable;
        private bool isBlueSliderEnable;
        private bool isGreenSliderEnable;
        private bool isRedSliderEnable;
        private ObservableCollection<MyColorWithId> savedColors;

        public MainViewModel()
        {
            addNewListElement = new DelegateCommand(AddColor);
            currentColor = new MyColorWithId(0);
            currentColor.Alpha = 255;
            savedColors = new ObservableCollection<MyColorWithId>();
            savedColors.Add(new MyColorWithId(0, currentColor));
        }

        public bool IsAddButtonEnable
        {
            get
            {
                bool isButtonEnable = true;
                for (int i = 0; i < savedColors.Count; i++)
                {
                    if (savedColors[i].Equals(currentColor))
                    {
                        isButtonEnable = false;
                    }
                }
                return isButtonEnable;
            }
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
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(IsAddButtonEnable)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(currentColor)));
            }
        }

        public int CurrentBlueColor
        {
            get { return currentColor.Blue; }
            set
            {
                currentColor.Blue = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(IsAddButtonEnable)));
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
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(IsAddButtonEnable)));
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
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(IsAddButtonEnable)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentRedColor)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(currentColor)));
            }
        }
        
        public ObservableCollection<MyColorWithId> SavedColors
        {
            get { return savedColors; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        public ICommand AddNewListElement() => addNewListElement;

        public void AddColor()
        {
            savedColors.Add(currentColor);
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(IsAddButtonEnable)));
        }
    }
}
