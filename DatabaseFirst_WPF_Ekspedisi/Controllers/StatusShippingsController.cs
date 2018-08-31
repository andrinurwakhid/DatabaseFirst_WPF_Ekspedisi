using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst_WPF_Ekspedisi.Models;

namespace DatabaseFirst_WPF_Ekspedisi.Controllers
{
    class StatusShippingsController
    {
        ExpeditionEntities context = new ExpeditionEntities();
        // =========================================== INSERT =============================================
        public void Insert()
        {
            Console.Clear();
            System.Console.Write("NAME            : ");
            string data1 = System.Console.ReadLine();

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
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<STATUS_SHIPPINGS> Read()
        {
            var getalls = context.STATUS_SHIPPINGS.ToList();
            foreach (STATUS_SHIPPINGS data in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                : " + data.ID);
                System.Console.WriteLine("NAME              : " + data.NAME);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public STATUS_SHIPPINGS GetById(int input)
        {
            var dataid = context.STATUS_SHIPPINGS.Find(input);
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
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("PLEASE INPUT  ID : ");
            string id_dpt = System.Console.ReadLine();

            var getid = context.STATUS_SHIPPINGS.Find(Convert.ToInt16(id_dpt));
            if (getid == null)
            {
                System.Console.Write("NOT FOUND ID " + id_dpt);
            }
            else
            {
                STATUS_SHIPPINGS updatedata = GetById(input);
                updatedata.NAME = field1;

                context.Entry(updatedata).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void Delete(int input)
        {
            var x = (from y in context.STATUS_SHIPPINGS where y.ID == input select y).FirstOrDefault();
            context.STATUS_SHIPPINGS.Remove(x);
            context.SaveChanges();
        }
    }
}
