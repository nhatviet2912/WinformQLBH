using BLL;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class HoaDonBan : Form
    {
        public HoaDonBan()
        {
            InitializeComponent();
        }

        //BLL_PhieuNhapKho BLL_PhieuNhapKho = new BLL_PhieuNhapKho();
        BLL_HoaDonBan BLL_HoaDonBan = new BLL_HoaDonBan();
        void CloseHH()
        {
            comboBox_ngaynhap.Enabled = false;
            textBox_tongtien.Enabled = false;
            comboBox_ncc.Enabled = false;
            comboBox_maphieu.Enabled = false;
            textBox_nhanvien.Enabled = false;

            textBox_tongtien.BackColor = Color.DarkGray;
            comboBox_ncc.BackColor = Color.DarkGray;
            comboBox_maphieu.BackColor = Color.DarkGray;
            comboBox_ngaynhap.BackColor = Color.DarkGray;
            textBox_nhanvien.BackColor = Color.DarkGray;
        }

        void Setnull()
        {
            comboBox_maphieu.Text = "";
            textBox_tongtien.Text = "";
            comboBox_ncc.Text = "";
            comboBox_ngaynhap.Text = "";
            comboBox_timkiem.Text = "";
            textBox_nhanvien.Text = "";
        }

        void Display()
        {
            dataGridView_hh.DataSource = BLL_HoaDonBan.GetData();
            if (dataGridView_hh.Columns["HoaDonBanId"] != null)
            {
                dataGridView_hh.Columns["HoaDonBanId"].Visible = false;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_hh.Columns[e.ColumnIndex].Name == "TongTien" && e.Value != null)
            {
                decimal gia = Convert.ToDecimal(e.Value);
                e.Value = gia.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " VND";
                e.FormattingApplied = true;
            }

            if (dataGridView_hh.Columns[e.ColumnIndex].Name == "NgayBan" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime dateValue))
                {
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
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
            CloseHH();
        }

        private void dataGridView_hh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CloseHH();
            button_hh_huybo.Enabled = true;
            var row = dataGridView_hh.Rows[e.RowIndex];
            try
            {
                comboBox_maphieu.Text = row.Cells[1].Value.ToString();
                comboBox_ngaynhap.Text = row.Cells[2].Value.ToString();
                comboBox_ncc.Text = row.Cells[3].Value.ToString();
                textBox_tongtien.Text = row.Cells[5].Value.ToString();
                textBox_nhanvien.Text = row.Cells[4].Value.ToString();
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
            dataGridView_hh.DataSource = BLL_HoaDonBan.Search(comboBox_timkiem.Text);
            CloseHH();
            button_hh_huybo.Enabled = true;
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            CloseHH();
            Setnull();
            Display();

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Chức năng";
            btnColumn.Text = "Xem";
            btnColumn.UseColumnTextForButtonValue = true;
            btnColumn.Name = "btnDetail";
            btnColumn.Width = 150;

            dataGridView_hh.Columns.Add(btnColumn);

            // Gắn event
            dataGridView_hh.CellContentClick += dataGridView1_CellContentClick;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra click vào cột "btnDetail"
            if (e.ColumnIndex == dataGridView_hh.Columns["btnDetail"].Index && e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng đang chọn (ví dụ cột "Id")
                var id = dataGridView_hh.Rows[e.RowIndex].Cells["HoaDonBanId"].Value.ToString();

                // Mở form chi tiết
                this.Hide();
                ChiTietHoaDonBan chiTietHoaDonBan = new ChiTietHoaDonBan(id);
                chiTietHoaDonBan.ShowDialog();
            }
        }
    }
}
