using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKyTucXa.Models;
using QuanLyKyTucXa.Services;

namespace QuanLyKyTucXa.Controllers
{
    class AccountController
    {
        AccountService accs = new AccountService();
        private AccountModel CreateAccount(string accID, string empID, string username, string password, string role, ref string error)
        {
            AccountModel account = new AccountModel(accID, empID, username, password, role);
            return account;
        }
        public bool CheckAccount(string name, string pass)
        {
            AccountService acc = new AccountService();
            List<AccountModel> account = new List<AccountModel>();
            account = acc.GetAccounts();

            foreach (var i in account)
            {
                if (i.TenDangNhap.Trim() == name && i.MatKhau.Trim() == pass)
                    return true;
            }  
            return false;
        }
        public bool InsertAccount(string accID, string empID, string username, string password, string role, ref string error)
        {
            try
            {
                if (accID == ""
                    || empID == ""
                    || username == ""
                    || password == ""
                    || role == "")
                {
                    error = "Missing parameter";
                    return false;
                }
                var account = this.CreateAccount(accID, empID, username, password, role, ref error);
                if (account != null)
                {
                    bool isInsert = accs.Insert(account);
                    if (isInsert)
                    {
                        error = "Insert account Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Insert account fail!";
                        return false;
                    }
                }
                error = "Account Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Add account!!!";
                return false;
            }
        }
        public bool UpdateAccount(string accID, string empID, string username, string password, string role, ref string error)
        {
            try
            {
                if (accID == ""
                    || empID == ""
                    || username == ""
                    || password == ""
                    || role == "")
                {
                    error = "Missing parameter";
                    return false;
                }
                var account = this.CreateAccount(accID, empID, username, password, role, ref error);
                if (account != null)
                {
                    bool isUpdate = accs.Update(account);
                    if (isUpdate)
                    {
                        error = "Update account Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Update account fail!";
                        return false;
                    }
                }
                error = "Account Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Update account!!!";
                return false;
            }
        }
        public bool RemoveAccount(string accID, ref string error)
        {
            try
            {
                bool numOfState = accs.Remove(accID);
                if (numOfState)
                {
                    error = "Remove account Success!!!";
                    return true;
                }
                else
                {
                    error = "Remove account Failure!!!";
                    return false;
                }
                error = "Account Is Not Exist!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Remove account!!!";
                return false;
            }
        }
    }
}
