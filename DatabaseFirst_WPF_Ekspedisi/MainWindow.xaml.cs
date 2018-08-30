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

        private void login_Click(object sender, RoutedEventArgs e)
        {

            string username, password;

            username = this.usernamebox.Text;
            password = this.passwordBox.Password;

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login Success !");
                this.Hide();
                dasboard das = new dasboard();
                das.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Username or password.\nPlease Try Again.");
            }
        }
    }
}
