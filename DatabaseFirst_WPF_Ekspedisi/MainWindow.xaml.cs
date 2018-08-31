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
using DatabaseFirst_WPF_Ekspedisi.Pages;

namespace DatabaseFirst_WPF_Ekspedisi
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

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        EmployeesController employeeC = new EmployeesController();
        private void login_Click(object sender, RoutedEventArgs e)
        {
            
            if (employeeC.login(usernamebox.Text, passwordBox.Password) == true)
            {
                MessageBox.Show("Login Success", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Hide();
                DassboardAdmin admin = new DassboardAdmin();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username and Password not match", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                passwordBox.Clear();
                usernamebox.Clear();
                usernamebox.Focus();
            }
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddEmployees addemployee = new AddEmployees();
            addemployee.ShowDialog();
        }
    }
}
