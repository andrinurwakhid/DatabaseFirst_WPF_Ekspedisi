using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst_WPF_Ekspedisi.Models;

namespace DatabaseFirst_WPF_Ekspedisi.Controllers
{
    class AssuranceController
    {
        ExpeditionEntities context = new ExpeditionEntities();
        // =========================================== INSERT =============================================
        public void Insert()
        {
            Console.Clear();
            System.Console.Write("TYPE            : ");
            string data1 = System.Console.ReadLine();
            System.Console.Write("PRICE           : ");
            int data2 = Convert.ToInt32(System.Console.ReadLine());

            ASSURANCE call = new ASSURANCE();
            {
                call.TYPES = data1;
                call.PRICE = data2;

            };
            try
            {
                context.ASSURANCES.Add(call);
                var result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<ASSURANCE> Read()
        {
            var getalls = context.ASSURANCES.ToList();
            foreach (ASSURANCE data in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                : " + data.ID);
                System.Console.WriteLine("TYPE              : " + data.TYPES);
                System.Console.WriteLine("PRICE             : " + data.PRICE);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public ASSURANCE GetById(int input)
        {
            var dataid = context.ASSURANCES.Find(input);
            if (dataid == null)
            {
                System.Console.WriteLine("ID " + input + " NOT FOUND");
            }
            return dataid;
        }
        public int Update(int input)
        {
            System.Console.Write("TYPE             : ");
            string field1 = System.Console.ReadLine();
            System.Console.Write("PRICE            : ");
            int field2 = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("PLEASE INPUT  ID : ");
            string id_dpt = System.Console.ReadLine();

            var getid = context.ASSURANCES.Find(Convert.ToInt16(id_dpt));
            if (getid == null)
            {
                System.Console.Write("NOT FOUND ID " + id_dpt);
            }
            else
            {
                ASSURANCE updatedata = GetById(input);
                updatedata.TYPES = field1;
                updatedata.PRICE = field2;

                context.Entry(updatedata).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void Delete(int input)
        {
            var x = (from y in context.ASSURANCES where y.ID == input select y).FirstOrDefault();
            context.ASSURANCES.Remove(x);
            context.SaveChanges();
        }
    }
}
