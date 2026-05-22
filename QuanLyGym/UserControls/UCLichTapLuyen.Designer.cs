namespace QuanLyGym.UserControls
{
    partial class UCLichTapLuyen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaHV = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtGioTap = new System.Windows.Forms.TextBox();
            this.lblGioTap = new System.Windows.Forms.Label();
            this.dtpNgayTap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTap = new System.Windows.Forms.Label();
            this.txtMaLichTap = new System.Windows.Forms.TextBox();
            this.lblMaLichTap = new System.Windows.Forms.Label();
            this.dgvLichTap = new System.Windows.Forms.DataGridView();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTap)).BeginInit();
            this.pnlBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.Controls.Add(this.lblMaNV);
            this.pnlThongTin.Controls.Add(this.txtMaNV);
            this.pnlThongTin.Controls.Add(this.lblMaHV);
            this.pnlThongTin.Controls.Add(this.txtMaHV);
            this.pnlThongTin.Controls.Add(this.cbTrangThai);
            this.pnlThongTin.Controls.Add(this.lblTrangThai);
            this.pnlThongTin.Controls.Add(this.txtGioTap);
            this.pnlThongTin.Controls.Add(this.lblGioTap);
            this.pnlThongTin.Controls.Add(this.dtpNgayTap);
            this.pnlThongTin.Controls.Add(this.lblNgayTap);
            this.pnlThongTin.Controls.Add(this.txtMaLichTap);
            this.pnlThongTin.Controls.Add(this.lblMaLichTap);
            this.pnlThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThongTin.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Padding = new System.Windows.Forms.Padding(10);
            this.pnlThongTin.Size = new System.Drawing.Size(800, 150);
            this.pnlThongTin.TabIndex = 0;
            // 
            // lblMaLichTap
            // 
            this.lblMaLichTap.AutoSize = true;
            this.lblMaLichTap.Location = new System.Drawing.Point(10, 20);
            this.lblMaLichTap.Name = "lblMaLichTap";
            this.lblMaLichTap.Size = new System.Drawing.Size(80, 13);
            this.lblMaLichTap.TabIndex = 0;
            this.lblMaLichTap.Text = "Mã Lịch Tập:";
            // 
            // txtMaLichTap
            // 
            this.txtMaLichTap.Location = new System.Drawing.Point(100, 20);
            this.txtMaLichTap.Name = "txtMaLichTap";
            this.txtMaLichTap.Size = new System.Drawing.Size(150, 20);
            this.txtMaLichTap.TabIndex = 1;
            // 
            // lblNgayTap
            // 
            this.lblNgayTap.AutoSize = true;
            this.lblNgayTap.Location = new System.Drawing.Point(280, 20);
            this.lblNgayTap.Name = "lblNgayTap";
            this.lblNgayTap.Size = new System.Drawing.Size(60, 13);
            this.lblNgayTap.TabIndex = 2;
            this.lblNgayTap.Text = "Ngày Tập:";
            // 
            // dtpNgayTap
            // 
            this.dtpNgayTap.Location = new System.Drawing.Point(350, 20);
            this.dtpNgayTap.Name = "dtpNgayTap";
            this.dtpNgayTap.Size = new System.Drawing.Size(150, 20);
            this.dtpNgayTap.TabIndex = 3;
            // 
            // lblGioTap
            // 
            this.lblGioTap.AutoSize = true;
            this.lblGioTap.Location = new System.Drawing.Point(520, 20);
            this.lblGioTap.Name = "lblGioTap";
            this.lblGioTap.Size = new System.Drawing.Size(50, 13);
            this.lblGioTap.TabIndex = 4;
            this.lblGioTap.Text = "Giờ Tập:";
            // 
            // txtGioTap
            // 
            this.txtGioTap.Location = new System.Drawing.Point(580, 20);
            this.txtGioTap.Name = "txtGioTap";
            this.txtGioTap.Size = new System.Drawing.Size(100, 20);
            this.txtGioTap.TabIndex = 5;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(10, 50);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(60, 13);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trạng Thái:";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Chưa Tập",
            "Đã Tập",
            "Vắng Mặt"});
            this.cbTrangThai.Location = new System.Drawing.Point(100, 50);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(150, 21);
            this.cbTrangThai.TabIndex = 7;
            // 
            // lblMaHV
            // 
            this.lblMaHV.AutoSize = true;
            this.lblMaHV.Location = new System.Drawing.Point(280, 50);
            this.lblMaHV.Name = "lblMaHV";
            this.lblMaHV.Size = new System.Drawing.Size(50, 13);
            this.lblMaHV.TabIndex = 8;
            this.lblMaHV.Text = "Mã HV:";
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(350, 50);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(150, 20);
            this.txtMaHV.TabIndex = 9;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(520, 50);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(50, 13);
            this.lblMaNV.TabIndex = 10;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(580, 50);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 11;
            // 
            // pnlBtn
            // 
            this.pnlBtn.Controls.Add(this.btnXoa);
            this.pnlBtn.Controls.Add(this.btnSua);
            this.pnlBtn.Controls.Add(this.btnThem);
            this.pnlBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtn.Location = new System.Drawing.Point(0, 500);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(800, 50);
            this.pnlBtn.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(20, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(140, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(260, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvLichTap
            // 
            this.dgvLichTap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichTap.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichTap.Location = new System.Drawing.Point(0, 150);
            this.dgvLichTap.Name = "dgvLichTap";
            this.dgvLichTap.Size = new System.Drawing.Size(800, 350);
            this.dgvLichTap.TabIndex = 1;
            // 
            // UCLichTapLuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvLichTap);
            this.Controls.Add(this.pnlBtn);
            this.Controls.Add(this.pnlThongTin);
            this.Name = "UCLichTapLuyen";
            this.Size = new System.Drawing.Size(800, 550);
            this.Load += new System.EventHandler(this.UCLichTapLuyen_Load);
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTap)).EndInit();
            this.pnlBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaHV;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtGioTap;
        private System.Windows.Forms.Label lblGioTap;
        private System.Windows.Forms.DateTimePicker dtpNgayTap;
        private System.Windows.Forms.Label lblNgayTap;
        private System.Windows.Forms.TextBox txtMaLichTap;
        private System.Windows.Forms.Label lblMaLichTap;
        private System.Windows.Forms.DataGridView dgvLichTap;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
