using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu 
{
    public partial class FormMain : Form
    {
    private SoundPlayer music; // thuộc tính để lưu nhạc
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
            DialogResult traLoi;
            traLoi = MessageBox.Show("Bạn có chắc muốn về màn hình Login không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi == DialogResult.OK) 
            {
                this.Hide();
                FormLogin login = new FormLogin();
                login.ShowDialog();
                this.Close();
            }        
        }

        //Nhấn Exit để đóng app
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi == DialogResult.OK)
            {
                Application.Exit();
            }            
        }

        private void playSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu âm thanh đã được khởi tạo trước đó
                if (music != null)
                {
                    // Dừng phát âm thanh nếu đang phát
                    music.Stop();
                    // Giải phóng tài nguyên
                    music.Dispose();
                }

                // Khởi tạo SoundPlayer với đường dẫn tới tệp âm thanh
                music = new SoundPlayer(@"C:\Users\NGUYEN\Time_Schedule_and_Expense_Management\Quản Lý Thời Gian Biểu và Chi Tiêu\resources\autumn-july.wav");

                // Phát âm thanh
                music.Play();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ví dụ: hiển thị thông báo cho người dùng)
                MessageBox.Show("Lỗi khi phát âm thanh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu âm thanh đã được khởi tạo trước đó
                if (music != null)
                {
                    // Dừng phát âm thanh nếu đang phát
                    music.Stop();
                    // Giải phóng tài nguyên
                    music.Dispose();
                }

                // Khởi tạo SoundPlayer với đường dẫn tới tệp âm thanh
                music = new SoundPlayer(@"C:\Users\NGUYEN\Time_Schedule_and_Expense_Management\Quản Lý Thời Gian Biểu và Chi Tiêu\resources\autumn-july.wav");

                // Phát âm thanh
                music.Stop();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ví dụ: hiển thị thông báo cho người dùng)
                MessageBox.Show("Lỗi khi phát âm thanh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //âm thanh được dừng khi form đóng
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            music.Stop();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ qua hot Line: 092193213\n" +
                "hoặc qua email sau: nguyen.hochi2004@gmail.com", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridBangThoiKhoaBieu.Rows.Clear();
            for (int i = 1; i <= 29; i++)
            {
                gridBangThoiKhoaBieu.Rows.Add(i + ". ", i + ". ", i + ". ", i + ". ", i + ". ", i + ". ", i + ". ");
            }
        }

        private void SaveToTextFile(DataGridView dataGridView, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Ghi tiêu đề cột
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        writer.Write(dataGridView.Columns[i].HeaderText);
                        if (i < dataGridView.Columns.Count - 1) //kiểm tra xem cột hiện tại có phải là cột cuối cùng của DataGridView hay không
                            writer.Write("\t");
                    }
                    writer.WriteLine();

                    // Ghi dữ liệu từ các dòng
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            writer.Write(row.Cells[i].Value);
                            if (i < dataGridView.Columns.Count - 1)
                                writer.Write("\t");
                        }
                        writer.WriteLine();
                    }
                }
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|File pdf|*.pdf |All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1; //Xác định chỉ số của bộ lọc mặc định được chọn trong danh sách các bộ lọc
            saveFileDialog.RestoreDirectory = true; //Khôi phục thư mục hiện tại khi hộp thoại đóng lại

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveToTextFile(gridBangThoiKhoaBieu, saveFileDialog.FileName);
            }
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

        //mở form các tài khoản ngân hàng
        private void btnTaiKhoanNganHang_Click(object sender, EventArgs e)
        {  
            FormTaiKhoan f = new FormTaiKhoan();
            f.TopLevel = false;
            this.Controls.Add(f); // Thêm form con vào các điều khiển của form cha
            f.Dock = DockStyle.Fill; // Đặt đầy đủ kích thước của form con
            f.BringToFront(); // Đưa form con lên phía trước
            f.Show(); // Hiển thị form con
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1; // mặc định chọn đuôi .txt

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    gridBangThoiKhoaBieu.Rows.Clear();
                    string filePath = openFileDialog.FileName;
                    // Đọc dữ liệu từ tệp và hiển thị trên DataGridView
                    string[] lines = File.ReadAllLines(filePath);
                    // Bỏ qua dòng đầu tiên
                    lines = lines.Skip(1).ToArray();
                    foreach (string line in lines)
                    {
                        string[] data = line.Split('\t'); // Giả sử dữ liệu được phân tách bằng tab (\t)
                        gridBangThoiKhoaBieu.Rows.Add(data);
                    }
                    MessageBox.Show("Đã mở tệp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở tệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTaiChinh_Click(object sender, EventArgs e)
        {
            FormTaiChinh f = new FormTaiChinh();    
            f.TopLevel = false;
            this.Controls.Add(f); // Thêm form con vào các điều khiển của form cha
            f.Dock = DockStyle.Fill; // Đặt đầy đủ kích thước của form con
            f.BringToFront(); // Đưa form con lên phía trước
            f.Show(); // Hiển thị form con
        }
    }
}
