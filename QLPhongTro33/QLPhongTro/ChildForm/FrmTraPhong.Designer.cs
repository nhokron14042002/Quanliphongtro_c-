namespace QLPhongTro.ChildForm
{
    partial class FrmTraPhong
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTìmKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThuePhong = new System.Windows.Forms.DataGridView();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND_CanCuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HKTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDatCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThanhToan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(306, 95);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(73, 22);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTìmKiem
            // 
            this.txtTìmKiem.Location = new System.Drawing.Point(176, 95);
            this.txtTìmKiem.Name = "txtTìmKiem";
            this.txtTìmKiem.Size = new System.Drawing.Size(111, 20);
            this.txtTìmKiem.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "QUẢN LÝ KHÁCH THUÊ PHÒNG";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tìm Kiếm :";
            // 
            // dgvThuePhong
            // 
            this.dgvThuePhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuePhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenLoaiPhong,
            this.TenPhong,
            this.HoTen,
            this.DienThoai,
            this.CMND_CanCuoc,
            this.HKTT,
            this.NgayThue,
            this.NgayTraPhong,
            this.GiaPhong,
            this.DaThanhToan,
            this.ConLai,
            this.TienDatCoc,
            this.btnThanhToan,
            this.ID});
            this.dgvThuePhong.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvThuePhong.Location = new System.Drawing.Point(3, 137);
            this.dgvThuePhong.MultiSelect = false;
            this.dgvThuePhong.Name = "dgvThuePhong";
            this.dgvThuePhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuePhong.Size = new System.Drawing.Size(873, 289);
            this.dgvThuePhong.TabIndex = 12;
            this.dgvThuePhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuePhong_CellClick);
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TenLoaiPhong.DataPropertyName = "TenLoaiPhong";
            this.TenLoaiPhong.HeaderText = "Loại Phòng";
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            this.TenLoaiPhong.Width = 86;
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Width = 63;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Khách Hàng";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // DienThoai
            // 
            this.DienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Width = 84;
            // 
            // CMND_CanCuoc
            // 
            this.CMND_CanCuoc.DataPropertyName = "CMND_CanCuoc";
            this.CMND_CanCuoc.HeaderText = "CMND/CCCD";
            this.CMND_CanCuoc.Name = "CMND_CanCuoc";
            // 
            // HKTT
            // 
            this.HKTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HKTT.DataPropertyName = "HKTT";
            this.HKTT.HeaderText = "HKTT";
            this.HKTT.Name = "HKTT";
            // 
            // NgayThue
            // 
            this.NgayThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NgayThue.DataPropertyName = "NgayThue";
            this.NgayThue.HeaderText = "Ngày Thuê";
            this.NgayThue.Name = "NgayThue";
            this.NgayThue.Width = 85;
            // 
            // NgayTraPhong
            // 
            this.NgayTraPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NgayTraPhong.DataPropertyName = "NgayTraPhong";
            this.NgayTraPhong.HeaderText = "Ngày Trả";
            this.NgayTraPhong.Name = "NgayTraPhong";
            this.NgayTraPhong.Width = 76;
            // 
            // GiaPhong
            // 
            this.GiaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GiaPhong.DataPropertyName = "GiaPhong";
            this.GiaPhong.HeaderText = "Gía Phòng";
            this.GiaPhong.Name = "GiaPhong";
            this.GiaPhong.Width = 84;
            // 
            // DaThanhToan
            // 
            this.DaThanhToan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DaThanhToan.DataPropertyName = "DaThanhToan";
            this.DaThanhToan.HeaderText = "Đã Thanh Toán";
            this.DaThanhToan.Name = "DaThanhToan";
            this.DaThanhToan.Width = 99;
            // 
            // ConLai
            // 
            this.ConLai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ConLai.DataPropertyName = "ConLai";
            this.ConLai.HeaderText = "Còn Lại";
            this.ConLai.Name = "ConLai";
            this.ConLai.Width = 51;
            // 
            // TienDatCoc
            // 
            this.TienDatCoc.DataPropertyName = "TienDatCoc";
            this.TienDatCoc.HeaderText = "Tiền Cọc";
            this.TienDatCoc.Name = "TienDatCoc";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.HeaderText = "#";
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Text = "Trả Phòng";
            this.btnThanhToan.UseColumnTextForButtonValue = true;
            this.btnThanhToan.Width = 80;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // FrmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(878, 426);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTìmKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThuePhong);
            this.Name = "FrmTraPhong";
            this.Text = "frmThuePhong";
            this.Load += new System.EventHandler(this.frmThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTìmKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThuePhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND_CanCuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HKTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDatCoc;
        private System.Windows.Forms.DataGridViewButtonColumn btnThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}