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

namespace Greet_a_person_using_WPF
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

        private void btngm_Click(object sender, RoutedEventArgs e)
        {
            string name = txtname.Text;
            try {
                  lbldisplay.Content = "Good Morning " + name + ", have a nice day"; }
            finally { txtname.Text = "Enter a name"; }
        }

        private void btnga_Click(object sender, RoutedEventArgs e)
        {
            try
            {   string name = txtname.Text;
                lbldisplay.Content = "Good Afternoon " + name + ", have a nice day"; }
            finally { txtname.Text = "Enter a name"; }
        }

        private void btnge_Click(object sender, RoutedEventArgs e)
        {            
            try { string name = txtname.Text;
                  lbldisplay.Content = "Good Evening " + name + ", have a nice day"; }
            finally { txtname.Text = "Enter a name"; }
        }
    }
}
