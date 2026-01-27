namespace duanmauquanlybangiay
{
    partial class LoaiSanPhamFrom
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
            btnsanpham = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            lblmaloai = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            lbltenloai = new Label();
            panel3 = new Panel();
            lbltrangthai = new Label();
            rdbconhang = new RadioButton();
            rdbhethang = new RadioButton();
            btnthem = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnlammoi = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnsanpham
            // 
            btnsanpham.AutoSize = true;
            btnsanpham.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsanpham.Location = new Point(310, 61);
            btnsanpham.Name = "btnsanpham";
            btnsanpham.Size = new Size(245, 37);
            btnsanpham.TabIndex = 1;
            btnsanpham.Text = "Loại Sản Phẩm";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblmaloai);
            panel1.Location = new Point(97, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 67);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 31);
            textBox1.TabIndex = 1;
            // 
            // lblmaloai
            // 
            lblmaloai.AutoSize = true;
            lblmaloai.Location = new Point(3, 18);
            lblmaloai.Name = "lblmaloai";
            lblmaloai.Size = new Size(70, 25);
            lblmaloai.TabIndex = 0;
            lblmaloai.Text = "Mã loại";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(lbltenloai);
            panel2.Location = new Point(97, 245);
            panel2.Name = "panel2";
            panel2.Size = new Size(675, 67);
            panel2.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(213, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(402, 31);
            textBox2.TabIndex = 1;
            // 
            // lbltenloai
            // 
            lbltenloai.AutoSize = true;
            lbltenloai.Location = new Point(3, 18);
            lbltenloai.Name = "lbltenloai";
            lbltenloai.Size = new Size(71, 25);
            lbltenloai.TabIndex = 0;
            lbltenloai.Text = "Tên loại";
            // 
            // panel3
            // 
            panel3.Controls.Add(rdbhethang);
            panel3.Controls.Add(rdbconhang);
            panel3.Controls.Add(lbltrangthai);
            panel3.Location = new Point(97, 337);
            panel3.Name = "panel3";
            panel3.Size = new Size(675, 67);
            panel3.TabIndex = 3;
            // 
            // lbltrangthai
            // 
            lbltrangthai.AutoSize = true;
            lbltrangthai.Location = new Point(3, 18);
            lbltrangthai.Name = "lbltrangthai";
            lbltrangthai.Size = new Size(89, 25);
            lbltrangthai.TabIndex = 0;
            lbltrangthai.Text = "Trạng thái";
            // 
            // rdbconhang
            // 
            rdbconhang.AutoSize = true;
            rdbconhang.Location = new Point(213, 14);
            rdbconhang.Name = "rdbconhang";
            rdbconhang.Size = new Size(119, 29);
            rdbconhang.TabIndex = 1;
            rdbconhang.TabStop = true;
            rdbconhang.Text = "Còn hàng ";
            rdbconhang.UseVisualStyleBackColor = true;
            // 
            // rdbhethang
            // 
            rdbhethang.AutoSize = true;
            rdbhethang.Location = new Point(427, 14);
            rdbhethang.Name = "rdbhethang";
            rdbhethang.Size = new Size(110, 29);
            rdbhethang.TabIndex = 2;
            rdbhethang.TabStop = true;
            rdbhethang.Text = "Hết hàng";
            rdbhethang.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(119, 468);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(112, 34);
            btnthem.TabIndex = 3;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(295, 468);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(112, 34);
            btnsua.TabIndex = 4;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(467, 468);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(112, 34);
            btnxoa.TabIndex = 5;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnlammoi
            // 
            btnlammoi.Location = new Point(642, 468);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(112, 34);
            btnlammoi.TabIndex = 6;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            // 
            // SanPhamFrom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 689);
            Controls.Add(btnlammoi);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnsanpham);
            Name = "SanPhamFrom";
            Text = "SanPhamFrom";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnsanpham;
        private Panel panel1;
        private TextBox textBox1;
        private Label lblmaloai;
        private Panel panel2;
        private TextBox textBox2;
        private Label lbltenloai;
        private Panel panel3;
        private Label lbltrangthai;
        private RadioButton rdbhethang;
        private RadioButton rdbconhang;
        private Button btnthem;
        private Button btnsua;
        private Button btnxoa;
        private Button btnlammoi;
    }
}