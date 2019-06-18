using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst_WPF_Ekspedisi.Models;
using System.Windows;

namespace DatabaseFirst_WPF_Ekspedisi.Controllers
{
    class StatusShippingsController
    {
        ExpeditionEntities2 context = new ExpeditionEntities2();
        // =========================================== INSERT =============================================
        public void Insert(string data1)
        {
            STATUS_SHIPPINGS call = new STATUS_SHIPPINGS();
            {
                call.NAME = data1;

            };
            try
            {
                context.STATUS_SHIPPINGS.Add(call);
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
