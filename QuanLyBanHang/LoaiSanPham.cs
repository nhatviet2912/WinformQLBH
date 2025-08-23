using BLL;
using DAL;
using System.Data;

namespace QuanLyBanHang
{
    public partial class LoaiSanPham : Form
    {
        public LoaiSanPham()
        {
            InitializeComponent();
        }
        BLL_LoaiSanPham bus = new BLL_LoaiSanPham();
        DTO_LoaiSanPham entity = new DTO_LoaiSanPham();
        bool addnew;
        int IDLSP = 0;
        void CloseNCC()
        {
            textBox_TenLoai.Enabled = false;
            textBox_mota.Enabled = false;
            textBox_TenLoai.BackColor = Color.DarkGray;
            textBox_mota.BackColor = Color.DarkGray;

            button_ncc_them.Enabled = true;
            button_ncc_luu.Enabled = false;
            button_ncc_sua.Enabled = false;
            button_ncc_xoa.Enabled = false;
            button_ncc_huybo.Enabled = false;
        }
        void OpenNCC()
        {
            textBox_TenLoai.Enabled = true;
            textBox_mota.Enabled = true;
            textBox_TenLoai.BackColor = Color.White;
            textBox_mota.BackColor = Color.White;

            button_ncc_them.Enabled = false;
            button_ncc_luu.Enabled = false;
            button_ncc_sua.Enabled = false;
            button_ncc_xoa.Enabled = false;
            button_ncc_huybo.Enabled = false;
        }
        void setnull()
        {
            textBox_mota.Text="";
            textBox_TenLoai.Text="";
            comboBox_timkiem.Text = "";
        }
        void Display()
        {
            dataGridView_ncc.DataSource = bus.GetData();
            if (dataGridView_ncc.Columns["Id"] != null)
            {
                dataGridView_ncc.Columns["Id"].Visible = false;
            }
        }

        private void button_ncc_them_Click(object sender, EventArgs e)
        {
            OpenNCC();
            setnull();
            addnew = true;
            button_ncc_luu.Enabled = true;
            button_ncc_huybo.Enabled = true;
            this.textBox_TenLoai.Focus();
        }

        private void button_ncc_luu_Click(object sender, EventArgs e)
        {
            if (textBox_TenLoai.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại tên loại sản phẩm !");
                return;
            }
            if (textBox_mota.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại mô tả loại sản phẩm !");
                return;
            }
            if (addnew == true)
            {
                try
                {
                    entity.TenLoai = textBox_TenLoai.Text;
                    entity.MoTa = textBox_mota.Text;
                    bus.AddData(entity);
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
                    entity.TenLoai = textBox_TenLoai.Text;
                    entity.MoTa = textBox_mota.Text;
                    entity.Id = IDLSP;
                    bus.EditData(entity);
                }
                catch
                {
                    MessageBox.Show("Không thể sửa được !");
                    return;
                }

            }
            CloseNCC();
            Display();
        }

        private void button_ncc_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_TenLoai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhấp chọn bên dưới !","Thông báo !");
                    return;
                }
                OpenNCC();
                addnew = false;
                button_ncc_luu.Enabled = true;
                button_ncc_huybo.Enabled = true;
                this.textBox_TenLoai.Focus();
                Display();
            }
            catch { }
        }

        private void button_ncc_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_TenLoai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhấp chọn bên dưới !","Thông báo !");
                    return;
                }
                entity.Id = IDLSP;
                bus.DeleteData(entity);
                setnull();
                Display();
                CloseNCC();
            }
            catch
            {
                MessageBox.Show("Không thể xóa !");
            }
        }

        private void button_ncc_huybo_Click(object sender, EventArgs e)
        {
            setnull();
            CloseNCC();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            CloseNCC();
            Display();
        }

        private void dataGridView_ncc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CloseNCC();
            button_ncc_sua.Enabled = true;
            button_ncc_xoa.Enabled = true;
            button_ncc_huybo.Enabled = true;
            var row = dataGridView_ncc.Rows[e.RowIndex];
            try
            {
                IDLSP = int.Parse(row.Cells[0].Value.ToString()!);
                textBox_TenLoai.Text = row.Cells[1].Value.ToString();
                textBox_mota.Text = row.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void dataGridView_ncc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenNCC();
            button_ncc_luu.Enabled = true;
            button_ncc_huybo.Enabled = true;
            addnew = false;
            this.textBox_TenLoai.Focus();
        }

        private void button_ncc_tc_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Trangchinh tc = new Trangchinh();
            tc.ShowDialog();
        }

        private void textBox_ncc_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            dataGridView_ncc.DataSource = bus.Search(comboBox_timkiem.Text);
            CloseNCC();
            button_ncc_sua.Enabled = true;
            button_ncc_huybo.Enabled = true;
            button_ncc_xoa.Enabled = true;

        }
    }
}