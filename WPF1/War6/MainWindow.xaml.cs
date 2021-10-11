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

namespace War7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            double a = rand.Next(10, 100);
            label.Content = "Случайно сгененрированное число: " + a;
            label1.Content = "Сумма числе: " + Math.Truncate(a % 10 + a/10);
            label2.Content = "Произведение чисел: " + a % 10 * Math.Truncate(a / 10);
        }
    }
}
