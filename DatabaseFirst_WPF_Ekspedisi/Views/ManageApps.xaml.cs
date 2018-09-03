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
    /// Interaction logic for ManageApps.xaml
    /// </summary>
    public partial class ManageApps : Window
    {
        ExpeditionEntities context = new ExpeditionEntities();
        WarehouseController wareh = new WarehouseController();
        public ManageApps()
        {
            InitializeComponent();
        }
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            ViewEmployees(dataemployees);
            ViewBranch(databranch);
            ViewWarehouse(datawarehouse);
            ViewCategories(datacategory);
            ViewPackages(datapackage);
            Viewstatshipping(datastatshiping);
            ViewShippings(datashipping);
            ViewAssurances(dataassurance);
            LoadGridCombo();
        }

        // CLEAR FUNCTIONS ===================================================================================================================================================
        private void clearemployee()
        {
            namebox.Text = "";
            positionbox.Text = "";
            idbox.Text = "";
        }
        private void clearbranch()
        {
            aidbox.Text = "";
            aprovincebox.Text = "";
            asubdistrictbox.Text = "";
            alocationbox.Text = "";
            awarehousebox.Text = "";
        }
        // EMPLOYEES ================================================================================================================================================

        // VIEW
        private void ViewEmployees(DataGrid DG)
        {
            DG.ItemsSource = context.EMPLOYEES.OrderBy(p => p.ID).ToList();
        }
        // CREATE
        // SELECTION
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dataemployees.SelectedItem;

                string data1 = (dataemployees.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                idbox.Text = data1;
                string data2 = (dataemployees.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                namebox.Text = data2;
                string data3 = (dataemployees.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                positionbox.Text = data3;
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }

        // UPDATE
        private EMPLOYEE SearchByIdEmployee(int id)
        {
            var dataid = context.EMPLOYEES.Find(id);
            if (dataid == null)
            {
                MessageBox.Show("ID " + id + " not found", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return dataid;
        }
        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            object item = dataemployees.SelectedItem;
            string temp_id = (dataemployees.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);

            EMPLOYEE datax = SearchByIdEmployee(id);
            datax.NAME = namebox.Text;
            datax.POSITION = positionbox.Text;

            try
            {
                context.Entry(datax).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                clearemployee();
                this.ViewEmployees(dataemployees);
                MessageBox.Show("Update Success !", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        // DELETE
        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            if ( MessageBox.Show("Are You Sure ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                object item = dataemployees.SelectedItem;
                string temp_id = (dataemployees.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                int id = Convert.ToInt32(temp_id);
                EMPLOYEE datadel = SearchByIdEmployee(id);
                context.Entry(datadel).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                clearemployee();
                this.ViewEmployees(dataemployees);
            }
            else 
            {

            }
        }

        // BRANCHS ===================================================================================================================================================

        private BRANCH SearchByIdBranch(int id)
        {
            var dataid = context.BRANCHS.Find(id);
            if (dataid == null)
            {
                MessageBox.Show("ID " + id + " not found", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return dataid;
        }
        // VIEW
        private void ViewBranch(DataGrid DG)
        {
            DG.ItemsSource = context.BRANCHS.OrderBy(p => p.ID).ToList();
        }
        // SELECT
        private void databranch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = databranch.SelectedItem;

                string data1 = (databranch.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                aidbox.Text = data1;
                string data2 = (databranch.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                anamebox.Text = data2;
                string data3 = (databranch.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                aprovincebox.Text = data3;
                string data4 = (databranch.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                asubdistrictbox.Text = data4;
                string data5 = (databranch.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                alocationbox.Text = data5;
                string data6 = (databranch.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                awarehousebox.Text = data6;
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // DELETE
        private void Adelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                object item = databranch.SelectedItem;
                string temp_id = (databranch.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                int id = Convert.ToInt32(temp_id);
                BRANCH datadel = SearchByIdBranch(id);
                context.Entry(datadel).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                clearbranch();
                this.ViewBranch(databranch);
            }
            else
            {

            }
        }


        // WAREHOUSE ===================================================================================================================================================
        // VIEW
        private void ViewWarehouse(DataGrid DG)
        {
            DG.ItemsSource = context.WAREHOUSES.OrderBy(p => p.ID).ToList();
        }
        // SELECT
        private void datawarehouse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                object item = datawarehouse.SelectedItem;

                string data1 = (datawarehouse.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                bidbox.Text = data1;
                string data2 = (datawarehouse.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                bnamebox.Text = data2;
                string data3 = (datawarehouse.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                bprovincebox.Text = data3;
                string data4 = (datawarehouse.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                bregencybox.Text = data4;
                string data5 = (datawarehouse.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                bsubdistrictbox.Text = data5;
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }


        // ASSURANCE ===================================================================================================================================================
        // VIEW
        private void ViewAssurances(DataGrid DG)
        {
            DG.ItemsSource = context.ASSURANCES.OrderBy(p => p.ID).ToList();
        }
        // SELECT
        private void dataassurance_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                object item = dataassurance.SelectedItem;

                string data1 = (dataassurance.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                eidbox.Text = data1;
                string data2 = (dataassurance.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                etypescombobox.Text = data2;
                string data3 = (dataassurance.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                epricebox.Text = data3;
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }


        // PACKAGES ===================================================================================================================================================
        // VIEW
        private void ViewPackages(DataGrid DG)
        {
            DG.ItemsSource = context.PACKAGES.OrderBy(p => p.ID).ToList();
        }
        // SELECT
        private void datapackage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = datapackage.SelectedItem;

                string data1 = (datapackage.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                didbox.Text = data1;
                string data2 = (datapackage.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                dnamebox.Text = data2;
                string data3 = (datapackage.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                dpricebox.Text = data3;
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }


        // CATEGORIES ===================================================================================================================================================
        // VIEW
        private void ViewCategories(DataGrid DG)
        {
            DG.ItemsSource = context.CATEGORIES.OrderBy(p => p.ID).ToList();
        }
        // SELECT
        private void datacategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                object item = datacategory.SelectedItem;

                string data1 = (datacategory.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                fidbox.Text = data1;
                string data2 = (datacategory.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                fnamebox.Text = data2;
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }


        // STATUS SHIPPING ===================================================================================================================================================
        // VIEW
        private void Viewstatshipping(DataGrid DG)
        {
            DG.ItemsSource = context.STATUS_SHIPPINGS.OrderBy(p => p.ID).ToList();
        }
        // SELECT
        private void datastatshiping_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = datastatshiping.SelectedItem;

                string data1 = (datastatshiping.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                gidbox.Text = data1;
                string data2 = (datastatshiping.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                gnamebox.Text = data2;
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }


        // SHIPPING ===================================================================================================================================================
        private void ViewShippings(DataGrid DG)
        {
            DG.ItemsSource = context.SHIPPINGS.OrderBy(p => p.ID).ToList();
        }
        
        private void logout_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }
        
        private void addempbtn_Click_1(object sender, RoutedEventArgs e)
        {
            AddEmployees add = new AddEmployees();
            add.Show();
        }
        public void LoadGridCombo()
        {
            awarehousebox.DisplayMemberPath = "NAME";
            awarehousebox.SelectedValuePath = "WAREHOUSE_ID";
            awarehousebox.ItemsSource = context.WAREHOUSES.ToList();
            
            etypescombobox.DisplayMemberPath = "TYPES";
            etypescombobox.SelectedValuePath = "TYPES";
            etypescombobox.ItemsSource = context.ASSURANCES.ToList();
        }

        private void addbrbtn_Click(object sender, RoutedEventArgs e)
        {
            AddBranch addbranch = new AddBranch();
            addbranch.Show();
        }
    }
}
