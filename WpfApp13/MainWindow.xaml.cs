using Osztályok;
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


namespace WpfApp13
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

        private void rdoKocka_Checked(object sender, RoutedEventArgs e)
        {
            txtAel.Text = "10";
            txtBel.Text = "10";
            txtCel.Text = "10";
            txtAel.IsEnabled=false;
            txtBel.IsEnabled=false;
            txtCel.IsEnabled=false;
        }

        private void rdoTeglatest_Checked(object sender, RoutedEventArgs e)
        {
            txtAel.IsEnabled = true;
            txtBel.IsEnabled = true;
            txtCel.IsEnabled = true;
            txtAel.Text = "";
            txtBel.Text = "";
            txtCel.Text = "";
        }

        private void btntolt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Convert.ToDouble(txtMennyitTolt.Text);
            }
            catch (Exception hiba)
            {

                MessageBox.Show("Számot kell megadni!");
            }
        }
    }
}
