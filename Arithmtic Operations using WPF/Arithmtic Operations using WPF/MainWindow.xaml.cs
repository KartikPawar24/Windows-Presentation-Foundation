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

namespace Arithmtic_Operations_using_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnclk.Click += Btnclk_Click;
        }

        private void Btnclk_Click(object sender, RoutedEventArgs e)
        {
            lblname.Content = "Thank You";
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtnum1.Text);
            double b = Convert.ToDouble(txtnum2.Text);
            double c = a + b;
            txtres.Text = c.ToString();
        }

        private void btnsub_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtnum1.Text);
            double b = Convert.ToDouble(txtnum2.Text);
            double c = a - b;
            txtres.Text = c.ToString();
        }

        private void btnmul_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtnum1.Text);
            double b = Convert.ToDouble(txtnum2.Text);
            double c = a * b;
            txtres.Text = c.ToString();
        }

        private void btndiv_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtnum1.Text);
            double b = Convert.ToDouble(txtnum2.Text);
            double c = a / b;
            txtres.Text = c.ToString();
        }

        private void btnrem_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtnum1.Text);
            double b = Convert.ToDouble(txtnum2.Text);
            double c = a % b;
            txtres.Text = c.ToString();
        }

        private void btnclr_Click(object sender, RoutedEventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtres.Text = "";

        }
    }
}
