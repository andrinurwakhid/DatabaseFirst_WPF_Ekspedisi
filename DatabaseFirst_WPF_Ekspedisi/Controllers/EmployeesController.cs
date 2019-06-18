using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst_WPF_Ekspedisi.Models;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;
using System.Windows;

namespace DatabaseFirst_WPF_Ekspedisi
{
    class EmployeesController
    {
        
        ExpeditionEntities2 context = new ExpeditionEntities2();
        // =========================================== LOGIN =============================================
        public bool login(string username, string password)
        {

            bool cek = false;
            SqlConnection con = new SqlConnection("Server=DESKTOP-VCT2PRF;Database=Expedition;Trusted_Connection=true");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from EMPLOYEES where USERNAME='" + username + "'  and PASSWORD='" + password + "'", con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                cek = true;
            }
            else
            {
                cek = false;
            }
            return cek;
        }

        // =========================================== INSERT =============================================
        public void Insert(string data1,string data2,string data3,string data4, int data5)
        {
            EMPLOYEE call = new EMPLOYEE();
            {
                call.NAME = data1;
                call.POSITION = data2;
                call.USERNAME = data3;
                call.PASSWORD = data4;
                call.BRANCH_ID = data5;

            };
            try
            {
                context.EMPLOYEES.Add(call);
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
