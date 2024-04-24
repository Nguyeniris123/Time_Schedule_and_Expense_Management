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

namespace Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu
{
    public partial class FormTaiKhoan_36_Nguyen : Form
    {
        public FormTaiKhoan_36_Nguyen()
        {
            InitializeComponent();
        }

        private void FormTaiKhoan_36_Nguyen_Load(object sender, EventArgs e)
        {
            cbChonTaiKhoanNganHang_36_Nguyen.SelectedIndex = 0;
        }

        //Không cho nhập chữ ở ô số tài khoản
        private void txtSoTaiKhoanNganHang_36_Nguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemNganHang_36_Nguyen_Click(object sender, EventArgs e)
        {
            String NganHang_36_Nguyen = cbChonTaiKhoanNganHang_36_Nguyen.SelectedItem.ToString();
            String taiKhoan_36_Nguyen = txtSoTaiKhoanNganHang_36_Nguyen.Text;
            String matKhau_36_Nguyen = txtMatKhauNganHang_36_Nguyen.Text;
            // Kiểm tra xem các TextBox có trống hay ko
            if (!string.IsNullOrEmpty(NganHang_36_Nguyen) && !string.IsNullOrEmpty(taiKhoan_36_Nguyen) && !string.IsNullOrEmpty(matKhau_36_Nguyen))
            {
                ListViewItem lvDs_36_Nguyen = lvDanhSachNganHang_36_Nguyen.Items.Add(cbChonTaiKhoanNganHang_36_Nguyen.Text);
                lvDs_36_Nguyen.SubItems.Add(txtSoTaiKhoanNganHang_36_Nguyen.Text);
                lvDs_36_Nguyen.SubItems.Add(txtMatKhauNganHang_36_Nguyen.Text);

                // Xóa nội dung của các TextBox sau khi thêm vào ListView
                txtSoTaiKhoanNganHang_36_Nguyen.Clear();
                txtMatKhauNganHang_36_Nguyen.Clear();
                txtSoTaiKhoanNganHang_36_Nguyen.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu trước khi thêm vào danh sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_36_Nguyen_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (lvDanhSachNganHang_36_Nguyen.SelectedItems.Count > 0)
            {
                // Xóa mục được chọn từ ListBox
                lvDanhSachNganHang_36_Nguyen.Items.Remove(lvDanhSachNganHang_36_Nguyen.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaAll_36_Nguyen_Click(object sender, EventArgs e)
        {
            DialogResult traLoiXoaAll_36_Nguyen;
            traLoiXoaAll_36_Nguyen = MessageBox.Show("Bạn có chắc muốn xoá tất cả không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoiXoaAll_36_Nguyen == DialogResult.OK)
            {
                lvDanhSachNganHang_36_Nguyen.Items.Clear();
            }
        }

        // chọn 1 nội dung trong lvDanhSachNganHang_36_Nguyen thì lấy nội dung được chọn cập nhật lên 3 ô
        private void lvDanhSachNganHang_36_Nguyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachNganHang_36_Nguyen.SelectedItems.Count > 0)
            {
                cbChonTaiKhoanNganHang_36_Nguyen.Text = lvDanhSachNganHang_36_Nguyen.SelectedItems[0].SubItems[0].Text;
                txtSoTaiKhoanNganHang_36_Nguyen.Text = lvDanhSachNganHang_36_Nguyen.SelectedItems[0].SubItems[1].Text;
                txtMatKhauNganHang_36_Nguyen.Text = lvDanhSachNganHang_36_Nguyen.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnSua_36_Nguyen_Click(object sender, EventArgs e)
        {
            if (lvDanhSachNganHang_36_Nguyen.SelectedItems.Count > 0)
            {
                lvDanhSachNganHang_36_Nguyen.SelectedItems[0].SubItems[0].Text = cbChonTaiKhoanNganHang_36_Nguyen.Text;
                lvDanhSachNganHang_36_Nguyen.SelectedItems[0].SubItems[1].Text = txtSoTaiKhoanNganHang_36_Nguyen.Text;
                lvDanhSachNganHang_36_Nguyen.SelectedItems[0].SubItems[2].Text = txtMatKhauNganHang_36_Nguyen.Text;
            }
            else 
                MessageBox.Show("Vui lòng chọn một nội dung trong danh sách tài khoản để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void xuLiXuatFile_36_Nguyen(string filePath, ListView listView)
        {
            try
            {
                // Mở tệp văn bản để ghi
                using (StreamWriter writer_36_Nguyen = new StreamWriter(filePath))
                {
                    // Lặp qua từng mục trong ListView và ghi vào tệp
                    foreach (ListViewItem item in listView.Items)
                    {
                        // Duyệt qua từng cột của mỗi mục và ghi vào tệp
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            writer_36_Nguyen.Write(subItem.Text);
                            writer_36_Nguyen.Write("\t"); // Phân cách giữa các cột
                        }
                        writer_36_Nguyen.WriteLine(); // Xuống dòng sau khi ghi xong một mục
                    }
                }

                MessageBox.Show("Xuất ListView thành công vào tệp " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuatFile_36_Nguyen_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog_36_Nguyen = new SaveFileDialog();
            saveFileDialog_36_Nguyen.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog_36_Nguyen.ShowDialog() == DialogResult.OK)
            {
                string filePath_36_Nguyen = saveFileDialog_36_Nguyen.FileName;

                // Gọi phương thức xuất ListView
                xuLiXuatFile_36_Nguyen(filePath_36_Nguyen, lvDanhSachNganHang_36_Nguyen);
            }
        }

        private void xuLiMoFile_36_Nguyen(string filePath, ListView listView)
        {
            try
            {
                // Kiểm tra xem tệp tồn tại trước khi đọc
                if (File.Exists(filePath))
                {
                    // Xóa dữ liệu cũ trong ListView trước khi tải dữ liệu mới
                    listView.Items.Clear();

                    // Mở tệp văn bản để đọc
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line_36_Nguyen;
                        while ((line_36_Nguyen = reader.ReadLine()) != null)
                        {
                            // Tách các giá trị trong mỗi dòng bằng dấu tab
                            string[] values_36_Nguyen = line_36_Nguyen.Split('\t');

                            // Tạo một ListViewItem mới
                            ListViewItem item_36_Nguyen = new ListViewItem(values_36_Nguyen[0]); // Giá trị đầu tiên là cho cột đầu tiên
                            for (int i = 1; i < values_36_Nguyen.Length; i++)
                            {
                                // Thêm các giá trị còn lại vào các SubItem (cột phụ)
                                item_36_Nguyen.SubItems.Add(values_36_Nguyen[i]);
                            }

                            // Thêm ListViewItem vào ListView
                            listView.Items.Add(item_36_Nguyen);
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

        private void btnMoFile_36_Nguyen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_36_Nguyen = new OpenFileDialog();
            openFileDialog_36_Nguyen.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog_36_Nguyen.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog_36_Nguyen.FileName;

                // Xóa các mục hiện có trong ListView trước khi tải dữ liệu mới
                lvDanhSachNganHang_36_Nguyen.Items.Clear();

                // Gọi phương thức để tải dữ liệu từ tệp vào ListView
                xuLiMoFile_36_Nguyen(filePath, lvDanhSachNganHang_36_Nguyen);
            }
        }

        private void btnTimKiem_36_Nguyen_Click(object sender, EventArgs e)
        {
            string searchText_36_Nguyen = txtTimKiem_36_Nguyen.Text.ToLower(); // Lấy dữ liệu cần tìm kiếm từ TextBox và chuyển thành chữ thường
            List<int> mucTimThay_36_Nguyen = new List<int>(); // Danh sách để lưu các chỉ số của các mục được tìm thấy

            // Duyệt qua từng mục trong ListView
            for (int i = 0; i < lvDanhSachNganHang_36_Nguyen.Items.Count; i++)
            {
                ListViewItem item_36_Nguyen = lvDanhSachNganHang_36_Nguyen.Items[i];
                string tenNganHang = item_36_Nguyen.SubItems[0].Text.ToLower(); // Cột 0 là tên ngân hàng
                string soTaiKhoan = item_36_Nguyen.SubItems[1].Text.ToLower(); // Cột 1 là số tài khoản
                string matKhau = item_36_Nguyen.SubItems[2].Text.ToLower(); // Cột 2 là mật khẩu

                // Kiểm tra xem dữ liệu của bất kỳ cột nào chứa dữ liệu tìm kiếm
                if (tenNganHang.Contains(searchText_36_Nguyen) || soTaiKhoan.Contains(searchText_36_Nguyen) || matKhau.Contains(searchText_36_Nguyen))
                {
                    mucTimThay_36_Nguyen.Add(i); // Thêm chỉ số của mục được tìm thấy vào danh sách
                }
            }

            // Kiểm tra xem có mục nào được tìm thấy hay không
            if (mucTimThay_36_Nguyen.Count > 0)
            {
                // Chọn và đảm bảo hiển thị tất cả các mục được tìm thấy trong ListView
                foreach (int index in mucTimThay_36_Nguyen)
                {
                    lvDanhSachNganHang_36_Nguyen.Items[index].Selected = true;
                    lvDanhSachNganHang_36_Nguyen.Items[index].EnsureVisible();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

