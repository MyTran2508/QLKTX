using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.Models
{
    class InvoiceModel
    {
        private string maHoaDon;
        private string maNhanVien;
        private string tenNhanVien;
        private string maPhong;
        private float soM3Nuoc;
        private float soCongToDien;
        private Int16 thangGhiSo;
        private double tongTien;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public float SoM3Nuoc { get => soM3Nuoc; set => soM3Nuoc = value; }
        public float SoCongToDien { get => soCongToDien; set => soCongToDien = value; }
        public Int16 ThangGhiSo { get => thangGhiSo; set => thangGhiSo = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }

        public InvoiceModel(string maHoaDon, string maPhong, float soM3Nuoc, float soCongToDien, Int16 thangGhiSo, string maNhanVien, double tongTien)
        {
            this.maHoaDon = maHoaDon;
            this.MaNhanVien = maNhanVien;
            this.MaPhong = maPhong;
            this.SoM3Nuoc = soM3Nuoc;
            this.SoCongToDien = soCongToDien;
            this.ThangGhiSo = thangGhiSo;
            this.TongTien = tongTien;
        }
        public InvoiceModel(string maHoaDon, string maPhong, string tenNhanVien, float soM3Nuoc, float soCongToDien, Int16 thangGhiSo, double tongTien)
        {
            this.maHoaDon = maHoaDon;
            this.tenNhanVien = tenNhanVien;
            this.MaPhong = maPhong;
            this.SoM3Nuoc = soM3Nuoc;
            this.SoCongToDien = soCongToDien;
            this.ThangGhiSo = thangGhiSo;
            this.TongTien = tongTien;
        }
    }
}
