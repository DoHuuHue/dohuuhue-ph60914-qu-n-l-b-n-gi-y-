namespace duanmauquanlybangiay
{
    partial class ThongKeDoanhThuFrom
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
            lblthongkedoanhthu = new Label();
            panel1 = new Panel();
            lblloaisanpham = new Label();
            panel2 = new Panel();
            cbbloaisanpham = new ComboBox();
            lbltungay = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbldenngay = new Label();
            dateTimePicker2 = new DateTimePicker();
            lblthongke = new Button();
            dgvthongkedoanhthu = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvthongkedoanhthu).BeginInit();
            SuspendLayout();
            // 
            // lblthongkedoanhthu
            // 
            lblthongkedoanhthu.AutoSize = true;
            lblthongkedoanhthu.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblthongkedoanhthu.Location = new Point(1, -1);
            lblthongkedoanhthu.Name = "lblthongkedoanhthu";
            lblthongkedoanhthu.Size = new Size(337, 37);
            lblthongkedoanhthu.TabIndex = 0;
            lblthongkedoanhthu.Text = "Thống Kê Doanh Thu";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvthongkedoanhthu);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(1523, 598);
            panel1.TabIndex = 1;
            // 
            // lblloaisanpham
            // 
            lblloaisanpham.AutoSize = true;
            lblloaisanpham.Location = new Point(13, 28);
            lblloaisanpham.Name = "lblloaisanpham";
            lblloaisanpham.Size = new Size(127, 25);
            lblloaisanpham.TabIndex = 0;
            lblloaisanpham.Text = "Loại sản phẩm";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblthongke);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(lbldenngay);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(lbltungay);
            panel2.Controls.Add(cbbloaisanpham);
            panel2.Controls.Add(lblloaisanpham);
            panel2.Location = new Point(16, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(1473, 78);
            panel2.TabIndex = 1;
            // 
            // cbbloaisanpham
            // 
            cbbloaisanpham.FormattingEnabled = true;
            cbbloaisanpham.Location = new Point(162, 20);
            cbbloaisanpham.Name = "cbbloaisanpham";
            cbbloaisanpham.Size = new Size(182, 33);
            cbbloaisanpham.TabIndex = 1;
            // 
            // lbltungay
            // 
            lbltungay.AutoSize = true;
            lbltungay.Location = new Point(413, 23);
            lbltungay.Name = "lbltungay";
            lbltungay.Size = new Size(76, 25);
            lbltungay.TabIndex = 2;
            lbltungay.Text = "Từ ngày";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(533, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // lbldenngay
            // 
            lbldenngay.AutoSize = true;
            lbldenngay.Location = new Point(913, 23);
            lbldenngay.Name = "lbldenngay";
            lbldenngay.Size = new Size(88, 25);
            lbldenngay.TabIndex = 4;
            lbldenngay.Text = "Đến ngày";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1033, 17);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 5;
            // 
            // lblthongke
            // 
            lblthongke.Location = new Point(1358, 14);
            lblthongke.Name = "lblthongke";
            lblthongke.Size = new Size(112, 34);
            lblthongke.TabIndex = 6;
            lblthongke.Text = "Thống kê";
            lblthongke.UseVisualStyleBackColor = true;
            // 
            // dgvthongkedoanhthu
            // 
            dgvthongkedoanhthu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvthongkedoanhthu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvthongkedoanhthu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvthongkedoanhthu.Location = new Point(16, 102);
            dgvthongkedoanhthu.Name = "dgvthongkedoanhthu";
            dgvthongkedoanhthu.RowHeadersWidth = 62;
            dgvthongkedoanhthu.Size = new Size(1473, 225);
            dgvthongkedoanhthu.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã sản phẩm";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên sản phẩm";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tổng tiền ";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Số lượng";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Số lượng phiếu";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Ngày lập phiếu";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Trạng thái";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            // 
            // ThongKeDoanhThuFrom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1663, 678);
            Controls.Add(panel1);
            Controls.Add(lblthongkedoanhthu);
            Name = "ThongKeDoanhThuFrom";
            Text = "ThongKeDoanhThuFrom";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvthongkedoanhthu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblthongkedoanhthu;
        private Panel panel1;
        private Panel panel2;
        private Label lblloaisanpham;
        private DataGridView dgvthongkedoanhthu;
        private Button lblthongke;
        private DateTimePicker dateTimePicker2;
        private Label lbldenngay;
        private DateTimePicker dateTimePicker1;
        private Label lbltungay;
        private ComboBox cbbloaisanpham;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}