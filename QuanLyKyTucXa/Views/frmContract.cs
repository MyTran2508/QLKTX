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
using QuanLyKyTucXa.Models;
using QuanLyKyTucXa.Utils.Common;
using QuanLyKyTucXa.Services;

namespace QuanLyKyTucXa.Views
{
    public partial class frmContract : Form
    {
        ContractController hd = null;
        RoomController rc = new RoomController();
        EmployeeController ec = new EmployeeController();
        StudentController sc = new StudentController();
        public frmContract()
        {
            InitializeComponent();
            this.hd = new ContractController();
            this.rc = new RoomController();
            this.ec = new EmployeeController();
            this.sc = new StudentController();
        }

        private void GetAllContracts()
        {
            string error = "";
            var Contracts = hd.GetAllContracts(ref error);

            if (Contracts != null)
            {
                DataTable dt = Common.GetDataTable(
                    "Mã Hợp Đồng",
                    "Nhân Viên Lập Hoá Đơn",
                    "Hoá Đơn Của Sinh Viên",
                    "Mã Phòng",
                    "Ngày Đăng Ký",
                    "Ngày Bắt Đầu",
                    "Ngày Kết Thúc"
                    );

                foreach (var ee in Contracts)
                {
                    dt.Rows.Add(ee.MaHopDong, ee.MaNhanVien, ee.MaSinhVien, ee.MaPhong, ee.NgayDangKy, ee.NgayBatDau, ee.NgayKetThuc);

                }
                // Return databale 
                this.dgvContract.DataSource = dt;
            }
        }
        private void FillComboBoxRooms()
        {
            string error = "";
            var rcptRoom = rc.FindAll(ref error);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = rcptRoom;
            CBPhong.DataSource = bindingSource.DataSource;
            CBPhong.DisplayMember = "MaPhong";
            CBPhong.ValueMember = "MaPhong";
        }
        private void FillComboBoxEmps()
        {
            string error = "";
            var rcptEmp = ec.FindAll(ref error);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = rcptEmp;
            CBMaNV.DataSource = bindingSource.DataSource;
            CBMaNV.DisplayMember = "HoTenNV"; // lay theo get, set cua EmployeeModel
            CBMaNV.ValueMember = "MaNhanVien";
        }
        private void FillComboBoxStudents()
        {
            string error = "";
            var rcptStudent = sc.FindAll(ref error);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = rcptStudent;
            CBMaSV.DataSource = bindingSource.DataSource;
            CBMaSV.DisplayMember = "HoTenSV";// lay theo get, set cua StudentModel
            CBMaSV.ValueMember = "MaSinhVien";
        }
        private void FillTextBox(int rowIndex)
        {
            // Get values
            string MaHD = Common.GetValueOfCellGridView(this.dgvContract, rowIndex, 0);
            string MaNV = Common.GetFormatValueOfCellGridView(this.dgvContract, rowIndex, 1);
            string MaSV = Common.GetFormatValueOfCellGridView(this.dgvContract, rowIndex, 2);
            string MaPhong = Common.GetFormatValueOfCellGridView(this.dgvContract, rowIndex, 3);
            string NgayDK = Common.GetValueOfCellGridView(this.dgvContract, rowIndex, 4);
            string NgayBD = Common.GetValueOfCellGridView(this.dgvContract, rowIndex, 5);
            string NgayKT = Common.GetValueOfCellGridView(this.dgvContract, rowIndex, 6);

            // Fill Textbox
            this.txt_MaHD.Text = MaHD;
            this.CBMaNV.Text = MaNV;
            this.CBMaSV.Text = MaSV;
            this.CBPhong.Text = MaPhong;
            this.txt_NgayDK.Text = NgayDK;
            this.txt_NgayBD.Text = NgayBD;
            this.txt_NgayKT.Text = NgayKT;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MaHD = txt_MaHD.Text.Trim();
                string MaNV = Common.GetValueComboBox(CBMaNV);
                string MaSV = Common.GetValueComboBox(CBMaSV);
                string MaPhong = Common.GetValueComboBox(CBPhong);
                DateTime NgayDK = DateTime.Parse(txt_NgayDK.Text.Trim());
                DateTime NgayBD = DateTime.Parse(txt_NgayBD.Text.Trim());
                DateTime NgayKT = DateTime.Parse(txt_NgayKT.Text.Trim());

                string error = "";
                bool isCreated = hd.InsertContract(MaHD, MaNV, MaSV, NgayDK, NgayBD, NgayKT, MaPhong, ref error);
                if (isCreated)
                {
                    // Refresh Data
                    this.GetAllContracts();
                }
                MessageBox.Show(error);
            }
            catch
            {
                MessageBox.Show("Đã Xảy Ra Lỗi, Vui Lòng Thử Lại");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.dgvContract);
                // Get Values
                string MaHD = txt_MaHD.Text.Trim();
                string MaNV = Common.GetValueComboBox(CBMaNV);
                string MaSV = Common.GetValueComboBox(CBMaSV);
                string MaPhong = Common.GetValueComboBox(CBPhong);
                DateTime NgayDK = DateTime.Parse(txt_NgayDK.Text.Trim());
                DateTime NgayBD = DateTime.Parse(txt_NgayBD.Text.Trim());
                DateTime NgayKT = DateTime.Parse(txt_NgayKT.Text.Trim());

                string error = "";
                bool isCreated = hd.UpdateContract(MaHD, MaNV, MaSV, NgayDK, NgayBD, NgayKT, MaPhong, ref error);
                if (isCreated)
                {
                    // Refresh Data
                    this.GetAllContracts();
                }
                MessageBox.Show(error);
            }
            catch
            {
                MessageBox.Show("Đã Xảy Ra Lỗi, Vui Lòng Thử Lại");
            }
        }

        private void frmContract_Load(object sender, EventArgs e)
        {
            this.GetAllContracts();
            this.FillComboBoxEmps();
            this.FillComboBoxRooms();
            this.FillComboBoxStudents();
        }

        private void dgvContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = Common.GetCurrentRowSelected(this.dgvContract);
            this.FillTextBox(rowIndex);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.dgvContract);
                // Get Id
                string MaHD = Common.GetValueOfCellGridView(this.dgvContract, rowIndex, 0);

                // remove
                string error = "";
                bool isDeleted = hd.RemoveContract(MaHD, ref error);
                if (isDeleted)
                {
                    this.GetAllContracts();
                }
                MessageBox.Show(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CBMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSV = Common.GetValueComboBox(CBMaSV);
            string error = "";
            if(maSV != null)
            {
                StudentModel st = sc.FindBy(maSV, ref error);
                if (st != null)
                    this.CBPhong.Text = st.MaPhong;
            }
            
        }
    }
}
