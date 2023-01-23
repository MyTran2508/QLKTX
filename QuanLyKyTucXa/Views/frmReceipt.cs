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
    public partial class frmReceipt : Form
    {
        ReceiptController rcptc = new ReceiptController();
        RoomController rc = new RoomController();
        EmployeeController ec = new EmployeeController();
        StudentController sc = new StudentController();
        public frmReceipt()
        {
            InitializeComponent();
            this.rcptc = new ReceiptController();
            this.rc = new RoomController();
            this.ec = new EmployeeController();
            this.sc = new StudentController();
        }
        private void GetView()
        {
            string error = "";
            var receipts = rcptc.GetView(ref error);

            if (receipts != null)
            {
                DataTable dt = Common.GetDataTable(
                    "Mã biên lai",
                    "NV tạo biên lai",
                    "Biên lai của SV",
                    "Số tiền",
                    "Ngày thu",
                    "Phòng",
                    "Năm học"
                    );

                foreach (var rcpt in receipts)
                {
                    dt.Rows.Add(rcpt.MaBienLai, rcpt.MaNhanVien, rcpt.MaSinhVien, rcpt.SoTien, rcpt.NgayThu, rcpt.MaPhong, rcpt.NamHoc);
                }
                // Return databale 
                this.dgvReceipt.DataSource = dt;
            }
        }
        private void FillComboBoxRooms()
        {
            string error = "";
            var rcptRoom = rc.FindAll(ref error);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = rcptRoom;
            CBPhong.DataSource = bindingSource.DataSource;
            CBPhong.DisplayMember = "MaPhong";// lay theo get, set cua RoomModel
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
            //get values
            string receiptID = Common.GetValueOfCellGridView(this.dgvReceipt, rowIndex, 0);
            string employeeID = Common.GetFormatValueOfCellGridView(this.dgvReceipt, rowIndex, 1);
            string studentID = Common.GetFormatValueOfCellGridView(this.dgvReceipt, rowIndex, 2);
            string fee = Common.GetValueOfCellGridView(this.dgvReceipt, rowIndex, 3);
            string date = Common.GetValueOfCellGridView(this.dgvReceipt, rowIndex, 4);
            string room = Common.GetFormatValueOfCellGridView(this.dgvReceipt, rowIndex, 5);
            string schoolYear = Common.GetValueOfCellGridView(this.dgvReceipt, rowIndex, 6);

            //fill text box
            this.tbMaBL.Text = receiptID;
            this.CBMaNV.Text = employeeID;
            this.CBMaSV.Text = studentID;
            this.tbSoTien.Text = fee;
            this.tbNgayThu.Text = date;
            this.CBPhong.Text = room;
            this.tbNamHoc.Text = schoolYear;
        }

        private void btnInsertReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                string receiptID = tbMaBL.Text.Trim();
                string employeeID = Common.GetValueComboBox(CBMaNV);
                string studentId = Common.GetValueComboBox(CBMaSV);
                string roomId = Common.GetValueComboBox(CBPhong);
                double fee = 0;
                DateTime date = Convert.ToDateTime(tbNgayThu.Text.Trim());
                string schoolYear = tbNamHoc.Text.Trim();

                string error = "";
                bool isCreated = rcptc.InsertReceipt(receiptID, employeeID,roomId,schoolYear, fee, date, studentId, ref  error);
                if (isCreated)
                {
                    // Refresh Data
                    this.GetView();
                }
                MessageBox.Show(error);
            }
            catch
            {
                MessageBox.Show("Đã Xảy Ra Lỗi, Vui Lòng Thử Lại");
            }
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            this.GetView();
            this.FillComboBoxRooms();
            this.FillComboBoxEmps();
            this.FillComboBoxStudents();
        }

        private void btnUpdateReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.dgvReceipt);
                // Get Values
                string receiptID = tbMaBL.Text.Trim();
                string employeeID = Common.GetValueComboBox(CBMaNV);
                string studentId = Common.GetValueComboBox(CBMaSV);
                string roomId = Common.GetValueComboBox(CBPhong);
                double fee = 0;
                DateTime date = Convert.ToDateTime(tbNgayThu.Text.Trim());
                string schoolYear = tbNamHoc.Text.Trim();

                string error = "";
                bool isCreated = rcptc.UpdateReceipt(receiptID, employeeID, roomId, schoolYear, fee, date, studentId, ref error);
                if (isCreated)
                {
                    // Refresh Data
                    this.GetView();
                }
                MessageBox.Show(error);
            }
            catch
            {
                MessageBox.Show("Đã Xảy Ra Lỗi, Vui Lòng Thử Lại");
            }
        }

        private void btnRemoveReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.dgvReceipt);
                // Get Id
                string Id = Common.
                    GetValueOfCellGridView(this.dgvReceipt, rowIndex, 0);

                // remove
                string error = "";
                bool isDeleted = rcptc.RemoveReceipt(Id, ref error);
                if (isDeleted)
                {
                    this.GetView();
                }
                MessageBox.Show(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = Common.GetCurrentRowSelected(this.dgvReceipt);
            this.FillTextBox(rowIndex);
        }
        private void CBMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
