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
    /// Interaction logic for AddWarehouse.xaml
    /// </summary>
    public partial class AddWarehouse : Window
    {
        ExpeditionEntities2 context = new ExpeditionEntities2();
        public AddWarehouse()
        {
            InitializeComponent();
        }

        private void saveW_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            WarehouseController controller = new WarehouseController();
            string data1 = addnameboxW.Text;
            string data2 = addprovinceboxW.Text;
            string data3 = addregencyboxW.Text;
            string data4 = addsubdistrictboxW.Text;
            string data5 = addlocationboxW.Text;
            controller.Insert(data1, data2, data3, data4, data5);
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

        private void cancelW_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ManageApps ma = new ManageApps();
            ma.Show();
        }
    }
}
