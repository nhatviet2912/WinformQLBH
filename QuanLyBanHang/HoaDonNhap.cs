using BLL;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class HoaDonNhap : Form
    {
        public HoaDonNhap()
        {
            InitializeComponent();
        }

        DTO_SanPham entity = new DTO_SanPham();
        BLL_SanPham sp = new BLL_SanPham();
        BLL_LoaiSanPham lsp = new BLL_LoaiSanPham();
        bool addnew;
        int Id = 0;
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

        void setButton (bool active)
        {
            button_hh_them.Enabled = !active;
            button_hh_luu.Enabled = active;
            button_hh_xoa.Enabled = active;
            button_hh_sua.Enabled = active;
            button_hh_huybo.Enabled = active;
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
            dataGridView_hh.DataSource = sp.GetData();
            if (dataGridView_hh.Columns["Id"] != null)
            {
                dataGridView_hh.Columns["Id"].Visible = false;
            }

            if (dataGridView_hh.Columns["LoaiSanPhamId"] != null)
            {
                dataGridView_hh.Columns["LoaiSanPhamId"].Visible = false;
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
            setButton(false);
        }

        private void dataGridView_hh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CloseHH();
            button_hh_sua.Enabled = true;
            button_hh_huybo.Enabled = true;
            button_hh_xoa.Enabled = true;
            var row = dataGridView_hh.Rows[e.RowIndex];
            Id = int.Parse(row.Cells[0].Value.ToString()!);
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

        private void button_hh_sua_Click(object sender, EventArgs e)
        {
            if (comboBox_hh_masp.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chọn bên dưới !", "Thông báo !");
                return;
            }
            addnew = false;
            OpenHH();
            button_hh_luu.Enabled = true;
            button_hh_huybo.Enabled = true;
            button_hh_sua.Enabled = false;
            button_hh_them.Enabled = false;
            button_hh_xoa.Enabled = false;
            this.comboBox_hh_tensp.Focus();
        }

        private void button_hh_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                entity.MaSanPham = comboBox_hh_masp.Text;
                entity.TenSanPham = comboBox_hh_tensp.Text;
                entity.LoaiSanPhamId = Convert.ToInt32(combobox_LSP.SelectedValue!);
                entity.DonViTinh = textBox_dvt.Text;
                entity.GiaBan = int.Parse(comboBox_hh_gb.Text);
                entity.MoTa = textBox_mota.Text;
                entity.ThuongHieu = textBox_ThuongHieu.Text;
                entity.XuatXu = textBox_XuatXu.Text;
                if (addnew == true)
                {
                    sp.AddData(entity);
                }
                else
                {
                    entity.Id = Id;
                    sp.EditData(entity);
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Setnull();
            CloseHH();
            Display();
            button_hh_xoa.Enabled = true;
            button_hh_sua.Enabled = true;
            button_hh_huybo.Enabled = false;
            button_hh_them.Enabled = true;
            button_hh_luu.Enabled = false;
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
            button_hh_them.Enabled = true;
            button_hh_luu.Enabled = false;
            button_hh_sua.Enabled = true;
            button_hh_xoa.Enabled = true;
            button_hh_huybo.Enabled = true;
        }

        private void button_nh_them_Click(object sender, EventArgs e)
        {
            addnew = true;
            Setnull();
            //AuToMaSP();
            OpenHH();
            button_hh_huybo.Enabled = true;
            button_hh_luu.Enabled = true;
            button_hh_sua.Enabled = false;
            button_hh_them.Enabled = false;
            button_hh_xoa.Enabled = false;
            this.comboBox_hh_tensp.Focus();
        }

        private void button_hh_xoa_Click(object sender, EventArgs e)
        {
            entity.Id = Id;
            sp.DeleteData(entity);
            CloseHH();
            Setnull();
            Display();
            //testbutton();
            setButton(false);
        }

        private bool ValidateInput()
        {
            if (comboBox_hh_masp.Text == "")
            {
                MessageBox.Show("Lỗi mã sản phẩm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBox_hh_tensp.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại tên sản phẩm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (combobox_LSP.SelectedValue == null || Convert.ToInt32(combobox_LSP.SelectedValue) == 0)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBox_dvt.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại đơn vị tính !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBox_hh_gb.Text == "" || int.Parse(comboBox_hh_gb.Text) == 0)
            {
                MessageBox.Show("Xin mời nhập lại giá bán !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBox_ThuongHieu.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại thương hiệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBox_XuatXu.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại xuất xứ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBox_mota.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool exitMasp = sp.ExitCode(comboBox_hh_masp.Text, Id);
            if (exitMasp)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại! Vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            CloseHH();
            //testbutton();
            Setnull();
            LoadDataLSP();
            Display();
            setButton(false);
        }
    }
}
