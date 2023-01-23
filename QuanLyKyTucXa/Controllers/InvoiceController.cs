using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKyTucXa.Models;
using QuanLyKyTucXa.Services;

namespace QuanLyKyTucXa.Controllers
{
    class InvoiceController
    {
        InvoiceService es = new InvoiceService();
        private InvoiceModel CreateInvoice(string maHoaDon, string maNhanVien, string maPhong, float soM3Nuoc, float soCongToDien, Int16 thangGhiSo, double tongTien)
        {
            InvoiceModel invoice = new InvoiceModel(maHoaDon, maPhong, soM3Nuoc, soCongToDien, thangGhiSo, maNhanVien, tongTien);
            return invoice;
        }

        public List<InvoiceModel> GetAllInvoices(ref string error)
        {

            try
            {
                var invoice = es.GetAllInvoices().ToList();
                if (invoice != null)
                {
                    error = "Get All invoice Success!!!";
                    return invoice;
                }
                else
                {
                    error = "Get All invoice Fail!!!";
                    return null;
                }
            }
            catch
            {
                error = "Sonething Was Wrong When Get invoices!!!";
                return null;
            }

        }

        // Insert invoice
        public bool InsertInvoice
        (
            string maHoaDon,
            string maNhanVien,
            string maPhong,
            float soM3Nuoc,
            float soCongToDien,
            Int16 thangGhiSo,
            double tongTien,
            ref string error)
        {
            try
            {
                var invoice = this.
                    CreateInvoice(maHoaDon, maNhanVien, maPhong, soM3Nuoc, soCongToDien, thangGhiSo, tongTien);
                if (invoice != null)
                {
                    bool isInsert = es.Insert(invoice);
                    if (isInsert)
                    {
                        error = "Add invoice Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Add invoice fail";
                        return false;
                    }
                }
                error = "invoice Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Add invoice!!!";
                return false;
            }
        }

        // Update invoice
        public bool UpdateInvoice
        (
            string maHoaDon,
            string maNhanVien,
            string maPhong,
            float soM3Nuoc,
            float soCongToDien,
            Int16 thangGhiSo,
            double tongTien,
            ref string error)
        {
            try
            {
                var invoice = this.
                    CreateInvoice(maHoaDon, maNhanVien, maPhong, soM3Nuoc, soCongToDien, thangGhiSo, tongTien);
                if (invoice != null)
                {
                    bool isInsert = es.Update(invoice);
                    if (isInsert)
                    {
                        error = "Update invoice Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Update invoice fail";
                        return false;
                    }
                }
                error = "invoice Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Add invoice!!!";
                return false;
            }
        }
        public bool RemoveInvoice(string maHoaDon, ref string error)
        {
            try
            {
                bool numOfState = es.Remove(maHoaDon);
                if (numOfState)
                {
                    error = "Remove invoice Success!!!";
                    return true;
                }
                else
                {
                    error = "Remove invoice Failure!!!";
                    return false;
                }
                error = "invoice Is Not Exist!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Remove invoice!!!";
                return false;
            }
        }
    }
}
