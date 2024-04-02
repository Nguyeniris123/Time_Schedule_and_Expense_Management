using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu
{
    public partial class IsRobot : Form
    {
        public IsRobot()
        {
            InitializeComponent();
        }

        Point p0ldPoint; //Biến lưu giữ vị trí chuột
        private void picIsRobot_MouseDown(object sender, MouseEventArgs e)
        {
            p0ldPoint = e.Location;
        }

        private void picIsRobot_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - p0ldPoint.X;
                int dy = e.Y - p0ldPoint.Y;
                picIsRobot.Left += dx;
                picIsRobot.Top += dy;
            }
        }
        private void picIsRobot_MouseUp(object sender, MouseEventArgs e)
        {
            if(panIsRobot.Bounds.Contains(picIsRobot.Bounds))
            {
                MessageBox.Show("Đăng kí tài khoản thành công, mời bạn đăng nhập ứng dụng", "Thông báo", MessageBoxButtons.OK);
                this.Hide();
                FormLogin login = new FormLogin();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
