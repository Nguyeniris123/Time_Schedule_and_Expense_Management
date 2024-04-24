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
    public partial class IsRobot_36_Nguyen : Form
    {
        public IsRobot_36_Nguyen()
        {
            InitializeComponent();
        }

        Point point_36_Nguyen; //Biến lưu giữ vị trí chuột
        private void picIsRobot_36_Nguyen_MouseDown(object sender, MouseEventArgs e)
        {
            point_36_Nguyen = e.Location;
        }

        private void picIsRobot_36_Nguyen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - point_36_Nguyen.X;
                int dy = e.Y - point_36_Nguyen.Y;
                picIsRobot_36_Nguyen.Left += dx;
                picIsRobot_36_Nguyen.Top += dy;
            }
        }
        private void picIsRobot_36_Nguyen_MouseUp(object sender, MouseEventArgs e)
        {
            if(panIsRobot_36_Nguyen.Bounds.Contains(picIsRobot_36_Nguyen.Bounds))
            {
                MessageBox.Show("Đăng kí tài khoản thành công, mời bạn đăng nhập ứng dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormLogin_36_Nguyen login = new FormLogin_36_Nguyen();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
