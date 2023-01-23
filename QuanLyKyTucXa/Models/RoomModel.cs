using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.Models
{
    class RoomModel
    {
        private string maPhong;
        private string maNhanVien;
        private string tinhTrangPhong;
        private string maLoaiPhong;
        private Int16 soLuongSinhVienHienTai;
        private bool loaiPhong;
        private Int16 soLuongSinhVienToiDa;
        private string hoTenNV;
        private string sdtNhanVien;
        private string chucVu;


        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TinhTrangPhong { get => tinhTrangPhong; set => tinhTrangPhong = value; }
        public Int16 SoLuongSinhVienHienTai { get => soLuongSinhVienHienTai; set => soLuongSinhVienHienTai = value; }
        public bool LoaiPhong { get => loaiPhong; set =>loaiPhong =value; }
        public string MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }
        public Int16 SoLuongSinhVienToiDa { get => soLuongSinhVienToiDa; set => soLuongSinhVienToiDa = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public string SDTNhanVien { get => sdtNhanVien; set => sdtNhanVien = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public RoomModel(string maPhong, string hoTenNV, string tinhTrangPhong, string  maLoaiPhong)
        {
            this.MaPhong = maPhong;
            this.HoTenNV = hoTenNV;
            this.TinhTrangPhong = tinhTrangPhong;
            this.MaLoaiPhong = maLoaiPhong;
        }
        public RoomModel(string maPhong, string maNhanVien, string tinhTrangPhong, Int16 soLuongSVHienTai, string maLoaiPhong)
        {
            this.MaPhong = maPhong;
            this.MaNhanVien = maNhanVien;
            this.TinhTrangPhong = tinhTrangPhong;
            this.SoLuongSinhVienHienTai = soLuongSVHienTai;
            this.MaLoaiPhong = maLoaiPhong;
        }
        public RoomModel(
            string maPhong, 
            string tinhTrangPhong,
            Int16 soLuongSinhVienHienTai, 
            bool loaiPhong,
            Int16 soLuongSinhVienToiDa,
            string hotenNhanVien,
            string sdtNhanVien,
            string chucVu
            )
        {
            this.MaPhong = maPhong;
            this.TinhTrangPhong = tinhTrangPhong;
            this.SoLuongSinhVienHienTai = soLuongSinhVienHienTai;
            this.LoaiPhong = loaiPhong;
            this.SoLuongSinhVienToiDa = soLuongSinhVienToiDa;
            this.HoTenNV = hotenNhanVien;
            this.SDTNhanVien = sdtNhanVien;
            this.ChucVu = chucVu;
        }

        public RoomModel(
           string maPhong,
           bool loaiPhong,
           Int16 soLuongSinhVienToiDa,
           Int16 soLuongSinhVienHienTai,
           string tinhTrangPhong,
           string maNhanVien,
           string hotenNhanVien,
           string chucVu,
           string sdtNhanVien
           )
        {
            this.MaPhong = maPhong;
            this.TinhTrangPhong = tinhTrangPhong;
            this.SoLuongSinhVienHienTai = soLuongSinhVienHienTai;
            this.LoaiPhong = loaiPhong;
            this.SoLuongSinhVienToiDa = soLuongSinhVienToiDa;
            this.HoTenNV = hotenNhanVien;
            this.SDTNhanVien = sdtNhanVien;
            this.ChucVu = chucVu;
            this.MaNhanVien = maNhanVien;
        }
        public RoomModel()
        { }
        public virtual EmployeeModel Employee { get; set; }
        public virtual KindOfRoomModel KindOfRoom { get; set; }
    }
}
