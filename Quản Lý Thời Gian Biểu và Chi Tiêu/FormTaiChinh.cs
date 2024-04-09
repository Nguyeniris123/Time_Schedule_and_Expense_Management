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
            // Kiểm tra nếu ký tự nhập vào không phải là số hoặc không phải là ký tự điều khiển (như phím Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Không cho phép ký tự được nhập vào TextBox
                e.Handled = true;
            }
        }

        private void txtNguonTien3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự nhập vào không phải là số hoặc không phải là ký tự điều khiển (như phím Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Không cho phép ký tự được nhập vào TextBox
                e.Handled = true;
            }
        }

        private void txtNguonTien4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự nhập vào không phải là số hoặc không phải là ký tự điều khiển (như phím Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Không cho phép ký tự được nhập vào TextBox
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

        

        
    }
}
