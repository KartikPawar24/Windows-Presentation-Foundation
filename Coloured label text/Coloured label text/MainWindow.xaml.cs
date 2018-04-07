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

namespace Coloured_label_text
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

        private void btnred_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked Red");
            lblblue.Content = String.Empty;
            lblgreen.Content = String.Empty;
            lblviolet.Content = String.Empty;
        }

        private void btnblue_Click(object sender, RoutedEventArgs e)
        {
            lblred.Content = String.Empty;
            MessageBox.Show("You clicked Blue");
            lblgreen.Content = String.Empty;
            lblviolet.Content = String.Empty;
        }

        private void btngreen_Click(object sender, RoutedEventArgs e)
        {
            lblred.Content = String.Empty; ;
            lblblue.Content = String.Empty;
            lblgreen.Content = "You clicked Green";
            lblviolet.Content = String.Empty;
        }

        private void btnviolet_Click(object sender, RoutedEventArgs e)
        {
            lblred.Content = String.Empty; ;
            lblblue.Content = String.Empty;
            lblgreen.Content = String.Empty;
            lblviolet.Content = "You clicked Violet";
        }
    }
}
