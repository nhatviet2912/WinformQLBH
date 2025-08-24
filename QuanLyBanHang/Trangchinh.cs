using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Trangchinh : Form
    {
        public Trangchinh()
        {
            InitializeComponent();
        }

        private void Trangchinh_Load(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //DangNhap Fdn = new DangNhap();
            //Fdn.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void baToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            //ThongTin tt = new ThongTin();
            //tt.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHang banHang = new BanHang();
            banHang.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang kh = new KhachHang();
            kh.ShowDialog();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang nhapHang = new NhapHang();
            nhapHang.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang kh = new KhachHang();
            kh.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HangHoa sanPham = new HangHoa();
            sanPham.ShowDialog();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoaiSanPham lsp = new LoaiSanPham();
            lsp.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang nhapHang = new NhapHang();
            nhapHang.ShowDialog();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoHang khoHang = new KhoHang();
            khoHang.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonNhap hoaDonNhap = new HoaDonNhap();
            hoaDonNhap.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonBan hoaDonBan = new HoaDonBan();
            hoaDonBan.ShowDialog();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHang banHang = new BanHang();
            banHang.ShowDialog();
        }

        private void button_tcbanhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoHang hang = new KhoHang();
            hang.ShowDialog();
        }
    }
}
