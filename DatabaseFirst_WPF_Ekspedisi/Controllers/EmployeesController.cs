using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst_WPF_Ekspedisi
{
    class EmployeesController
    {
        public List<Employees> GetAll()
        {
            var getall = _context.Employees.ToList();
            foreach (Employee employee in getall)
            {
                System.Console.WriteLine("================");
                System.Console.WriteLine("Id : " + employee.Id);
                System.Console.WriteLine("Nama Depan : " + employee.First_Name);
                System.Console.WriteLine("Nama Belakang : " + employee.Last_Name);
                System.Console.WriteLine("Email : " + employee.Email + "@Mii.co.id");
                System.Console.WriteLine("Phone Number : " + employee.Phone_Number);
                System.Console.WriteLine("Birth Date : " + employee.BirthDate);
                System.Console.WriteLine("Salary : " + employee.Salary);
                System.Console.WriteLine("Commission Pct : " + employee.Commission_Pct);
                System.Console.WriteLine("Department : " + employee.Department.Department_Name);
                System.Console.WriteLine("================");
            }
            return getall;
        }
    }
}
