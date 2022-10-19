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
        }
        int fn, sn;
        char op;
        private void three_Click(object sender, RoutedEventArgs e)
        {
            output.Text += "3";
        }
        private void nine_Click(object sender, RoutedEventArgs e)
        {
            output.Text += "9";

        }
        private void plus_Click(object sender, RoutedEventArgs e)
        {
            fn = int.Parse(output.Text);
            output.Text = "";
            op = '+';

        }
        private void minus_Click(object sender, RoutedEventArgs e)
        {
            fn = int.Parse(output.Text);
            output.Text = "";
            op = '-';
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            fn = int.Parse(output.Text);
            output.Text = "";
            op = '*';
        }
        private void divide_Click(object sender, RoutedEventArgs e)
        {
            fn = int.Parse(output.Text);
            output.Text = "";
            op = '/';
        }
        private void modulus_Click(object sender, RoutedEventArgs e)
        {
            fn = int.Parse(output.Text);
            output.Text = "";
            op = '%';
        }
        private void one_Click(object sender, RoutedEventArgs e)
        {
            output.Text += "1";
        }
        private void two_Click(object sender, RoutedEventArgs e)
        {
            output.Text += "2";

        }
        private void four_Click(object sender, RoutedEventArgs e)
        {
            output.Text += "4";

        }
        private void five_Click(object sender, RoutedEventArgs e)
        {
            output.Text += "5";

        }
        private void six_Click(object sender, RoutedEventArgs e)
        {
            output.Text += "6";

        }
       private void seven_Click(object sender, RoutedEventArgs e)
        {
            output.Text += "7";

        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            output.Text += "8";

        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            output.Text += "0";

        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            sn = int.Parse(output.Text);
            int res = 0;
            if (op == '+')
                res = fn + sn;
            else if (op == '-')
                res = fn - sn;
            else if (op == '*')
                res = fn * sn;
            else if (op == '/')
                res = fn / sn;
            else if (op == '%')
                res = fn % sn;

            output.Text = "";
            output.Text = res.ToString();
        }
    }
}
