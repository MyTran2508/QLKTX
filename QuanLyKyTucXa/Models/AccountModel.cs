using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.Models
{
    class AccountModel
    {
        private string maTaiKhoan;
        private string maNhanVien;
        private string tenDangNhap;
        private string matKhau;
        private string role;

        public string MaTaiKhoan { get =>maTaiKhoan; set =>maTaiKhoan = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string Role { get => role; set => role = value; }

        public AccountModel(string maTaiKhoan, string maNhanVien, string tenDangNhap, string matKhau, string role)
        {
            this.MaTaiKhoan = maTaiKhoan;
            this.MaNhanVien = maNhanVien;
            this.MatKhau = matKhau;
            this.TenDangNhap = tenDangNhap;
            this.Role = role;
        }
    }
}
