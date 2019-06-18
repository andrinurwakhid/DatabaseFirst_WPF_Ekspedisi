using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst_WPF_Ekspedisi.Models;
using System.Windows;

namespace DatabaseFirst_WPF_Ekspedisi.Controllers
{
    class BranchController
    {
        ExpeditionEntities2 context = new ExpeditionEntities2();
        // =========================================== INSERT =============================================
        public void Insert(string data1, string data2, string data3, string data4,string data5,string data6, int data7, int data8)
        {

            BRANCH call = new BRANCH();
            {
                call.NAME = data1;
                call.PROVINCE_ID = data2;
                call.REGENCY_ID = data3;
                call.DISTRICT_ID = data4;
                call.VILLAGE_ID = data5;
                call.ADDRESS = data6;
                call.WAREHOUSE_ID = data7;
                call.PRICE = data8;

            };
            try
            {
                context.BRANCHS.Add(call);
                var result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                System.Console.Write(ex.InnerException);
            }
        }
    }
}

