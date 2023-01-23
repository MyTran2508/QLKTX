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


namespace QuanLyKyTucXa.Views
{
    public partial class frmStudent : Form
    {
        StudentController sc = null;
        RoomController rc = null;
        public frmStudent()
        {
            InitializeComponent();
            this.sc = new StudentController();
            this.rc = new RoomController();
        }

        private void FindAll()
        {
            string error = "";
            var students = sc.FindAll(ref error);

            if (students != null)
            {
                DataTable dt = Common.GetDataTable(
                    "Mã sinh viên",
                    "Họ tên sinh viên",
                    "Giới tính",
                    "Địa chỉ",
                    "CMND",
                    "Niên khóa",
                    "Mã phòng",
                    "Số lượng sinh viên hiện tại",
                    "Số lượng sinh viên tối đa"
                    );

                foreach (var ss in students)
                {
                    string GioiTinh = "Nam";
                    if (ss.GioiTinh)
                        GioiTinh = "Nữ";
                    dt.Rows.Add(ss.MaSinhVien, ss.HoTenSV, GioiTinh, ss.DiaChi, ss.CCCD, ss.NienKhoa, ss.MaPhong, ss.SoLuongSinhVienTrongPhong, ss.SoLuongSinhVienToiDa);

                }
                // Return databale 
                this.dgvStudent.DataSource = dt;
            }
        }

        private void FillTextBox(int rowIndex)
        {
            // Get values
            string id = Common.
                   GetValueOfCellGridView(this.dgvStudent, rowIndex, 0);
            string StudentName = Common.GetValueOfCellGridView(this.dgvStudent, rowIndex, 1);
            string gender = Common.GetValueOfCellGridView(this.dgvStudent, rowIndex, 2);
            string address = Common.GetValueOfCellGridView(this.dgvStudent, rowIndex, 3);
            string CMND = Common.GetValueOfCellGridView(this.dgvStudent, rowIndex, 4);
            string SchoolYear = Common.GetValueOfCellGridView(this.dgvStudent, rowIndex, 5);
            string RoomId = Common.GetFormatValueOfCellGridView(this.dgvStudent, rowIndex, 6);

            // Fill Textbox
            TbMaSV.Text = id;
            TbHoTen.Text = StudentName;
            TbGioiTinh.Text = gender;
            TbDiaChi.Text = address;
            TbCMND.Text = CMND;
            TbNienKhoa.Text = SchoolYear;
            CbMaPhong.Text = RoomId;

        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            this.FindAll();
            this.FillComboBoxRooms();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = Common.GetCurrentRowSelected(this.dgvStudent);
            this.FillTextBox(rowIndex);
        }
        private void FillComboBoxRooms()
        {
            string error = "";
            var rooms = rc.FindAll(ref error);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = rooms;
            CbMaPhong.DataSource = bindingSource.DataSource;
            CbMaPhong.DisplayMember = "MaPhong";
            CbMaPhong.ValueMember = "MaPhong";
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string StudentId = TbMaSV.Text.Trim();
                string RoomId = Common.GetValueComboBox(CbMaPhong);
                string StudentName = TbHoTen.Text.Trim();
                bool gender = true;
                if (TbGioiTinh.Text.Trim().ToLower() == "nam")
                    gender = false;
                string cccd = TbCMND.Text.Trim();
                string address = TbDiaChi.Text.Trim();
                Int16 SchoolYear = Int16.Parse(TbNienKhoa.Text.Trim());
                string error = "";
                bool isCreated = sc.InsertStudent(StudentId, RoomId, StudentName, gender, address, cccd, SchoolYear, ref error);
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
                int rowIndex = Common.GetCurrentRowSelected(this.dgvStudent);
                // Get Values
                string StudentId = Common.
                    GetValueOfCellGridView(this.dgvStudent, rowIndex, 0);
                string RoomId = Common.GetValueComboBox(CbMaPhong);
                string StudentName = TbHoTen.Text.Trim();
                bool gender = true;
                if (TbGioiTinh.Text.Trim().ToLower() == "nam")
                    gender = false;
                string cccd = TbCMND.Text.Trim();
                string address = TbDiaChi.Text.Trim();
                Int16 SchoolYear = Int16.Parse(TbNienKhoa.Text.Trim());

                string error = "";
                bool isCreated = sc.UpdateStudent(StudentId, RoomId, StudentName, gender, address, cccd, SchoolYear, ref error);
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
                int rowIndex = Common.GetCurrentRowSelected(this.dgvStudent);
                // Get Id
                string Id = Common.
                    GetValueOfCellGridView(this.dgvStudent, rowIndex, 0);

                // remove
                string error = "";
                bool isDeleted = sc.RemoveStudent(Id, ref error);
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
