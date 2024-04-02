namespace Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu
{
    partial class IsRobot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsRobot));
            this.panIsRobot = new System.Windows.Forms.Panel();
            this.lbIsRobot = new System.Windows.Forms.Label();
            this.picIsRobot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIsRobot)).BeginInit();
            this.SuspendLayout();
            // 
            // panIsRobot
            // 
            this.panIsRobot.BackColor = System.Drawing.Color.Pink;
            this.panIsRobot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panIsRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panIsRobot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panIsRobot.Location = new System.Drawing.Point(518, 75);
            this.panIsRobot.Name = "panIsRobot";
            this.panIsRobot.Size = new System.Drawing.Size(172, 244);
            this.panIsRobot.TabIndex = 1;
            // 
            // lbIsRobot
            // 
            this.lbIsRobot.AutoSize = true;
            this.lbIsRobot.BackColor = System.Drawing.Color.Transparent;
            this.lbIsRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsRobot.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbIsRobot.Location = new System.Drawing.Point(75, 370);
            this.lbIsRobot.Name = "lbIsRobot";
            this.lbIsRobot.Size = new System.Drawing.Size(615, 25);
            this.lbIsRobot.TabIndex = 2;
            this.lbIsRobot.Text = "Kéo hình ảnh vào ô trống để xác minh bạn không phải là Robot";
            // 
            // picIsRobot
            // 
            this.picIsRobot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIsRobot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIsRobot.Image = global::Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu.Properties.Resources.isRobotImg;
            this.picIsRobot.Location = new System.Drawing.Point(119, 108);
            this.picIsRobot.Name = "picIsRobot";
            this.picIsRobot.Size = new System.Drawing.Size(116, 172);
            this.picIsRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIsRobot.TabIndex = 0;
            this.picIsRobot.TabStop = false;
            this.picIsRobot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIsRobot_MouseDown);
            this.picIsRobot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picIsRobot_MouseMove);
            this.picIsRobot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picIsRobot_MouseUp);
            // 
            // IsRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = global::Quản_Lý_Thời_Gian_Biểu_và_Chi_Tiêu.Properties.Resources.Nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 439);
            this.Controls.Add(this.picIsRobot);
            this.Controls.Add(this.lbIsRobot);
            this.Controls.Add(this.panIsRobot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(777, 478);
            this.Name = "IsRobot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác thực bạn có phải là Robot?";
            ((System.ComponentModel.ISupportInitialize)(this.picIsRobot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIsRobot;
        private System.Windows.Forms.Panel panIsRobot;
        private System.Windows.Forms.Label lbIsRobot;
    }
}