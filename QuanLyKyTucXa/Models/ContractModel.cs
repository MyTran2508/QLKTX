using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.Models
{
    class ContractModel
    {
        private string maHopDong;
        private string maNhanVien;
        private string maSinhVien;
        private string tenNhanVien;
        private string tenSinhVien;
        private DateTime ngayDangKy;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string maPhong;

        public string MaHopDong { get => maHopDong; set => maHopDong = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string TenSinhVien { get => tenSinhVien; set => tenSinhVien = value; }
        public DateTime NgayDangKy { get => ngayDangKy; set => ngayDangKy = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }


        public ContractModel(string maHopDong, DateTime ngayDangKy, DateTime ngayBatDau, DateTime ngayKetThuc, string maNhanVien, string maSinhVien, string maPhong)
        {
            this.MaHopDong = maHopDong;
            this.MaNhanVien = maNhanVien;
            this.MaSinhVien = maSinhVien;
            this.NgayDangKy = ngayDangKy;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.MaPhong = maPhong;
        }
        public ContractModel(string maHopDong, string tenNhanVien, string tenSinhVien, DateTime ngayDangKy, DateTime ngayBatDau, DateTime ngayKetThuc, string maPhong)
        {
            this.MaHopDong = maHopDong;
            this.TenNhanVien = tenNhanVien;
            this.TenSinhVien = tenSinhVien;
            this.NgayDangKy = ngayDangKy;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.MaPhong = maPhong;
        }
    }
}
