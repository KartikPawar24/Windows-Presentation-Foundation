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

namespace Generate_Random_Numbers
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

        private void btnran_Click(object sender, RoutedEventArgs e)
        {
            int data = Convert.ToInt16(txtnum.Text);
            Random rannum = new Random();
            int res = rannum.Next(1, data);
            txtres.Text = res.ToString();
        }

        private void btnclr_Click(object sender, RoutedEventArgs e)
        {
            txtnum.Text = String.Empty;
            txtres.Text = String.Empty;
        }
    }
}
