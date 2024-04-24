using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
    public partial class FormMain_36_Nguyen : Form
    {
        private SoundPlayer music_36_Nguyen; // thuộc tính để lưu nhạc
        private int currentImageIndex_36_Nguyen = 0;
        private List<Image> images_36_Nguyen = new List<Image>(); // Danh sách các ảnh cần thay đổi
        public FormMain_36_Nguyen()
        {           
            InitializeComponent();
            // Thêm các ảnh vào danh sách
            images_36_Nguyen.Add(Properties.Resources.cake);
            images_36_Nguyen.Add(Properties.Resources.gioiThieuCake);
            images_36_Nguyen.Add(Properties.Resources.laisuatall);

            // Bắt đầu đếm thời gian sau mỗi 3 giây
            timerImg_36_Nguyen.Start();

            // ngày giờ
            timerDateTime_36_Nguyen.Start();
        }

        //Main form---------------------------------------------------------------
        private void picAvatar_36_Nguyen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile_36_Nguyen = new OpenFileDialog();
            //set tiêu đề
            openFile_36_Nguyen.Title = "Mở ảnh đại diện";
            //check điều kiện lọc file
            openFile_36_Nguyen.Filter = "File anh|*.jpg;|All file|*.*";
            //check xem người dùng đã chọn file hay chưa
            if (openFile_36_Nguyen.ShowDialog() == DialogResult.OK)
            {
                picAvatar_36_Nguyen.Image = Image.FromFile(openFile_36_Nguyen.FileName);
            }
        }

        // thêm row cho bảng thời khoá biểu khi form dc load
        private void FormMain_36_Nguyen_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                gridBangThoiKhoaBieu_36_Nguyen.Rows.Add(i + ". ", i + ". ", i + ". ", i + ". ", i + ". ", i + ". ", i + ". ");
            }
        }

        //mở form các tài khoản ngân hàng
        private void btnTaiKhoanNganHang_36_Nguyen_Click(object sender, EventArgs e)
        {  
            FormTaiKhoan_36_Nguyen f_36_Nguyen = new FormTaiKhoan_36_Nguyen();
            f_36_Nguyen.TopLevel = false;
            this.Controls.Add(f_36_Nguyen); // Thêm form con vào các điều khiển của form cha
            f_36_Nguyen.Dock = DockStyle.Fill; // Đặt đầy đủ kích thước của form con
            f_36_Nguyen.BringToFront(); // Đưa form con lên phía trước
            f_36_Nguyen.Show(); // Hiển thị form con
        }

        //Mở form tài chính
        private void btnTaiChinh_36_Nguyen_Click(object sender, EventArgs e)
        {
            FormTaiChinh_36_Nguyen f_36_Nguyen = new FormTaiChinh_36_Nguyen();
            f_36_Nguyen.TopLevel = false;
            this.Controls.Add(f_36_Nguyen); // Thêm form con vào các điều khiển của form cha
            f_36_Nguyen.Dock = DockStyle.Fill; // Đặt đầy đủ kích thước của form con
            f_36_Nguyen.BringToFront(); // Đưa form con lên phía trước
            f_36_Nguyen.Show(); // Hiển thị form con
        }

        private void timerImg_36_Nguyen_Tick(object sender, EventArgs e)
        {
            // Kiểm tra nếu đã đến ảnh cuối cùng trong danh sách, quay lại ảnh đầu tiên
            if (currentImageIndex_36_Nguyen == images_36_Nguyen.Count - 1)
            {
                currentImageIndex_36_Nguyen = 0;
            }
            else
            {
                currentImageIndex_36_Nguyen++;
            }

            // Hiển thị ảnh tương ứng trong Panel
            picQuangCao_36_Nguyen.Image = images_36_Nguyen[currentImageIndex_36_Nguyen];
        }

        private void timerDateTime_36_Nguyen_Tick(object sender, EventArgs e)
        {
            // Cập nhật thời gian lên Label
            lbDateTime_36_Nguyen.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        //Menu-------------------------------------------------------------
        //Làm mới bảng
        private void newToolStripMenuItem2_36_Nguyen_Click(object sender, EventArgs e)
        {
            gridBangThoiKhoaBieu_36_Nguyen.Rows.Clear();
            for (int i = 1; i <= 31; i++)
            {
                gridBangThoiKhoaBieu_36_Nguyen.Rows.Add(i + ". ", i + ". ", i + ". ", i + ". ", i + ". ", i + ". ", i + ". ");
            }
        }

        //Mở bảng grid tkb
        private void openToolStripMenuItem2_36_Nguyen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_36_Nguyen = new OpenFileDialog();
            openFileDialog_36_Nguyen.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog_36_Nguyen.FilterIndex = 1; // mặc định chọn đuôi .txt

            if (openFileDialog_36_Nguyen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    gridBangThoiKhoaBieu_36_Nguyen.Rows.Clear();
                    string filePath_36_Nguyen = openFileDialog_36_Nguyen.FileName;
                    // Đọc dữ liệu từ tệp và hiển thị trên DataGridView
                    string[] lines_36_Nguyen = File.ReadAllLines(filePath_36_Nguyen);
                    // Bỏ qua dòng đầu tiên
                    lines_36_Nguyen = lines_36_Nguyen.Skip(1).ToArray();
                    foreach (string line in lines_36_Nguyen)
                    {
                        string[] data_36_Nguyen = line.Split('\t'); // Giả sử dữ liệu được phân tách bằng tab (\t)
                        gridBangThoiKhoaBieu_36_Nguyen.Rows.Add(data_36_Nguyen);
                    }
                    MessageBox.Show("Đã mở tệp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở tệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //hàm xử lí Lưu bảng thành file 
        private void SaveToTextFile_36_Nguyen(DataGridView dataGridView, string filePath)
        {
            try
            {
                using (StreamWriter writer_36_Nguyen = new StreamWriter(filePath))
                {
                    // Ghi tiêu đề cột
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        writer_36_Nguyen.Write(dataGridView.Columns[i].HeaderText);
                        if (i < dataGridView.Columns.Count - 1)
                            writer_36_Nguyen.Write("\t");
                    }
                    writer_36_Nguyen.WriteLine();

                    // Ghi dữ liệu từ các dòng
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            writer_36_Nguyen.Write(row.Cells[i].Value);
                            if (i < dataGridView.Columns.Count - 1)
                                writer_36_Nguyen.Write("\t");
                        }
                        writer_36_Nguyen.WriteLine();
                    }
                }
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Lưu bảng thời khoá biểu thành txt
        private void saveToolStripMenuItem2_36_Nguyen_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog_36_Nguyen = new SaveFileDialog();
            saveFileDialog_36_Nguyen.Filter = "Text files (*.txt)|*.txt|File pdf|*.pdf |All files (*.*)|*.*";
            saveFileDialog_36_Nguyen.FilterIndex = 1; //Xác định chỉ số của bộ lọc mặc định được chọn trong danh sách các bộ lọc
            saveFileDialog_36_Nguyen.RestoreDirectory = true; //Khôi phục thư mục hiện tại khi hộp thoại đóng lại

            if (saveFileDialog_36_Nguyen.ShowDialog() == DialogResult.OK)
            {
                SaveToTextFile_36_Nguyen(gridBangThoiKhoaBieu_36_Nguyen, saveFileDialog_36_Nguyen.FileName);
            }
        }

        //Nhấn Exit để đóng app
        private void exitToolStripMenuItem2_36_Nguyen_Click(object sender, EventArgs e)
        {
            DialogResult traLoi_36_Nguyen;
            traLoi_36_Nguyen = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi_36_Nguyen == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //FontDialog menu
        //Chỉnh font chữ
        private void fontEditToolStripMenuItem1_36_Nguyen_Click(object sender, EventArgs e)
        {
            FontDialog dlg_36_Nguyen = new FontDialog();
            dlg_36_Nguyen.ShowEffects = true;
            //dlg.ShowColor = true;
            dlg_36_Nguyen.ShowApply = true;
            if (dlg_36_Nguyen.ShowDialog() == DialogResult.OK)
            {
                // Lặp qua tất cả các control trong Form
                foreach (Control control in this.Controls)
                {
                    // Thay đổi font cho mỗi control là Label, Button, TextBox, v.v.
                    control.Font = dlg_36_Nguyen.Font;
                }
            }
        }

        //ColorDialog menu
        //Màu chữ   
        private void fontColorToolStripMenuItem1_36_Nguyen_Click(object sender, EventArgs e)
        {
            ColorDialog dlg_36_Nguyen = new ColorDialog();
            dlg_36_Nguyen.FullOpen = true;    // Cho phép hiển thị tất cả các màu sắc
            if (dlg_36_Nguyen.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = dlg_36_Nguyen.Color;
                }
            }
        }

        //Màu form
        private void formColorToolStripMenuItem1_36_Nguyen_Click(object sender, EventArgs e)
        {
            ColorDialog dlg_36_Nguyen = new ColorDialog();
            dlg_36_Nguyen.FullOpen = true; // Cho phép hiển thị tất cả các màu sắc
            if (dlg_36_Nguyen.ShowDialog() == DialogResult.OK)
            {
                // Gán màu được chọn từ ColorDialog cho màu nền của Form
                this.BackColor = dlg_36_Nguyen.Color;
            }
        }

        //Màu control
        private void controlColorToolStripMenuItem1_36_Nguyen_Click(object sender, EventArgs e)
        {
            ColorDialog dlg_36_Nguyen = new ColorDialog();
            dlg_36_Nguyen.FullOpen = true;
            if (dlg_36_Nguyen.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in this.Controls)
                {
                    control.BackColor = dlg_36_Nguyen.Color;
                }
            }
        }

        //Phát nhạc
        private void playToolStripMenuItem1_36_Nguyen_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu âm thanh đã được khởi tạo trước đó
                if (music_36_Nguyen != null)
                {
                    // Dừng phát âm thanh nếu đang phát
                    music_36_Nguyen.Stop();
                    // Giải phóng tài nguyên
                    music_36_Nguyen.Dispose();
                }

                // Khởi tạo SoundPlayer với đường dẫn tới tệp âm thanh
                music_36_Nguyen = new SoundPlayer(@"C:\Users\NGUYEN\Time_Schedule_and_Expense_Management\Quản Lý Thời Gian Biểu và Chi Tiêu\resources\autumn-july.wav");

                // Phát âm thanh
                music_36_Nguyen.Play();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ví dụ: hiển thị thông báo cho người dùng)
                MessageBox.Show("Lỗi khi phát âm thanh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Dừng nhạc
        private void stopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu âm thanh đã được khởi tạo trước đó
                if (music_36_Nguyen != null)
                {
                    // Dừng phát âm thanh nếu đang phát
                    music_36_Nguyen.Stop();
                    // Giải phóng tài nguyên
                    music_36_Nguyen.Dispose();
                }

                // Khởi tạo SoundPlayer với đường dẫn tới tệp âm thanh
                music_36_Nguyen = new SoundPlayer(@"C:\Users\NGUYEN\Time_Schedule_and_Expense_Management\Quản Lý Thời Gian Biểu và Chi Tiêu\resources\autumn-july.wav");

                // Dừng âm thanh
                music_36_Nguyen.Stop();
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
            music_36_Nguyen.Stop();
        }

        //help content
        private void helpToolStripMenuItem2_36_Nguyen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ qua HotLine: 0332636829\n" +
                "hoặc qua email sau: nguyen.hochi2004@gmail.com", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //nhấn vào Log out để ra màn hình đăng nhập
        private void logOutToolStripMenuItem1_36_Nguyen_Click(object sender, EventArgs e)
        {
            DialogResult traLoi_36_Nguyen;
            traLoi_36_Nguyen = MessageBox.Show("Bạn có chắc muốn về màn hình Login không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi_36_Nguyen == DialogResult.OK)
            {
                this.Hide();
                FormLogin_36_Nguyen login = new FormLogin_36_Nguyen();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
