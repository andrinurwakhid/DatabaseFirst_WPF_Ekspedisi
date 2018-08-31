using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst_WPF_Ekspedisi.Models;

namespace DatabaseFirst_WPF_Ekspedisi.Controllers
{
    class WarehouseController
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

            Warehouse call = new Warehouse();
            {
                call.NAME = data1;
                call.PROVINCE = data2;
                call.REGENCY = data3;
                call.SUB_DISTRICT = data4;
                call.LOCATION = data5;

            };
            try
            {
                context.WAREHOUSES.Add(call);
                var result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<Warehouse> Read()
        {
            var getalls = context.WAREHOUSES.ToList();
            foreach (Warehouse data in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                : " + data.ID);
                System.Console.WriteLine("NAME              : " + data.NAME);
                System.Console.WriteLine("PROVINCE          : " + data.PROVINCE);
                System.Console.WriteLine("REGENCY           : " + data.REGENCY);
                System.Console.WriteLine("SUB DISTRICT      : " + data.SUB_DISTRICT);
                System.Console.WriteLine("LOCATION          : " + data.LOCATION);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public Warehouse GetById(int input)
        {
            var dataid = context.WAREHOUSES.Find(input);
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
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("PLEASE INPUT  ID : ");
            string id_dpt = System.Console.ReadLine();

            var getid = context.WAREHOUSES.Find(Convert.ToInt16(id_dpt));
            if (getid == null)
            {
                System.Console.Write("NOT FOUND ID " + id_dpt);
            }
            else
            {
                Warehouse updatedata = GetById(input);
                updatedata.NAME = field1;
                updatedata.PROVINCE = field2;
                updatedata.REGENCY = field3;
                updatedata.SUB_DISTRICT = field4;

                context.Entry(updatedata).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void Delete(int input)
        {
            var x = (from y in context.WAREHOUSES where y.ID == input select y).FirstOrDefault();
            context.WAREHOUSES.Remove(x);
            context.SaveChanges();
        }
    }
}
