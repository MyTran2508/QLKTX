
namespace QuanLyKyTucXa.Views
{
    partial class frmInvoice
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
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.pnTable = new System.Windows.Forms.Panel();
            this.lbSubHeading = new System.Windows.Forms.Label();
            this.pnSubHeading = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Som3Nuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SoCTD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Thang = new System.Windows.Forms.TextBox();
            this.CBPhong = new System.Windows.Forms.ComboBox();
            this.CBMaNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.pnTable.SuspendLayout();
            this.pnSubHeading.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 10);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.Size = new System.Drawing.Size(940, 263);
            this.dgvInvoice.TabIndex = 0;
            this.dgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            // 
            // pnTable
            // 
            this.pnTable.Controls.Add(this.dgvInvoice);
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
            this.lbSubHeading.Size = new System.Drawing.Size(236, 25);
            this.lbSubHeading.TabIndex = 1;
            this.lbSubHeading.Text = "THÔNG TIN HÓA ĐƠN";
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
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(186, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Thêm hóa đơn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(381, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cập nhật hóa đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(580, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xóa hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(111, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã hóa đơn";
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
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(111, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "NV tạo HĐ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(111, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số phòng";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(507, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số m3 nước";
            // 
            // txt_Som3Nuoc
            // 
            this.txt_Som3Nuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Som3Nuoc.Location = new System.Drawing.Point(632, 9);
            this.txt_Som3Nuoc.Multiline = true;
            this.txt_Som3Nuoc.Name = "txt_Som3Nuoc";
            this.txt_Som3Nuoc.Size = new System.Drawing.Size(203, 30);
            this.txt_Som3Nuoc.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(507, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Số KG điện";
            // 
            // txt_SoCTD
            // 
            this.txt_SoCTD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoCTD.Location = new System.Drawing.Point(632, 58);
            this.txt_SoCTD.Multiline = true;
            this.txt_SoCTD.Name = "txt_SoCTD";
            this.txt_SoCTD.Size = new System.Drawing.Size(203, 30);
            this.txt_SoCTD.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(507, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tháng";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(507, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tổng tiền";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TongTien.Location = new System.Drawing.Point(632, 155);
            this.txt_TongTien.Multiline = true;
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(203, 30);
            this.txt_TongTien.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Thang);
            this.panel1.Controls.Add(this.CBPhong);
            this.panel1.Controls.Add(this.CBMaNV);
            this.panel1.Controls.Add(this.txt_TongTien);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_SoCTD);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_Som3Nuoc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_MaHD);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 250);
            this.panel1.TabIndex = 10;
            // 
            // txt_Thang
            // 
            this.txt_Thang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Thang.Location = new System.Drawing.Point(632, 110);
            this.txt_Thang.Multiline = true;
            this.txt_Thang.Name = "txt_Thang";
            this.txt_Thang.Size = new System.Drawing.Size(203, 30);
            this.txt_Thang.TabIndex = 24;
            // 
            // CBPhong
            // 
            this.CBPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPhong.FormattingEnabled = true;
            this.CBPhong.Location = new System.Drawing.Point(236, 113);
            this.CBPhong.Name = "CBPhong";
            this.CBPhong.Size = new System.Drawing.Size(203, 24);
            this.CBPhong.TabIndex = 23;
            // 
            // CBMaNV
            // 
            this.CBMaNV.DisplayMember = "ho_ten";
            this.CBMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMaNV.FormattingEnabled = true;
            this.CBMaNV.Location = new System.Drawing.Point(236, 59);
            this.CBMaNV.Name = "CBMaNV";
            this.CBMaNV.Size = new System.Drawing.Size(203, 24);
            this.CBMaNV.TabIndex = 22;
            this.CBMaNV.ValueMember = "ma_nhan_vien";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(940, 575);
            this.Controls.Add(this.pnTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSubHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInvoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.pnTable.ResumeLayout(false);
            this.pnSubHeading.ResumeLayout(false);
            this.pnSubHeading.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Panel pnTable;
        private System.Windows.Forms.Label lbSubHeading;
        private System.Windows.Forms.Panel pnSubHeading;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Som3Nuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SoCTD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBMaNV;
        private System.Windows.Forms.ComboBox CBPhong;
        private System.Windows.Forms.TextBox txt_Thang;
    }
}