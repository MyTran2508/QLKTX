using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.Models
{
    class StudentModel
    {
        private string maSinhVien;
        private string maPhong;
        private string hoTenSV;
        private bool gioiTinh;
        private string diaChi;
        private string cCCD;
        private Int16 niemKhoa;

        private Int16 soLuongSinhVienTrongPhong;
        private string tinhTrangPhong;
        private Int16 soLuongSinhVienToiDa;

        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string HoTenSV { get => hoTenSV; set => hoTenSV = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public Int16 NienKhoa { get => niemKhoa; set =>niemKhoa =value; }
        public Int16 SoLuongSinhVienTrongPhong { get => soLuongSinhVienTrongPhong; set => soLuongSinhVienTrongPhong = value; }
        public Int16 SoLuongSinhVienToiDa { get => soLuongSinhVienToiDa; set => soLuongSinhVienToiDa = value; }
        public string TinhTrangPhong { get => tinhTrangPhong; set => tinhTrangPhong = value; }
        public StudentModel(string maSinhVien, string hoTenSV, bool gioiTinh, string diaChi, string cCCD, Int16 nienKhoa, string maPhong, Int16 soLuongSinhVienTrongPhong, Int16 soLuongSVToiDa)
        {
            this.MaSinhVien = maSinhVien;
            this.MaPhong = maPhong;
            this.HoTenSV = hoTenSV;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.CCCD = cCCD;
            this.NienKhoa = nienKhoa;
            this.SoLuongSinhVienTrongPhong = soLuongSinhVienTrongPhong;
            this.SoLuongSinhVienToiDa = soLuongSVToiDa;
        }
        public StudentModel(string maSinhVien, string maPhong, string hoTenNV, bool gioiTinh, string diaChi, string cCCD, Int16 nienKhoa)
        {
            this.MaSinhVien = maSinhVien;
            this.MaPhong = maPhong;
            this.HoTenSV= hoTenNV;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.CCCD = cCCD;
            this.NienKhoa = nienKhoa;
        }

        public StudentModel(string maPhong)
        {
            this.maPhong = maPhong;
        }

    }
}
