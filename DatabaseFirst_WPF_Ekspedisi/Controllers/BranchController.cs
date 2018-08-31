using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst_WPF_Ekspedisi.Models;

namespace DatabaseFirst_WPF_Ekspedisi.Controllers
{
    class BranchController
    {
        ExpeditionEntities context = new ExpeditionEntities();
        // =========================================== INSERT =============================================
        public void Insert()
        {
            Console.Clear();
            System.Console.Write("NAME            : ");
            string data1 = System.Console.ReadLine();
            System.Console.Write("PROVINCE        : ");
            string data2 = System.Console.ReadLine();
            System.Console.Write("REGENCY         : ");
            string data3 = System.Console.ReadLine();
            System.Console.Write("SUB DISTRICT    : ");
            string data4 = System.Console.ReadLine();
            System.Console.Write("LOCATION        : ");
            string data5 = System.Console.ReadLine();
            System.Console.Write("WAREHOUSE ID    : ");
            int data6 = Convert.ToInt32(System.Console.ReadLine());

            BRANCH call = new BRANCH();
            {
                call.NAME = data1;
                call.PROVINCE = data2;
                call.REGENCY = data3;
                call.SUB_DISTRICT = data4;
                call.LOCATION = data5;
                call.WAREHOUSE_ID = data6;

            };
            try
            {
                context.BRANCHS.Add(call);
                var result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<BRANCH> Read()
        {
            var getalls = context.BRANCHS.ToList();
            foreach (BRANCH data in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                : " + data.ID);
                System.Console.WriteLine("NAME              : " + data.NAME);
                System.Console.WriteLine("PROVINCE          : " + data.PROVINCE);
                System.Console.WriteLine("REGENCY           : " + data.REGENCY);
                System.Console.WriteLine("SUB DISTRICT      : " + data.SUB_DISTRICT);
                System.Console.WriteLine("LOCATION          : " + data.LOCATION);
                System.Console.WriteLine("WAREHOUSE ID      : " + data.WAREHOUSE_ID);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public BRANCH GetById(int input)
        {
            var dataid = context.BRANCHS.Find(input);
            if (dataid == null)
            {
                System.Console.WriteLine("ID " + input + " NOT FOUND");
            }
            return dataid;
        }
        public int Update(int input)
        {
            System.Console.Write("NAME             : ");
            string field1 = System.Console.ReadLine();
            System.Console.Write("PROVINCE         : ");
            string field2 = System.Console.ReadLine();
            System.Console.Write("REGENCY          : ");
            string field3 = System.Console.ReadLine();
            System.Console.Write("SUB DISTRICT     : ");
            string field4 = System.Console.ReadLine();
            System.Console.Write("WAREHOUSE ID     : ");
            int field5 = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("PLEASE INPUT  ID : ");
            string id_dpt = System.Console.ReadLine();

            var getid = context.BRANCHS.Find(Convert.ToInt16(id_dpt));
            if (getid == null)
            {
                System.Console.Write("NOT FOUND ID " + id_dpt);
            }
            else
            {
                BRANCH updatedata = GetById(input);
                updatedata.NAME = field1;
                updatedata.PROVINCE = field2;
                updatedata.REGENCY = field3;
                updatedata.SUB_DISTRICT = field4;
                updatedata.WAREHOUSE_ID = field5;

                context.Entry(updatedata).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void Delete(int input)
        {
            var x = (from y in context.BRANCHS where y.ID == input select y).FirstOrDefault();
            context.BRANCHS.Remove(x);
            context.SaveChanges();
        }
    }
}
