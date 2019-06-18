using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst_WPF_Ekspedisi.Models;
using System.Windows;

namespace DatabaseFirst_WPF_Ekspedisi.Controllers
{
    class WarehouseController
    {
        ExpeditionEntities2 context = new ExpeditionEntities2();
        // =========================================== INSERT =============================================
        public void Insert(string data1, string data2, string data3, string data4, string data5)
        {
            //Warehouse call = new Warehouse();
            //{
            //    call.NAME = data1;
            //    call.PROVINCE = data2;
            //    call.REGENCY = data3;
            //    call.SUB_DISTRICT = data4;
            //    call.LOCATION = data5;

            //};
            //try
            //{
            //    context.WAREHOUSES.Add(call);
            //    var result = context.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show(ex.StackTrace);
            //    System.Console.Write(ex.InnerException);
            //}
        }
    }
}
