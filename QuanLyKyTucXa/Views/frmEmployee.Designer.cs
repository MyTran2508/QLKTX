
namespace QuanLyKyTucXa.Views
{
    partial class frmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbChucVu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TbGioiTinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbHoTenNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.TBMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnTable = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnSubHeading = new System.Windows.Forms.Panel();
            this.lbSubHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.pnTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnSubHeading.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbChucVu
            // 
            this.TbChucVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbChucVu.Location = new System.Drawing.Point(632, 107);
            this.TbChucVu.Multiline = true;
            this.TbChucVu.Name = "TbChucVu";
            this.TbChucVu.Size = new System.Drawing.Size(203, 30);
            this.TbChucVu.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(507, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Chức vụ";
            // 
            // TbDiaChi
            // 
            this.TbDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDiaChi.Location = new System.Drawing.Point(632, 58);
            this.TbDiaChi.Multiline = true;
            this.TbDiaChi.Name = "TbDiaChi";
            this.TbDiaChi.Size = new System.Drawing.Size(203, 30);
            this.TbDiaChi.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(507, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Địa chỉ";
            // 
            // TbGioiTinh
            // 
            this.TbGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbGioiTinh.Location = new System.Drawing.Point(632, 9);
            this.TbGioiTinh.Multiline = true;
            this.TbGioiTinh.Name = "TbGioiTinh";
            this.TbGioiTinh.Size = new System.Drawing.Size(203, 30);
            this.TbGioiTinh.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(507, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giới tính";
            // 
            // TbSDT
            // 
            this.TbSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSDT.Location = new System.Drawing.Point(236, 107);
            this.TbSDT.Multiline = true;
            this.TbSDT.Name = "TbSDT";
            this.TbSDT.Size = new System.Drawing.Size(203, 30);
            this.TbSDT.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(111, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "SĐT";
            // 
            // TbHoTenNV
            // 
            this.TbHoTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbHoTenNV.Location = new System.Drawing.Point(236, 58);
            this.TbHoTenNV.Multiline = true;
            this.TbHoTenNV.Name = "TbHoTenNV";
            this.TbHoTenNV.Size = new System.Drawing.Size(203, 30);
            this.TbHoTenNV.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(111, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Họ tên";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 10);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(940, 264);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // TBMaNV
            // 
            this.TBMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBMaNV.Location = new System.Drawing.Point(236, 9);
            this.TBMaNV.Multiline = true;
            this.TBMaNV.Name = "TBMaNV";
            this.TBMaNV.Size = new System.Drawing.Size(203, 30);
            this.TBMaNV.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(111, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "MNV";
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(580, 202);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 40);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Xóa nhân viên";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(381, 202);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật nhân viên";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(186, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm nhân viên";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnTable
            // 
            this.pnTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTable.Controls.Add(this.dgvEmployee);
            this.pnTable.Location = new System.Drawing.Point(0, 290);
            this.pnTable.Name = "pnTable";
            this.pnTable.Size = new System.Drawing.Size(940, 286);
            this.pnTable.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TbChucVu);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TbDiaChi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TbGioiTinh);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TbSDT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TbHoTenNV);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TBMaNV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 250);
            this.panel1.TabIndex = 10;
            // 
            // pnSubHeading
            // 
            this.pnSubHeading.Controls.Add(this.lbSubHeading);
            this.pnSubHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubHeading.Location = new System.Drawing.Point(0, 0);
            this.pnSubHeading.Name = "pnSubHeading";
            this.pnSubHeading.Size = new System.Drawing.Size(940, 40);
            this.pnSubHeading.TabIndex = 5;
            // 
            // lbSubHeading
            // 
            this.lbSubHeading.AutoSize = true;
            this.lbSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubHeading.Location = new System.Drawing.Point(349, 9);
            this.lbSubHeading.Name = "lbSubHeading";
            this.lbSubHeading.Size = new System.Drawing.Size(252, 25);
            this.lbSubHeading.TabIndex = 1;
            this.lbSubHeading.Text = "THÔNG TIN NHÂN VIÊN";
            this.lbSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(940, 575);
            this.Controls.Add(this.pnTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSubHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployee";
            this.Text = "frmEmployee2";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.pnTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnSubHeading.ResumeLayout(false);
            this.pnSubHeading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TbChucVu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbGioiTinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbHoTenNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox TBMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnSubHeading;
        private System.Windows.Forms.Label lbSubHeading;
    }
}