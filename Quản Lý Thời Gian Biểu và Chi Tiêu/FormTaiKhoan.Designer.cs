namespace Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu
{
    partial class FormTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan));
            this.cbChonTaiKhoanNganHang = new System.Windows.Forms.ComboBox();
            this.lbQuanLyTaiKhoanBank = new System.Windows.Forms.Label();
            this.lbChonNganHang = new System.Windows.Forms.Label();
            this.btnThemNganHang = new System.Windows.Forms.Button();
            this.ListTaiKhoanNganHang = new System.Windows.Forms.ListBox();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtMatKhauNganHang = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoanNganHang = new System.Windows.Forms.TextBox();
            this.lbTenTaiKhoanNganHang = new System.Windows.Forms.Label();
            this.lbMatKhauNganHang = new System.Windows.Forms.Label();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnMoFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbChonTaiKhoanNganHang
            // 
            this.cbChonTaiKhoanNganHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbChonTaiKhoanNganHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonTaiKhoanNganHang.FormattingEnabled = true;
            this.cbChonTaiKhoanNganHang.Items.AddRange(new object[] {
            "Agribank",
            "Vietcombank",
            "Techcombank",
            "ACB bank",
            "BIDV",
            "Cake bank",
            "MB bank",
            "Nam A bank",
            "Dong A bank",
            "Kbank",
            "Kpbank",
            "Sacombank",
            "OCB bank",
            "Momo",
            "ZaloPay",
            "VNPay"});
            this.cbChonTaiKhoanNganHang.Location = new System.Drawing.Point(15, 79);
            this.cbChonTaiKhoanNganHang.Name = "cbChonTaiKhoanNganHang";
            this.cbChonTaiKhoanNganHang.Size = new System.Drawing.Size(144, 21);
            this.cbChonTaiKhoanNganHang.TabIndex = 0;
            // 
            // lbQuanLyTaiKhoanBank
            // 
            this.lbQuanLyTaiKhoanBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbQuanLyTaiKhoanBank.AutoSize = true;
            this.lbQuanLyTaiKhoanBank.BackColor = System.Drawing.Color.Yellow;
            this.lbQuanLyTaiKhoanBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbQuanLyTaiKhoanBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLyTaiKhoanBank.Location = new System.Drawing.Point(238, 9);
            this.lbQuanLyTaiKhoanBank.Name = "lbQuanLyTaiKhoanBank";
            this.lbQuanLyTaiKhoanBank.Size = new System.Drawing.Size(186, 24);
            this.lbQuanLyTaiKhoanBank.TabIndex = 1;
            this.lbQuanLyTaiKhoanBank.Text = "Ngân hàng của bạn";
            this.lbQuanLyTaiKhoanBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbChonNganHang
            // 
            this.lbChonNganHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbChonNganHang.AutoSize = true;
            this.lbChonNganHang.Location = new System.Drawing.Point(12, 53);
            this.lbChonNganHang.Name = "lbChonNganHang";
            this.lbChonNganHang.Size = new System.Drawing.Size(133, 13);
            this.lbChonNganHang.TabIndex = 2;
            this.lbChonNganHang.Text = "Chọn tài khoản ngân hàng";
            // 
            // btnThemNganHang
            // 
            this.btnThemNganHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemNganHang.Location = new System.Drawing.Point(559, 78);
            this.btnThemNganHang.Name = "btnThemNganHang";
            this.btnThemNganHang.Size = new System.Drawing.Size(68, 20);
            this.btnThemNganHang.TabIndex = 3;
            this.btnThemNganHang.Text = "Thêm";
            this.btnThemNganHang.UseVisualStyleBackColor = true;
            this.btnThemNganHang.Click += new System.EventHandler(this.btnThemNganHang_Click);
            // 
            // ListTaiKhoanNganHang
            // 
            this.ListTaiKhoanNganHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ListTaiKhoanNganHang.BackColor = System.Drawing.Color.MintCream;
            this.ListTaiKhoanNganHang.FormattingEnabled = true;
            this.ListTaiKhoanNganHang.Location = new System.Drawing.Point(15, 158);
            this.ListTaiKhoanNganHang.Name = "ListTaiKhoanNganHang";
            this.ListTaiKhoanNganHang.Size = new System.Drawing.Size(612, 173);
            this.ListTaiKhoanNganHang.TabIndex = 4;
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoaAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnXoaAll.Location = new System.Drawing.Point(453, 346);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(79, 21);
            this.btnXoaAll.TabIndex = 5;
            this.btnXoaAll.Text = "Xoá tất cả";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(548, 346);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 21);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Location = new System.Drawing.Point(556, 120);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(71, 20);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTimKiem.Location = new System.Drawing.Point(15, 120);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(517, 20);
            this.txtTimKiem.TabIndex = 8;
            // 
            // txtMatKhauNganHang
            // 
            this.txtMatKhauNganHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMatKhauNganHang.Location = new System.Drawing.Point(382, 80);
            this.txtMatKhauNganHang.Name = "txtMatKhauNganHang";
            this.txtMatKhauNganHang.Size = new System.Drawing.Size(150, 20);
            this.txtMatKhauNganHang.TabIndex = 9;
            // 
            // txtTenTaiKhoanNganHang
            // 
            this.txtTenTaiKhoanNganHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTenTaiKhoanNganHang.Location = new System.Drawing.Point(201, 79);
            this.txtTenTaiKhoanNganHang.Name = "txtTenTaiKhoanNganHang";
            this.txtTenTaiKhoanNganHang.Size = new System.Drawing.Size(142, 20);
            this.txtTenTaiKhoanNganHang.TabIndex = 10;
            // 
            // lbTenTaiKhoanNganHang
            // 
            this.lbTenTaiKhoanNganHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTenTaiKhoanNganHang.AutoSize = true;
            this.lbTenTaiKhoanNganHang.Location = new System.Drawing.Point(198, 53);
            this.lbTenTaiKhoanNganHang.Name = "lbTenTaiKhoanNganHang";
            this.lbTenTaiKhoanNganHang.Size = new System.Drawing.Size(98, 13);
            this.lbTenTaiKhoanNganHang.TabIndex = 11;
            this.lbTenTaiKhoanNganHang.Text = "Nhập tên tài khoản";
            // 
            // lbMatKhauNganHang
            // 
            this.lbMatKhauNganHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbMatKhauNganHang.AutoSize = true;
            this.lbMatKhauNganHang.Location = new System.Drawing.Point(379, 53);
            this.lbMatKhauNganHang.Name = "lbMatKhauNganHang";
            this.lbMatKhauNganHang.Size = new System.Drawing.Size(134, 13);
            this.lbMatKhauNganHang.TabIndex = 12;
            this.lbMatKhauNganHang.Text = "Nhập mật khẩu ngân hàng";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXuatFile.BackColor = System.Drawing.Color.Yellow;
            this.btnXuatFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatFile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnXuatFile.Location = new System.Drawing.Point(15, 346);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(101, 21);
            this.btnXuatFile.TabIndex = 13;
            this.btnXuatFile.Text = "Xuất danh sách";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnMoFile
            // 
            this.btnMoFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMoFile.BackColor = System.Drawing.Color.Yellow;
            this.btnMoFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoFile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMoFile.Location = new System.Drawing.Point(134, 346);
            this.btnMoFile.Name = "btnMoFile";
            this.btnMoFile.Size = new System.Drawing.Size(101, 21);
            this.btnMoFile.TabIndex = 14;
            this.btnMoFile.Text = "Mở tệp";
            this.btnMoFile.UseVisualStyleBackColor = false;
            this.btnMoFile.Click += new System.EventHandler(this.btnMoFile_Click);
            // 
            // FormTaiKhoan
            // 
            this.AcceptButton = this.btnThemNganHang;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(642, 379);
            this.Controls.Add(this.btnMoFile);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.lbMatKhauNganHang);
            this.Controls.Add(this.lbTenTaiKhoanNganHang);
            this.Controls.Add(this.txtTenTaiKhoanNganHang);
            this.Controls.Add(this.txtMatKhauNganHang);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXoaAll);
            this.Controls.Add(this.ListTaiKhoanNganHang);
            this.Controls.Add(this.btnThemNganHang);
            this.Controls.Add(this.lbChonNganHang);
            this.Controls.Add(this.lbQuanLyTaiKhoanBank);
            this.Controls.Add(this.cbChonTaiKhoanNganHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(658, 418);
            this.Name = "FormTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tài khoản ngân hàng";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChonTaiKhoanNganHang;
        private System.Windows.Forms.Label lbQuanLyTaiKhoanBank;
        private System.Windows.Forms.Label lbChonNganHang;
        private System.Windows.Forms.Button btnThemNganHang;
        private System.Windows.Forms.ListBox ListTaiKhoanNganHang;
        private System.Windows.Forms.Button btnXoaAll;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtMatKhauNganHang;
        private System.Windows.Forms.TextBox txtTenTaiKhoanNganHang;
        private System.Windows.Forms.Label lbTenTaiKhoanNganHang;
        private System.Windows.Forms.Label lbMatKhauNganHang;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnMoFile;
    }
}