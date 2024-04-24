namespace Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu
{
    partial class IsRobot_36_Nguyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsRobot_36_Nguyen));
            this.panIsRobot_36_Nguyen = new System.Windows.Forms.Panel();
            this.lbIsRobot_36_Nguyen = new System.Windows.Forms.Label();
            this.picIsRobot_36_Nguyen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIsRobot_36_Nguyen)).BeginInit();
            this.SuspendLayout();
            // 
            // panIsRobot_36_Nguyen
            // 
            this.panIsRobot_36_Nguyen.BackColor = System.Drawing.Color.Pink;
            this.panIsRobot_36_Nguyen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panIsRobot_36_Nguyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panIsRobot_36_Nguyen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panIsRobot_36_Nguyen.Location = new System.Drawing.Point(518, 75);
            this.panIsRobot_36_Nguyen.Name = "panIsRobot_36_Nguyen";
            this.panIsRobot_36_Nguyen.Size = new System.Drawing.Size(172, 244);
            this.panIsRobot_36_Nguyen.TabIndex = 1;
            // 
            // lbIsRobot_36_Nguyen
            // 
            this.lbIsRobot_36_Nguyen.AutoSize = true;
            this.lbIsRobot_36_Nguyen.BackColor = System.Drawing.Color.Transparent;
            this.lbIsRobot_36_Nguyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsRobot_36_Nguyen.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbIsRobot_36_Nguyen.Location = new System.Drawing.Point(75, 370);
            this.lbIsRobot_36_Nguyen.Name = "lbIsRobot_36_Nguyen";
            this.lbIsRobot_36_Nguyen.Size = new System.Drawing.Size(615, 25);
            this.lbIsRobot_36_Nguyen.TabIndex = 2;
            this.lbIsRobot_36_Nguyen.Text = "Kéo hình ảnh vào ô trống để xác minh bạn không phải là Robot";
            // 
            // picIsRobot_36_Nguyen
            // 
            this.picIsRobot_36_Nguyen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIsRobot_36_Nguyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIsRobot_36_Nguyen.Image = global::Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu.Properties.Resources.isRobotImg;
            this.picIsRobot_36_Nguyen.Location = new System.Drawing.Point(119, 108);
            this.picIsRobot_36_Nguyen.Name = "picIsRobot_36_Nguyen";
            this.picIsRobot_36_Nguyen.Size = new System.Drawing.Size(116, 172);
            this.picIsRobot_36_Nguyen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIsRobot_36_Nguyen.TabIndex = 0;
            this.picIsRobot_36_Nguyen.TabStop = false;
            this.picIsRobot_36_Nguyen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIsRobot_36_Nguyen_MouseDown);
            this.picIsRobot_36_Nguyen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picIsRobot_36_Nguyen_MouseMove);
            this.picIsRobot_36_Nguyen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picIsRobot_36_Nguyen_MouseUp);
            // 
            // IsRobot_36_Nguyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = global::Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu.Properties.Resources.Nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 439);
            this.Controls.Add(this.picIsRobot_36_Nguyen);
            this.Controls.Add(this.lbIsRobot_36_Nguyen);
            this.Controls.Add(this.panIsRobot_36_Nguyen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(777, 478);
            this.Name = "IsRobot_36_Nguyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác thực bạn có phải là Robot?";
            ((System.ComponentModel.ISupportInitialize)(this.picIsRobot_36_Nguyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIsRobot_36_Nguyen;
        private System.Windows.Forms.Panel panIsRobot_36_Nguyen;
        private System.Windows.Forms.Label lbIsRobot_36_Nguyen;
    }
}