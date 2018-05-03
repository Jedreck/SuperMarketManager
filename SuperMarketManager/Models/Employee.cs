using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public DateTime Birth { get; set; }
        public string BankAccount { get; set; }
        public string Email { get; set; }
        public int Position { get; set; }
        public string PassWord { get; set; }

        public Employee() { }

        public Employee(string name, string sex, string phone, string birth,
             int position, string password = "", string bankAccount="",string email="")
        {
            Name = name;
            Sex = sex;
            Phone = phone;
            Birth = DateTime.Parse(birth);
            Position = position;
            PassWord = password;
            BankAccount = bankAccount;
            Email = email;
        }

        public static List<Employee> getList(OdbcDataReader reader)
        {
            List<Employee> list = new List<Employee>();
            Employee employee;
            while (reader.Read())
            {
                employee = new Employee();
                employee.ID = reader.GetString(0);
                employee.Name = reader.GetString(1);
                employee.Sex = reader.GetString(2);
                employee.Phone = reader.GetString(3);
                employee.Birth = reader.GetDate(4);
                employee.BankAccount = reader[5].ToString();
                employee.Email = reader[6].ToString();
                employee.Position = reader.GetInt32(7);
                employee.PassWord = reader.GetString(8);
                list.Add(employee);
            }
            return list;
        }
    }
}