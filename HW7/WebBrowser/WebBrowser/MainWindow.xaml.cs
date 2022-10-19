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

namespace WebBrowser
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
        private void forward_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wb.GoForward();
            }
            catch (Exception) { MessageBox.Show("No initial Forward", "Error"); }
        }
        private void search_Click(object sender, RoutedEventArgs e)
        {
            try { wb.Navigate(input.Text); }
            catch (Exception) { MessageBox.Show("Invalid Search", "Error"); }
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            try { wb.GoBack(); }
            catch (Exception) { MessageBox.Show("No initial Back", "Error"); }
        }
        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wb.Refresh();
            }
            catch (Exception) { MessageBox.Show("No initial Back", "Error"); }
        }
    }
}
