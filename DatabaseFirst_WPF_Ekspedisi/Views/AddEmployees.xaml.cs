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

namespace DatabaseFirst_WPF_Ekspedisi.Pages
{
    /// <summary>
    /// Interaction logic for AddEmployees.xaml
    /// </summary>
    public partial class AddEmployees : Window
    {
        public AddEmployees()
        {
            InitializeComponent();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow hasil = new MainWindow();
            hasil.ShowDialog();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            EmployeesController controller = new EmployeesController();
            string data1 = namebox.Text;
            string data2 = positionbox.Text;
            string data3 = usernamebox.Text;
            string data4 = passwordbox.Text;
            controller.Insert(data1,data2,data3,data4);
            MessageBox.Show("Register Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
        }
    }
}
