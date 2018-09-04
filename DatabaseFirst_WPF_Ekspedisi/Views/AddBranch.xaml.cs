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
    /// Interaction logic for AddBranch.xaml
    /// </summary>
    public partial class AddBranch : Window
    {

        ExpeditionEntities context = new ExpeditionEntities();
        public AddBranch()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            BranchController controller = new BranchController();
            string data1 = addnamebox.Text;
            string data2 = addprovincebox.Text;
            string data3 = addregencybox.Text;
            string data4 = addsubdistrictbox.Text;
            string data5 = addlocationbox.Text;
            int data6 = Convert.ToInt16(addwarehousebox.SelectedValue);
            controller.Insert(data1, data2, data3, data4, data5, data6);
            MessageBox.Show("Insert data Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            addwarehousebox.DisplayMemberPath = "TYPES";
            addwarehousebox.SelectedValuePath = "ID";
            addwarehousebox.ItemsSource = context.ASSURANCES.ToList();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ManageApps ma = new ManageApps();
            ma.Show();
        }
    }
}
