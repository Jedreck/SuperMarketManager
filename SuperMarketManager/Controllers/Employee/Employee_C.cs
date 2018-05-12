using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace SuperMarketManager.Controllers
{
    public class Employee_C
    {
        //添加员工_1
        public static Employee AddEmployee(string name, string sex, string phone, string birth
            , int position, string bankAccount = "", string email = "")
        {
            return AddEmployee(new Employee(name, sex, phone, birth, position, bankAccount, email));
        }

        //添加员工_2s
        public static Employee AddEmployee(Employee employee)
        {
            int i = 0;
            string id = "";
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            OdbcCommand odbcCommand = new OdbcCommand();
            OdbcDataReader odbcDataReader = null;
            odbcCommand.Connection = odbcConnection;
            string selectSql = "select * from employee where E_ID='";
            while (i < 5)//检查id是否可用
            {
                id = IDFormat.getID_8();
                selectSql = selectSql + id + "'";
                odbcCommand.CommandText = selectSql;
                odbcDataReader = odbcCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (!odbcDataReader.HasRows)
                {
                    break;
                }
                odbcDataReader.Close();
                i++;
            }
            if (i >= 5)//5次获取不到ID，返回null
            {
                odbcConnection.Close();
                return null;
            }
            //成功获取到ID
            odbcDataReader.Close();
            odbcConnection.Close();
            odbcConnection.Open();
            employee.ID = id;
            employee.PassWord = "000000";
            String insertSql = String.Format("insert into `marketmanage`.`employee`  (`E_ID`, `E_Name`, `E_Sex`, `E_Phone`, `E_Birth`, `E_BankAccount`, `E_Email`, `E_Position`, `E_Password`) " +
                "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')"
                , employee.ID, employee.Name, employee.Sex, employee.Phone, employee.Birth, employee.BankAccount, employee.Email, employee.Position, employee.PassWord);
            odbcCommand.CommandText = insertSql;
            i = odbcCommand.ExecuteNonQuery();
            odbcConnection.Close();
            return (i > 0) ? employee : null;
        }

        internal static bool AlterByID(Employee employee)
        {
            throw new NotImplementedException();
        }

        //删
        public static bool DeleteByID(string id)
        {
            int deleted = 0;
            string sql = "DELETE FROM employee WHERE E_ID='" + id + "'";
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
            deleted = odbcCommand.ExecuteNonQuery();
            odbcConnection.Close();
            return (deleted > 0) ? true : false;
        }

        //改
        public static bool AlterByID(Employee employee)
        {
            String sql = "UPDATE `marketmanage`.`employee` "
                + " SET "
                + " `E_Name`= '" + employee.Name + "'"
                + " ,`E_Sex`= '" + employee.Sex + "'"
                + " ,`E_Phone`= '" + employee.Phone + "'"
                + " ,`E_Birth`= '" + employee.Birth + "'"
                + " ,`E_BankAccount`= '" + employee.BankAccount + "'"
                + " ,`E_Position`=" + employee.Position
                + " ,`E_Password`= '" + employee.PassWord + "'"
                + "WHERE"
                +"`D_ID`= '"+employee.ID+"'";
            OdbcConnection connection = DBManager.GetOdbcConnection();
            connection.Open();
            OdbcCommand cammand = new OdbcCommand(sql, connection);
            int i = cammand.ExecuteNonQuery();
            connection.Close();
            return (i > 0) ? true : false;
        }

        //查
        public static List<Employee> SelectFuzzy(string info)
        {
            string sql = "SELECT * FROM employee "
                + "WHERE `E_ID` LIKE '%" + info + "%'"
                + "OR `E_Name` LIKE '%" + info + "%'"
                + "OR `E_Sex` LIKE '%" + info + "%'"
                + "OR `E_Phone` LIKE '%" + info + "%'"
                + "OR `E_Birth` LIKE '%" + info + "%'"
                + "OR `E_BankAccount` LIKE '%" + info + "%'"
                + "OR `E_Email` LIKE '%" + info + "%'"
                + "OR `E_Position` LIKE '%" + info + "%'";
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
            OdbcDataReader odbcDataReader = odbcCommand.ExecuteReader(CommandBehavior.CloseConnection);
            if (odbcDataReader.HasRows)
            {
                List<Employee> list = Employee.getList(odbcDataReader);
                odbcConnection.Close();
                return list;
            }
            else
                odbcConnection.Close();
            return null;
        }
    }
}