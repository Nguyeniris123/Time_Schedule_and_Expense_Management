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
    public partial class FormLogin_36_Nguyen : Form
    {
        private bool isEyeOpen_36_Nguyen = false;
        public FormLogin_36_Nguyen()
        {
            InitializeComponent();
        }

        //Phương thức đọc file tài khoản (accounts) có tồn tại hay không
        private bool CheckCredentials_36_Nguyen(string username, string password)
        {
            string filePath = "C:\\Users\\NGUYEN\\Time_Schedule_and_Expense_Management\\Quản Lý Thời Gian Biểu và Chi Tiêu\\resources\\accounts.txt";
            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines_36_Nguyen = File.ReadAllLines(filePath);
                    foreach (string line in lines_36_Nguyen)
                    {
                        string[] parts_36_Nguyen = line.Split(',');
                        if (parts_36_Nguyen.Length == 2 && parts_36_Nguyen[0].Trim() == username && parts_36_Nguyen[1].Trim() == password)
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

        // login btn
        private void btnLogin_36_Nguyen_Click(object sender, EventArgs e)
        {
            string username_36_Nguyen = txtUser_36_Nguyen.Text;
            string password_36_Nguyen = txtPassWord_36_Nguyen.Text;
            bool isAuthenticated = CheckCredentials_36_Nguyen(username_36_Nguyen, password_36_Nguyen);
            if (isAuthenticated)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormMain_36_Nguyen frmMain = new FormMain_36_Nguyen();
                frmMain.ShowDialog();
                this.Close();
            }
            else if (txtUser_36_Nguyen.Text == "Nguyen" && txtPassWord_36_Nguyen.Text == "36")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormMain_36_Nguyen frmMain = new FormMain_36_Nguyen();
                frmMain.ShowDialog();
                this.Close();
            }    
            else if (txtUser_36_Nguyen.Text == "" || txtPassWord_36_Nguyen.Text == "")
                MessageBox.Show("Tài khoản hoặc mật khẩu để trống", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu!!!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser_36_Nguyen.Focus();
            }
        }

        //Ghi file tài khoản và mật khẩu khi đăng kí (Sign Up)
        private void btnSignUp_36_Nguyen_Click(object sender, EventArgs e)
        {
            string username_36_Nguyen = txtUser_36_Nguyen.Text;
            string password_36_Nguyen = txtPassWord_36_Nguyen.Text;
            bool isAuthenticated_36_Nguyen = CheckCredentials_36_Nguyen(username_36_Nguyen, password_36_Nguyen);
            if (isAuthenticated_36_Nguyen)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }        
            else if (txtUser_36_Nguyen.Text == "" || txtPassWord_36_Nguyen.Text == "")
                MessageBox.Show("Tài khoản hoặc mật khẩu để trống", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    // Đường dẫn đến tệp tin, khi sử dụng ký tự @, không cần escape các ký tự \ trong chuỗi đường dẫn
                    string filePath = @"C:\Users\NGUYEN\Time_Schedule_and_Expense_Management\Quản Lý Thời Gian Biểu và Chi Tiêu\resources\accounts.txt";
                    // Mở tệp tin để ghi
                    using (StreamWriter sw_36_Nguyen = File.AppendText(filePath))
                    {
                        // Ghi tên người dùng và mật khẩu vào tệp tin
                        sw_36_Nguyen.WriteLine(/*"\n" + */username_36_Nguyen + "," + password_36_Nguyen);
                    }
                    this.Hide();
                    IsRobot_36_Nguyen robot = new IsRobot_36_Nguyen();
                    robot.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi đăng kí tài khoản: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        //Phương thức thay đổi ảnh mật khẩu hiện và ẩn
        private void ChangeEyeImage_36_Nguyen()
        {
            if (isEyeOpen_36_Nguyen)
            {
                picEye_36_Nguyen.Image = Properties.Resources.EyeOpen;
            }
            else
            {
                picEye_36_Nguyen.Image = Properties.Resources.Eye;
            }
        }
        private void picEye_36_Nguyen_Click (object sender, EventArgs e)
        {
            // Khi PictureBox picEye được nhấn, chuyển đổi hiển thị mật khẩu
            if (txtPassWord_36_Nguyen.PasswordChar == '*')
                txtPassWord_36_Nguyen.PasswordChar = '\0'; // Hiển thị mật khẩu
            else
                txtPassWord_36_Nguyen.PasswordChar = '*'; // Ẩn mật khẩu

            // nếu isEyeOpen là false sẽ thành true và ngược lại
            isEyeOpen_36_Nguyen = !isEyeOpen_36_Nguyen;
            ChangeEyeImage_36_Nguyen();
        }

        private void lbQuenMK_36_Nguyen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ hỗ trợ qua email: " +
                "nguyen.hochi2004@gmail.com\n" +
                "Hoặc liên hệ qua hot line: 0332636829", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //CSS
        // in nghiêng ô quên mk khi hover
        private void lbQuenMK_36_Nguyen_MouseHover(object sender, EventArgs e)
        {
            lbQuenMK_36_Nguyen.Font = new Font(lbQuenMK_36_Nguyen.Font, FontStyle.Underline);
        }

        private void lbQuenMK_36_Nguyen_MouseLeave(object sender, EventArgs e)
        {
            lbQuenMK_36_Nguyen.Font = new Font(lbQuenMK_36_Nguyen.Font, FontStyle.Italic);
        }

        //Hover vào có màu ở ô Đăng nhập
        private void txtUser_36_Nguyen_MouseDown(object sender, MouseEventArgs e)
        {
            txtUser_36_Nguyen.BackColor = Color.LightGreen;
        }

        private void txtUser_36_Nguyen_MouseLeave(object sender, EventArgs e)
        {
            txtUser_36_Nguyen.BackColor = Color.White;
        }

        //Hover vào có màu ở ô Mật khẩu
        private void txtPassWork_36_Nguyen_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassWord_36_Nguyen.BackColor = Color.LightGreen;
        }

        private void txtPassWork_36_Nguyen_MouseLeave(object sender, EventArgs e)
        {
            txtPassWord_36_Nguyen.BackColor = Color.White;
        }
    }
}
