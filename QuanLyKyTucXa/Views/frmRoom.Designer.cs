
namespace QuanLyKyTucXa.Views
{
    partial class frmRoom
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
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.pnTable = new System.Windows.Forms.Panel();
            this.TBTinhTrang = new System.Windows.Forms.TextBox();
            this.lbSubHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBNhanVien = new System.Windows.Forms.ComboBox();
            this.CBLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbMaPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.pnSubHeading = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.pnTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnSubHeading.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRoom
            // 
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(0, 10);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.RowTemplate.Height = 24;
            this.dgvRoom.Size = new System.Drawing.Size(940, 263);
            this.dgvRoom.TabIndex = 0;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // pnTable
            // 
            this.pnTable.Controls.Add(this.dgvRoom);
            this.pnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTable.Location = new System.Drawing.Point(0, 290);
            this.pnTable.Name = "pnTable";
            this.pnTable.Size = new System.Drawing.Size(940, 285);
            this.pnTable.TabIndex = 7;
            // 
            // TBTinhTrang
            // 
            this.TBTinhTrang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTinhTrang.Location = new System.Drawing.Point(632, 9);
            this.TBTinhTrang.Multiline = true;
            this.TBTinhTrang.Name = "TBTinhTrang";
            this.TBTinhTrang.Size = new System.Drawing.Size(203, 30);
            this.TBTinhTrang.TabIndex = 11;
            // 
            // lbSubHeading
            // 
            this.lbSubHeading.AutoSize = true;
            this.lbSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubHeading.Location = new System.Drawing.Point(349, 9);
            this.lbSubHeading.Name = "lbSubHeading";
            this.lbSubHeading.Size = new System.Drawing.Size(213, 25);
            this.lbSubHeading.TabIndex = 1;
            this.lbSubHeading.Text = "THÔNG TIN PHÒNG";
            this.lbSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBNhanVien);
            this.panel1.Controls.Add(this.CBLoaiPhong);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TBTinhTrang);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TbMaPhong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BtnRemove);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 250);
            this.panel1.TabIndex = 10;
            // 
            // CBNhanVien
            // 
            this.CBNhanVien.FormattingEnabled = true;
            this.CBNhanVien.Location = new System.Drawing.Point(236, 65);
            this.CBNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBNhanVien.Name = "CBNhanVien";
            this.CBNhanVien.Size = new System.Drawing.Size(203, 24);
            this.CBNhanVien.TabIndex = 75;
            // 
            // CBLoaiPhong
            // 
            this.CBLoaiPhong.FormattingEnabled = true;
            this.CBLoaiPhong.Location = new System.Drawing.Point(632, 65);
            this.CBLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBLoaiPhong.Name = "CBLoaiPhong";
            this.CBLoaiPhong.Size = new System.Drawing.Size(203, 24);
            this.CBLoaiPhong.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(507, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Loại phòng";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(507, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(111, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "NV quản lý";
            // 
            // TbMaPhong
            // 
            this.TbMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMaPhong.Location = new System.Drawing.Point(236, 9);
            this.TbMaPhong.Multiline = true;
            this.TbMaPhong.Name = "TbMaPhong";
            this.TbMaPhong.Size = new System.Drawing.Size(203, 30);
            this.TbMaPhong.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(111, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã phòng";
            // 
            // BtnRemove
            // 
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.Location = new System.Drawing.Point(580, 202);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(180, 40);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Xóa phòng";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(381, 202);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(180, 40);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Cập nhật phòng";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(186, 202);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(180, 40);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Thêm phòng";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(940, 575);
            this.Controls.Add(this.pnTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSubHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRoom";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.pnTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnSubHeading.ResumeLayout(false);
            this.pnSubHeading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Panel pnTable;
        private System.Windows.Forms.TextBox TBTinhTrang;
        private System.Windows.Forms.Label lbSubHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbMaPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel pnSubHeading;
        private System.Windows.Forms.ComboBox CBLoaiPhong;
        private System.Windows.Forms.ComboBox CBNhanVien;
    }
}