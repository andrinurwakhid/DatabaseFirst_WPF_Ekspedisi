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
    /// Interaction logic for AddStatShipping.xaml
    /// </summary>
    public partial class AddStatShipping : Window
    {
        ExpeditionEntities2 context = new ExpeditionEntities2();
        public AddStatShipping()
        {
            InitializeComponent();
        }

        private void saveSS_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            StatusShippingsController controller = new StatusShippingsController();
            string data1 = addnameboxSS.Text;
            controller.Insert(data1);
            MessageBox.Show("Insert data Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                System.Console.Write(ex.InnerException);
            }
        }

        private void cancelSS_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ManageApps ma = new ManageApps();
            ma.Show();

        }
    }
}
