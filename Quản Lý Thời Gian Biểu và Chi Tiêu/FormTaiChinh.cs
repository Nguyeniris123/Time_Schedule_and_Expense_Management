using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu
{
    public partial class FormTaiChinh_36_Nguyen : Form
    {
        public FormTaiChinh_36_Nguyen()
        {
            InitializeComponent();
        }

        private void FormTaiChinh_36_Nguyen_Load(object sender, EventArgs e)
        {
            cbNguonTien1_36_Nguyen.SelectedIndex = 0;
            cbNguonTien2_36_Nguyen.SelectedIndex = 1;
            cbNguonTien3_36_Nguyen.SelectedIndex = 2;
            cbNguonTien4_36_Nguyen.SelectedIndex = 3;
            cbMucDich_36_Nguyen.SelectedIndex = 0;
        }

        private void txtNguonTien1_36_Nguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự nhập vào không phải là số hoặc không phải là ký tự điều khiển (như phím Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Không cho phép ký tự được nhập vào TextBox
                e.Handled = true;
            }
        }

        private void txtNguonTien2_36_Nguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNguonTien3_36_Nguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNguonTien4_36_Nguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {               
                e.Handled = true;
            }
        }

        private void txtSoTien_36_Nguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNguonTien1_36_Nguyen_TextChanged(object sender, EventArgs e)
        {
            tinhTong_36_Nguyen();
        }

        private void txtNguonTien2_36_Nguyen_TextChanged(object sender, EventArgs e)
        {
            tinhTong_36_Nguyen();
        }

        private void txtNguonTien3_36_Nguyen_TextChanged(object sender, EventArgs e)
        {
            tinhTong_36_Nguyen();
        }

        private void txtNguonTien4_36_Nguyen_TextChanged(object sender, EventArgs e)
        {
            tinhTong_36_Nguyen();
        }

        private void tinhTong_36_Nguyen()
        {
            decimal tong_36_Nguyen = 0;
            // Kiểm tra và cộng giá trị của từng ô TextBox vào tổng
            if (decimal.TryParse(txtNguonTien1_36_Nguyen.Text, out decimal source1_36_Nguyen))
            {
                tong_36_Nguyen += source1_36_Nguyen;
            }
            if (decimal.TryParse(txtNguonTien2_36_Nguyen.Text, out decimal source2_36_Nguyen))
            {
                tong_36_Nguyen += source2_36_Nguyen;
            }
            if (decimal.TryParse(txtNguonTien3_36_Nguyen.Text, out decimal source3_36_Nguyen))
            {
                tong_36_Nguyen += source3_36_Nguyen;
            }
            if (decimal.TryParse(txtNguonTien4_36_Nguyen.Text, out decimal source4_36_Nguyen))
            {
                tong_36_Nguyen += source4_36_Nguyen;
            }
            // Hiển thị tổng trong TextBox tổng
            txtTong_36_Nguyen.Text = tong_36_Nguyen.ToString();
        }

        private void btnThem_36_Nguyen_Click(object sender, EventArgs e)
        {
            //kiểm tra nguồn tiền có nhập ko
            if (string.IsNullOrEmpty(txtNguonTien1_36_Nguyen.Text) ||
                string.IsNullOrEmpty(txtNguonTien2_36_Nguyen.Text) ||
                string.IsNullOrEmpty(txtNguonTien3_36_Nguyen.Text) ||
                string.IsNullOrEmpty(txtNguonTien4_36_Nguyen.Text) ||
                string.IsNullOrEmpty(txtSoTien_36_Nguyen.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin chi tiêu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng lại nếu có ô TextBox nào đó trống
            }

            // Lấy thông tin từ các điều khiển nhập liệu
            decimal nguonTien1_36_nguyen = decimal.Parse(txtNguonTien1_36_Nguyen.Text);
            decimal nguonTien2_36_nguyen = decimal.Parse(txtNguonTien2_36_Nguyen.Text);
            decimal nguonTien3_36_nguyen = decimal.Parse(txtNguonTien3_36_Nguyen.Text);
            decimal nguonTien4_36_nguyen = decimal.Parse(txtNguonTien4_36_Nguyen.Text);
            decimal tongTien_36_Nguyen = decimal.Parse(txtTong_36_Nguyen.Text);

            string mucDich_36_Nguyen = cbMucDich_36_Nguyen.Text;
            decimal soTien_36_Nguyen = decimal.Parse(txtSoTien_36_Nguyen.Text); // Chuyển đổi về kiểu decimal (hoặc int)
            
            DateTime ngayThucHien_36_Nguyen = dateTimeChiTieu_36_Nguyen.Value;
            string moTa_36_Nguyen = richTextBoxChiTiet_36_Nguyen.Text;

            //Tính tiền còn lại
            txtTong_36_Nguyen.Text = String.Format("{0}", tongTien_36_Nguyen - soTien_36_Nguyen);
            decimal tongTienConLai_36_Nguyen = tongTien_36_Nguyen - soTien_36_Nguyen;

            // Tạo một chuỗi để hiển thị trong ListBox, .ToString("C") là để thêm đ vào sau tiền
            string item_36_Nguyen = $"Tổng tiền: {tongTien_36_Nguyen.ToString("C")} - " +
                $"Nguồn tiền: {nguonTien1_36_nguyen.ToString("C")}, {nguonTien2_36_nguyen.ToString("C")}, {nguonTien3_36_nguyen.ToString("C")}, {nguonTien4_36_nguyen.ToString("C")} - " +
                $"{mucDich_36_Nguyen} - Số tiền chi: {soTien_36_Nguyen.ToString("C")} - {ngayThucHien_36_Nguyen.ToShortDateString()} - {moTa_36_Nguyen} - " +
                $"Còn lại: {tongTienConLai_36_Nguyen.ToString("C")}";

            // Thêm mục vào ListBox
            listBoxChiTieu_36_Nguyen.Items.Add(item_36_Nguyen);          

            // Xóa nội dung của các TextBox sau khi thêm vào ListBox
            txtSoTien_36_Nguyen.Clear();
            richTextBoxChiTiet_36_Nguyen.Clear();
        }

        private void btnXoa_36_Nguyen_Click(object sender, EventArgs e)
        {
            if (listBoxChiTieu_36_Nguyen.SelectedIndex != -1)
            {
                // Lấy chỉ số của mục được chọn
                int mucChon_36_Nguyen = listBoxChiTieu_36_Nguyen.SelectedIndex;

                // Xóa mục được chọn từ ListBox
                listBoxChiTieu_36_Nguyen.Items.RemoveAt(mucChon_36_Nguyen);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void xuatGhiFile_36_Nguyen(string filePath, ListBox listBox)
        {
            try
            {
                // Mở tệp văn bản để ghi
                using (StreamWriter writer_36_Nguyen = new StreamWriter(filePath))
                {
                    // Lặp qua từng mục trong ListBox và ghi vào tệp
                    foreach (var item in listBox.Items)
                    {
                        writer_36_Nguyen.WriteLine(item.ToString());
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
            SaveFileDialog saveFileDialog_36_Nguyen = new SaveFileDialog();
            saveFileDialog_36_Nguyen.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog_36_Nguyen.ShowDialog() == DialogResult.OK)
            {
                string filePath_36_Nguyen = saveFileDialog_36_Nguyen.FileName;
                // Gọi phương thức xuất ListBox
                xuatGhiFile_36_Nguyen(filePath_36_Nguyen, listBoxChiTieu_36_Nguyen);
            }
        }      
    }
}
