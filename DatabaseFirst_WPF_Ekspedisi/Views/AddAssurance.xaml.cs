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
using DatabaseFirst_WPF_Ekspedisi.Controllers;
using DatabaseFirst_WPF_Ekspedisi.Pages;
using DatabaseFirst_WPF_Ekspedisi.Models;

namespace DatabaseFirst_WPF_Ekspedisi.Views
{
    /// <summary>
    /// Interaction logic for AddAssurance.xaml
    /// </summary>
    public partial class AddAssurance : Window
    {
        ExpeditionEntities context = new ExpeditionEntities();
        public AddAssurance()
        {
            InitializeComponent();
        }

        private void saveA_Click(object sender, RoutedEventArgs e)
        {
            AssuranceController controller = new AssuranceController();
            string data1 = addtypeA.Text;
            int data2 = Convert.ToInt32(addpriceA.Text);
            controller.Insert(data1, data2);
            MessageBox.Show("Insert data Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
        }

        private void cancelA_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ManageApps ma = new ManageApps();
            ma.Show();

        }
    }
}
