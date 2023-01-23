using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuanLyKyTucXa.Views
{
    public partial class frmDashboard : Form
    {
        struct clientRect
        {
            public Point location;
            public int width;
            public int height;
        };
        clientRect restore;
        private static bool isFullScreen;
        private Point _mouseLoc;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public frmDashboard()
        {
            InitializeComponent();
            isFullScreen = false;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            frmEmployee child = new frmEmployee();
            this.OpenChildForm(this.pnContent, child);
        }

        private void frmDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void frmDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);

            }
        }
        public void OpenChildForm(Panel parent, Form child)
        {
            parent.Controls.Clear();
            child.TopLevel = false;
            parent.Controls.Add(child);
            child.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee child = new frmEmployee();
            this.OpenChildForm(this.pnContent, child);
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            frmContract child = new frmContract();
            this.OpenChildForm(this.pnContent, child);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudent child = new frmStudent();
            this.OpenChildForm(this.pnContent, child);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRoom child = new frmRoom();
            this.OpenChildForm(this.pnContent, child);
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            frmInvoice child = new frmInvoice();
            this.OpenChildForm(this.pnContent, child);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmReceipt child = new frmReceipt();
            this.OpenChildForm(this.pnContent, child);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resizeScreenBtn_Click(object sender, EventArgs e)
        {
            isFullScreen = !isFullScreen;
            if (isFullScreen)
            {
                // Backup old size
                this.restore.location = this.Location;
                this.restore.width = this.Width;
                this.restore.height = this.Height;
                this.Region = null;

                WindowState = FormWindowState.Maximized;
                this.Size = new Size(int.MaxValue, int.MaxValue);
            }
            else
            {
                WindowState = FormWindowState.Normal;
                this.Location = this.restore.location;
                this.Width = this.restore.width;
                this.Height = this.restore.height;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
            TopMost = isFullScreen;


        }

        private void minimizeScreenBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
