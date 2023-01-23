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
    public partial class frmEmployee : Form
    {
        EmployeeController emp = null;
        public frmEmployee()
        {
            InitializeComponent();
            emp = new EmployeeController();
        }

        private void FindAll()
        {
            string error = "";
            var employees = emp.FindAll(ref error);

            if (employees != null)
            {
                DataTable dt = Common.GetDataTable(
                    "Mã nhân viên",
                    "Họ tên nhân viên",
                    "Giới tính",
                    "Địa chỉ",
                    "Số điện thoại",
                    "Chức vụ"
                    );

                foreach (var ee in employees)
                {
                    string GioiTinh = "Nam";
                    if (ee.GioiTinh)
                        GioiTinh = "Nữ";
                    dt.Rows.Add(ee.MaNhanVien, ee.HoTenNV, GioiTinh, ee.DiaChi, ee.SoDienThoai, ee.ChucVu);

                }
                // Return databale 
                this.dgvEmployee.DataSource = dt;
            }
        }

        private void FillTextBox(int rowIndex)
        {
            // Get values
            string id = Common.
                   GetValueOfCellGridView(this.dgvEmployee, rowIndex, 0);
            string name = Common.GetValueOfCellGridView(this.dgvEmployee, rowIndex, 1);
            string gender = Common.GetValueOfCellGridView(this.dgvEmployee, rowIndex, 2);
            string address = Common.GetValueOfCellGridView(this.dgvEmployee, rowIndex, 3);
            string phone = Common.GetValueOfCellGridView(this.dgvEmployee, rowIndex, 4);
            string position = Common.GetValueOfCellGridView(this.dgvEmployee, rowIndex, 5);

            // Fill Textbox
            this.TBMaNV.Text = id;
            this.TbHoTenNV.Text = name;
            this.TbGioiTinh.Text = gender;
            this.TbDiaChi.Text = address;
            this.TbSDT.Text = phone;
            this.TbChucVu.Text = position;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = TBMaNV.Text.Trim();
                string EmployeeName = TbHoTenNV.Text.Trim();
                string Address = TbDiaChi.Text.Trim();
                bool Sex = true;
                if (TbGioiTinh.Text.Trim().ToLower() == "nam")
                    Sex = false;
                string PhoneNumber = TbSDT.Text.Trim();
                string Position = TbChucVu.Text.Trim();

                string error = "";
                bool isCreated = emp.
                    InsertEmployee(Id, EmployeeName, Sex, Address, PhoneNumber, Position, ref error);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.dgvEmployee);
                // Get Values
                string id = Common.
                    GetValueOfCellGridView(this.dgvEmployee, rowIndex, 0);
                string EmployeeName = TbHoTenNV.Text.Trim();
                string Address = TbDiaChi.Text.Trim();
                bool Sex = true;
                if (TbGioiTinh.Text.Trim().ToLower() == "nam")
                    Sex = false;
                string PhoneNumber = TbSDT.Text.Trim();
                string Position = TbChucVu.Text.Trim();

                string error = "";
                bool isCreated = emp.
                    UpdateEmployee(id, EmployeeName, Sex, Address, PhoneNumber, Position, ref error);
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

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            this.FindAll();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = Common.GetCurrentRowSelected(this.dgvEmployee);
            this.FillTextBox(rowIndex);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.dgvEmployee);
                // Get Id
                string Id = Common.
                    GetValueOfCellGridView(this.dgvEmployee, rowIndex, 0);

                // remove
                string error = "";
                bool isDeleted = emp.RemoveEmployee(Id, ref error);
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
