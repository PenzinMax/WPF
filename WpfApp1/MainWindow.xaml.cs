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

namespace WpfApp1
{
    public partial class MainWindow : Window

    {
        public MainWindow()
        {
            InitializeComponent();

            textBox1.Text = "2";
            textBox2.Text = "8";
            textBox3.Text = "16";
        }

        private void Button2(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            textBox1.Text = (number * 2).ToString();
        }

        private void Button8(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(textBox2.Text);
            textBox2.Text = (number * 8).ToString();
        }

        private void Button16(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(textBox3.Text);
            textBox3.Text = (number * 16).ToString();
        }
    }
}
