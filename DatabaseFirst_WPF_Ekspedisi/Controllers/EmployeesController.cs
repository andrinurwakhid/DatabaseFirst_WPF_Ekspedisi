﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst_WPF_Ekspedisi.Models;

namespace DatabaseFirst_WPF_Ekspedisi
{
    class EmployeesController
    {
        
        ExpeditionEntities context = new ExpeditionEntities();
        // =========================================== LOGIN =============================================
        public bool login(string username, string password)
        {

            bool cek = false;
            var temp = context.EMPLOYEES.FirstOrDefault();
            try
            {
                if (temp.USERNAME == username && temp.PASSWORD == password)
                {
                    cek = true;
                }
            }
            catch (Exception context)
            {
                cek = false;
                context.GetBaseException();
            }
            return cek;
        }

        // =========================================== INSERT =============================================
        public void Insert()
        {
            Console.Clear();
            System.Console.Write("NAME        : ");
            string data1 = System.Console.ReadLine();
            System.Console.Write("POSITION    : ");
            string data2 = System.Console.ReadLine();
            System.Console.Write("USERNAME    : ");
            string data3 = System.Console.ReadLine();
            System.Console.Write("PASSWORD    : ");
            string data4 = System.Console.ReadLine();

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
