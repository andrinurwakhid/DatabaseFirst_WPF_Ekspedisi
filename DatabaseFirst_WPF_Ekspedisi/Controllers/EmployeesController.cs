using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst_WPF_Ekspedisi.Models;

namespace DatabaseFirst_WPF_Ekspedisi
{
    class EmployeesController
    {
        
        ExpeditionEntities ex = new ExpeditionEntities();
        public bool loginEmployees(string username, string password)
        {

            bool cek = false;
            var temp = ex.EMPLOYEES.FirstOrDefault();
            try
            {
                if (temp.USERNAME == username && temp.PASSWORD == password)
                {
                    cek = true;
                }
            }
            catch (Exception ex)
            {
                cek = false;
                ex.GetBaseException();
            }
            return cek;
        }
    }
}
