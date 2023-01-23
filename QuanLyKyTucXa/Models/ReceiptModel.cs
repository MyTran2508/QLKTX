using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.Models
{
    class ReceiptModel
    {
        private string maBienLai;
        private string maNhanVien;
        private string tenNhanVien;
        private string tenSinhVien;
        private string maPhong;
        private string namHoc;
        private double soTien;
        private DateTime ngayThu;
        private string maSinhVien;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string TenSinhVien { get => tenSinhVien; set => tenSinhVien = value; }
        public string MaBienLai { get => maBienLai; set => maBienLai = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string NamHoc { get => namHoc; set => namHoc = value; }
        public double SoTien { get => soTien; set => soTien = value; }
        public DateTime NgayThu { get => ngayThu; set => ngayThu = value; }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien =value; }

        public ReceiptModel(string maBienLai, string maNhanVien, string maPhong, string namHoc, double soTien, DateTime ngayThu, string maSinhVien)
        {
            this.maBienLai = maBienLai;
            this.MaNhanVien = maNhanVien;
            this.MaPhong = maPhong;
            this.NamHoc = namHoc;
            this.SoTien = soTien;
            this.NgayThu = ngayThu;
            this.MaSinhVien = maSinhVien;
        }

        public ReceiptModel(string maBienLai, string tenNhanVien, string tenSinhVien, string maPhong, string namHoc, double soTien, DateTime ngayThu)
        {
            this.maBienLai = maBienLai;
            this.TenNhanVien = tenNhanVien;
            this.MaPhong = maPhong;
            this.NamHoc = namHoc;
            this.SoTien = soTien;
            this.NgayThu = ngayThu;
            this.TenNhanVien = tenSinhVien;
        }

    }
}
