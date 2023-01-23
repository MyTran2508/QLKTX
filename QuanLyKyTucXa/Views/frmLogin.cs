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
using System.Runtime.InteropServices;
using QuanLyKyTucXa.Services;
using System.IO;

namespace QuanLyKyTucXa.Views
{
    public partial class frmLogin : Form
    {
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
        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text != "" && this.txtPassword.Text != "")
            {
                UserCache(txtUsername.Text, txtPassword.Text);
                AccountController acc = new AccountController();
                if (acc.CheckAccount(txtUsername.Text, txtPassword.Text))
                {
                    this.Hide();
                    frmDashboard f = new frmDashboard();
                    f.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Sai tên người dùng hoặc mật khẩu!", "Thông báo");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Error");
        }
        
        private void UserCache( string user, string pass)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var basePath = currentDirectory.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0];
            string AccountLogin = basePath + @"\AccountCache.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(AccountLogin))
                {
                    writer.WriteLine(user);
                    writer.WriteLine(pass);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void pnHeading_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void pnHeading_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbUsername_Click(object sender, EventArgs e)
        {
            this.txtUsername.Focus();
        }

        private void pbPassword_Click(object sender, EventArgs e)
        {
            this.txtPassword.Focus();
        }

        private void picShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                picHidePass.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void picHidePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                picShowPass.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
