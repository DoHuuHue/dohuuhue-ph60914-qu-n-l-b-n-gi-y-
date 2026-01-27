namespace duanmauquanlybangiay
{
    public partial class QuanLyPhieuBanHangFrom : Form
    {
        public QuanLyPhieuBanHangFrom()
        {
            InitializeComponent();
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "Id";
            colId.HeaderText = "Ma so";
            colId.Width = 90;
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.Name = "Name";
            colName.HeaderText = "ten";
            colName.Width = 150;
            DataGridViewTextBoxColumn colAge = new DataGridViewTextBoxColumn();
            colAge.Name = "Age";
            colAge.HeaderText = "tuoi";
            colAge.Width = 80;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[]
                {
                colId,
                colName,
                colAge
                });
            AddRow();
        }
        private void AddRow()
        {
            dataGridView1.Rows.Add(
             "1",
             "Nguyen Van A",
             "20"
            );
            dataGridView1.Rows.Add(
             "1",
             "Nguyen Van A",
             "20"
            );
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dtpngaytao_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
