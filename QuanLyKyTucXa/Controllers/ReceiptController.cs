using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKyTucXa.Models;
using QuanLyKyTucXa.Services;

namespace QuanLyKyTucXa.Controllers
{
    class ReceiptController
    {
        ReceiptService receipts = new ReceiptService();
        private ReceiptModel CreateReceipt(string receiptID, string employeeID, string roomID, string schoolYear, double fee, DateTime date, string studentID, ref string error)
        {
            ReceiptModel receipt = new ReceiptModel(receiptID, employeeID, roomID, schoolYear, fee, date, studentID);
            return receipt;
        }
        public List<ReceiptModel> GetView(ref string error)
        {

            try
            {
                var receipt = receipts.GetView().ToList();
                if (receipt != null)
                {
                    error = "Get All receipts Success!!!";
                    return receipt;
                }
                else
                {
                    error = "Get All receipts Fail!!!";
                    return null;
                }
            }
            catch
            {
                error = "Sonething Was Wrong When Get receipts!!!";
                return null;
            }
        }
        public bool InsertReceipt(string receiptID, string employeeID, string roomID, string schoolYear, double fee, DateTime date, string studentID, ref string error)
        {
            try
            {
                if (receiptID =="" 
                    || employeeID == "" 
                    || roomID == "" 
                    || schoolYear == "" 
                    || date == null 
                    || studentID == "")
                {
                    error = "Missing parameter";
                    return false;
                }
                var receipt = this.CreateReceipt(receiptID, employeeID, roomID, schoolYear, fee, date, studentID, ref error);
                if (receipt != null)
                {
                    bool isInsert = receipts.Insert(receipt);
                    if (isInsert)
                    {
                        error = "Insert receipt Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Insert receipt fail!";
                        return false;
                    }
                }
                error = "receipt Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Add receipt!!!";
                return false;
            }
        }
        public bool UpdateReceipt(string receiptID, string employeeID, string roomID, string schoolYear, double fee, DateTime date, string studentID, ref string error)
        {
            try
            {
                if (receiptID == ""
                    || employeeID == ""
                    || roomID == ""
                    || schoolYear == ""
                    || date == null
                    || studentID == "")
                {
                    error = "Missing parameter";
                    return false;
                }
                var receipt = this.CreateReceipt(receiptID, employeeID, roomID, schoolYear, fee, date, studentID, ref error);
                if (receipt != null)
                {
                    bool isInsert = receipts.Update(receipt);
                    if (isInsert)
                    {
                        error = "Update receipt Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Update receipt fail!";
                        return false;
                    }
                }
                error = "receipt Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Update receipt!!!";
                return false;
            }
        }
        public bool RemoveReceipt(string receiptID, ref string error)
        {
            try
            {
                bool numOfState = receipts.Remove(receiptID);
                if (numOfState)
                {
                    error = "Remove receipt Success!!!";
                    return true;
                }
                else
                {
                    error = "Remove receipt Failure!!!";
                    return false;
                }
                error = "receipt Is Not Exist!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Remove receipt!!!";
                return false;
            }
        }
    }
}
