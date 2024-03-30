using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO; // phải có cái này Mới sử dụng dc File
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu
{
    public partial class FormLogin : Form
    {
        private bool isEyeOpen = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassWord.Text;
            bool isAuthenticated = CheckCredentials(username, password);
            if (isAuthenticated)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                FormMain frmMain = new FormMain();
                frmMain.ShowDialog();
                this.Close();
            }
            else if (txtUser.Text == "" || txtPassWord.Text == "")
                MessageBox.Show("Tài khoản hoặc mật khẩu để trống", "Lỗi!!!", MessageBoxButtons.OK);
            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu!!!", "Lỗi!!!", MessageBoxButtons.OK);
                txtUser.Focus();
            }
        }

        //Phương thức đọc file tài khoản (accounts) - Kiểm tra thông tin xác thực
        private bool CheckCredentials(string username, string password)
        {
            string filePath = "C:\\Users\\NGUYEN\\source\\repos\\Quản Lý Thời Gian Biểu và Chi Tiêu\\Quản Lý Thời Gian Biểu và Chi Tiêu\\resources\\accounts.txt";
            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2 && parts[0].Trim() == username && parts[1].Trim() == password)
                        {
                            return true; // Tìm thấy tài khoản và mật khẩu trùng khớp
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("Không tìm thấy tệp lưu trữ tài khoản!", "Lỗi");
                    return false; // Không tìm thấy tài khoản hoặc mật khẩu
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            return false; // Không tìm thấy tài khoản hoặc mật khẩu
        }

        //Ghi file tài khoản và mật khẩu ghi đăng kí (Sign Up)



        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassWord.Text;
            bool isAuthenticated = CheckCredentials(username, password);
            if (isAuthenticated)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                return;
            }        
            else if (txtUser.Text == "" || txtPassWord.Text == "")
                MessageBox.Show("Tài khoản hoặc mật khẩu để trống", "Lỗi!!!", MessageBoxButtons.OK);
            else
            {
                try
                {
                    // Đường dẫn đến tệp tin, khi sử dụng ký tự @, không cần escape các ký tự \ trong chuỗi đường dẫn
                    string filePath = @"C:\Users\NGUYEN\source\repos\Quản Lý Thời Gian Biểu và Chi Tiêu\Quản Lý Thời Gian Biểu và Chi Tiêu\resources\accounts.txt";
                    // Mở tệp tin để ghi
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        // Ghi tên người dùng và mật khẩu vào tệp tin
                        sw.WriteLine(/*"\n" + */username + "," + password);
                    }
                    MessageBox.Show("Đăng kí tài khoản thành công, mời bạn đăng nhập ứng dụng", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi đăng kí tài khoản: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        //Thay đổi ảnh mật khẩu hiện và ẩn
        private void ChangeEyeImage()
        {
            if (isEyeOpen)
            {
                picEye.Image = Properties.Resources.EyeOpen;
            }
            else
            {
                picEye.Image = Properties.Resources.Eye;
            }
        }
        private void picEye_Click(object sender, EventArgs e)
        {
            // Khi PictureBox picEye được nhấn, chuyển đổi hiển thị mật khẩu
            if (txtPassWord.PasswordChar == '*')
                txtPassWord.PasswordChar = '\0'; // Hiển thị mật khẩu
            else
                txtPassWord.PasswordChar = '*'; // Ẩn mật khẩu

            // nếu isEyeOpen là false sẽ thành true và ngược lại
            isEyeOpen = !isEyeOpen;
            ChangeEyeImage();
        }
        private void lbQuenMK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ hỗ trợ qua email: " +
                "nguyen.hochi2004@gmail.com\n" +
                "Hoặc liên hệ qua hot line: 0332636829", "Help", MessageBoxButtons.OKCancel);
        }

        //Css
        private void lbQuenMK_MouseHover(object sender, EventArgs e)
        {
            lbQuenMK.Font = new Font(lbQuenMK.Font, FontStyle.Underline);
        }

        private void lbQuenMK_MouseLeave(object sender, EventArgs e)
        {
            lbQuenMK.Font = new Font(lbQuenMK.Font, FontStyle.Italic);
        }

        private void txtUser_MouseDown(object sender, MouseEventArgs e)
        {
            txtUser.BackColor = Color.LightGreen;
        }

        private void txtUser_MouseLeave(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.White;
        }

        private void txtPassWork_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassWord.BackColor = Color.LightGreen;
        }

        private void txtPassWork_MouseLeave(object sender, EventArgs e)
        {
            txtPassWord.BackColor = Color.White;
        }
    }
}
