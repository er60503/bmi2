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

namespace WpfApplication2
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double h = double.Parse(heightbox .Text );
            double w = double.Parse(weightbox .Text );
            double bmi = w / (h * h);
        }

        private void heightbar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            heightbox.Text = heightbar.Value.ToString();
            double h = double.Parse(heightbox.Text)/100;
            double w = double.Parse(weightbox.Text);
            double bmi = w / (h * h);
            answer.Text =bmi.ToString();
        }

        private void weightbar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            weightbox.Text = weightbar.Value.ToString();
            double h = double.Parse(heightbox.Text)/100;
            double w = double.Parse(weightbox.Text);
            double bmi = w / (h * h);
            answer.Text = bmi.ToString();
        }
    }
}
