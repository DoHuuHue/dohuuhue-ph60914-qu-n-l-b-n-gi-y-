namespace duanmauquanlybangiay
{
    partial class QuanLyPhieuBanHangFrom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnxoachitiet = new Button();
            btnthanhtoan = new Button();
            btnsuachitiet = new Button();
            btnthemchitiet = new Button();
            btnlammoi = new Button();
            btnxoaphieu = new Button();
            btnsuaphiei = new Button();
            btnthemphieu = new Button();
            gbchitietphieu = new GroupBox();
            cbbsanpham = new ComboBox();
            txtthanhtien = new TextBox();
            txtdongia = new TextBox();
            txtsoluong = new TextBox();
            lblthanhtien = new Label();
            lbldongia = new Label();
            lblsoluong = new Label();
            lblsanpham = new Label();
            gbthongtinphieu = new GroupBox();
            rdodathanhtoan = new RadioButton();
            rdochoxacnhan = new RadioButton();
            lbltrangthai = new Label();
            dtpngaytao = new DateTimePicker();
            lblngaytao = new Label();
            cbbmathe = new ComboBox();
            lblmathe = new Label();
            cbbmanhanvien = new ComboBox();
            label2 = new Label();
            txtmaphieu = new TextBox();
            lblmaphieu = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvDsChiTietHoaDon = new DataGridView();
            colMaHd = new DataGridViewTextBoxColumn();
            colMaHh = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colSoLuongXuat = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            gbchitietphieu.SuspendLayout();
            gbthongtinphieu.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsChiTietHoaDon).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 524);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1173, 210);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1213, 778);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnxoachitiet);
            tabPage1.Controls.Add(btnthanhtoan);
            tabPage1.Controls.Add(btnsuachitiet);
            tabPage1.Controls.Add(btnthemchitiet);
            tabPage1.Controls.Add(btnlammoi);
            tabPage1.Controls.Add(btnxoaphieu);
            tabPage1.Controls.Add(btnsuaphiei);
            tabPage1.Controls.Add(btnthemphieu);
            tabPage1.Controls.Add(gbchitietphieu);
            tabPage1.Controls.Add(gbthongtinphieu);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1205, 740);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Phiếu bán hàng";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnxoachitiet
            // 
            btnxoachitiet.Location = new Point(1076, 461);
            btnxoachitiet.Name = "btnxoachitiet";
            btnxoachitiet.Size = new Size(112, 34);
            btnxoachitiet.TabIndex = 12;
            btnxoachitiet.Text = "Xóa";
            btnxoachitiet.UseVisualStyleBackColor = true;
            // 
            // btnthanhtoan
            // 
            btnthanhtoan.Location = new Point(654, 461);
            btnthanhtoan.Name = "btnthanhtoan";
            btnthanhtoan.Size = new Size(112, 34);
            btnthanhtoan.TabIndex = 11;
            btnthanhtoan.Text = "Thanh toán";
            btnthanhtoan.UseVisualStyleBackColor = true;
            // 
            // btnsuachitiet
            // 
            btnsuachitiet.Location = new Point(945, 461);
            btnsuachitiet.Name = "btnsuachitiet";
            btnsuachitiet.Size = new Size(112, 34);
            btnsuachitiet.TabIndex = 10;
            btnsuachitiet.Text = "Sửa";
            btnsuachitiet.UseVisualStyleBackColor = true;
            // 
            // btnthemchitiet
            // 
            btnthemchitiet.Location = new Point(815, 461);
            btnthemchitiet.Name = "btnthemchitiet";
            btnthemchitiet.Size = new Size(112, 34);
            btnthemchitiet.TabIndex = 9;
            btnthemchitiet.Text = "Thêm";
            btnthemchitiet.UseVisualStyleBackColor = true;
            // 
            // btnlammoi
            // 
            btnlammoi.Location = new Point(507, 461);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(112, 34);
            btnlammoi.TabIndex = 8;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            // 
            // btnxoaphieu
            // 
            btnxoaphieu.Location = new Point(346, 461);
            btnxoaphieu.Name = "btnxoaphieu";
            btnxoaphieu.Size = new Size(112, 34);
            btnxoaphieu.TabIndex = 7;
            btnxoaphieu.Text = "Xóa";
            btnxoaphieu.UseVisualStyleBackColor = true;
            // 
            // btnsuaphiei
            // 
            btnsuaphiei.Location = new Point(180, 461);
            btnsuaphiei.Name = "btnsuaphiei";
            btnsuaphiei.Size = new Size(112, 34);
            btnsuaphiei.TabIndex = 6;
            btnsuaphiei.Text = "Sửa ";
            btnsuaphiei.UseVisualStyleBackColor = true;
            // 
            // btnthemphieu
            // 
            btnthemphieu.Location = new Point(36, 461);
            btnthemphieu.Name = "btnthemphieu";
            btnthemphieu.Size = new Size(112, 34);
            btnthemphieu.TabIndex = 5;
            btnthemphieu.Text = "Thêm phiếu ";
            btnthemphieu.UseVisualStyleBackColor = true;
            // 
            // gbchitietphieu
            // 
            gbchitietphieu.Controls.Add(cbbsanpham);
            gbchitietphieu.Controls.Add(txtthanhtien);
            gbchitietphieu.Controls.Add(txtdongia);
            gbchitietphieu.Controls.Add(txtsoluong);
            gbchitietphieu.Controls.Add(lblthanhtien);
            gbchitietphieu.Controls.Add(lbldongia);
            gbchitietphieu.Controls.Add(lblsoluong);
            gbchitietphieu.Controls.Add(lblsanpham);
            gbchitietphieu.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbchitietphieu.Location = new Point(815, 116);
            gbchitietphieu.Name = "gbchitietphieu";
            gbchitietphieu.Size = new Size(373, 322);
            gbchitietphieu.TabIndex = 4;
            gbchitietphieu.TabStop = false;
            gbchitietphieu.Text = "Chi tiết phiếu ";
            // 
            // cbbsanpham
            // 
            cbbsanpham.FormattingEnabled = true;
            cbbsanpham.Location = new Point(152, 51);
            cbbsanpham.Name = "cbbsanpham";
            cbbsanpham.Size = new Size(197, 32);
            cbbsanpham.TabIndex = 12;
            // 
            // txtthanhtien
            // 
            txtthanhtien.Location = new Point(152, 251);
            txtthanhtien.Name = "txtthanhtien";
            txtthanhtien.Size = new Size(197, 30);
            txtthanhtien.TabIndex = 11;
            // 
            // txtdongia
            // 
            txtdongia.Location = new Point(152, 187);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(197, 30);
            txtdongia.TabIndex = 10;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(152, 123);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(197, 30);
            txtsoluong.TabIndex = 9;
            // 
            // lblthanhtien
            // 
            lblthanhtien.AutoSize = true;
            lblthanhtien.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblthanhtien.Location = new Point(24, 260);
            lblthanhtien.Name = "lblthanhtien";
            lblthanhtien.Size = new Size(96, 21);
            lblthanhtien.TabIndex = 8;
            lblthanhtien.Text = "Thành tiền";
            // 
            // lbldongia
            // 
            lbldongia.AutoSize = true;
            lbldongia.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldongia.Location = new Point(24, 196);
            lbldongia.Name = "lbldongia";
            lbldongia.Size = new Size(78, 21);
            lbldongia.TabIndex = 7;
            lbldongia.Text = "Đơn Giá";
            // 
            // lblsoluong
            // 
            lblsoluong.AutoSize = true;
            lblsoluong.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsoluong.Location = new Point(24, 133);
            lblsoluong.Name = "lblsoluong";
            lblsoluong.Size = new Size(85, 21);
            lblsoluong.TabIndex = 6;
            lblsoluong.Text = "Số lượng";
            // 
            // lblsanpham
            // 
            lblsanpham.AutoSize = true;
            lblsanpham.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsanpham.Location = new Point(24, 62);
            lblsanpham.Name = "lblsanpham";
            lblsanpham.Size = new Size(91, 21);
            lblsanpham.TabIndex = 5;
            lblsanpham.Text = "Sản phẩm";
            // 
            // gbthongtinphieu
            // 
            gbthongtinphieu.Controls.Add(rdodathanhtoan);
            gbthongtinphieu.Controls.Add(rdochoxacnhan);
            gbthongtinphieu.Controls.Add(lbltrangthai);
            gbthongtinphieu.Controls.Add(dtpngaytao);
            gbthongtinphieu.Controls.Add(lblngaytao);
            gbthongtinphieu.Controls.Add(cbbmathe);
            gbthongtinphieu.Controls.Add(lblmathe);
            gbthongtinphieu.Controls.Add(cbbmanhanvien);
            gbthongtinphieu.Controls.Add(label2);
            gbthongtinphieu.Controls.Add(txtmaphieu);
            gbthongtinphieu.Controls.Add(lblmaphieu);
            gbthongtinphieu.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbthongtinphieu.Location = new Point(15, 116);
            gbthongtinphieu.Name = "gbthongtinphieu";
            gbthongtinphieu.Size = new Size(751, 322);
            gbthongtinphieu.TabIndex = 3;
            gbthongtinphieu.TabStop = false;
            gbthongtinphieu.Text = "Thông tin phiếu";
            gbthongtinphieu.Enter += groupBox1_Enter;
            // 
            // rdodathanhtoan
            // 
            rdodathanhtoan.AutoSize = true;
            rdodathanhtoan.Location = new Point(383, 223);
            rdodathanhtoan.Name = "rdodathanhtoan";
            rdodathanhtoan.Size = new Size(160, 25);
            rdodathanhtoan.TabIndex = 14;
            rdodathanhtoan.TabStop = true;
            rdodathanhtoan.Text = "Đã thanh toán ";
            rdodathanhtoan.UseVisualStyleBackColor = true;
            // 
            // rdochoxacnhan
            // 
            rdochoxacnhan.AutoSize = true;
            rdochoxacnhan.Location = new Point(165, 223);
            rdochoxacnhan.Name = "rdochoxacnhan";
            rdochoxacnhan.Size = new Size(156, 25);
            rdochoxacnhan.TabIndex = 13;
            rdochoxacnhan.TabStop = true;
            rdochoxacnhan.Text = "Chờ xác nhận";
            rdochoxacnhan.UseVisualStyleBackColor = true;
            rdochoxacnhan.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // lbltrangthai
            // 
            lbltrangthai.AutoSize = true;
            lbltrangthai.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltrangthai.Location = new Point(21, 227);
            lbltrangthai.Name = "lbltrangthai";
            lbltrangthai.Size = new Size(91, 21);
            lbltrangthai.TabIndex = 12;
            lbltrangthai.Text = "Trạng thái";
            // 
            // dtpngaytao
            // 
            dtpngaytao.Location = new Point(534, 126);
            dtpngaytao.Name = "dtpngaytao";
            dtpngaytao.Size = new Size(197, 28);
            dtpngaytao.TabIndex = 11;
            dtpngaytao.ValueChanged += dtpngaytao_ValueChanged;
            // 
            // lblngaytao
            // 
            lblngaytao.AutoSize = true;
            lblngaytao.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblngaytao.Location = new Point(431, 132);
            lblngaytao.Name = "lblngaytao";
            lblngaytao.Size = new Size(82, 21);
            lblngaytao.TabIndex = 10;
            lblngaytao.Text = "Ngày tạo";
            // 
            // cbbmathe
            // 
            cbbmathe.FormattingEnabled = true;
            cbbmathe.Location = new Point(534, 54);
            cbbmathe.Name = "cbbmathe";
            cbbmathe.Size = new Size(197, 29);
            cbbmathe.TabIndex = 9;
            // 
            // lblmathe
            // 
            lblmathe.AutoSize = true;
            lblmathe.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmathe.Location = new Point(431, 62);
            lblmathe.Name = "lblmathe";
            lblmathe.Size = new Size(65, 21);
            lblmathe.TabIndex = 8;
            lblmathe.Text = "Mã thẻ";
            // 
            // cbbmanhanvien
            // 
            cbbmanhanvien.FormattingEnabled = true;
            cbbmanhanvien.Location = new Point(165, 129);
            cbbmanhanvien.Name = "cbbmanhanvien";
            cbbmanhanvien.Size = new Size(197, 29);
            cbbmanhanvien.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 137);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 6;
            label2.Text = "Mã nhân viên";
            // 
            // txtmaphieu
            // 
            txtmaphieu.Location = new Point(165, 55);
            txtmaphieu.Name = "txtmaphieu";
            txtmaphieu.Size = new Size(197, 28);
            txtmaphieu.TabIndex = 5;
            // 
            // lblmaphieu
            // 
            lblmaphieu.AutoSize = true;
            lblmaphieu.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmaphieu.Location = new Point(21, 62);
            lblmaphieu.Name = "lblmaphieu";
            lblmaphieu.Size = new Size(84, 21);
            lblmaphieu.TabIndex = 4;
            lblmaphieu.Text = "Mã phiếu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(446, 39);
            label1.Name = "label1";
            label1.Size = new Size(252, 37);
            label1.TabIndex = 2;
            label1.Text = "Phiếu bán hàng";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvDsChiTietHoaDon);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1205, 740);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Chi tiết phiếu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDsChiTietHoaDon
            // 
            dgvDsChiTietHoaDon.AllowUserToAddRows = false;
            dgvDsChiTietHoaDon.AllowUserToDeleteRows = false;
            dgvDsChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDsChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsChiTietHoaDon.Columns.AddRange(new DataGridViewColumn[] { colMaHd, colMaHh, colDonGia, colSoLuongXuat });
            dgvDsChiTietHoaDon.Location = new Point(0, 4);
            dgvDsChiTietHoaDon.Margin = new Padding(4);
            dgvDsChiTietHoaDon.Name = "dgvDsChiTietHoaDon";
            dgvDsChiTietHoaDon.ReadOnly = true;
            dgvDsChiTietHoaDon.RowHeadersWidth = 51;
            dgvDsChiTietHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDsChiTietHoaDon.Size = new Size(1205, 504);
            dgvDsChiTietHoaDon.TabIndex = 4;
            // 
            // colMaHd
            // 
            colMaHd.DataPropertyName = "ma_hd";
            colMaHd.HeaderText = "Sản Phẩm";
            colMaHd.MinimumWidth = 6;
            colMaHd.Name = "colMaHd";
            colMaHd.ReadOnly = true;
            // 
            // colMaHh
            // 
            colMaHh.DataPropertyName = "ma_hh";
            colMaHh.HeaderText = "Số lượng";
            colMaHh.MinimumWidth = 6;
            colMaHh.Name = "colMaHh";
            colMaHh.ReadOnly = true;
            // 
            // colDonGia
            // 
            colDonGia.DataPropertyName = "don_gia";
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
            // 
            // colSoLuongXuat
            // 
            colSoLuongXuat.DataPropertyName = "so_luong_xuat";
            colSoLuongXuat.HeaderText = "Thành tiền ";
            colSoLuongXuat.MinimumWidth = 6;
            colSoLuongXuat.Name = "colSoLuongXuat";
            colSoLuongXuat.ReadOnly = true;
            // 
            // QuanLyPhieuBanHangFrom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 792);
            Controls.Add(tabControl1);
            Name = "QuanLyPhieuBanHangFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            gbchitietphieu.ResumeLayout(false);
            gbchitietphieu.PerformLayout();
            gbthongtinphieu.ResumeLayout(false);
            gbthongtinphieu.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDsChiTietHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox gbthongtinphieu;
        private Label label1;
        private Label lblngaytao;
        private ComboBox cbbmathe;
        private Label lblmathe;
        private ComboBox cbbmanhanvien;
        private Label label2;
        private TextBox txtmaphieu;
        private Label lblmaphieu;
        private Label lbltrangthai;
        private DateTimePicker dtpngaytao;
        private RadioButton rdochoxacnhan;
        private GroupBox gbchitietphieu;
        private RadioButton rdodathanhtoan;
        private ComboBox cbbsanpham;
        private TextBox txtthanhtien;
        private TextBox txtdongia;
        private TextBox txtsoluong;
        private Label lblthanhtien;
        private Label lbldongia;
        private Label lblsoluong;
        private Label lblsanpham;
        private Button btnthanhtoan;
        private Button btnsuachitiet;
        private Button btnthemchitiet;
        private Button btnlammoi;
        private Button btnxoaphieu;
        private Button btnsuaphiei;
        private Button btnthemphieu;
        private Button btnxoachitiet;
        private DataGridView dgvDsChiTietHoaDon;
        private DataGridViewTextBoxColumn colMaHd;
        private DataGridViewTextBoxColumn colMaHh;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colSoLuongXuat;
    }
}
