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
    /// Interaction logic for AddCategory.xaml
    /// </summary>
    public partial class AddCategory : Window
    {
        ExpeditionEntities context = new ExpeditionEntities();
        public AddCategory()
        {
            InitializeComponent();
        }

        private void cancelC_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();
            ManageApps ma = new ManageApps();
            ma.Show();
        }

        private void saveC_Click(object sender, RoutedEventArgs e)
        {
            CategoryController controller = new CategoryController();
            string data1 = addnameboxC.Text;
            controller.Insert(data1);
            MessageBox.Show("Insert data Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();

        }
    }
}
