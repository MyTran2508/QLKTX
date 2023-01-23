using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKyTucXa.Controllers;
using QuanLyKyTucXa.Utils.Common;
using QuanLyKyTucXa.Models;

using QuanLyKyTucXa.Services;

namespace QuanLyKyTucXa.Views
{
    public partial class frmRoom : Form
    {
        RoomController rc = null;
        EmployeeController ec = null;
        KindOfRoomController kofc = null;
        public frmRoom()
        {
            InitializeComponent();
            rc = new RoomController();
            ec = new EmployeeController();
            kofc = new KindOfRoomController();
        }
        private void FindAll()
        {
            string error = "";
            var rooms = rc.FindAll(ref error);

            if (rooms != null)
            {
                //DataTable dt = Common.GetDataTable(
                //    "Mã phòng",
                //    "Tình trạng phòng",
                //    "Số lượng sinh viên hiện tại",
                //    "Loại phòng",
                //    "Số lượng sinh viên tối đa",
                //    "Họ tên nhân viên",
                //    "Số điện thoại nhân viên",
                //    "Chức vụ"
                //    );

                //foreach (var rr in rooms)
                //{
                //    Int16 LoaiPhong = 0;
                //    if (rr.LoaiPhong)
                //        LoaiPhong = 1;
                //    dt.Rows.Add(
                //        rr.MaPhong,
                //        rr.TinhTrangPhong, 
                //        rr.SoLuongNhanVienHienTai,
                //        LoaiPhong, 
                //        rr.SoLuongNhanVienToiDa,
                //        rr.HoTenNV,
                //        rr.SDTNhanVien,
                //        rr.ChucVu);

                //}

                DataTable dt = Common.GetDataTable(
                    "Mã phòng",
                    "Loại phòng",
                    "Số lượng sinh viên tối đa",
                    "Số lượng sinh viên hiện tại",
                    "Tình trạng phòng",
                    "Mã nhân viên",
                    "Họ tên nhân viên",
                    "Chức vụ",
                    "Số điện thoại"
                    );

                foreach (var rr in rooms)
                {
                    string LoaiPhong = "Nam";
                    if (rr.LoaiPhong)
                        LoaiPhong = "Nữ";
                    dt.Rows.Add(
                        rr.MaPhong,
                        LoaiPhong,
                        rr.SoLuongSinhVienToiDa,
                        rr.SoLuongSinhVienHienTai,
                        rr.TinhTrangPhong,
                        rr.MaNhanVien,
                        rr.HoTenNV,
                        rr.ChucVu,
                        rr.SDTNhanVien);

                }
                // Return databale 
                this.dgvRoom.DataSource = dt;
            }
        }
        private void FillTextBox(int rowIndex)
        {
            string error = "";
            // Get values
            string id = Common.
                   GetValueOfCellGridView(this.dgvRoom, rowIndex, 0);
            string RoomStatus = Common.GetValueOfCellGridView(this.dgvRoom, rowIndex, 1);
            var room = rc.GetRoomById(id, ref error);

            // Fill Textbox
            TbMaPhong.Text = id;
            TBTinhTrang.Text = RoomStatus;
            CBNhanVien.Text = room.HoTenNV;
            CBLoaiPhong.Text = room.MaLoaiPhong;
        }
        private void frmRoom_Load(object sender, EventArgs e)
        {
            this.FindAll();
            this.FillComboBoxEmployees();
            this.FillComboBoxKindOfRooms();
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = Common.GetCurrentRowSelected(this.dgvRoom);
            this.FillTextBox(rowIndex);
        }
        private void FillComboBoxEmployees()
        {
            string error = "";
            var employees = ec.FindAll(ref error);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = employees;
            CBNhanVien.DataSource = bindingSource.DataSource;
            CBNhanVien.DisplayMember = "HoTenNV";
            CBNhanVien.ValueMember = "MaNhanVien";

            //CBNhanVien.DisplayMember = "HoTenNV";
            //CBNhanVien.ValueMember = "MaPhong";
            //CBNhanVien.DataSource = rooms;
            //CBNhanVien.BindingContext = this.BindingContext;
        }

        private void FillComboBoxKindOfRooms()
        {
            string error = "";
            var kofs = kofc.FindAll(ref error);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = kofs;
            CBLoaiPhong.DataSource = bindingSource.DataSource;
            CBLoaiPhong.DisplayMember = "MaLoaiPhong";
            CBLoaiPhong.ValueMember = "MaLoaiPhong";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = TbMaPhong.Text.Trim();
                string EmployeeId = Common.GetValueComboBox(CBNhanVien);
                string RoomStatus = TBTinhTrang.Text.Trim();
                string KindOfRoomId = Common.GetValueComboBox(CBLoaiPhong);
                Int16 NumberOfStudent = 0;
                string error = "";
                bool isCreated = rc.InsertRoom(Id, EmployeeId, RoomStatus,NumberOfStudent, KindOfRoomId, ref error);
                if (isCreated)
                {
                    // Refresh Data
                    this.FindAll();
                }
                MessageBox.Show(error);
            }
            catch
            {
                MessageBox.Show("Đã Xảy Ra Lỗi, Vui Lòng Thử Lại");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.dgvRoom);
                // Get Values
                string id = Common.
                    GetValueOfCellGridView(this.dgvRoom, rowIndex, 0);
                string EmployeeId = Common.GetValueComboBox(CBNhanVien);
                string RoomStatus = TBTinhTrang.Text.Trim();
                string KindOfRoomId = Common.GetValueComboBox(CBLoaiPhong);
                Int16 NumberOfStudent = 0;

                string error = "";
                bool isCreated = rc.UpdateRoom(id, EmployeeId, RoomStatus, NumberOfStudent, KindOfRoomId, ref error);
                if (isCreated)
                {
                    // Refresh Data
                    this.FindAll();
                }
                MessageBox.Show(error);
            }
            catch
            {
                MessageBox.Show("Đã Xảy Ra Lỗi, Vui Lòng Thử Lại");
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.dgvRoom);
                // Get Id
                string Id = Common.
                    GetValueOfCellGridView(this.dgvRoom, rowIndex, 0);
                // remove
                string error = "";
                bool isDeleted = rc.RemoveRoom(Id, ref error);
                if (isDeleted)
                {
                    this.FindAll();
                }
                MessageBox.Show(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
