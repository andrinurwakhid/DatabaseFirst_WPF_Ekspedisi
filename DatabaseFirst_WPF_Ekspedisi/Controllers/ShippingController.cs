using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst_WPF_Ekspedisi.Models;
using System.Windows;
using System.Windows.Controls;

namespace DatabaseFirst_WPF_Ekspedisi.Controllers
{
    class ShippingController
    {
        ExpeditionEntities2 context = new ExpeditionEntities2();
        
        // =========================================== INSERT =============================================
        public void Insert(DateTime data1,int data2, int data3, int data4, int data5, string data6, 
                           string data7, string data8, string data9, string data10, string data11,
                           string data12, string data13, string data14, string data15, string data16,
                           string data17, string data18, string data19, int data20, int data21, int data22,
                           int data23, int data24, int data25)
        {
            SHIPPING call = new SHIPPING();
            {
                call.DATE = data1;
                call.QUANTITY = data2;
                call.ASSURANCES = data3;
                call.WEIGHTS = data4;
                call.CATEGORY_ID= data5;
                call.SENDER_NAME = data6;
                call.SENDER_PHONE = data7;
                call.SENDER_PROVINCE_ID = data8;
                call.SENDER_REGENCY_ID = data9;
                call.SENDER_DISTRICT_ID = data10;
                call.SENDER_VILLAGE_ID = data11;
                call.SENDER_ADDRESS = data12;
                call.RECEIVER_NAME = data13;
                call.RECEIVER_PHONE = data14;
                call.RECEIVER_PROVINCE_ID = data15;
                call.RECEIVER_REGENCY_ID = data16;
                call.RECEIVER_DISTRICT_ID = data17;
                call.RECEIVER_VILLAGE_ID = data18;
                call.RECEIVER_ADDRESS = data19;
                call.PRICE = data20;
                call.TOTAL_PRICE = data21;
                call.STATUS_SHIPPING_ID = data22;
                call.EMPLOYEE_ID = data23;
                call.PACKAGE_ID = data24;
                call.DESTINATION_BRACH_ID = data25;

            };
            try
            {
                context.SHIPPINGS.Add(call);
                var result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                System.Console.Write(ex.InnerException);
            }
        }

        internal void Insert(DateTime now, TextBox txtQuantity, char v1, TextBox txtWeight, ComboBox cmbCategory, TextBox txtNameSender, TextBox txtPhoneSender, ComboBox cmbProvinceSender, ComboBox cmbRegencySender, ComboBox cmbDistrictSender, ComboBox cmbVillageSender, TextBox txtAddressSender, TextBox txtNameReceiver, TextBox txtPhoneReceiver, ComboBox cmbProvinceReceiver, ComboBox cmbRegencyReceiver, ComboBox cmbDistrictReceiver, ComboBox cmbVillageReceiver, TextBox txtAddressReceiver, TextBox txtPrice, TextBox txtTotalPrice, char v2, char v3, int v4)
        {
            throw new NotImplementedException();
        }
    }
}
