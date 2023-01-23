using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.Models
{
    class EmployeeModel
    {
        private string maNhanVien;
        private string hoTenNV;
        private bool gioiTinh;
        private string diaChi;
        private string soDienThoai;
        private string chucVu;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien=value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public bool GioiTinh { get => gioiTinh ; set =>gioiTinh =value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string ChucVu { get => chucVu; set =>  chucVu =value; }

        public EmployeeModel(string maNhanVien, string hoTenNV, bool gioiTinh, string diaChi, string soDienThoai, string chucVu)
        {
            this.MaNhanVien = maNhanVien;
            this.HoTenNV = hoTenNV;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
            this.ChucVu = chucVu;
        }
    }
}
