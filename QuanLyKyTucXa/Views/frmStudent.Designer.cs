
namespace QuanLyKyTucXa.Views
{
    partial class frmStudent
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.pnTable = new System.Windows.Forms.Panel();
            this.lbSubHeading = new System.Windows.Forms.Label();
            this.pnSubHeading = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.TbMaSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TbGioiTinh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbCMND = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbMaPhong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbNienKhoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.pnTable.SuspendLayout();
            this.pnSubHeading.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(0, 10);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(940, 263);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // pnTable
            // 
            this.pnTable.Controls.Add(this.dgvStudent);
            this.pnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTable.Location = new System.Drawing.Point(0, 290);
            this.pnTable.Name = "pnTable";
            this.pnTable.Size = new System.Drawing.Size(940, 285);
            this.pnTable.TabIndex = 7;
            // 
            // lbSubHeading
            // 
            this.lbSubHeading.AutoSize = true;
            this.lbSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubHeading.Location = new System.Drawing.Point(349, 9);
            this.lbSubHeading.Name = "lbSubHeading";
            this.lbSubHeading.Size = new System.Drawing.Size(243, 25);
            this.lbSubHeading.TabIndex = 1;
            this.lbSubHeading.Text = "THÔNG TIN SINH VIÊN";
            this.lbSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(186, 202);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(180, 40);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Thêm sinh viên";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(381, 202);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(180, 40);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Cập nhật sinh viên";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.Location = new System.Drawing.Point(580, 202);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(180, 40);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Xóa sinh viên";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(111, 14);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 20);
            this.label.TabIndex = 4;
            this.label.Text = "MSV";
            // 
            // TbMaSV
            // 
            this.TbMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMaSV.Location = new System.Drawing.Point(236, 9);
            this.TbMaSV.Multiline = true;
            this.TbMaSV.Name = "TbMaSV";
            this.TbMaSV.Size = new System.Drawing.Size(203, 30);
            this.TbMaSV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(111, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Họ tên";
            // 
            // TbHoTen
            // 
            this.TbHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbHoTen.Location = new System.Drawing.Point(236, 58);
            this.TbHoTen.Multiline = true;
            this.TbHoTen.Name = "TbHoTen";
            this.TbHoTen.Size = new System.Drawing.Size(203, 30);
            this.TbHoTen.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(111, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa chỉ";
            // 
            // TbDiaChi
            // 
            this.TbDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDiaChi.Location = new System.Drawing.Point(236, 107);
            this.TbDiaChi.Multiline = true;
            this.TbDiaChi.Name = "TbDiaChi";
            this.TbDiaChi.Size = new System.Drawing.Size(203, 30);
            this.TbDiaChi.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(507, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã Phòng";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(507, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Giới tính";
            // 
            // TbGioiTinh
            // 
            this.TbGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbGioiTinh.Location = new System.Drawing.Point(632, 58);
            this.TbGioiTinh.Multiline = true;
            this.TbGioiTinh.Name = "TbGioiTinh";
            this.TbGioiTinh.Size = new System.Drawing.Size(203, 30);
            this.TbGioiTinh.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(507, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "CMND";
            // 
            // TbCMND
            // 
            this.TbCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCMND.Location = new System.Drawing.Point(632, 107);
            this.TbCMND.Multiline = true;
            this.TbCMND.Name = "TbCMND";
            this.TbCMND.Size = new System.Drawing.Size(203, 30);
            this.TbCMND.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CbMaPhong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TbNienKhoa);
            this.panel1.Controls.Add(this.TbCMND);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TbGioiTinh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TbDiaChi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TbHoTen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TbMaSV);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.BtnRemove);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 250);
            this.panel1.TabIndex = 10;
            // 
            // CbMaPhong
            // 
            this.CbMaPhong.FormattingEnabled = true;
            this.CbMaPhong.Location = new System.Drawing.Point(632, 14);
            this.CbMaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbMaPhong.Name = "CbMaPhong";
            this.CbMaPhong.Size = new System.Drawing.Size(203, 24);
            this.CbMaPhong.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(111, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Niên khóa";
            // 
            // TbNienKhoa
            // 
            this.TbNienKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNienKhoa.Location = new System.Drawing.Point(236, 155);
            this.TbNienKhoa.Multiline = true;
            this.TbNienKhoa.Name = "TbNienKhoa";
            this.TbNienKhoa.Size = new System.Drawing.Size(203, 30);
            this.TbNienKhoa.TabIndex = 16;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(940, 575);
            this.Controls.Add(this.pnTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSubHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudent";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.pnTable.ResumeLayout(false);
            this.pnSubHeading.ResumeLayout(false);
            this.pnSubHeading.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Panel pnTable;
        private System.Windows.Forms.Label lbSubHeading;
        private System.Windows.Forms.Panel pnSubHeading;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox TbMaSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbGioiTinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbCMND;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbNienKhoa;
        private System.Windows.Forms.ComboBox CbMaPhong;
    }
}