namespace Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.picEye = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbQuenMK = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.lbCauNoi = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.AutoSize = true;
            this.panelLogin.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.picEye);
            this.panelLogin.Controls.Add(this.btnSignUp);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.lbQuenMK);
            this.panelLogin.Controls.Add(this.txtPassWord);
            this.panelLogin.Controls.Add(this.txtUser);
            this.panelLogin.Controls.Add(this.lbPassWord);
            this.panelLogin.Controls.Add(this.lbLogin);
            this.panelLogin.Controls.Add(this.lbUser);
            this.panelLogin.Location = new System.Drawing.Point(320, 66);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(277, 320);
            this.panelLogin.TabIndex = 0;
            // 
            // picEye
            // 
            this.picEye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEye.Image = global::Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu.Properties.Resources.Eye;
            this.picEye.Location = new System.Drawing.Point(223, 182);
            this.picEye.Name = "picEye";
            this.picEye.Size = new System.Drawing.Size(28, 26);
            this.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEye.TabIndex = 8;
            this.picEye.TabStop = false;
            this.picEye.Click += new System.EventHandler(this.picEye_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(26, 259);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(107, 30);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "Đăng kí";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.AutoSize = true;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(145, 259);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 30);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbQuenMK
            // 
            this.lbQuenMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbQuenMK.AutoSize = true;
            this.lbQuenMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuenMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuenMK.Location = new System.Drawing.Point(153, 220);
            this.lbQuenMK.Name = "lbQuenMK";
            this.lbQuenMK.Size = new System.Drawing.Size(98, 15);
            this.lbQuenMK.TabIndex = 5;
            this.lbQuenMK.Text = "Quên mật khẩu?";
            this.lbQuenMK.Click += new System.EventHandler(this.lbQuenMK_Click);
            this.lbQuenMK.MouseLeave += new System.EventHandler(this.lbQuenMK_MouseLeave);
            this.lbQuenMK.MouseHover += new System.EventHandler(this.lbQuenMK_MouseHover);
            // 
            // txtPassWord
            // 
            this.txtPassWord.AcceptsReturn = true;
            this.txtPassWord.AcceptsTab = true;
            this.txtPassWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(26, 182);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(225, 26);
            this.txtPassWord.TabIndex = 4;
            this.txtPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassWord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPassWork_MouseDown);
            this.txtPassWord.MouseLeave += new System.EventHandler(this.txtPassWork_MouseLeave);
            // 
            // txtUser
            // 
            this.txtUser.AcceptsReturn = true;
            this.txtUser.AcceptsTab = true;
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(26, 102);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(225, 26);
            this.txtUser.TabIndex = 3;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtUser_MouseDown);
            this.txtUser.MouseLeave += new System.EventHandler(this.txtUser_MouseLeave);
            // 
            // lbPassWord
            // 
            this.lbPassWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPassWord.AutoSize = true;
            this.lbPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassWord.Location = new System.Drawing.Point(22, 150);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(83, 20);
            this.lbPassWord.TabIndex = 2;
            this.lbPassWord.Text = "Mật khẩu";
            // 
            // lbLogin
            // 
            this.lbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Lime;
            this.lbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLogin.Location = new System.Drawing.Point(89, 13);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(106, 33);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "LOGIN";
            // 
            // lbUser
            // 
            this.lbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(22, 70);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(129, 20);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Tên đăng nhập";
            // 
            // picBanner
            // 
            this.picBanner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBanner.BackColor = System.Drawing.Color.LimeGreen;
            this.picBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBanner.Image = global::Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu.Properties.Resources.banner;
            this.picBanner.Location = new System.Drawing.Point(101, 66);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(221, 320);
            this.picBanner.TabIndex = 1;
            this.picBanner.TabStop = false;
            // 
            // lbCauNoi
            // 
            this.lbCauNoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCauNoi.AutoSize = true;
            this.lbCauNoi.BackColor = System.Drawing.Color.PeachPuff;
            this.lbCauNoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCauNoi.Location = new System.Drawing.Point(115, 303);
            this.lbCauNoi.MaximumSize = new System.Drawing.Size(210, 0);
            this.lbCauNoi.Name = "lbCauNoi";
            this.lbCauNoi.Size = new System.Drawing.Size(194, 34);
            this.lbCauNoi.TabIndex = 2;
            this.lbCauNoi.Text = "Cần cù thì bù siêng năng, có tiết kiệm thì mới có ăn";
            this.lbCauNoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Crimson;
            this.BackgroundImage = global::Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu.Properties.Resources.Nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.lbCauNoi);
            this.Controls.Add(this.picBanner);
            this.Controls.Add(this.panelLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(711, 489);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbQuenMK;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox picEye;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Label lbCauNoi;
    }
}