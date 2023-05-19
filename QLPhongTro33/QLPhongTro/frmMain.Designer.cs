namespace QLPhongTro
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.ptbState = new System.Windows.Forms.PictureBox();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pblBottom = new System.Windows.Forms.Panel();
            this.grbContent = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.htDN = new System.Windows.Forms.ToolStripMenuItem();
            this.htKMH = new System.Windows.Forms.ToolStripMenuItem();
            this.htDMK = new System.Windows.Forms.ToolStripMenuItem();
            this.htThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.loaiPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dichVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tacvu = new System.Windows.Forms.ToolStripMenuItem();
            this.thuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngĐangThuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngTrốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềnĐiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềnNướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.phiênBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảnQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.ptbMinimize);
            this.pnlTop.Controls.Add(this.ptbState);
            this.pnlTop.Controls.Add(this.ptbExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(891, 30);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phần mềm quản lý phòng trọ ";
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimize.Image = global::QLPhongTro.Properties.Resources.minimazar;
            this.ptbMinimize.Location = new System.Drawing.Point(809, 7);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(20, 20);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimize.TabIndex = 0;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Click += new System.EventHandler(this.ptbMinimize_Click);
            // 
            // ptbState
            // 
            this.ptbState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbState.Image = global::QLPhongTro.Properties.Resources.maxi;
            this.ptbState.Location = new System.Drawing.Point(835, 7);
            this.ptbState.Name = "ptbState";
            this.ptbState.Size = new System.Drawing.Size(20, 20);
            this.ptbState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbState.TabIndex = 0;
            this.ptbState.TabStop = false;
            this.ptbState.Click += new System.EventHandler(this.ptbState_Click);
            // 
            // ptbExit
            // 
            this.ptbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExit.Image = global::QLPhongTro.Properties.Resources.close;
            this.ptbExit.Location = new System.Drawing.Point(859, 7);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(20, 20);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit.TabIndex = 0;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 30);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(10, 453);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(881, 30);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(10, 453);
            this.pnlRight.TabIndex = 0;
            // 
            // pblBottom
            // 
            this.pblBottom.BackColor = System.Drawing.Color.SteelBlue;
            this.pblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblBottom.Location = new System.Drawing.Point(0, 483);
            this.pblBottom.Name = "pblBottom";
            this.pblBottom.Size = new System.Drawing.Size(891, 10);
            this.pblBottom.TabIndex = 0;
            // 
            // grbContent
            // 
            this.grbContent.BackColor = System.Drawing.Color.SteelBlue;
            this.grbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbContent.Location = new System.Drawing.Point(10, 54);
            this.grbContent.Name = "grbContent";
            this.grbContent.Size = new System.Drawing.Size(871, 429);
            this.grbContent.TabIndex = 1;
            this.grbContent.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethong,
            this.danhmuc,
            this.tacvu,
            this.thongke,
            this.thongtin});
            this.menuStrip1.Location = new System.Drawing.Point(10, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hethong
            // 
            this.hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.htDN,
            this.htKMH,
            this.htDMK,
            this.htThoat});
            this.hethong.Name = "hethong";
            this.hethong.Size = new System.Drawing.Size(69, 20);
            this.hethong.Text = "Hệ thống";
            // 
            // htDN
            // 
            this.htDN.Name = "htDN";
            this.htDN.Size = new System.Drawing.Size(180, 22);
            this.htDN.Text = "Đăng nhập";
            this.htDN.Click += new System.EventHandler(this.dangNhap_Click);
            // 
            // htKMH
            // 
            this.htKMH.Name = "htKMH";
            this.htKMH.Size = new System.Drawing.Size(180, 22);
            this.htKMH.Text = "Hủy đăng nhập";
            this.htKMH.Click += new System.EventHandler(this.htKMH_Click);
            // 
            // htDMK
            // 
            this.htDMK.Name = "htDMK";
            this.htDMK.Size = new System.Drawing.Size(180, 22);
            this.htDMK.Text = "Đổi mật khẩu";
            this.htDMK.Click += new System.EventHandler(this.htDMK_Click);
            // 
            // htThoat
            // 
            this.htThoat.Name = "htThoat";
            this.htThoat.Size = new System.Drawing.Size(180, 22);
            this.htThoat.Text = "Thoát";
            this.htThoat.Click += new System.EventHandler(this.htThoat_Click);
            // 
            // danhmuc
            // 
            this.danhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loaiPhongToolStripMenuItem,
            this.phongToolStripMenuItem,
            this.dichVuToolStripMenuItem});
            this.danhmuc.Name = "danhmuc";
            this.danhmuc.Size = new System.Drawing.Size(74, 20);
            this.danhmuc.Text = "Danh mục";
            // 
            // loaiPhongToolStripMenuItem
            // 
            this.loaiPhongToolStripMenuItem.Name = "loaiPhongToolStripMenuItem";
            this.loaiPhongToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.loaiPhongToolStripMenuItem.Text = "Loại phòng";
            this.loaiPhongToolStripMenuItem.Click += new System.EventHandler(this.loaiPhongToolStripMenuItem_Click);
            // 
            // phongToolStripMenuItem
            // 
            this.phongToolStripMenuItem.Name = "phongToolStripMenuItem";
            this.phongToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.phongToolStripMenuItem.Text = "Phòng";
            this.phongToolStripMenuItem.Click += new System.EventHandler(this.phongToolStripMenuItem_Click);
            // 
            // dichVuToolStripMenuItem
            // 
            this.dichVuToolStripMenuItem.Name = "dichVuToolStripMenuItem";
            this.dichVuToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dichVuToolStripMenuItem.Text = "Dịch vụ";
            this.dichVuToolStripMenuItem.Click += new System.EventHandler(this.dichVuToolStripMenuItem_Click);
            // 
            // tacvu
            // 
            this.tacvu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuêPhòngToolStripMenuItem,
            this.trảPhòngToolStripMenuItem});
            this.tacvu.Name = "tacvu";
            this.tacvu.Size = new System.Drawing.Size(52, 20);
            this.tacvu.Text = "Tác vụ";
            // 
            // thuêPhòngToolStripMenuItem
            // 
            this.thuêPhòngToolStripMenuItem.Name = "thuêPhòngToolStripMenuItem";
            this.thuêPhòngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thuêPhòngToolStripMenuItem.Text = "Thuê phòng";
            this.thuêPhòngToolStripMenuItem.Click += new System.EventHandler(this.thuêPhòngToolStripMenuItem_Click);
            // 
            // trảPhòngToolStripMenuItem
            // 
            this.trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            this.trảPhòngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trảPhòngToolStripMenuItem.Text = "Trả phòng";
            this.trảPhòngToolStripMenuItem.Click += new System.EventHandler(this.trảPhòngToolStripMenuItem_Click);
            // 
            // thongke
            // 
            this.thongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngĐangThuêToolStripMenuItem,
            this.phòngTrốngToolStripMenuItem,
            this.tiềnĐiệnToolStripMenuItem,
            this.tiềnNướcToolStripMenuItem,
            this.doanhThuToolStripMenuItem});
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(68, 20);
            this.thongke.Text = "Thống kê";
            // 
            // phòngĐangThuêToolStripMenuItem
            // 
            this.phòngĐangThuêToolStripMenuItem.Name = "phòngĐangThuêToolStripMenuItem";
            this.phòngĐangThuêToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.phòngĐangThuêToolStripMenuItem.Text = "Phòng đang thuê";
            // 
            // phòngTrốngToolStripMenuItem
            // 
            this.phòngTrốngToolStripMenuItem.Name = "phòngTrốngToolStripMenuItem";
            this.phòngTrốngToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.phòngTrốngToolStripMenuItem.Text = "Phòng trống";
            // 
            // tiềnĐiệnToolStripMenuItem
            // 
            this.tiềnĐiệnToolStripMenuItem.Name = "tiềnĐiệnToolStripMenuItem";
            this.tiềnĐiệnToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tiềnĐiệnToolStripMenuItem.Text = "Tiền điện";
            // 
            // tiềnNướcToolStripMenuItem
            // 
            this.tiềnNướcToolStripMenuItem.Name = "tiềnNướcToolStripMenuItem";
            this.tiềnNướcToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tiềnNướcToolStripMenuItem.Text = "Tiền nước";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // thongtin
            // 
            this.thongtin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiênBảnToolStripMenuItem,
            this.bảnQuyềnToolStripMenuItem,
            this.liênHệToolStripMenuItem});
            this.thongtin.Name = "thongtin";
            this.thongtin.Size = new System.Drawing.Size(70, 20);
            this.thongtin.Text = "Thông tin";
            // 
            // phiênBảnToolStripMenuItem
            // 
            this.phiênBảnToolStripMenuItem.Name = "phiênBảnToolStripMenuItem";
            this.phiênBảnToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.phiênBảnToolStripMenuItem.Text = "Phiên bản";
            // 
            // bảnQuyềnToolStripMenuItem
            // 
            this.bảnQuyềnToolStripMenuItem.Name = "bảnQuyềnToolStripMenuItem";
            this.bảnQuyềnToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.bảnQuyềnToolStripMenuItem.Text = "Bản quyền";
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.liênHệToolStripMenuItem.Text = "Liên hệ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(891, 493);
            this.Controls.Add(this.grbContent);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pblBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý phòng trọ";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pblBottom;
        private System.Windows.Forms.GroupBox grbContent;
        private System.Windows.Forms.PictureBox ptbMinimize;
        private System.Windows.Forms.PictureBox ptbState;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hethong;
        private System.Windows.Forms.ToolStripMenuItem htDN;
        private System.Windows.Forms.ToolStripMenuItem htKMH;
        private System.Windows.Forms.ToolStripMenuItem htDMK;
        private System.Windows.Forms.ToolStripMenuItem htThoat;
        private System.Windows.Forms.ToolStripMenuItem danhmuc;
        private System.Windows.Forms.ToolStripMenuItem loaiPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dichVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tacvu;
        private System.Windows.Forms.ToolStripMenuItem thuêPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongke;
        private System.Windows.Forms.ToolStripMenuItem phòngĐangThuêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngTrốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiềnĐiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiềnNướcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongtin;
        private System.Windows.Forms.ToolStripMenuItem phiênBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảnQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
    }
}

