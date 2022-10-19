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

namespace messageBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(fn.Text);
            int b = int.Parse(sn.Text);
            int result = a + b;

            MessageBox.Show(result.ToString(), "Result of addition");
        }
    }
}
