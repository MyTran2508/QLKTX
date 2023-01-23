
namespace QuanLyKyTucXa.Views
{
    partial class frmContract
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
            this.txt_NgayKT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_NgayBD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_NgayDK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pnTable = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBPhong = new System.Windows.Forms.ComboBox();
            this.CBMaSV = new System.Windows.Forms.ComboBox();
            this.CBMaNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSubHeading = new System.Windows.Forms.Panel();
            this.lbSubHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.pnTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnSubHeading.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_NgayKT
            // 
            this.txt_NgayKT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NgayKT.Location = new System.Drawing.Point(632, 107);
            this.txt_NgayKT.Multiline = true;
            this.txt_NgayKT.Name = "txt_NgayKT";
            this.txt_NgayKT.Size = new System.Drawing.Size(203, 30);
            this.txt_NgayKT.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(507, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ngày KT";
            // 
            // txt_NgayBD
            // 
            this.txt_NgayBD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NgayBD.Location = new System.Drawing.Point(632, 58);
            this.txt_NgayBD.Multiline = true;
            this.txt_NgayBD.Name = "txt_NgayBD";
            this.txt_NgayBD.Size = new System.Drawing.Size(203, 30);
            this.txt_NgayBD.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(507, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày BĐ";
            // 
            // txt_NgayDK
            // 
            this.txt_NgayDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NgayDK.Location = new System.Drawing.Point(632, 9);
            this.txt_NgayDK.Multiline = true;
            this.txt_NgayDK.Name = "txt_NgayDK";
            this.txt_NgayDK.Size = new System.Drawing.Size(203, 30);
            this.txt_NgayDK.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(507, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày ĐK";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(111, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "HĐ của SV";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(111, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "NV tạo HĐ";
            // 
            // dgvContract
            // 
            this.dgvContract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContract.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Location = new System.Drawing.Point(0, 7);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.RowHeadersWidth = 51;
            this.dgvContract.RowTemplate.Height = 24;
            this.dgvContract.Size = new System.Drawing.Size(940, 266);
            this.dgvContract.TabIndex = 0;
            this.dgvContract.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContract_CellClick);
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaHD.Location = new System.Drawing.Point(236, 9);
            this.txt_MaHD.Multiline = true;
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(203, 30);
            this.txt_MaHD.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(111, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã HD";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(580, 202);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(180, 40);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xóa hợp đồng";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(381, 202);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(180, 40);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Cập nhật hợp đồng";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(186, 202);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(180, 40);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Thêm hợp đồng";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnTable
            // 
            this.pnTable.Controls.Add(this.dgvContract);
            this.pnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTable.Location = new System.Drawing.Point(0, 290);
            this.pnTable.Name = "pnTable";
            this.pnTable.Size = new System.Drawing.Size(940, 285);
            this.pnTable.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBPhong);
            this.panel1.Controls.Add(this.CBMaSV);
            this.panel1.Controls.Add(this.CBMaNV);
            this.panel1.Controls.Add(this.txt_NgayKT);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_NgayBD);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_NgayDK);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_MaHD);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 250);
            this.panel1.TabIndex = 10;
            // 
            // CBPhong
            // 
            this.CBPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPhong.FormattingEnabled = true;
            this.CBPhong.Location = new System.Drawing.Point(236, 149);
            this.CBPhong.Name = "CBPhong";
            this.CBPhong.Size = new System.Drawing.Size(203, 24);
            this.CBPhong.TabIndex = 24;
            this.CBPhong.SelectedValueChanged += new System.EventHandler(this.CBMaSV_SelectedIndexChanged);
            // 
            // CBMaSV
            // 
            this.CBMaSV.DisplayMember = "ho_ten";
            this.CBMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMaSV.FormattingEnabled = true;
            this.CBMaSV.Location = new System.Drawing.Point(236, 103);
            this.CBMaSV.Name = "CBMaSV";
            this.CBMaSV.Size = new System.Drawing.Size(203, 24);
            this.CBMaSV.TabIndex = 23;
            this.CBMaSV.ValueMember = "ma_sinh_vien";
            this.CBMaSV.SelectedValueChanged += new System.EventHandler(this.CBMaSV_SelectedIndexChanged);
            // 
            // CBMaNV
            // 
            this.CBMaNV.DisplayMember = "ho_ten";
            this.CBMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMaNV.FormattingEnabled = true;
            this.CBMaNV.Location = new System.Drawing.Point(236, 57);
            this.CBMaNV.Name = "CBMaNV";
            this.CBMaNV.Size = new System.Drawing.Size(203, 24);
            this.CBMaNV.TabIndex = 22;
            this.CBMaNV.ValueMember = "ma_nhan_vien";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(111, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Phòng";
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
            this.lbSubHeading.Size = new System.Drawing.Size(251, 25);
            this.lbSubHeading.TabIndex = 1;
            this.lbSubHeading.Text = "THÔNG TIN HỢP ĐỒNG";
            this.lbSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(940, 575);
            this.Controls.Add(this.pnTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSubHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContract";
            this.Load += new System.EventHandler(this.frmContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.pnTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnSubHeading.ResumeLayout(false);
            this.pnSubHeading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_NgayKT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_NgayBD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_NgayDK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel pnTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnSubHeading;
        private System.Windows.Forms.Label lbSubHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBMaNV;
        private System.Windows.Forms.ComboBox CBMaSV;
        private System.Windows.Forms.ComboBox CBPhong;
    }
}