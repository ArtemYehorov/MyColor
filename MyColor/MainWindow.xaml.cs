using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyColor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public Color clr { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SliderRed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            VM.Color1Red = Convert.ToByte(value);
            clr = Color.FromArgb(VM.Color1Alpha,VM.Color1Red, VM.Color1Green, VM.Color1Blue);
            this.VM.ColorLabel = new SolidColorBrush(clr);
            // this.VM.ColorLabel = new SolidColorBrush(Color.FromArgb(VM.Color1Alpha, VM.Color1Red, VM.Color1Green, VM.Color1Blue));
        }

        private void SliderGreen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            VM.Color1Green = Convert.ToByte(value);
            clr = Color.FromArgb(VM.Color1Alpha, VM.Color1Red, VM.Color1Green, VM.Color1Blue);
            this.VM.ColorLabel = new SolidColorBrush(clr);
            //this.VM.ColorLabel = new SolidColorBrush(Color.FromArgb(VM.Color1Alpha, VM.Color1Red, VM.Color1Green, VM.Color1Blue));
        }

        private void SliderBlue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            VM.Color1Blue = Convert.ToByte(value);
            clr = Color.FromArgb(VM.Color1Alpha, VM.Color1Red, VM.Color1Green, VM.Color1Blue);
            this.VM.ColorLabel = new SolidColorBrush(clr);
            //this.VM.ColorLabel = new SolidColorBrush(Color.FromArgb(VM.Color1Alpha, VM.Color1Red, VM.Color1Green, VM.Color1Blue));
        }

        private void SliderAlpha_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            VM.Color1Alpha = Convert.ToByte(value);
            clr = Color.FromArgb(VM.Color1Alpha, VM.Color1Red, VM.Color1Green, VM.Color1Blue);
            this.VM.ColorLabel = new SolidColorBrush(clr);
            //this.VM.ColorLabel = new SolidColorBrush(Color.FromArgb(VM.Color1Alpha, VM.Color1Red, VM.Color1Green, VM.Color1Blue));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var r = new Button();
            ListColors list = new ListColors { Hexadecimal = VM.ColorLabel.Color.ToString() };
            r.Content = list.Hexadecimal;
            r.Background= new SolidColorBrush(clr);
            r.Click += R_Click;

            ListColorsH.Children.Add(r);
           
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            ListColorsH.Children.Remove(button);
        }
    }
}
