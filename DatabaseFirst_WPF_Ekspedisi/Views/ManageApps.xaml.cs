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
        ExpeditionEntities2 context = new ExpeditionEntities2();

        public ManageApps()
        {
            InitializeComponent();

        }

        //private void cmbNamaRuanganTransaksi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    //var ruangan = et.ROOMs.Where(p => p.ROOM_ID == Convert.ToInt32(cmbNamaRuanganTransaksi.SelectedValue));
        //    int temp_date = Convert.ToDateTime(dtKepergianTransaksi.Text).Day - Convert.ToDateTime(dtKedatanganTransaksi.Text).Day;

        //    var ruangan = from r in et.ROOMs.ToList()
        //                  join tr in et.TYPE_ROOM.ToList()
        //                  on r.TYPE_ROOM_ID equals tr.TYPE_ROOM_ID
        //                  where r.ROOM_ID == Convert.ToInt32(cmbNamaRuanganTransaksi.SelectedValue)
        //                  select r;

        //    foreach (var item in ruangan)
        //    {
        //        txtJenisRuanganTransaksi.Text = item.TYPE_ROOM.NAME;
        //        txtBiayaRuanganTransaksi.Text = item.TYPE_ROOM.PRICE.ToString();
        //    }



        //private void cmbProvinceBranch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var prov = context.PROVINCES.Where(p => p.ID == Convert.ToString(cmbProvinceBranch.SelectedValue));
        //    //int temp_date = Convert.ToDateTime(dtKepergianTransaksi.Text).Day - Convert.ToDateTime(dtKedatanganTransaksi.Text).Day;

        //    var ruangan = from r in et.ROOMs.ToList()
        //                  join tr in et.TYPE_ROOM.ToList()
        //                  on r.TYPE_ROOM_ID equals tr.TYPE_ROOM_ID
        //                  where r.ROOM_ID == Convert.ToInt32(cmbNamaRuanganTransaksi.SelectedValue)
        //                  select r;

        //    foreach (var item in ruangan)
        //    {
        //        txtJenisRuanganTransaksi.Text = item.TYPE_ROOM.NAME;
        //        txtBiayaRuanganTransaksi.Text = item.TYPE_ROOM.PRICE.ToString();
        //    }
        public void LoadGridCombo()
        {
            cmbWarehouseBranch.DisplayMemberPath = "NAME";
            cmbWarehouseBranch.SelectedValuePath = "ID";
            cmbWarehouseBranch.ItemsSource = context.WAREHOUSES.ToList();

            cmbIdBranchEmployee.DisplayMemberPath = "NAME";
            cmbIdBranchEmployee.SelectedValuePath = "ID";
            cmbIdBranchEmployee.ItemsSource = context.BRANCHS.ToList();
            
            string provincename = cmbProvinceBranch.DisplayMemberPath = "NAME";
            string provinceId = cmbProvinceBranch.SelectedValuePath = "ID";
            cmbProvinceBranch.ItemsSource = context.PROVINCES.ToList();

            cmbRegencyBranch.DisplayMemberPath = "NAME";
            cmbRegencyBranch.SelectedValuePath = "ID";
            cmbRegencyBranch.ItemsSource = context.REGENCIES.ToList();

            cmbDistrictBranch.DisplayMemberPath = "NAME";
            cmbDistrictBranch.SelectedValuePath = "ID";
            cmbDistrictBranch.ItemsSource = context.DISTRICTS.ToList();

            cmbVillageBranch.DisplayMemberPath = "NAME";
            cmbVillageBranch.SelectedValuePath = "ID";
            cmbVillageBranch.ItemsSource = context.VILLAGES.ToList();


            //etypescombobox.DisplayMemberPath = "TYPES";
            //etypescombobox.SelectedValuePath = "TYPES";
            //etypescombobox.ItemsSource = context.ASSURANCES.ToList();
        }

        //private void Window_Loaded_1(object sender, RoutedEventArgs e)
        //{
        //    ViewEmployees(dataemployees);
        //    ViewBranch(databranch);
        //    ViewWarehouse(datawarehouse);
        //    ViewCategories(datacategory);
        //    ViewPackages(datapackage);
        //    Viewstatshipping(datastatshiping);
        //    ViewShippings(datashipping);
        //   // ViewAssurances(dataassurance);
        //    LoadGridCombo();
        //}
        private void logout_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }
        
        #region Clear Function
        private void clearbranch()
        {
            txtIdBranch.Text = "";
            txtNameBranch.Text = "";
            txtAddressBranch.Text = "";
            cmbProvinceBranch.Text = "";
            cmbRegencyBranch.Text = "";
            cmbDistrictBranch.Text = "";
            cmbVillageBranch.Text = "";
            cmbWarehouseBranch.Text = "";
            txtPriceBranch.Text = "";
        }
        private void clearwarehouse()
        {
            //bidbox.Text = "";
            //bnamebox.Text = "";
            //bprovincebox.Text = "";
            //bregencybox.Text = "";
            //bsubdistrictbox.Text = "";
            //blocationbox.Text = "";
        }
        private void clearemployee()
        {
            txtIdEmployee.Text = "";
            txtNameEmployee.Text = "";
            txtUsernameEmployee.Text = "";
            txtPasswordEmployee.Password = "";
            cmbIdBranchEmployee.SelectedItem = null;
        }
        private void clearpackage()
        {
            txtIdPackage.Text = "";
            txtNamePackage.Text = "";
            txtPricePackage.Text = "0";
        }
        private void clearassurance()
        {
        //    eidbox.Text = "";
        //    etypescombobox.Text = "";
        //    epricebox.Text = "";
        }
        private void clearcategory()
        {
            txtIdCategory.Text = "";
            txtNameCategory.Text = "";
        }
        private void clearstatshipping()
        {
            txtIdStatus.Text = "";
            txtNameStatus.Text = "";
        }
        #endregion

        #region A
        // EMPLOYEES ================================================================================================================================================

        // VIEW
        
        // CREATE
        private void addempbtn_Click_1(object sender, RoutedEventArgs e)
        {
            //AddEmployees add = new AddEmployees();
            //add.Show();
        }
        // SELECTION
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dataemployees.SelectedItem;

                string data1 = (dataemployees.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                txtIdEmployee.Text = data1;
                string data2 = (dataemployees.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                txtNameEmployee.Text = data2;
                string data3 = (dataemployees.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                txtPositionEmployee.Text = data3;
                string data4 = (dataemployees.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                txtUsernameEmployee.Text = data4;
                string data5 = (dataemployees.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                txtPasswordEmployee.Password = data5;
                string data6 = (dataemployees.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                cmbIdBranchEmployee.Text = data6;
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
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
            //object item = dataemployees.SelectedItem;
            //string temp_id = (dataemployees.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            //int id = Convert.ToInt32(temp_id);

            //EMPLOYEE datax = SearchByIdEmployee(id);
            //datax.NAME = txtNameEmployee.Text;
            //datax.POSITION = txtPositionEmployee.Text;

            //try
            //{
            //    context.Entry(datax).State = System.Data.Entity.EntityState.Modified;
            //    context.SaveChanges();
            //    clearemployee();
            //    this.ViewEmployees(dataemployees);
            //    MessageBox.Show("Update Success !", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            //}
            //catch (DbEntityValidationException ex)
            //{
            //    foreach (var eve in ex.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //    throw;
            //}
        }

        // DELETE
        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            if ( MessageBox.Show("Are You Sure ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                    System.Console.Write(ex.InnerException);
                }
            }
            else 
            {

            }
        }

        // BRANCHS ===================================================================================================================================================
        // INSERT
        private void addbrbtn_Click(object sender, RoutedEventArgs e)
        {
            AddBranch addbranch = new AddBranch();
            addbranch.Show();
        }
        private BRANCH SearchByIdBranch(int id)
        {
            var dataid = context.BRANCHS.Find(id);
            if (dataid == null)
            {
                MessageBox.Show("ID " + id + " not found", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return dataid;
        }

        private BRANCH SearchByNameBranch(int id)
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
       
        // DELETE
        private void Adelete_Click(object sender, RoutedEventArgs e)
        {
            
        }
        // UPDATE
        private void Aupdate_Click(object sender, RoutedEventArgs e)
        {
            //object item = databranch.SelectedItem;
            //string temp_id = (databranch.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            
            //int id = Convert.ToInt32(temp_id);

            //BRANCH datax = SearchByIdBranch(id);
            //datax.NAME = txtNameBranch.Text;
            //datax.PROVINCE_ID = Convert.ToString(cmbProvinceBranch.SelectedValue);
            //datax.REGENCY_ID = Convert.ToString(cmbRegencyBranch.SelectedValue);
            //datax.DISTRICT_ID = Convert.ToString(cmbDistrictBranch.SelectedValue);
            //datax.VILLAGE_ID = Convert.ToString(cmbVillageBranch.SelectedValue);
            //datax.ADDRESS = txtAddressBranch.Text;
            //datax.WAREHOUSE_ID = Convert.ToInt32(cmbWarehouseBranch.SelectedValue);
            //datax.PRICE = Convert.ToInt32(txtPriceBranch.Text);

            //try
            //{
            //    context.Entry(datax).State = System.Data.Entity.EntityState.Modified;
            //    context.SaveChanges();
            //    clearbranch();
            //    this.ViewBranch(databranch);
            //    MessageBox.Show("Update Success !", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            //}
            //catch (DbEntityValidationException ex)
            //{
            //    foreach (var eve in ex.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //    throw;
            //}
        }

        // WAREHOUSE ===================================================================================================================================================
        // VIEW
        

        // INSERT
        private void addwrbtn_Click(object sender, RoutedEventArgs e)
        {
            AddWarehouse aw = new AddWarehouse();
            aw.Show();
        }

        private Warehouse SearchByIdWarehouse(int id)
        {
            var dataid = context.WAREHOUSES.Find(id);
            if (dataid == null)
            {
                MessageBox.Show("ID " + id + " not found", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return dataid;
        }
        // SELECT
        private void datawarehouse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                object item = datawarehouse.SelectedItem;

                //string data1 = (datawarehouse.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                //bidbox.Text = data1;
                //string data2 = (datawarehouse.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                //bnamebox.Text = data2;
                //string data3 = (datawarehouse.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                //bprovincebox.Text = data3;
                //string data4 = (datawarehouse.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                //bregencybox.Text = data4;
                //string data5 = (datawarehouse.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                //bsubdistrictbox.Text = data5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                System.Console.Write(ex.InnerException);
            }
        }
        // UPDATE
        private void Bupdate_Click(object sender, RoutedEventArgs e)
        {
            object item = datawarehouse.SelectedItem;
            string temp_id = (datawarehouse.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);

            Warehouse datax = SearchByIdWarehouse(id);
            //datax.NAME = bnamebox.Text;
            //datax.PROVINCE_ID = bprovincebox.Text;
            //datax.REGENCY_ID = bregencybox.Text;
            //datax.DISTRICT_ID = bsubdistrictbox.Text;
            //datax.VILLAGE_ID = blocationbox.Text;

            try
            {
                context.Entry(datax).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                clearbranch();
                this.ViewWarehouse(datawarehouse);
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
        private void Bdelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                try
                {
                object item = datawarehouse.SelectedItem;
                string temp_id = (datawarehouse.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                int id = Convert.ToInt32(temp_id);
                Warehouse datadel = SearchByIdWarehouse(id);
                context.Entry(datadel).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                clearwarehouse();
                this.ViewWarehouse(datawarehouse);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                    System.Console.Write(ex.InnerException);
                }
            }
            else
            {

            }

        }

        // ASSURANCE ===================================================================================================================================================
        // VIEW
        //private void ViewAssurances(DataGrid DG)
        //{
        //    var query = from x in context.ASSURANCES select x;
        //    DG.ItemsSource = query.ToList();
        //}
        //private ASSURANCE SearchByIdAssurance(int id)
        ////{
        ////    var dataid = context.ASSURANCES.Find(id);
        ////    if (dataid == null)
        ////    {
        ////        MessageBox.Show("ID " + id + " not found", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        ////    }

        ////    return dataid;
        //}
        // INSERT
        private void addassbtn_Click(object sender, RoutedEventArgs e)
        {
            //AddAssurance add = new AddAssurance();
            //add.Show();
        }
        // SELECT
        private void dataassurance_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //try
            //{
            //    object item = dataassurance.SelectedItem;

            //    string data1 = (dataassurance.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            //    eidbox.Text = data1;
            //    string data2 = (dataassurance.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            //    etypescombobox.Text = data2;
            //    string data3 = (dataassurance.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            //    epricebox.Text = data3;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show(ex.StackTrace);
            //    System.Console.Write(ex.InnerException);
            //}
        }

        // UPDATE
        private void Eupdate_Click(object sender, RoutedEventArgs e)
        {
            //object item = dataassurance.SelectedItem;
            //string temp_id = (dataassurance.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            //int id = Convert.ToInt32(temp_id);

            //ASSURANCE datax = SearchByIdAssurance(id);
            //datax.TYPES = etypescombobox.Text;
            //datax.PRICE = Convert.ToInt32(epricebox.Text);

            //try
            //{
            //    context.Entry(datax).State = System.Data.Entity.EntityState.Modified;
            //    context.SaveChanges();
            //    clearassurance();
            //    this.ViewAssurances(dataassurance);
            //    MessageBox.Show("Update Success !", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            //}
            //catch (DbEntityValidationException ex)
            //{
            //    foreach (var eve in ex.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //    throw;
            //}

        }
        // DELETE
        private void Edelete_Click(object sender, RoutedEventArgs e)
        {
            //if (MessageBox.Show("Are You Sure ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            //{
            //    try
            //    {
            //    object item = dataassurance.SelectedItem;
            //    string temp_id = (dataassurance.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            //    int id = Convert.ToInt32(temp_id);
            //    ASSURANCE datadel = SearchByIdAssurance(id);
            //    context.Entry(datadel).State = System.Data.Entity.EntityState.Deleted;
            //    context.SaveChanges();
            //    clearassurance();
            //    this.ViewPackages(dataassurance);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        MessageBox.Show(ex.StackTrace);
            //        System.Console.Write(ex.InnerException);
            //    }
            //}
            //else
            //{

            //}

        }
        // PACKAGES ===================================================================================================================================================
        // VIEW
        
        private PACKAGE SearchByIdPackage(int id)
        {
            var dataid = context.PACKAGES.Find(id);
            if (dataid == null)
            {
                MessageBox.Show("ID " + id + " not found", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return dataid;
        }
        // INSERT
        private void addpackbtn_Click(object sender, RoutedEventArgs e)
        {
            //AddPackage add = new AddPackage();
            //add.Show();
        }
        // SELECT
        private void datapackage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = datapackage.SelectedItem;

                string data1 = (datapackage.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                txtIdPackage.Text = data1;
                string data2 = (datapackage.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                txtNamePackage.Text = data2;
                string data3 = (datapackage.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                txtPricePackage.Text = data3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                System.Console.Write(ex.InnerException);
            }
        }

        // UPDATE
        private void Dupdate_Click(object sender, RoutedEventArgs e)
        {
            //object item = datapackage.SelectedItem;
            //string temp_id = (datapackage.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            //int id = Convert.ToInt32(temp_id);

            //PACKAGE datax = SearchByIdPackage(id);
            //datax.NAME = dnamebox.Text;
            //datax.PRICE = Convert.ToInt32(dpricebox.Text);

            //try
            //{
            //    context.Entry(datax).State = System.Data.Entity.EntityState.Modified;
            //    context.SaveChanges();
            //    clearpackage();
            //    this.ViewPackages(datapackage);
            //    MessageBox.Show("Update Success !", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            //}
            //catch (DbEntityValidationException ex)
            //{
            //    foreach (var eve in ex.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //    throw;
            //}
        }

        // DELETE

        private void Ddelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                try
                {
                object item = datapackage.SelectedItem;
                string temp_id = (datapackage.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                int id = Convert.ToInt32(temp_id);
                PACKAGE datadel = SearchByIdPackage(id);
                context.Entry(datadel).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                clearpackage();
                this.ViewPackages(datapackage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                    System.Console.Write(ex.InnerException);
                }
            }
            else
            {

            }
        }

        // CATEGORIES ===================================================================================================================================================
        // VIEW
        
        private CATEGORy SearchByIdCategory(int id)
        {
            var dataid = context.CATEGORIES.Find(id);
            if (dataid == null)
            {
                MessageBox.Show("ID " + id + " not found", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return dataid;
        }
        // INSERT
        private void addcatbtn_Click(object sender, RoutedEventArgs e)
        {
        //    AddCategory add = new AddCategory();
        //    add.Show();
        }
        // SELECT
        private void datacategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                object item = datacategory.SelectedItem;

                string data1 = (datacategory.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                txtIdCategory.Text = data1;
                string data2 = (datacategory.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                txtNameCategory.Text = data2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                System.Console.Write(ex.InnerException);
            }
        }

        // UPDATE
        private void Fupdate_Click(object sender, RoutedEventArgs e)
        {
            object item = datacategory.SelectedItem;
            string temp_id = (datacategory.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);

            CATEGORy datax = SearchByIdCategory(id);
            datax.NAME = txtNameCategory.Text;

            try
            {
                context.Entry(datax).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                clearcategory();
                this.ViewCategories(datacategory);
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
        private void Fdelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                try
                {
                object item = datacategory.SelectedItem;
                string temp_id = (datacategory.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                int id = Convert.ToInt32(temp_id);
                CATEGORy datadel = SearchByIdCategory(id);
                context.Entry(datadel).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                clearcategory();
                this.ViewCategories(datacategory);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                    System.Console.Write(ex.InnerException);
                }
            }
            else
            {

            }

        }

        // STATUS SHIPPING ===================================================================================================================================================
        // VIEW
        //private void Viewstatshipping(DataGrid DG)
        //{
        //    DG.ItemsSource = context.STATUS_SHIPPINGS.OrderBy(p => p.ID).ToList();
        //}
        private STATUS_SHIPPINGS SearchByIdStatShipping(int id)
        {
            var dataid = context.STATUS_SHIPPINGS.Find(id);
            if (dataid == null)
            {
                MessageBox.Show("ID " + id + " not found", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return dataid;
        }
        // INSERT
        private void addstatbtn_Click(object sender, RoutedEventArgs e)
        {
            AddStatShipping add = new AddStatShipping();
            add.Show();
        }
        // SELECT
        private void datastatshiping_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = datastatshiping.SelectedItem;

                string data1 = (datastatshiping.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                txtIdStatus.Text = data1;
                string data2 = (datastatshiping.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                txtNameStatus.Text = data2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                System.Console.Write(ex.InnerException);
            }
        }

        // UPDATE
                private void Gupdate_Click(object sender, RoutedEventArgs e)
        {
            object item = datastatshiping.SelectedItem;
            string temp_id = (datastatshiping.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);

            STATUS_SHIPPINGS datax = SearchByIdStatShipping(id);
            datax.NAME = txtNameStatus.Text;

            try
            {
                context.Entry(datax).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                clearstatshipping();
                this.Viewstatshipping(datastatshiping);
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
        private void Gdelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                try
                {
                object item = datastatshiping.SelectedItem;
                string temp_id = (datastatshiping.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                int id = Convert.ToInt32(temp_id);
                STATUS_SHIPPINGS datadel = SearchByIdStatShipping(id);
                context.Entry(datadel).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                clearstatshipping();
                this.Viewstatshipping(datastatshiping);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                    System.Console.Write(ex.InnerException);
                }
            }
            else
            {

            }
        }

        // SHIPPING ===================================================================================================================================================
        // VIEW
       
        private SHIPPING SearchByIdShipping(int id)
        {
            var dataid = context.SHIPPINGS.Find(id);
            if (dataid == null)
            {
                MessageBox.Show("ID " + id + " not found", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return dataid;
        }
        #endregion

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DassboardAdmin da = new DassboardAdmin();
            da.Show();
        }

        #region View Datagrid

        private void ViewCategories(DataGrid DG)
        {
            DG.ItemsSource = context.CATEGORIES.OrderBy(p => p.ID).ToList();
        }
        private void ViewShippings(DataGrid DG)
        {
            DG.ItemsSource = context.SHIPPINGS.OrderBy(p => p.ID).ToList();
        }
        private void Viewstatshipping(DataGrid DG)
        {
            DG.ItemsSource = context.STATUS_SHIPPINGS.OrderBy(p => p.ID).ToList();
        }
        private void ViewPackages(DataGrid DG)
        {
            DG.ItemsSource = context.PACKAGES.OrderBy(p => p.ID).ToList();
        }
        private void ViewWarehouse(DataGrid DG)
        {
            DG.ItemsSource = context.WAREHOUSES.OrderBy(p => p.ID).ToList();
        }
        private void ViewEmployees(DataGrid DG)
        {
            DG.ItemsSource = context.EMPLOYEES.OrderBy(p => p.ID).ToList();
        }

        #endregion

        #region datagrid
        //branch
        private void databranch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = databranch.SelectedItem;

                txtIdBranch.Text = (databranch.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                //txtIdBranch.Text = data;
                txtNameBranch.Text = (databranch.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                //txtNameBranch.Text = data1;
                txtAddressBranch.Text = (databranch.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                //txtAddressBranch.Text = data2;
                cmbVillageBranch.Text = (databranch.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                //cmbVillageBranch.Text = data3;
                cmbDistrictBranch.Text = (databranch.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                //cmbDistrictBranch.Text = data4;
                cmbRegencyBranch.Text = (databranch.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                //cmbRegencyBranch.Text = data5;
                cmbProvinceBranch.Text = (databranch.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
                //cmbProvinceBranch.Text = data6;
                cmbWarehouseBranch.Text = (databranch.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text;
                //cmbWarehouseBranch.Text = data7;
                txtPriceBranch.Text = (databranch.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text;
                //txtPriceBranch.Text = data8;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                System.Console.Write(ex.InnerException);
            }
        }


        #endregion
        #region Button
        #region Button Branch

        //Load Combobox
        private void cmbProvinceBranch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string idprov = Convert.ToString(cmbProvinceBranch.SelectedValue);

            cmbRegencyBranch.DisplayMemberPath = "NAME";
            cmbRegencyBranch.SelectedValuePath = "ID";
            cmbRegencyBranch.ItemsSource = context.REGENCIES.Where(TP => TP.PROVINCE_ID == idprov).ToList();

        }
        private void cmbRegencyBranch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string idregen = Convert.ToString(cmbRegencyBranch.SelectedValue);
            cmbDistrictBranch.DisplayMemberPath = "NAME";
            cmbDistrictBranch.SelectedValuePath = "ID";
            cmbDistrictBranch.ItemsSource = context.DISTRICTS.Where(TP => TP.REGENCY_ID == idregen).ToList();
        }

        private void cmbDistrictBranch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string iddistrict = Convert.ToString(cmbDistrictBranch.SelectedValue);
            cmbVillageBranch.DisplayMemberPath = "NAME";
            cmbVillageBranch.SelectedValuePath = "ID";
            cmbVillageBranch.ItemsSource = context.VILLAGES.Where(TP => TP.DISTRICT_ID == iddistrict).ToList();
        }


        private void btnSearchBranch_Click(object sender, RoutedEventArgs e)
        {
            //int brachs = Convert.ToInt32(txtSearchBranch.Text);
 
            //BRANCH datax = SearchByIdBranch(brachs);
            //DataGrid DG = new DataGrid();
            //DG.ItemsSource = context.BRANCHS.OrderBy(p => p.ID).ToList();

            //try
            //{
            //    object item = databranch.SelectedItem;

            //    string data1 = (databranch.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            //    txtIdBranch.Text = data1;
            //    string data2 = (databranch.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            //    txtNameBranch.Text = data2;
            //    string data7 = (databranch.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            //    txtAddressBranch.Text = data7;
            //    string data3 = (databranch.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
            //    cmbProvinceBranch.Text = data3;
            //    string data4 = (databranch.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
            //    cmbRegencyBranch.Text = data4;
            //    string data5 = (databranch.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
            //    cmbDistrictBranch.Text = data5;
            //    string data6 = (databranch.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
            //    cmbVillageBranch.Text = data6;
            //    string data8 = (databranch.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text;
            //    cmbWarehouseBranch.Text = data8;

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show(ex.StackTrace);
            //    System.Console.Write(ex.InnerException);
            //}
        }

        private void btnSaveBranch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BranchController controller = new BranchController();

                controller.Insert(
                    txtNameBranch.Text,
                    Convert.ToString(cmbProvinceBranch.SelectedValue),
                    Convert.ToString(cmbRegencyBranch.SelectedValue),
                    Convert.ToString(cmbDistrictBranch.SelectedValue),
                    Convert.ToString(cmbVillageBranch.SelectedValue),
                    txtAddressBranch.Text,
                    Convert.ToInt32(cmbWarehouseBranch.SelectedValue),
                    Convert.ToInt32(txtPriceBranch.Text) 
                    );
                MessageBox.Show("Insert data Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                //this.Hide();
                ViewBranch(databranch);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                System.Console.Write(ex.InnerException);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadGridCombo();
            ViewEmployees(dataemployees);
            ViewBranch(databranch);
            ViewWarehouse(datawarehouse);
            ViewCategories(datacategory);
            ViewPackages(datapackage);
            Viewstatshipping(datastatshiping);
            ViewShippings(datashipping);
           // ViewAssurances(dataassurance);
            
        }

        private void btnEditBrach_Click(object sender, RoutedEventArgs e)
        {
            object item = databranch.SelectedItem;
            string temp_id = (databranch.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);

            BRANCH datax = SearchByIdBranch(id);
            datax.NAME = txtNameBranch.Text;
            datax.PROVINCE_ID = Convert.ToString(cmbProvinceBranch.SelectedValue);
            datax.REGENCY_ID = Convert.ToString(cmbRegencyBranch.SelectedValue);
            datax.DISTRICT_ID = Convert.ToString(cmbDistrictBranch.SelectedValue);
            datax.VILLAGE_ID = Convert.ToString(cmbVillageBranch.SelectedValue);
            datax.ADDRESS = txtAddressBranch.Text;
            datax.WAREHOUSE_ID = Convert.ToInt32(cmbWarehouseBranch.SelectedValue);
            datax.PRICE = Convert.ToInt32(txtPriceBranch.Text);

            try
            {
                context.Entry(datax).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                clearbranch();
                this.ViewBranch(databranch);
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
        #endregion
        #region Button Employee
        private void btnSaveEmployee_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EmployeesController controller = new EmployeesController();
                //string data1 = txtNameEmployee.Text;
                //string data2 = txtPositionEmployee.Text;
                //string data3 = txtUsernameEmployee.Text;
                //string data4 = txtPasswordEmployee.Text;
                //controller.Insert(data1, data2, data3, data4);

                controller.Insert(
                    txtNameEmployee.Text,
                    txtPositionEmployee.Text,
                    txtUsernameEmployee.Text,
                    txtPasswordEmployee.Password,
                    Convert.ToInt32(cmbIdBranchEmployee.SelectedValue));
                MessageBox.Show("Register Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
               // this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                System.Console.Write(ex.InnerException);
            }
        }

        private void btnDeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                try
                {
                    //object item = dataemployees.SelectedItem;
                    //string temp_id = (dataemployees.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                    int id = Convert.ToInt32(txtIdEmployee.Text);
                    EMPLOYEE datadel = SearchByIdEmployee(id);
                    context.Entry(datadel).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    clearemployee();
                    this.ViewEmployees(dataemployees);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                    System.Console.Write(ex.InnerException);
                }
            }
            else
            {

            }
            
            ////object item = dataGridAll.SelectedItem;
            //string data = txtIdEmployee.Text;
            //int id_em = Convert.ToInt32(data);

            //bool flag = db.EMPLOYEES.Where(x => x.ID == id_em).Any();
            //if (flag)
            //{

            //    ep = db.EMPLOYEES.Where(x => x.ID == id_em).First();
            //    if (MessageBox.Show("Anda Yakin ingin menghapus data ini?",
            //        "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            //    {
            //        db.EMPLOYEES.Remove(ep);
            //        db.SaveChanges();
            //        MessageBox.Show("Data Removed Sucessfully...!");
            //        reloadEmployee();
            //    }
            //    else { }
            //}
            //else
            //{
            //    MessageBox.Show("Invalid ID. Try Again....!");
            //}
        }

        private void btnEditEmployee_Click(object sender, RoutedEventArgs e)
        {
            //object item = dataemployees.SelectedItem;
            //string temp_id = (dataemployees.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(txtIdEmployee.Text);

            EMPLOYEE datax = SearchByIdEmployee(id);
            datax.NAME = txtNameEmployee.Text;
            datax.POSITION = txtPositionEmployee.Text;
            datax.USERNAME = txtUsernameEmployee.Text;
            datax.PASSWORD = txtPasswordEmployee.Password;

            try
            {
                context.Entry(datax).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                clearemployee();
                this.ViewEmployees(dataemployees);
                //MessageBox.Show("Update Success !", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                //ViewEmployees(dataemployees);
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
        #endregion
        #region Button Package
        private void btnSavePackage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PackageController controller = new PackageController();
                string data1 = txtNamePackage.Text;
                int data2 = Convert.ToInt32(txtPricePackage.Text);
                controller.Insert(data1, data2);
                MessageBox.Show("Insert data Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                //this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                System.Console.Write(ex.InnerException);
            }
        }

        private void btnEditPackage_Click(object sender, RoutedEventArgs e)
        {
            object item = datapackage.SelectedItem;
            string temp_id = (datapackage.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);

            PACKAGE datax = SearchByIdPackage(id);
            datax.NAME = txtNamePackage.Text;
            datax.PRICE = Convert.ToInt32(txtPricePackage.Text);

            try
            {
                context.Entry(datax).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                clearpackage();
                this.ViewPackages(datapackage);
                //MessageBox.Show("Update Success !", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
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
        #endregion
        #region Button Category
        private void btnSaveCategory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CategoryController controller = new CategoryController();
                string data1 = txtNameCategory.Text;
                controller.Insert(data1);
                MessageBox.Show("Insert data Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                //this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                System.Console.Write(ex.InnerException);
            }
        }
        #endregion
        #region Button status
        private void btnSaveStatus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StatusShippingsController controller = new StatusShippingsController();
                string data1 = txtNameStatus.Text;
                controller.Insert(data1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                System.Console.Write(ex.InnerException);
            }
        }



        #endregion

        #endregion

        private void btnDeleteBranch_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                try
                {
                    //object item = databranch.SelectedItem;
                    //string temp_id = (databranch.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                    int id = Convert.ToInt32(txtIdBranch.Text);
                    BRANCH datadel = SearchByIdBranch(id);
                    context.Entry(datadel).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    clearbranch();
                    this.ViewBranch(databranch);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }
    }
}
