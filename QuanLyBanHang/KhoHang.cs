using BLL;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class KhoHang : Form
    {
        public KhoHang()
        {
            InitializeComponent();
        }

        BLL_SanPham sp = new BLL_SanPham();
        BLL_LoaiSanPham lsp = new BLL_LoaiSanPham();
        BLL_TonKho bLL_TonKho = new BLL_TonKho();
        void CloseHH()
        {
            comboBox_hh_tensp.Enabled = false;
            textBox_dvt.Enabled = false;
            comboBox_hh_gb.Enabled = false;
            comboBox_hh_masp.Enabled = false;
            combobox_LSP.Enabled = false;
            textBox_XuatXu.Enabled = false;
            textBox_mota.Enabled = false;
            textBox_ThuongHieu.Enabled = false;

            textBox_dvt.BackColor = Color.DarkGray;
            comboBox_hh_gb.BackColor = Color.DarkGray;
            comboBox_hh_masp.BackColor = Color.DarkGray;
            comboBox_hh_tensp.BackColor = Color.DarkGray;
            combobox_LSP.BackColor = Color.DarkGray;
            textBox_XuatXu.BackColor = Color.DarkGray;
            textBox_mota.BackColor = Color.DarkGray;
            textBox_ThuongHieu.BackColor = Color.DarkGray;

            if (combobox_LSP.Items.Count > 0)
            {
                combobox_LSP.SelectedIndex = 0;
            }
        }
        void OpenHH()
        {
            comboBox_hh_tensp.Enabled = true;
            comboBox_hh_tensp.Enabled = true;
            textBox_dvt.Enabled = true;
            comboBox_hh_gb.Enabled = true;
            combobox_LSP.Enabled = true;
            textBox_XuatXu.Enabled = true;
            textBox_mota.Enabled = true;
            textBox_ThuongHieu.Enabled = true;
            comboBox_hh_masp.Enabled = true;

            textBox_dvt.BackColor = Color.White;
            comboBox_hh_gb.BackColor = Color.White;
            comboBox_hh_masp.BackColor = Color.White;
            comboBox_hh_tensp.BackColor = Color.White;
            combobox_LSP.BackColor = Color.White;
            textBox_XuatXu.BackColor = Color.White;
            textBox_mota.BackColor = Color.White;
            textBox_ThuongHieu.BackColor = Color.White;

        }

        void Setnull()
        {
            comboBox_hh_masp.Text = "";
            textBox_dvt.Text = "";
            comboBox_hh_gb.Text = "";
            comboBox_hh_tensp.Text = "";
            comboBox_timkiem.Text = "";
            textBox_mota.Text = "";
            textBox_ThuongHieu.Text = "";
            textBox_XuatXu.Text = "";
        }

        private void LoadDataLSP()
        {
            var data = lsp.GetData();
            DataRow row = data.NewRow();
            row["Id"] = 0;
            row["TenLoai"] = "";
            data.Rows.InsertAt(row, 0);
            combobox_LSP.DataSource = data;
            combobox_LSP.DisplayMember = "TenLoai";
            combobox_LSP.ValueMember = "Id";
        }

        void Display()
        {
            dataGridView_hh.DataSource = bLL_TonKho.GetData();
            if (dataGridView_hh.Columns["Id"] != null)
            {
                dataGridView_hh.Columns["Id"].Visible = false;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_hh.Columns[e.ColumnIndex].Name == "GiaBan" && e.Value != null)
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
            Trangchinh tc = new Trangchinh();
            tc.ShowDialog();
        }

        private void button_hh_huybo_Click(object sender, EventArgs e)
        {
            Setnull();
            //testbutton();
            CloseHH();
        }

        private void dataGridView_hh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CloseHH();
            var row = dataGridView_hh.Rows[e.RowIndex];
            try
            {
                comboBox_hh_masp.Text = row.Cells[1].Value.ToString();
                comboBox_hh_tensp.Text = row.Cells[2].Value.ToString();
                textBox_mota.Text = row.Cells[3].Value.ToString();
                comboBox_hh_gb.Text = row.Cells[4].Value.ToString();
                textBox_dvt.Text = row.Cells[5].Value.ToString();
                textBox_XuatXu.Text = row.Cells[6].Value.ToString();
                textBox_ThuongHieu.Text = row.Cells[7].Value.ToString();
                combobox_LSP.SelectedValue = row.Cells["LoaiSanPhamId"].Value;
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

        private void comboBox_timkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            dataGridView_hh.DataSource = sp.Search(comboBox_timkiem.Text);
            CloseHH();
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            CloseHH();
            //testbutton();
            Setnull();
            LoadDataLSP();
            Display();
        }
    }
}
