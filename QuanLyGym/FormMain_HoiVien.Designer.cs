namespace QuanLyGym
{
    partial class FormMain_HoiVien
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnThongTinCaNhan = new System.Windows.Forms.Button();
            this.btnChiSoInbody = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnLichTap = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnThongTinCaNhan);
            this.panelMenu.Controls.Add(this.btnChiSoInbody);
            this.panelMenu.Controls.Add(this.btnHopDong);
            this.panelMenu.Controls.Add(this.btnLichTap);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 554);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThongTinCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(31, 390);
            this.btnThongTinCaNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(199, 51);
            this.btnThongTinCaNhan.TabIndex = 3;
            this.btnThongTinCaNhan.Text = "Thông Tin Cá Nhân";
            this.btnThongTinCaNhan.UseVisualStyleBackColor = false;
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
            // 
            // btnChiSoInbody
            // 
            this.btnChiSoInbody.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnChiSoInbody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiSoInbody.Location = new System.Drawing.Point(31, 298);
            this.btnChiSoInbody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChiSoInbody.Name = "btnChiSoInbody";
            this.btnChiSoInbody.Size = new System.Drawing.Size(199, 51);
            this.btnChiSoInbody.TabIndex = 2;
            this.btnChiSoInbody.Text = "Chi Số InBody";
            this.btnChiSoInbody.UseVisualStyleBackColor = false;
            this.btnChiSoInbody.Click += new System.EventHandler(this.btnChiSoInbody_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDong.Location = new System.Drawing.Point(31, 202);
            this.btnHopDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(199, 51);
            this.btnHopDong.TabIndex = 1;
            this.btnHopDong.Text = "Hợp Đồng";
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnLichTap
            // 
            this.btnLichTap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLichTap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichTap.Location = new System.Drawing.Point(31, 109);
            this.btnLichTap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLichTap.Name = "btnLichTap";
            this.btnLichTap.Size = new System.Drawing.Size(199, 51);
            this.btnLichTap.TabIndex = 0;
            this.btnLichTap.Text = "Lịch Tập Luyện";
            this.btnLichTap.UseVisualStyleBackColor = false;
            this.btnLichTap.Click += new System.EventHandler(this.btnLichTap_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(267, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 554);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // FormMain_HoiVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain_HoiVien";
            this.Text = "Quản Lý Gym - Tài Khoản Hội Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_HoiVien_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_HoiVien_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnThongTinCaNhan;
        private System.Windows.Forms.Button btnChiSoInbody;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnLichTap;
    }
}
