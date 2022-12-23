
using System.ComponentModel;
using System.Reflection.Emit;
using System.Windows.Controls;
using System.Windows.Media;
using Label = System.Windows.Controls.Label;

namespace MyColor
{
    public class Color1ViewModel : INotifyPropertyChanged
    {
        
        private Color1 model;
      
        public Color1ViewModel()
        {
            model = new Color1 { Alpha = 0, Red = 0, Green = 0, Blue = 0};
        }

        public SolidColorBrush ColorLabel
        {
            get { return model.LColor; }
            set
            {
                model.LColor = value;
                OnPropertyChanged(nameof(ColorLabel));
            }
        }

        public byte Color1Alpha
        {
            get { return model.Alpha; }
            set
            {
                model.Alpha = value;
                OnPropertyChanged("ColorAlpha");
            }
        }

        public byte Color1Green
        {
            get { return model.Green; }
            set 
            {
                model.Green = value;
                OnPropertyChanged("ColorGreen");
            }
        }

        public byte Color1Red
        {
            get { return model.Red; }
            set
            {
                model.Red = value;
                OnPropertyChanged("ColorRed");
            }
        }

        public byte Color1Blue
        {
            get { return model.Blue; }
            set
            {
                model.Blue = value;
                OnPropertyChanged("ColorBlue");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }
        }
    }
}
