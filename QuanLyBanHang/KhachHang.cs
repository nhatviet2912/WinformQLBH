using BLL;
using DTO;
using System.Data;

namespace QuanLyBanHang
{
    public partial class KhachHang : Form
    {
        BLL_KhachHang bus = new BLL_KhachHang();
        DTO_KhachHang ex = new DTO_KhachHang();
        DataTable kh = new DataTable();
        bool addnew;
        int Id = 0;
        public KhachHang()
        {
            InitializeComponent();
            comboBox_kh_gioitinh.Items.Add("");
            comboBox_kh_gioitinh.Items.Add("Nam");
            comboBox_kh_gioitinh.Items.Add("Nữ");
            comboBox_kh_gioitinh.Items.Add("Khác");

            comboBox_kh_gioitinh.SelectedIndex = 0;

        }

        void LockKH()
        {
            textBox_kh_makh.Enabled = false;
            textBox_kh_emailkh.Enabled = false;
            comboBox_kh_gioitinh.Enabled = false;
            textBox_kh_tenkh.Enabled = false;
            textBox_kh_sdt.Enabled = false;
            textBox_kh_dc.Enabled = false;
            textBox_kh_dc.BackColor = Color.DarkGray;
            textBox_kh_sdt.BackColor = Color.DarkGray;
            textBox_kh_tenkh.BackColor = Color.DarkGray;
            textBox_kh_makh.BackColor = Color.DarkGray;
            textBox_kh_emailkh.BackColor = Color.DarkGray;
            comboBox_kh_gioitinh.BackColor = Color.DarkGray;


            button_kh_them.Enabled = true;
            button_kh_luu.Enabled = false;
            button_kh_sua.Enabled = false;
            button_kh_xoa.Enabled = false;
            button_kh_huybo.Enabled = false;
        }
        void OpenKH()
        {
            textBox_kh_makh.Enabled = true;
            textBox_kh_emailkh.Enabled = true;
            comboBox_kh_gioitinh.Enabled = true;
            textBox_kh_tenkh.Enabled = true;
            textBox_kh_sdt.Enabled = true;
            textBox_kh_dc.Enabled = true;
            textBox_kh_dc.BackColor = Color.White;
            textBox_kh_sdt.BackColor = Color.White;
            textBox_kh_tenkh.BackColor = Color.White;
            textBox_kh_makh.BackColor = Color.White;
            textBox_kh_emailkh.BackColor = Color.White;
            comboBox_kh_gioitinh.BackColor = Color.White;
            textBox_kh_makh.Focus();

            button_kh_them.Enabled = false;
            button_kh_luu.Enabled = false;
            button_kh_sua.Enabled = false;
            button_kh_xoa.Enabled = false;
            button_kh_huybo.Enabled = false;
        }
        void SetNull()
        {
            textBox_kh_makh.Text = "";
            textBox_kh_tenkh.Text = "";
            textBox_kh_sdt.Text = "";
            textBox_kh_dc.Text = "";
            comboBox_timkiem.Text = "";
            Id = 0;
            textBox_kh_emailkh.Text = "";
            comboBox_kh_gioitinh.SelectedIndex = 0;
        }

        void Display()
        {
            dataGridView_kh.DataSource = bus.GetData();
            if (dataGridView_kh.Columns["Id"] != null)
            {
                dataGridView_kh.Columns["Id"].Visible = false;
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_kh_thoat_Click(object sender, EventArgs e)
        {
            SetNull();
            LockKH();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            //comboBox_timkiem.DataSource = bus.GetData("");
            //comboBox_timkiem.ValueMember = "TenKhachHang";
            //comboBox_timkiem.Text = "";
            LockKH();
            Display();
        }

        private void button_kh_them_Click(object sender, EventArgs e)
        {
            OpenKH();
            SetNull();
            addnew = true;
            button_kh_luu.Enabled = true;
            button_kh_huybo.Enabled = true;
            //AutoNCC();
            Display();

        }

        private void button_kh_luu_Click(object sender, EventArgs e)
        {
            int gioiTinhValue = 0;
            switch (comboBox_kh_gioitinh.SelectedItem?.ToString())
            {
                case "Nam":
                    gioiTinhValue = 1;
                    break;
                case "Nữ":
                    gioiTinhValue = 2;
                    break;
                case "Khác":
                    gioiTinhValue = 3;
                    break;
                default:
                    gioiTinhValue = 0;
                    break;
            }
            if (!Validate()) return;
            if (addnew == true)
            {
                try
                {
                    if (textBox_kh_sdt.Text.Length == 10 || textBox_kh_sdt.Text.Length == 11)
                    {
                        ex.MaCode = textBox_kh_makh.Text;
                        ex.TenKhachHang = textBox_kh_tenkh.Text;
                        ex.DienThoai = textBox_kh_sdt.Text;
                        ex.DiaChi = textBox_kh_dc.Text;
                        ex.Email = textBox_kh_emailkh.Text;
                        ex.GioiTinh = gioiTinhValue;
                        bus.AddData(ex);
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể thêm mới được !");
                    return;
                }
            }
            else
            {
                try
                {
                    if (textBox_kh_sdt.Text.Length == 10 || textBox_kh_sdt.Text.Length == 11)
                    {
                        ex.Id = Id;
                        ex.MaCode = textBox_kh_makh.Text;
                        ex.TenKhachHang = textBox_kh_tenkh.Text;
                        ex.DienThoai = textBox_kh_sdt.Text;
                        ex.DiaChi = textBox_kh_dc.Text;
                        ex.Email = textBox_kh_emailkh.Text;
                        ex.GioiTinh = gioiTinhValue;
                        bus.EditData(ex);
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể sửa được !");
                    return;
                }

            }
            LockKH();
            Display();
        }

        private void button_kh_sua_Click(object sender, EventArgs e)
        {
            try
            {

                OpenKH();
                addnew = false;
                button_kh_luu.Enabled = true;
                button_kh_huybo.Enabled = true;
                this.textBox_kh_tenkh.Focus();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể sửa dữ liệu !");
                return;
            }
        }

        private void button_kh_xoa_Click(object sender, EventArgs e)
        {
            try
            {

                ex.Id = Id;
                bus.DeleteData(ex);
                LockKH();
                SetNull();
                Display();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa dữ liệu !");
            }
        }

        private void dataGridView_kh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dataGridView_kh.Rows[e.RowIndex];

            LockKH();
            button_kh_them.Enabled = false;
            button_kh_sua.Enabled = true;
            button_kh_xoa.Enabled = true;
            button_kh_huybo.Enabled = true;
            try
            {
                Id = int.Parse(row.Cells[0].Value.ToString());
                textBox_kh_tenkh.Text = row.Cells[1].Value.ToString();
                textBox_kh_dc.Text = row.Cells[2].Value.ToString();
                textBox_kh_sdt.Text = row.Cells[3].Value.ToString();
                textBox_kh_makh.Text = row.Cells[4].Value.ToString();
                textBox_kh_emailkh.Text = row.Cells[5].Value.ToString();
                comboBox_kh_gioitinh.SelectedItem = row.Cells[6].Value;
            }
            catch
            {
            }
        }
        private void dataGridView_kh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenKH();
            button_kh_luu.Enabled = true;
            button_kh_huybo.Enabled = true;
            addnew = false;
            this.textBox_kh_tenkh.Focus();
        }

        private void dataGridView_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_kh_tc_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Trangchinh tc = new Trangchinh();
            tc.ShowDialog();
        }

        private void textBox_kh_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            dataGridView_kh.DataSource = bus.SearchKH(comboBox_timkiem.Text);
            //OpenKH();
            //button_kh_huybo.Enabled = true;
            //button_kh_sua.Enabled = true;
            //button_kh_xoa.Enabled = true;
        }

        private bool Validate ()
        {
            if (string.IsNullOrEmpty(textBox_kh_makh.Text))
            {
                MessageBox.Show("Xin mời nhập mã khách hàng");
                return false;
            }

            if (textBox_kh_tenkh.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại tên khách hàng !");
                return false;
            }
            if (textBox_kh_sdt.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại số điện thoại của khách hàng !");
                return false;
            }

            if (textBox_kh_sdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại không đúng !");
                return false;
            }
            if (textBox_kh_dc.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại địa chỉ của khách hàng !");
                return false;
            }

            if (string.IsNullOrEmpty(textBox_kh_emailkh.Text))
            {
                MessageBox.Show("Xin mời nhập lại email khách hàng !");
                return false;
            }

            if (!Helper.Helper.ValidateEmail(textBox_kh_emailkh.Text))
            {
                MessageBox.Show("Email không đúng định dạng !");
                return false;
            }

            bool isExitMaCode = bus.ExitMaCode(textBox_kh_makh.Text);


            if (isExitMaCode)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại, Vui lòng nhập mã khác");
                return false;
            }

            return true;
        }
    }

}