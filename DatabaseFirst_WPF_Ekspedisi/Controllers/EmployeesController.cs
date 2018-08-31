using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst_WPF_Ekspedisi.Models;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace DatabaseFirst_WPF_Ekspedisi
{
    class EmployeesController
    {
        
        ExpeditionEntities context = new ExpeditionEntities();
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
        public void Insert(string data1,string data2,string data3,string data4)
        {
            EMPLOYEE call = new EMPLOYEE();
            {
                call.NAME = data1;
                call.POSITION = data2;
                call.USERNAME = data3;
                call.PASSWORD = data4;

            };
            try
            {
                context.EMPLOYEES.Add(call);
                var result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<EMPLOYEE> Read()
        {
            var getalls = context.EMPLOYEES.ToList();
            foreach (EMPLOYEE data in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                : " + data.ID);
                System.Console.WriteLine("NAME              : " + data.NAME);
                System.Console.WriteLine("POSITION          : " + data.POSITION);
                System.Console.WriteLine("USERNAME          : " + data.USERNAME);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public EMPLOYEE GetById(int input)
        {
            var dataid = context.EMPLOYEES.Find(input);
            if (dataid == null)
            {
                System.Console.WriteLine("ID "+input+" NOT FOUND");
            }
            return dataid;
        }
        public int Update(int input)
        {
            System.Console.Write("NAME             : ");
            string field1 = System.Console.ReadLine();
            System.Console.Write("POSITION         : ");
            string field2 = System.Console.ReadLine();
            System.Console.Write("USERNAME         : ");
            string field3 = System.Console.ReadLine();
            System.Console.Write("PASSWORD         : ");
            string field4 = System.Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("PLEASE INPUT  ID : ");
            string id_dpt = System.Console.ReadLine();

            var getid = context.EMPLOYEES.Find(Convert.ToInt16(id_dpt));
            if (getid == null)
            {
                System.Console.Write("NOT FOUND ID " + id_dpt);
            }
            else
            {
                EMPLOYEE updatedata = GetById(input);
                updatedata.NAME = field1;
                updatedata.POSITION = field2;
                updatedata.USERNAME = field3;
                updatedata.PASSWORD = field4;

                context.Entry(updatedata).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            return input;
        }

        // =========================================== DELETE =============================================
        public void Delete(int input)
        {
            var x = (from y in context.EMPLOYEES where y.ID == input select y).FirstOrDefault();
            context.EMPLOYEES.Remove(x);
            context.SaveChanges();
        }
    }
}
