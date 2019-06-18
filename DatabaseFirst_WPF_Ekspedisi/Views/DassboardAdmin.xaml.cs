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
using System.Windows.Shapes;
using DatabaseFirst_WPF_Ekspedisi.Models;
using System.Data.Entity.Validation;
using DatabaseFirst_WPF_Ekspedisi.Controllers;
using DatabaseFirst_WPF_Ekspedisi.Views;

namespace DatabaseFirst_WPF_Ekspedisi.Pages
{
    /// <summary>
    /// Interaction logic for DassboardAdmin.xaml
    /// </summary>
    public partial class DassboardAdmin : Window
    {
        public DassboardAdmin()
        {
            InitializeComponent();
        }

        private void app_master_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void app_master_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ManageApps ma = new ManageApps();
            ma.Show();
        }

        private void shipping_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Shipping_DetailShipping shi = new Shipping_DetailShipping();
            shi.Show();
        }

        private void tracking_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            TrackingItems shi = new TrackingItems();
            shi.Show();
        }
    }
}
