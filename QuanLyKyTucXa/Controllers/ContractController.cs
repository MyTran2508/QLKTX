using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKyTucXa.Models;
using QuanLyKyTucXa.Services;

namespace QuanLyKyTucXa.Controllers
{
    class ContractController
    {
        ContractService es = new ContractService();
        private ContractModel CreateContract(string maHopDong, DateTime ngayDangKy, DateTime ngayBatDau, DateTime ngayKetThuc, string maNhanVien, string maSinhVien, string maPhong)
        {
            ContractModel Contract = new ContractModel(maHopDong, ngayDangKy, ngayBatDau, ngayKetThuc,  maNhanVien, maSinhVien, maPhong);
            return Contract;
        }

        public List<ContractModel> GetAllContracts(ref string error)
        {

            try
            {
                var Contract = es.GetAllContracts().ToList();
                if (Contract != null)
                {
                    error = "Get All Contract Success!!!";
                    return Contract;
                }
                else
                {
                    error = "Get All Contract Fail!!!";
                    return null;
                }
            }
            catch
            {
                error = "Sonething Was Wrong When Get Contracts!!!";
                return null;
            }

        }

        // Insert Contract
        public bool InsertContract
        (
            string maHopDong,
            string maNhanVien,
            string maSinhVien,
            DateTime ngayDangKy,
            DateTime ngayBatDau,
            DateTime ngayKetThuc,
            string maPhong,
            ref string error)
        {
            try
            {
                var Contract = this.
                    CreateContract(maHopDong, ngayDangKy, ngayBatDau, ngayKetThuc, maNhanVien, maSinhVien, maPhong);
                if (Contract != null)
                {
                    bool isInsert = es.Insert(Contract);
                    if (isInsert)
                    {
                        error = "Add Contract Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Add Contract fail";
                        return false;
                    }
                }
                error = "Contract Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Add Contract!!!";
                return false;
            }
        }

        // Update Contract
        public bool UpdateContract
        (
            string maHopDong,
            string maNhanVien,
            string maSinhVien,
            DateTime ngayDangKy,
            DateTime ngayBatDau,
            DateTime ngayKetThuc,
            string maPhong,
            ref string error)
        {
            try
            {
                var Contract = this.
                    CreateContract(maHopDong, ngayDangKy, ngayBatDau, ngayKetThuc, maNhanVien, maSinhVien, maPhong);
                if (Contract != null)
                {
                    bool isInsert = es.Update(Contract);
                    if (isInsert)
                    {
                        error = "Update Contract Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Update Contract fail";
                        return false;
                    }
                }
                error = "Contract Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Add Contract!!!";
                return false;
            }
        }
        public bool RemoveContract(string maHopDong, ref string error)
        {
            try
            {
                bool numOfState = es.Remove(maHopDong);
                if (numOfState)
                {
                    error = "Remove Contract Success!!!";
                    return true;
                }
                else
                {
                    error = "Remove Contract Failure!!!";
                    return false;
                }
                error = "Contract Is Not Exist!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Remove Contract!!!";
                return false;
            }
        }
    }
}
