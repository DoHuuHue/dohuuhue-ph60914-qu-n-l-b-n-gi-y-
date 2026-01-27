namespace duanmauquanlybangiay
{
    partial class DangNhapFrom
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
            panel1 = new Panel();
            panel3 = new Panel();
            textBox2 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            txbusername = new Label();
            btndangnhap = new Button();
            btnthoat = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnthoat);
            panel1.Controls.Add(btndangnhap);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(43, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 337);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(30, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 91);
            panel3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(177, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(481, 31);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(122, 29);
            label1.TabIndex = 1;
            label1.Text = "Mật Khẩu";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(txbusername);
            panel2.Location = new Point(30, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 81);
            panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(177, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(481, 31);
            textBox1.TabIndex = 1;
            // 
            // txbusername
            // 
            txbusername.AutoSize = true;
            txbusername.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbusername.Location = new Point(23, 30);
            txbusername.Name = "txbusername";
            txbusername.Size = new Size(130, 29);
            txbusername.TabIndex = 1;
            txbusername.Text = "Tài Khoản";
            // 
            // btndangnhap
            // 
            btndangnhap.Location = new Point(486, 229);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(112, 34);
            btndangnhap.TabIndex = 3;
            btndangnhap.Text = "Đăng Nhập";
            btndangnhap.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(618, 229);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(112, 34);
            btnthoat.TabIndex = 4;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // DangNhapFrom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 406);
            Controls.Add(panel1);
            Name = "DangNhapFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhapFrom";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label txbusername;
        private Panel panel3;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button btnthoat;
        private Button btndangnhap;
    }
}