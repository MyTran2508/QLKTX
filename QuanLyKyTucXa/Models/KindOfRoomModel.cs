using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.Models
{
    class KindOfRoomModel
    {
        private string maLoaiPhong;
        private bool loaiPhong;
        private Int16 soLuongSVToiDa;

        public string MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }
        public bool LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public Int16 SoLuongSVToiDa { get => soLuongSVToiDa; set => soLuongSVToiDa = value; }

        public KindOfRoomModel(string maLoaiPhong, bool loaiPhong, Int16 soLuongSVToiDa)
        {
            this.MaLoaiPhong = maLoaiPhong;
            this.LoaiPhong = loaiPhong;
            this.SoLuongSVToiDa = soLuongSVToiDa;
        }
    }
}
