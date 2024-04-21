using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu
{
    public partial class FormTaiChinh : Form
    {
        public FormTaiChinh()
        {
            InitializeComponent();
        }

        private void FormTaiChinh_Load(object sender, EventArgs e)
        {
            cbNguonTien1.SelectedIndex = 0;
            cbNguonTien2.SelectedIndex = 1;
            cbNguonTien3.SelectedIndex = 2;
            cbNguonTien4.SelectedIndex = 3;
            cbMucDich_36_Nguyen.SelectedIndex = 0;
        }

        private void txtNguonTien1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự nhập vào không phải là số hoặc không phải là ký tự điều khiển (như phím Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Không cho phép ký tự được nhập vào TextBox
                e.Handled = true;
            }
        }

        private void txtNguonTien2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNguonTien3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNguonTien4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {               
                e.Handled = true;
            }
        }

        private void txtNguonTien1_TextChanged(object sender, EventArgs e)
        {
            tinhTong();
        }

        private void txtNguonTien2_TextChanged(object sender, EventArgs e)
        {
            tinhTong();
        }

        private void txtNguonTien3_TextChanged(object sender, EventArgs e)
        {
            tinhTong();
        }

        private void txtNguonTien4_TextChanged(object sender, EventArgs e)
        {
            tinhTong();
        }

        private void txtSoTien_36_Nguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tinhTong()
        {
            decimal tong = 0;
            // Kiểm tra và cộng giá trị của từng ô TextBox vào tổng
            if (decimal.TryParse(txtNguonTien1.Text, out decimal source1))
            {
                tong += source1;
            }
            if (decimal.TryParse(txtNguonTien2.Text, out decimal source2))
            {
                tong += source2;
            }
            if (decimal.TryParse(txtNguonTien3.Text, out decimal source3))
            {
                tong += source3;
            }
            if (decimal.TryParse(txtNguonTien4.Text, out decimal source4))
            {
                tong += source4;
            }
            // Hiển thị tổng trong TextBox tổng
            txtTong.Text = tong.ToString();
        }

        private void btnThem_36_Nguyen_Click(object sender, EventArgs e)
        {
            //kiểm tra nguồn tiền có nhập ko
            if (string.IsNullOrEmpty(txtNguonTien1.Text) ||
                string.IsNullOrEmpty(txtNguonTien2.Text) ||
                string.IsNullOrEmpty(txtNguonTien3.Text) ||
                string.IsNullOrEmpty(txtNguonTien4.Text) ||
                string.IsNullOrEmpty(txtSoTien_36_Nguyen.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin chi tiêu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng lại nếu có ô TextBox nào đó trống
            }

            // Lấy thông tin từ các điều khiển nhập liệu
            decimal nguonTien1_36_nguyen = decimal.Parse(txtNguonTien1.Text);
            decimal nguonTien2_36_nguyen = decimal.Parse(txtNguonTien2.Text);
            decimal nguonTien3_36_nguyen = decimal.Parse(txtNguonTien3.Text);
            decimal nguonTien4_36_nguyen = decimal.Parse(txtNguonTien4.Text);
            decimal tongTien_36_Nguyen = decimal.Parse(txtTong.Text);

            string mucDich = cbMucDich_36_Nguyen.Text;
            decimal soTien = decimal.Parse(txtSoTien_36_Nguyen.Text); // Chuyển đổi về kiểu decimal (hoặc int)
            
            DateTime ngayThucHien = dateTimeChiTieu_36_Nguyen.Value;
            string moTa = richTextBoxChiTiet_36_Nguyen.Text;

            //Tính tiền còn lại
            txtTong.Text = String.Format("{0}", tongTien_36_Nguyen - soTien);
            decimal tongTienConLai_36_Nguyen = tongTien_36_Nguyen - soTien;

            // Tạo một chuỗi để hiển thị trong ListBox, .ToString("C") là để thêm đ vào sau tiền
            string item = $"Tổng tiền: {tongTien_36_Nguyen.ToString("C")} - " +
                $"Nguồn tiền: {nguonTien1_36_nguyen.ToString("C")}, {nguonTien2_36_nguyen.ToString("C")}, {nguonTien3_36_nguyen.ToString("C")}, {nguonTien4_36_nguyen.ToString("C")} - " +
                $"{mucDich} - Số tiền chi: {soTien.ToString("C")} - {ngayThucHien.ToShortDateString()} - {moTa} - " +
                $"Còn lại: {tongTienConLai_36_Nguyen.ToString("C")}";

            // Thêm mục vào ListBox
            listBoxChiTieu_36_Nguyen.Items.Add(item);          

            // Xóa nội dung của các TextBox sau khi thêm vào ListBox
            txtSoTien_36_Nguyen.Clear();
            richTextBoxChiTiet_36_Nguyen.Clear();
        }

        private void btnXoa_36_Nguyen_Click(object sender, EventArgs e)
        {
            if (listBoxChiTieu_36_Nguyen.SelectedIndex != -1)
            {
                // Lấy chỉ số của mục được chọn
                int mucChon = listBoxChiTieu_36_Nguyen.SelectedIndex;

                // Xóa mục được chọn từ ListBox
                listBoxChiTieu_36_Nguyen.Items.RemoveAt(mucChon);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnXuatDanhSach_36_Nguyen_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                // Gọi phương thức xuất ListBox
                xuatGhiFile(filePath, listBoxChiTieu_36_Nguyen);
            }
        }      
    }
}
