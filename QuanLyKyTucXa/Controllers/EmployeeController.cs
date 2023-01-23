using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKyTucXa.Models;
using QuanLyKyTucXa.Services;

namespace QuanLyKyTucXa.Controllers
{
    class EmployeeController
    {
        EmployeeService es = new EmployeeService();
        private EmployeeModel CreateEmployee(string Id, string EmployeeName, bool Gender, string Address, string Phonenumber, string Postiton)
        {
            EmployeeModel employee = new EmployeeModel(Id, EmployeeName, Gender, Address, Phonenumber, Postiton);
            return employee;
        }

        public List<EmployeeModel> FindAll(ref string error)
        {

            try
            {
                var employee = es.FindAll().ToList();
                if (employee != null)
                {
                    error = "Get All Employee Success!!!";
                    return employee;
                }
                else
                {
                    error = "Get All Employee Fail!!!";
                    return null;
                }
            }
            catch
            {
                error = "Sonething Was Wrong When Get Employees!!!";
                return null;
            }

        }

        // Insert Employee
        public bool InsertEmployee
        (
            string EmployeeId,
            string EmployeeName,
            bool Gender,
            string Address,
            string PhoneNumber,
            string Postion,
            ref string error)
        {
            try
            {
                if (EmployeeId == ""
                    || EmployeeName == ""
                    || Address == ""
                    || PhoneNumber == ""
                    || Postion == "")
                {
                    error = "Missing parameter";
                    return false;
                }
                var employee = this.
                    CreateEmployee(EmployeeId, EmployeeName, Gender, Address, PhoneNumber, Postion);
                if (employee != null)
                {
                    bool isInsert = es.Insert(employee);
                    if (isInsert)
                    {
                        error = "Add Employee Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Add Employee fail";
                        return false;
                    }
                }
                error = "Employee Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Add Employee!!!";
                return false;
            }
        }

        // Update Employee
        public bool UpdateEmployee
        (
            string EmployeeId,
            string EmployeeName,
            bool Sex,
            string Address,
            string PhoneNumber,
            string Postion,
            ref string error)
        {
            try
            {
                if (EmployeeId == ""
                    || EmployeeName == ""
                    || Address == ""
                    || PhoneNumber == ""
                    || Postion == "")
                {
                    error = "Missing parameter";
                    return false;
                }

                var employee = this.
                    CreateEmployee(EmployeeId, EmployeeName, Sex, Address, PhoneNumber, Postion);
                if (employee != null)
                {
                    bool isInsert = es.Update(employee);
                    if (isInsert)
                    {
                        error = "Update Employee Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Update Employee fail";
                        return false;
                    }
                }
                error = "Employee Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Add Employee!!!";
                return false;
            }
        }
        public bool RemoveEmployee(string Id, ref string error)
        {
            try
            {
                bool numOfState = es.Remove(Id);
                if (numOfState)
                {
                    error = "Remove Employee Success!!!";
                    return true;
                }
                else
                {
                    error = "Remove Employee Failure!!!";
                    return false;
                }
                error = "Employee Is Not Exist!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Remove Employee!!!";
                return false;
            }
        }
    }
}
