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
    public partial class frmInvoice : Form
    {
        InvoiceController hd = null;
        EmployeeController emp = null;
        RoomController rc = null;

        public frmInvoice()
        {
            InitializeComponent();
            hd = new InvoiceController();
            emp = new EmployeeController();
            rc = new RoomController();
        }

        private void GetAllInvoices()
        {
            string error = "";
            var Invoices = hd.GetAllInvoices(ref error);

            if (Invoices != null)
            {
                DataTable dt = Common.GetDataTable(
                    "Mã Hoá Đơn",
                    "Mã Nhân Viên",
                    "Mã Phòng",
                    "Số m3 Nước",
                    "Số Công Tơ Điện",
                    "Tháng Ghi Sổ",
                    "Tổng Tiền"
                    );

                foreach (var ie in Invoices)
                {
                    dt.Rows.Add(ie.MaHoaDon, ie.MaNhanVien, ie.MaPhong, ie.SoM3Nuoc, ie.SoCongToDien, ie.ThangGhiSo, ie.TongTien);

                }
                // Return databale 
                this.dgvInvoice.DataSource = dt;
            }
        }

        private void FillComboBoxEmployees()
        {
            string error = "";
            var employees = emp.FindAll(ref error);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = employees;
            CBMaNV.DataSource = bindingSource.DataSource;
            CBMaNV.DisplayMember = "HoTenNV";
            CBMaNV.ValueMember = "MaNhanVien";
        }

        private void FillComboBoxRooms()
        {
            string error = "";
            var rooms = rc.FindAll(ref error);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = rooms;
            CBPhong.DataSource = bindingSource.DataSource;
            CBPhong.DisplayMember = "MaPhong";
            CBPhong.ValueMember = "MaPhong";
        }
        private void FillTextBox(int rowIndex)
        {
            // Get values
            string MaHoaDon = Common.GetValueOfCellGridView(this.dgvInvoice, rowIndex, 0);
            string MaNhanVien = Common.GetFormatValueOfCellGridView(this.dgvInvoice, rowIndex, 1);
            string MaPhong = Common.GetFormatValueOfCellGridView(this.dgvInvoice, rowIndex, 2);
            string SoM3Nuoc = Common.GetValueOfCellGridView(this.dgvInvoice, rowIndex, 3);
            string SoCongToDien = Common.GetValueOfCellGridView(this.dgvInvoice, rowIndex, 4);
            string ThangGhiSo = Common.GetValueOfCellGridView(this.dgvInvoice, rowIndex, 5);
            string TongTien = Common.GetValueOfCellGridView(this.dgvInvoice, rowIndex, 6);

            // Fill Textbox
            this.txt_MaHD.Text = MaHoaDon;
            this.CBMaNV.Text = MaNhanVien;
            this.CBPhong.Text = MaPhong;
            this.txt_Som3Nuoc.Text = SoM3Nuoc;
            this.txt_SoCTD.Text = SoCongToDien;
            this.txt_Thang.Text = ThangGhiSo;
            this.txt_TongTien.Text = TongTien;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MaHoaDon = txt_MaHD.Text.Trim();
                string MaNhanVien = Common.GetValueComboBox(CBMaNV);
                string MaPhong = Common.GetValueComboBox(CBPhong);
                float SoM3Nuoc = float.Parse(txt_Som3Nuoc.Text.Trim());
                float SoCongToDien = float.Parse(txt_SoCTD.Text.Trim());
                Int16 ThangGhiSo = Int16.Parse(txt_Thang.Text.Trim());
                float TongTien = 0;

                string error = "";
                bool isCreated = hd.InsertInvoice(MaHoaDon, MaNhanVien, MaPhong, SoM3Nuoc, SoCongToDien, ThangGhiSo, TongTien, ref error);
                if (isCreated)
                {
                    // Refresh Data
                    this.GetAllInvoices();
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
                int rowIndex = Common.GetCurrentRowSelected(this.dgvInvoice);
                // Get Values
                string MaHoaDon = txt_MaHD.Text.Trim();
                string MaNhanVien = Common.GetValueComboBox(CBMaNV);
                string MaPhong = Common.GetValueComboBox(CBPhong);
                float SoM3Nuoc = float.Parse(txt_Som3Nuoc.Text.Trim());
                float SoCongToDien = float.Parse(txt_SoCTD.Text.Trim());
                Int16 ThangGhiSo = Int16.Parse(txt_Thang.Text.Trim());
                float TongTien = 0;

                string error = "";
                bool isCreated = hd.UpdateInvoice(MaHoaDon, MaNhanVien, MaPhong, SoM3Nuoc, SoCongToDien, ThangGhiSo, TongTien, ref error);
                if (isCreated)
                {
                    // Refresh Data
                    this.GetAllInvoices();
                }
                MessageBox.Show(error);
            }
            catch
            {
                MessageBox.Show("Đã Xảy Ra Lỗi, Vui Lòng Thử Lại");
            }
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            this.GetAllInvoices();
            this.FillComboBoxEmployees();
            this.FillComboBoxRooms();
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = Common.GetCurrentRowSelected(this.dgvInvoice);
            this.FillTextBox(rowIndex);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.dgvInvoice);
                // Get Id
                string MaHoaDon = Common.GetValueOfCellGridView(this.dgvInvoice, rowIndex, 0);

                // remove
                string error = "";
                bool isDeleted = hd.RemoveInvoice(MaHoaDon, ref error);
                if (isDeleted)
                {
                    this.GetAllInvoices();
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
