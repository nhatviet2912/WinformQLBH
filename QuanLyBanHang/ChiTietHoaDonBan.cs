using BLL;

namespace QuanLyBanHang
{
    public partial class ChiTietHoaDonBan : Form
    {
        private string _id;
        public ChiTietHoaDonBan(string id)
        {
            InitializeComponent();
            _id = id;
        }

        BLL_HoaDonBan bLL_HoaDonBan = new BLL_HoaDonBan();
        void CloseHH()
        {
            comboBox_tsp.Enabled = false;
            textBox_dg.Enabled = false;
            comboBox_tt.Enabled = false;
            comboBox_msp.Enabled = false;
            textBox_xx.Enabled = false;
            textBox_sl.Enabled = false;
            combobox_thuonghieu.Enabled = false;
            comboBox_tongtien.Enabled = false;

            textBox_dg.BackColor = Color.DarkGray;
            comboBox_tt.BackColor = Color.DarkGray;
            comboBox_msp.BackColor = Color.DarkGray;
            comboBox_tsp.BackColor = Color.DarkGray;
            textBox_xx.BackColor = Color.DarkGray;
            textBox_sl.BackColor = Color.DarkGray;
            combobox_thuonghieu.BackColor = Color.DarkGray;
            comboBox_tongtien.BackColor = Color.DarkGray;
        }

        void Setnull()
        {
            comboBox_msp.Text = "";
            textBox_dg.Text = "";
            comboBox_tt.Text = "";
            comboBox_tsp.Text = "";
            textBox_sl.Text = "";
            textBox_xx.Text = "";
        }

        void Display()
        {
            dataGridView_hh.DataSource = bLL_HoaDonBan.GetDetailData(_id);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_hh.Columns[e.ColumnIndex].Name == "DonGia" && e.Value != null)
            {
                decimal gia = Convert.ToDecimal(e.Value);
                e.Value = gia.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " VND";
                e.FormattingApplied = true;
            }

            if (dataGridView_hh.Columns[e.ColumnIndex].Name == "ThanhTien" && e.Value != null)
            {
                decimal gia = Convert.ToDecimal(e.Value);
                e.Value = gia.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " VND";
                e.FormattingApplied = true;
            }
        }

        private void dataGridView_hh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button_hh_tc_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonBan hoaDonBan = new HoaDonBan();
            hoaDonBan.ShowDialog();
        }

        private void button_hh_huybo_Click(object sender, EventArgs e)
        {
            Setnull();
            CloseHH();
        }

        private void dataGridView_hh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CloseHH();
            button_hh_huybo.Enabled = true;
            var row = dataGridView_hh.Rows[e.RowIndex];
            try
            {
                comboBox_msp.Text = row.Cells[3].Value.ToString();
                comboBox_tsp.Text = row.Cells[4].Value.ToString();
                comboBox_tt.Text = row.Cells[2].Value.ToString();
                textBox_dg.Text = row.Cells[1].Value.ToString();
                textBox_xx.Text = row.Cells[6].Value.ToString();
                textBox_sl.Text = row.Cells[0].Value.ToString();
                combobox_thuonghieu.Text = row.Cells[5].Value.ToString();
                comboBox_tongtien.Text = row.Cells[7].Value.ToString();
            }
            catch
            {

            }
        }

        private void comboBox_hh_slt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_hh_gn_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_hh_gb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_hh_sln_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_hh_slx_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            CloseHH();
            Setnull();
            Display();

        }
    }
}
