
namespace QuanLyKyTucXa.Views
{
    partial class frmDashboard
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
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pnNavigate = new System.Windows.Forms.Panel();
            this.minimizeScreenBtn = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.lbHeading = new System.Windows.Forms.Label();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnSidebar.SuspendLayout();
            this.pnNavigate.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContent
            // 
            this.pnContent.AutoSize = true;
            this.pnContent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnContent.Location = new System.Drawing.Point(250, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnContent.Size = new System.Drawing.Size(950, 575);
            this.pnContent.TabIndex = 18;
            // 
            // pnSidebar
            // 
            this.pnSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnSidebar.BackColor = System.Drawing.SystemColors.Menu;
            this.pnSidebar.Controls.Add(this.btnLogout);
            this.pnSidebar.Controls.Add(this.btnReceipt);
            this.pnSidebar.Controls.Add(this.btnInvoice);
            this.pnSidebar.Controls.Add(this.btnContract);
            this.pnSidebar.Controls.Add(this.btnRoom);
            this.pnSidebar.Controls.Add(this.btnStudent);
            this.pnSidebar.Controls.Add(this.btnEmployee);
            this.pnSidebar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnSidebar.Name = "pnSidebar";
            this.pnSidebar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnSidebar.Size = new System.Drawing.Size(250, 575);
            this.pnSidebar.TabIndex = 17;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(0, 534);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 41);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceipt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReceipt.Location = new System.Drawing.Point(0, 205);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReceipt.Size = new System.Drawing.Size(250, 41);
            this.btnReceipt.TabIndex = 27;
            this.btnReceipt.Text = "Biên Lai";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInvoice.Location = new System.Drawing.Point(0, 164);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInvoice.Size = new System.Drawing.Size(250, 41);
            this.btnInvoice.TabIndex = 26;
            this.btnInvoice.Text = "Hoá Đơn";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnContract
            // 
            this.btnContract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContract.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContract.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContract.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContract.Location = new System.Drawing.Point(0, 123);
            this.btnContract.Name = "btnContract";
            this.btnContract.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnContract.Size = new System.Drawing.Size(250, 41);
            this.btnContract.TabIndex = 25;
            this.btnContract.Text = "Hợp Đồng";
            this.btnContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRoom.Location = new System.Drawing.Point(0, 82);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRoom.Size = new System.Drawing.Size(250, 41);
            this.btnRoom.TabIndex = 24;
            this.btnRoom.Text = "Phòng";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStudent.Location = new System.Drawing.Point(0, 41);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(250, 41);
            this.btnStudent.TabIndex = 23;
            this.btnStudent.Text = "Sinh Viên";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(250, 41);
            this.btnEmployee.TabIndex = 14;
            this.btnEmployee.Text = "Nhân Viên";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnNavigate
            // 
            this.pnNavigate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnNavigate.Controls.Add(this.minimizeScreenBtn);
            this.pnNavigate.Controls.Add(this.btnClose);
            this.pnNavigate.Controls.Add(this.lbHeading);
            this.pnNavigate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNavigate.Location = new System.Drawing.Point(0, 0);
            this.pnNavigate.Name = "pnNavigate";
            this.pnNavigate.Size = new System.Drawing.Size(1200, 25);
            this.pnNavigate.TabIndex = 16;
            this.pnNavigate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDashboard_MouseDown);
            this.pnNavigate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDashboard_MouseMove);
            // 
            // minimizeScreenBtn
            // 
            this.minimizeScreenBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimizeScreenBtn.AutoSize = true;
            this.minimizeScreenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeScreenBtn.Location = new System.Drawing.Point(1131, 2);
            this.minimizeScreenBtn.Name = "minimizeScreenBtn";
            this.minimizeScreenBtn.Size = new System.Drawing.Size(19, 20);
            this.minimizeScreenBtn.TabIndex = 3;
            this.minimizeScreenBtn.Text = "_";
            this.minimizeScreenBtn.Click += new System.EventHandler(this.minimizeScreenBtn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1167, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.Location = new System.Drawing.Point(10, 0);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(135, 24);
            this.lbHeading.TabIndex = 0;
            this.lbHeading.Text = "Quản Lý KTX\r\n";
            this.lbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnContent);
            this.pnBody.Controls.Add(this.pnSidebar);
            this.pnBody.Location = new System.Drawing.Point(0, 25);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1200, 575);
            this.pnBody.TabIndex = 0;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnNavigate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDashboard2";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnSidebar.ResumeLayout(false);
            this.pnNavigate.ResumeLayout(false);
            this.pnNavigate.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Panel pnSidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel pnNavigate;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Label minimizeScreenBtn;
    }
}