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
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(23, 219);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(149, 23);
            this.btnThongTinCaNhan.TabIndex = 3;
            this.btnThongTinCaNhan.Text = "Thông Tin Cá Nhân";
            this.btnThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
            // 
            // btnChiSoInbody
            // 
            this.btnChiSoInbody.Location = new System.Drawing.Point(23, 168);
            this.btnChiSoInbody.Name = "btnChiSoInbody";
            this.btnChiSoInbody.Size = new System.Drawing.Size(149, 23);
            this.btnChiSoInbody.TabIndex = 2;
            this.btnChiSoInbody.Text = "Chi Số InBody";
            this.btnChiSoInbody.UseVisualStyleBackColor = true;
            this.btnChiSoInbody.Click += new System.EventHandler(this.btnChiSoInbody_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Location = new System.Drawing.Point(23, 117);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(149, 23);
            this.btnHopDong.TabIndex = 1;
            this.btnHopDong.Text = "Hợp Đồng";
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnLichTap
            // 
            this.btnLichTap.Location = new System.Drawing.Point(23, 75);
            this.btnLichTap.Name = "btnLichTap";
            this.btnLichTap.Size = new System.Drawing.Size(149, 23);
            this.btnLichTap.TabIndex = 0;
            this.btnLichTap.Text = "Lịch Tập Luyện";
            this.btnLichTap.UseVisualStyleBackColor = true;
            this.btnLichTap.Click += new System.EventHandler(this.btnLichTap_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(600, 450);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // FormMain_HoiVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain_HoiVien";
            this.Text = "Quản Lý Gym - Tài Khoản Hội Viên";
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
