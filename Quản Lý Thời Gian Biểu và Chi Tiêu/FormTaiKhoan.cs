using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu
{
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            ListTaiKhoanNganHang.Items.Add("----------DANH SÁCH TÀI KHOẢN NGÂN HÀNG----------");
            cbChonTaiKhoanNganHang.SelectedIndex = 0;
        }

        private void btnThemNganHang_Click(object sender, EventArgs e)
        {
            String tenNganHang = cbChonTaiKhoanNganHang.SelectedItem.ToString();
            String taiKhoan = txtTenTaiKhoanNganHang.Text;
            String matKhau = txtMatKhauNganHang.Text;
            // Kiểm tra xem các TextBox có trống hay ko
            if (!string.IsNullOrEmpty(tenNganHang) && !string.IsNullOrEmpty(taiKhoan) && !string.IsNullOrEmpty(matKhau))
            {
                // Chuỗi chứa thông tin tài khoản ngân hàng
                // $ giúp chèn các biến hoặc biểu thức trực tiếp vào chuỗi mà không cần phải sử dụng các toán tử nối chuỗi
                string thongTinTaiKhoan = $"{tenNganHang} - Tài khoản: {taiKhoan}, Mật khẩu: {matKhau}";

                // Thêm dữ liệu từ ComboBox và TextBox vào ListBox
                ListTaiKhoanNganHang.Items.Add(thongTinTaiKhoan);

                // Xóa nội dung của các TextBox sau khi thêm vào ListBox
                txtTenTaiKhoanNganHang.Clear();
                txtMatKhauNganHang.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu trước khi thêm vào danh sách", "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (ListTaiKhoanNganHang.SelectedIndex != -1)
            {
                // Lấy chỉ số của mục được chọn
                int mucChon = ListTaiKhoanNganHang.SelectedIndex;

                // Xóa mục được chọn từ ListBox
                ListTaiKhoanNganHang.Items.RemoveAt(mucChon);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa", "Lỗi");
            }
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            DialogResult traLoiXoaAll;
            traLoiXoaAll = MessageBox.Show("Bạn có chắc muốn xoá tất cả không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoiXoaAll == DialogResult.OK)
            {
                ListTaiKhoanNganHang.Items.Clear();
            }          
        }

        private void xuatGhiFile(string filePath, ListBox listBox)
        {
            try
            {
                // Mở tệp văn bản để ghi
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Lặp qua từng mục trong ListBox và ghi vào tệp
                    foreach (var item in listBox.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }

                MessageBox.Show("Xuất ListBox thành công vào tệp " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Gọi phương thức xuất ListBox
                xuatGhiFile(filePath, ListTaiKhoanNganHang);
            }
        }

        private void xuLiMoFile(string filePath, ListBox listBox)
        {
            try
            {
                // Kiểm tra xem tệp tồn tại trước khi đọc
                if (File.Exists(filePath))
                {
                    // Mở tệp văn bản để đọc
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Đọc từng dòng của tệp và thêm vào ListBox
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            listBox.Items.Add(line);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tệp không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Xóa các mục hiện có trong ListBox trước khi tải dữ liệu mới
                ListTaiKhoanNganHang.Items.Clear();

                // Gọi phương thức để tải dữ liệu từ tệp vào ListBox
                xuLiMoFile(filePath, ListTaiKhoanNganHang);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.ToLower(); // Lấy dữ liệu cần tìm kiếm từ TextBox và chuyển thành chữ thường
            // Duyệt qua từng mục trong ListBox
            for (int i = 0; i < ListTaiKhoanNganHang.Items.Count; i++)
            {
                string itemText = ListTaiKhoanNganHang.Items[i].ToString().ToLower(); // Lấy dữ liệu từng mục trong ListBox và chuyển thành chữ thường
                // Nếu dữ liệu trong mục khớp với dữ liệu cần tìm kiếm
                if (itemText.Contains(searchText))
                {                
                    ListTaiKhoanNganHang.SetSelected(i, true); // Đặt màu sắc cho mục tương ứng
                    ListTaiKhoanNganHang.TopIndex = i; // Cuộn ListBox đến mục được chọn
                    ListTaiKhoanNganHang.Focus(); // Đưa focus vào ListBox để dễ dàng nhìn thấy mục được chọn
                    return; // Dừng vòng lặp khi tìm thấy kết quả
                }
            }
            MessageBox.Show("Không tìm thấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
