using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst_WPF_Ekspedisi.Models;

namespace DatabaseFirst_WPF_Ekspedisi.Controllers
{
    class ShippingController
    {
        ExpeditionEntities context = new ExpeditionEntities();
        
        // =========================================== INSERT =============================================
        public void Insert()
        {
            Console.Clear();
            System.Console.Write("DATE SHIPPING          : ");
            DateTime data1 = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("WEIGHT                 : ");
            int data2 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("VOLUME                 : ");
            int data3 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("QUANTITY               : ");
            int data4 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("ASSURANCE ID           : ");
            int data5 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("RECEIVER NAME          : ");
            string data6 = System.Console.ReadLine();
            System.Console.Write("DEST. ADDRESS          : ");
            string data7 = System.Console.ReadLine();
            System.Console.Write("DEST. SUB DISTRICT     : ");
            string data8 = System.Console.ReadLine();
            System.Console.Write("DEST. REGENCY          : ");
            string data9 = System.Console.ReadLine();
            System.Console.Write("DEST. PROVINCE         : ");
            string data10 = System.Console.ReadLine();
            System.Console.Write("RECEIVER PHONE         : ");
            string data11 = System.Console.ReadLine();
            System.Console.Write("SEND. NAME             : ");
            string data12 = System.Console.ReadLine();
            System.Console.Write("SEND. ADDRESS          : ");
            string data13 = System.Console.ReadLine();
            System.Console.Write("SEND. SUB DISTRICT     : ");
            string data14 = System.Console.ReadLine();
            System.Console.Write("SEND. REGENCY          : ");
            string data15 = System.Console.ReadLine();
            System.Console.Write("SEND. PROVINCE         : ");
            string data16 = System.Console.ReadLine();
            System.Console.Write("SEND. PHONE            : ");
            string data17 = System.Console.ReadLine();
            System.Console.Write("PRICE                  : ");
            int data18 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("TOTAL PRICE            : ");
            int data19 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("STATUS SHIPPING ID     : ");
            int data20 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("EMPLOYEE ID            : ");
            int data21 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("BRANCH ID              : ");
            int data22 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("PACKAGE ID             : ");
            int data23 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("CATEGORY ID            : ");
            int data24 = Convert.ToInt32(System.Console.ReadLine());

            SHIPPING call = new SHIPPING();
            {
                call.DATE_SHIPPING = data1;
                call.WEIGHTS = data2;
                call.VOLUME = data3;
                call.QUANTITY = data4;
                call.ASSURANCES_ID = data5;
                call.RECEIVER_NAME = data6;
                call.DESTINATION_ADDRESS = data7;
                call.DESTINATION_SUB_DISTRICT = data8;
                call.DESTINATION_REGENCY = data9;
                call.DESTINATION_PROVINCE = data10;
                call.RECEIVER_PHONE = data11;
                call.SENDER_NAME = data12;
                call.SENDER_ADDRESS = data13;
                call.SENDER_SUB_DISTRICT = data14;
                call.SENDER_REGENCY = data15;
                call.SENDER_PROVINCE = data16;
                call.SENDER_PHONE = data17;
                call.PRICE = data18;
                call.TOTAL_PRICE = data19;
                call.STATUS_SHIPPING_ID = data20;
                call.EMPLOYEE_ID = data21;
                call.BRANCH_ID = data22;
                call.PACKAGE_ID = data23;
                call.CATEGORY_ID = data24;

            };
            try
            {
                context.SHIPPINGS.Add(call);
                var result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<SHIPPING> Read()
        {
            var getalls = context.SHIPPINGS.ToList();
            foreach (SHIPPING data in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                     : " + data.ID);
                System.Console.WriteLine("DATE SHIPPING          : " + data.DATE_SHIPPING);
                System.Console.WriteLine("WEIGHT                 : " + data.WEIGHTS);
                System.Console.WriteLine("VOLUME                 : " + data.VOLUME);
                System.Console.WriteLine("QUANTITY               : " + data.QUANTITY);
                System.Console.WriteLine("ASSURANCE ID           : " + data.ASSURANCES_ID);
                System.Console.WriteLine("RECEIVER NAME          : " + data.RECEIVER_NAME);
                System.Console.WriteLine("DEST. ADDRESS          : " + data.DESTINATION_ADDRESS);
                System.Console.WriteLine("DEST. SUB DISTRICT     : " + data.DESTINATION_SUB_DISTRICT);
                System.Console.WriteLine("DEST. REGENCY          : " + data.DESTINATION_REGENCY);
                System.Console.WriteLine("DEST. PROVINCE         : " + data.DESTINATION_PROVINCE);
                System.Console.WriteLine("RECEIVER PHONE         : " + data.RECEIVER_PHONE);
                System.Console.WriteLine("SEND. NAME             : " + data.SENDER_NAME);
                System.Console.WriteLine("SEND. ADDRESS          : " + data.SENDER_ADDRESS);
                System.Console.WriteLine("SEND. SUB DISTRICT     : " + data.SENDER_SUB_DISTRICT);
                System.Console.WriteLine("SEND. REGENCY          : " + data.SENDER_REGENCY);
                System.Console.WriteLine("SEND. PROVINCE         : " + data.SENDER_PROVINCE);
                System.Console.WriteLine("SEND. PHONE            : " + data.SENDER_PHONE);
                System.Console.WriteLine("PRICE                  : " + data.PRICE);
                System.Console.WriteLine("TOTAL PRICE            : " + data.TOTAL_PRICE);
                System.Console.WriteLine("STATUS SHIPPING ID     : " + data.STATUS_SHIPPING_ID);
                System.Console.WriteLine("EMPLOYEE ID            : " + data.EMPLOYEE_ID);
                System.Console.WriteLine("BRANCH ID              : " + data.BRANCH_ID);
                System.Console.WriteLine("PACKAGE ID             : " + data.PACKAGE_ID);
                System.Console.WriteLine("CATEGORY ID            : " + data.CATEGORY_ID);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public SHIPPING GetById(int input)
        {
            var dataid = context.SHIPPINGS.Find(input);
            if (dataid == null)
            {
                System.Console.WriteLine("ID " + input + " NOT FOUND");
            }
            return dataid;
        }
        public int Update(int input)
        {

            System.Console.Write("DATE SHIPPING          : ");
            DateTime field1 = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("WEIGHT                 : ");
            int field2 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("VOLUME                 : ");
            int field3 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("QUANTITY               : ");
            int field4 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("ASSURANCE ID           : ");
            int field5 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("RECEIVER NAME          : ");
            string field6 = System.Console.ReadLine();
            System.Console.Write("DEST. ADDRESS          : ");
            string field7 = System.Console.ReadLine();
            System.Console.Write("DEST. SUB DISTRICT     : ");
            string field8 = System.Console.ReadLine();
            System.Console.Write("DEST. REGENCY          : ");
            string field9 = System.Console.ReadLine();
            System.Console.Write("DEST. PROVINCE         : ");
            string field10 = System.Console.ReadLine();
            System.Console.Write("RECEIVER PHONE         : ");
            string field11 = System.Console.ReadLine();
            System.Console.Write("SEND. NAME             : ");
            string field12 = System.Console.ReadLine();
            System.Console.Write("SEND. ADDRESS          : ");
            string field13 = System.Console.ReadLine();
            System.Console.Write("SEND. SUB DISTRICT     : ");
            string field14 = System.Console.ReadLine();
            System.Console.Write("SEND. REGENCY          : ");
            string field15 = System.Console.ReadLine();
            System.Console.Write("SEND. PROVINCE         : ");
            string field16 = System.Console.ReadLine();
            System.Console.Write("SEND. PHONE            : ");
            string field17 = System.Console.ReadLine();
            System.Console.Write("PRICE                  : ");
            int field18 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("TOTAL PRICE            : ");
            int field19 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("STATUS SHIPPING ID     : ");
            int field20 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("EMPLOYEE ID            : ");
            int field21 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("BRANCH ID              : ");
            int field22 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("PACKAGE ID             : ");
            int field23 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("CATEGORY ID            : ");
            int field24 = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("PLEASE INPUT  ID : ");
            string id_dpt = System.Console.ReadLine();

            var getid = context.SHIPPINGS.Find(Convert.ToInt16(id_dpt));
            if (getid == null)
            {
                System.Console.Write("NOT FOUND ID " + id_dpt);
            }
            else
            {
                SHIPPING updatedata = GetById(input);
                updatedata.DATE_SHIPPING = field1;
                updatedata.WEIGHTS = field2;
                updatedata.VOLUME = field3;
                updatedata.QUANTITY = field4;
                updatedata.ASSURANCES_ID = field5;
                updatedata.RECEIVER_NAME = field6;
                updatedata.DESTINATION_ADDRESS = field7;
                updatedata.DESTINATION_SUB_DISTRICT = field8;
                updatedata.DESTINATION_REGENCY = field9;
                updatedata.DESTINATION_PROVINCE = field10;
                updatedata.RECEIVER_PHONE = field11;
                updatedata.SENDER_NAME = field12;
                updatedata.SENDER_ADDRESS = field13;
                updatedata.SENDER_SUB_DISTRICT = field14;
                updatedata.SENDER_REGENCY = field15;
                updatedata.SENDER_PROVINCE = field16;
                updatedata.SENDER_PHONE = field17;
                updatedata.PRICE = field18;
                updatedata.TOTAL_PRICE = field19;
                updatedata.STATUS_SHIPPING_ID = field20;
                updatedata.EMPLOYEE_ID = field21;
                updatedata.BRANCH_ID = field22;
                updatedata.PACKAGE_ID = field23;
                updatedata.CATEGORY_ID = field24;

                context.Entry(updatedata).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void Delete(int input)
        {
            var x = (from y in context.SHIPPINGS where y.ID == input select y).FirstOrDefault();
            context.SHIPPINGS.Remove(x);
            context.SaveChanges();
        }
    }
}
