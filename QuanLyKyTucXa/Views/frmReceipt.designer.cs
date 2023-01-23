
namespace QuanLyKyTucXa.Views
{
    partial class frmReceipt
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
            this.components = new System.ComponentModel.Container();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.pnTable = new System.Windows.Forms.Panel();
            this.tbNamHoc = new System.Windows.Forms.TextBox();
            this.tbSoTien = new System.Windows.Forms.TextBox();
            this.lbSubHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBMaNV = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKyTucXaDBDataSet1 = new QuanLyKyTucXa.QuanLyKyTucXaDBDataSet1();
            this.CBPhong = new System.Windows.Forms.ComboBox();
            this.CBMaSV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNgayThu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaBL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveReceipt = new System.Windows.Forms.Button();
            this.btnUpdateReceipt = new System.Windows.Forms.Button();
            this.btnInsertReceipt = new System.Windows.Forms.Button();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKyTucXaDBDataSet2 = new QuanLyKyTucXa.QuanLyKyTucXaDBDataSet2();
            this.pnSubHeading = new System.Windows.Forms.Panel();
            this.nhanVienTableAdapter = new QuanLyKyTucXa.QuanLyKyTucXaDBDataSet1TableAdapters.NhanVienTableAdapter();
            this.sinhVienTableAdapter = new QuanLyKyTucXa.QuanLyKyTucXaDBDataSet2TableAdapters.SinhVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.pnTable.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKyTucXaDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKyTucXaDBDataSet2)).BeginInit();
            this.pnSubHeading.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AllowUserToAddRows = false;
            this.dgvReceipt.AllowUserToDeleteRows = false;
            this.dgvReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipt.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Location = new System.Drawing.Point(0, 10);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.RowTemplate.Height = 24;
            this.dgvReceipt.Size = new System.Drawing.Size(940, 275);
            this.dgvReceipt.TabIndex = 0;
            this.dgvReceipt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipt_CellContentClick);
            // 
            // pnTable
            // 
            this.pnTable.Controls.Add(this.dgvReceipt);
            this.pnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTable.Location = new System.Drawing.Point(0, 290);
            this.pnTable.Name = "pnTable";
            this.pnTable.Size = new System.Drawing.Size(940, 285);
            this.pnTable.TabIndex = 7;
            // 
            // tbNamHoc
            // 
            this.tbNamHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNamHoc.Location = new System.Drawing.Point(632, 157);
            this.tbNamHoc.Multiline = true;
            this.tbNamHoc.Name = "tbNamHoc";
            this.tbNamHoc.Size = new System.Drawing.Size(203, 30);
            this.tbNamHoc.TabIndex = 15;
            // 
            // tbSoTien
            // 
            this.tbSoTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoTien.Location = new System.Drawing.Point(632, 9);
            this.tbSoTien.Multiline = true;
            this.tbSoTien.Name = "tbSoTien";
            this.tbSoTien.ReadOnly = true;
            this.tbSoTien.Size = new System.Drawing.Size(203, 30);
            this.tbSoTien.TabIndex = 11;
            // 
            // lbSubHeading
            // 
            this.lbSubHeading.AutoSize = true;
            this.lbSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubHeading.Location = new System.Drawing.Point(349, 9);
            this.lbSubHeading.Name = "lbSubHeading";
            this.lbSubHeading.Size = new System.Drawing.Size(224, 25);
            this.lbSubHeading.TabIndex = 1;
            this.lbSubHeading.Text = "THÔNG TIN BIÊN LAI";
            this.lbSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBMaNV);
            this.panel1.Controls.Add(this.CBPhong);
            this.panel1.Controls.Add(this.CBMaSV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbNamHoc);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbNgayThu);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbSoTien);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbMaBL);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnRemoveReceipt);
            this.panel1.Controls.Add(this.btnUpdateReceipt);
            this.panel1.Controls.Add(this.btnInsertReceipt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 250);
            this.panel1.TabIndex = 10;
            // 
            // CBMaNV
            // 
            this.CBMaNV.DataSource = this.nhanVienBindingSource;
            this.CBMaNV.DisplayMember = "ho_ten";
            this.CBMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMaNV.FormattingEnabled = true;
            this.CBMaNV.Location = new System.Drawing.Point(234, 72);
            this.CBMaNV.Name = "CBMaNV";
            this.CBMaNV.Size = new System.Drawing.Size(203, 24);
            this.CBMaNV.TabIndex = 21;
            this.CBMaNV.ValueMember = "ma_nhan_vien";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyKyTucXaDBDataSet1;
            // 
            // quanLyKyTucXaDBDataSet1
            // 
            this.quanLyKyTucXaDBDataSet1.DataSetName = "QuanLyKyTucXaDBDataSet1";
            this.quanLyKyTucXaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBPhong
            // 
            this.CBPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPhong.FormattingEnabled = true;
            this.CBPhong.Location = new System.Drawing.Point(632, 108);
            this.CBPhong.Name = "CBPhong";
            this.CBPhong.Size = new System.Drawing.Size(203, 24);
            this.CBPhong.TabIndex = 20;
            // 
            // CBMaSV
            // 
            this.CBMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMaSV.FormattingEnabled = true;
            this.CBMaSV.Location = new System.Drawing.Point(234, 121);
            this.CBMaSV.Name = "CBMaSV";
            this.CBMaSV.Size = new System.Drawing.Size(203, 24);
            this.CBMaSV.TabIndex = 19;
            this.CBMaSV.SelectedIndexChanged += new System.EventHandler(this.CBMaSV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(507, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Phòng";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(507, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Năm học";
            // 
            // tbNgayThu
            // 
            this.tbNgayThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNgayThu.Location = new System.Drawing.Point(632, 58);
            this.tbNgayThu.Multiline = true;
            this.tbNgayThu.Name = "tbNgayThu";
            this.tbNgayThu.Size = new System.Drawing.Size(203, 30);
            this.tbNgayThu.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(507, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày thu";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(507, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số tiền";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(109, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "BL của SV";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(109, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "NV tạo BL";
            // 
            // tbMaBL
            // 
            this.tbMaBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaBL.Location = new System.Drawing.Point(234, 28);
            this.tbMaBL.Multiline = true;
            this.tbMaBL.Name = "tbMaBL";
            this.tbMaBL.Size = new System.Drawing.Size(203, 30);
            this.tbMaBL.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(109, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã biên lai";
            // 
            // btnRemoveReceipt
            // 
            this.btnRemoveReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveReceipt.Location = new System.Drawing.Point(580, 202);
            this.btnRemoveReceipt.Name = "btnRemoveReceipt";
            this.btnRemoveReceipt.Size = new System.Drawing.Size(180, 40);
            this.btnRemoveReceipt.TabIndex = 3;
            this.btnRemoveReceipt.Text = "Xóa biên lai";
            this.btnRemoveReceipt.UseVisualStyleBackColor = true;
            this.btnRemoveReceipt.Click += new System.EventHandler(this.btnRemoveReceipt_Click);
            // 
            // btnUpdateReceipt
            // 
            this.btnUpdateReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateReceipt.Location = new System.Drawing.Point(381, 202);
            this.btnUpdateReceipt.Name = "btnUpdateReceipt";
            this.btnUpdateReceipt.Size = new System.Drawing.Size(180, 40);
            this.btnUpdateReceipt.TabIndex = 2;
            this.btnUpdateReceipt.Text = "Cập nhật biên lai";
            this.btnUpdateReceipt.UseVisualStyleBackColor = true;
            this.btnUpdateReceipt.Click += new System.EventHandler(this.btnUpdateReceipt_Click);
            // 
            // btnInsertReceipt
            // 
            this.btnInsertReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertReceipt.Location = new System.Drawing.Point(186, 202);
            this.btnInsertReceipt.Name = "btnInsertReceipt";
            this.btnInsertReceipt.Size = new System.Drawing.Size(180, 40);
            this.btnInsertReceipt.TabIndex = 1;
            this.btnInsertReceipt.Text = "Thêm biên lai";
            this.btnInsertReceipt.UseVisualStyleBackColor = true;
            this.btnInsertReceipt.Click += new System.EventHandler(this.btnInsertReceipt_Click);
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.quanLyKyTucXaDBDataSet2;
            // 
            // quanLyKyTucXaDBDataSet2
            // 
            this.quanLyKyTucXaDBDataSet2.DataSetName = "QuanLyKyTucXaDBDataSet2";
            this.quanLyKyTucXaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(940, 575);
            this.Controls.Add(this.pnTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSubHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReceipt";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.pnTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKyTucXaDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKyTucXaDBDataSet2)).EndInit();
            this.pnSubHeading.ResumeLayout(false);
            this.pnSubHeading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceipt;
        private System.Windows.Forms.Panel pnTable;
        private System.Windows.Forms.TextBox tbNamHoc;
        private System.Windows.Forms.TextBox tbSoTien;
        private System.Windows.Forms.Label lbSubHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNgayThu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaBL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveReceipt;
        private System.Windows.Forms.Button btnUpdateReceipt;
        private System.Windows.Forms.Button btnInsertReceipt;
        private System.Windows.Forms.Panel pnSubHeading;
        private System.Windows.Forms.ComboBox CBPhong;
        private System.Windows.Forms.ComboBox CBMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBMaNV;
        private QuanLyKyTucXaDBDataSet1 quanLyKyTucXaDBDataSet1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyKyTucXaDBDataSet1TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QuanLyKyTucXaDBDataSet2 quanLyKyTucXaDBDataSet2;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QuanLyKyTucXaDBDataSet2TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
    }
}