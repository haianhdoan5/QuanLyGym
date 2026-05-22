namespace QuanLyGym.UserControls
{
    partial class UCChiSoInbody
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
            this.lblMaHV = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.lblTyLeMo = new System.Windows.Forms.Label();
            this.txtTyLeMo = new System.Windows.Forms.TextBox();
            this.lblTyLeCo = new System.Windows.Forms.Label();
            this.txtTyLeCo = new System.Windows.Forms.TextBox();
            this.lblChieuCao = new System.Windows.Forms.Label();
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.lblCanNang = new System.Windows.Forms.Label();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.lblMaInbody = new System.Windows.Forms.Label();
            this.txtMaInbody = new System.Windows.Forms.TextBox();
            this.dgvChiSo = new System.Windows.Forms.DataGridView();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSo)).BeginInit();
            this.pnlBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.Controls.Add(this.lblMaHV);
            this.pnlThongTin.Controls.Add(this.txtMaHV);
            this.pnlThongTin.Controls.Add(this.lblTyLeMo);
            this.pnlThongTin.Controls.Add(this.txtTyLeMo);
            this.pnlThongTin.Controls.Add(this.lblTyLeCo);
            this.pnlThongTin.Controls.Add(this.txtTyLeCo);
            this.pnlThongTin.Controls.Add(this.lblChieuCao);
            this.pnlThongTin.Controls.Add(this.txtChieuCao);
            this.pnlThongTin.Controls.Add(this.lblCanNang);
            this.pnlThongTin.Controls.Add(this.txtCanNang);
            this.pnlThongTin.Controls.Add(this.lblMaInbody);
            this.pnlThongTin.Controls.Add(this.txtMaInbody);
            this.pnlThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThongTin.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Padding = new System.Windows.Forms.Padding(10);
            this.pnlThongTin.Size = new System.Drawing.Size(800, 120);
            this.pnlThongTin.TabIndex = 0;
            // 
            // lblMaInbody
            // 
            this.lblMaInbody.AutoSize = true;
            this.lblMaInbody.Location = new System.Drawing.Point(10, 20);
            this.lblMaInbody.Name = "lblMaInbody";
            this.lblMaInbody.Size = new System.Drawing.Size(80, 13);
            this.lblMaInbody.TabIndex = 0;
            this.lblMaInbody.Text = "Mã InBody:";
            // 
            // txtMaInbody
            // 
            this.txtMaInbody.Location = new System.Drawing.Point(100, 20);
            this.txtMaInbody.Name = "txtMaInbody";
            this.txtMaInbody.Size = new System.Drawing.Size(120, 20);
            this.txtMaInbody.TabIndex = 1;
            // 
            // lblCanNang
            // 
            this.lblCanNang.AutoSize = true;
            this.lblCanNang.Location = new System.Drawing.Point(240, 20);
            this.lblCanNang.Name = "lblCanNang";
            this.lblCanNang.Size = new System.Drawing.Size(80, 13);
            this.lblCanNang.TabIndex = 2;
            this.lblCanNang.Text = "Cân Nặng (kg):";
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(330, 20);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(100, 20);
            this.txtCanNang.TabIndex = 3;
            // 
            // lblChieuCao
            // 
            this.lblChieuCao.AutoSize = true;
            this.lblChieuCao.Location = new System.Drawing.Point(450, 20);
            this.lblChieuCao.Name = "lblChieuCao";
            this.lblChieuCao.Size = new System.Drawing.Size(90, 13);
            this.lblChieuCao.TabIndex = 4;
            this.lblChieuCao.Text = "Chiều Cao (cm):";
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Location = new System.Drawing.Point(550, 20);
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size = new System.Drawing.Size(100, 20);
            this.txtChieuCao.TabIndex = 5;
            // 
            // lblTyLeCo
            // 
            this.lblTyLeCo.AutoSize = true;
            this.lblTyLeCo.Location = new System.Drawing.Point(10, 50);
            this.lblTyLeCo.Name = "lblTyLeCo";
            this.lblTyLeCo.Size = new System.Drawing.Size(75, 13);
            this.lblTyLeCo.TabIndex = 6;
            this.lblTyLeCo.Text = "Tỷ Lệ Cơ (%):";
            // 
            // txtTyLeCo
            // 
            this.txtTyLeCo.Location = new System.Drawing.Point(100, 50);
            this.txtTyLeCo.Name = "txtTyLeCo";
            this.txtTyLeCo.Size = new System.Drawing.Size(120, 20);
            this.txtTyLeCo.TabIndex = 7;
            // 
            // lblTyLeMo
            // 
            this.lblTyLeMo.AutoSize = true;
            this.lblTyLeMo.Location = new System.Drawing.Point(240, 50);
            this.lblTyLeMo.Name = "lblTyLeMo";
            this.lblTyLeMo.Size = new System.Drawing.Size(80, 13);
            this.lblTyLeMo.TabIndex = 8;
            this.lblTyLeMo.Text = "Tỷ Lệ Mỡ (%):";
            // 
            // txtTyLeMo
            // 
            this.txtTyLeMo.Location = new System.Drawing.Point(330, 50);
            this.txtTyLeMo.Name = "txtTyLeMo";
            this.txtTyLeMo.Size = new System.Drawing.Size(100, 20);
            this.txtTyLeMo.TabIndex = 9;
            // 
            // lblMaHV
            // 
            this.lblMaHV.AutoSize = true;
            this.lblMaHV.Location = new System.Drawing.Point(450, 50);
            this.lblMaHV.Name = "lblMaHV";
            this.lblMaHV.Size = new System.Drawing.Size(50, 13);
            this.lblMaHV.TabIndex = 10;
            this.lblMaHV.Text = "Mã HV:";
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(550, 50);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(100, 20);
            this.txtMaHV.TabIndex = 11;
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
            // dgvChiSo
            // 
            this.dgvChiSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiSo.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiSo.Location = new System.Drawing.Point(0, 120);
            this.dgvChiSo.Name = "dgvChiSo";
            this.dgvChiSo.Size = new System.Drawing.Size(800, 380);
            this.dgvChiSo.TabIndex = 1;
            // 
            // UCChiSoInbody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvChiSo);
            this.Controls.Add(this.pnlBtn);
            this.Controls.Add(this.pnlThongTin);
            this.Name = "UCChiSoInbody";
            this.Size = new System.Drawing.Size(800, 550);
            this.Load += new System.EventHandler(this.UCChiSoInbody_Load);
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSo)).EndInit();
            this.pnlBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Label lblMaHV;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label lblTyLeMo;
        private System.Windows.Forms.TextBox txtTyLeMo;
        private System.Windows.Forms.Label lblTyLeCo;
        private System.Windows.Forms.TextBox txtTyLeCo;
        private System.Windows.Forms.Label lblChieuCao;
        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.Label lblCanNang;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.Label lblMaInbody;
        private System.Windows.Forms.TextBox txtMaInbody;
        private System.Windows.Forms.DataGridView dgvChiSo;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
