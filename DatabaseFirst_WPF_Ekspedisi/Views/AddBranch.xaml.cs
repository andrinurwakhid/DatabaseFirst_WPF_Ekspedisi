﻿using System;
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

        ExpeditionEntities2 context = new ExpeditionEntities2();
        public AddBranch()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //BranchController controller = new BranchController();
            //string data1 = addnamebox.Text;
            //string data2 = addprovincebox.Text;
            //string data3 = addregencybox.Text;
            //string data4 = addsubdistrictbox.Text;
            //string data5 = addlocationbox.Text;
            //int data6 = Convert.ToInt16(addwarehousebox.SelectedValue);
            //int data7 = Convert.ToInt32(addpricebox.Text);
            //    controller.Insert(data1, data2, data3, data4, data5, data6, data7, data8, data9);
            //MessageBox.Show("Insert data Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            //this.Hide();
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show(ex.StackTrace);
            //    System.Console.Write(ex.InnerException);
            //}
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //addwarehousebox.DisplayMemberPath = "TYPES";
            //addwarehousebox.SelectedValuePath = "ID";
            //addwarehousebox.ItemsSource = context.ASSURANCES.ToList();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ManageApps ma = new ManageApps();
            ma.Show();
        }
    }
}
