using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //FontDialog menu
        private void fontsEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowEffects = true;
            //dlg.ShowColor = true;
            dlg.ShowApply = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Lặp qua tất cả các control trong Form
                foreach (Control control in this.Controls)
                {
                    // Thay đổi font cho mỗi control là Label, Button, TextBox, v.v.
                    control.Font = dlg.Font;
                }
            }
        }

        //ColorDialog menu
        private void fontsColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;    // Cho phép hiển thị tất cả các màu sắc
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = dlg.Color;
                }
            }
        }

        private void backControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in this.Controls)
                {
                    control.BackColor = dlg.Color;
                }
            }
        }

        private void backFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true; // Cho phép hiển thị tất cả các màu sắc
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Gán màu được chọn từ ColorDialog cho màu nền của Form
                this.BackColor = dlg.Color;
            }
        }

        //nhấn vào Log out để ra màn hình đăng nhập
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
            this.Close();
        }

        //Nhấn Exit để đóng app
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //set tiêu đề
            openFile.Title = "Mở ảnh đại diện";
            //check điều kiện lọc file
            openFile.Filter = "File anh|*.jpg;|All file|*.*";
            //check xem người dùng đã chọn file hay chưa
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image = Image.FromFile(openFile.FileName);
            }
        }

        // thêm row cho bảng thời khoá biểu khi form dc load
        private void FormMain_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 29; i++)
            {
                gridBangThoiKhoaBieu.Rows.Add(i + ". ", i + ". ", i + ". ", i + ". ", i + ". ", i + ". ", i + ". ");
            }
        }

       
    }
}
