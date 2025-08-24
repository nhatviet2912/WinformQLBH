using BLL;
using DAL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Diagnostics;

namespace QuanLyBanHang
{
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }
        /// KHỞI TẠO CÁC THÔNG SỐ 
        BLL_PhieuNhapKho phieuNhap = new BLL_PhieuNhapKho();
        BLL_SanPham sanPham = new BLL_SanPham();
        DTO_PhieuNhapKho phieuNhapKhoEntity = new DTO_PhieuNhapKho();
        List<DTO_ChiTietPhieuNhap> chiTietPhieuNhaps = new List<DTO_ChiTietPhieuNhap>();
        DTO_TonKho tonKho = new DTO_TonKho();
        DataTable sp2 = new DataTable();
        DataTable sp3 = new DataTable();
        DataTable load = new DataTable();
        Int64 tongcong = 0;
        Int64 thanhtien;
        bool addnew;
        bool exit;
        bool fail = false;
        /// ----------------------------------------------------------
        void Open()
        {
            comboBox_nh_tenhang.Enabled = true;
            textBox_nh_sl.Enabled = true;
            comboBox_nh_dgn.Enabled = true;
            textBox_ncc.Enabled = true;
            textbox_ghichu.Enabled = true;
            textBox_tnv.Enabled = true;
            comboBox_nh_masp.Enabled = true;
        }
        void CloseCB()
        {
            comboBox_nh_tenhang.Enabled = false;
            textBox_nh_sl.Enabled = false;
            comboBox_nh_dgn.Enabled = false;
            textBox_ncc.Enabled = false;
            textbox_ghichu.Enabled = false;
            textBox_tnv.Enabled = false;
            comboBox_nh_masp.Enabled = false;
            textBox_dvt.Enabled = false;

            button_nh_save.Enabled = false;
            button_ncc_huybo.Enabled = false;
            button_nh_xoa.Enabled = false;
            button_nh_sua.Enabled = false;
        }
        void testButton()
        {
            if (dataGridView_nh.Rows[0].Cells[0].Value == null)
            {
                button_nh_them.Enabled = true;
                button_nh_save.Enabled = false;
                button_nh_sua.Enabled = false;
                button_nh_xoa.Enabled = false;
            }
            else
            {
                button_nh_them.Enabled = true;
                button_nh_save.Enabled = false;
                button_nh_sua.Enabled = true;
                button_nh_xoa.Enabled = true;
            }
        }
        void SetNull()
        {
            comboBox_nh_masp.Text = "";
            comboBox_nh_tenhang.Text = "";
            textBox_nh_sl.Text = "";
            comboBox_nh_dgn.Text = "";
            textBox_ncc.Text = "";
            textbox_ghichu.Text = "";
            textBox_tnv.Text = "";
            textBox_dvt.Text = "";
            textBox_nh_sl.Text = "1";
            comboBox_nh_dgn.Text = "0";
            comboBox_nh_masp.SelectedIndex = 0;
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            exit = false;

            var maPhieuNhap = phieuNhap.GetMaCodeAuto();
            comboBox_nh_mahd.Text = maPhieuNhap;

            var sanPhamDropdown = sanPham.GetData()
                .DefaultView.ToTable(false, "Id", "MaSanPham", "TenSanPham", "DonViTinh");
            DataRow row = sanPhamDropdown.NewRow();
            row["Id"] = 0;
            row["MaSanPham"] = "Chọn mã sản phẩm";
            row["TenSanPham"] = "";
            row["DonViTinh"] = "";
            sanPhamDropdown.Rows.InsertAt(row, 0);
            comboBox_nh_masp.DataSource = sanPhamDropdown;
            comboBox_nh_masp.DisplayMember = "MaSanPham";
            comboBox_nh_masp.ValueMember = "Id";
            // TẠO TRƯỜNG HIỂN THỊ LÊN DATAGRIDVIEW
            sp3.Columns.Add("Id");
            sp3.Columns.Add("MaSP");
            sp3.Columns.Add("TenSP");
            sp3.Columns.Add("DonViTinh");
            sp3.Columns.Add("SoLuong");
            sp3.Columns.Add("GiaNhap");
            sp3.Columns.Add("ThanhTienNhap");
            sp3.Columns.Add("GiaBan");
            sp3.Columns.Add("MaNhom");
            sp3.Columns.Add("TenNhom");
            sp3.Columns.Add("MaNCC");

            dataGridView_nh.CellFormatting += dataGridView_nh_CellFormatting;
            addnew = false;
            //----------------------------------------------------------------------------------------
            CloseCB();
            exit = false;
            SetNull();
            textBox_nh_sl.Text = "";
            comboBox_nh_dgn.Text = "";
            //----------------------------------------------------------------------------------------
        }
        private void dataGridView_nh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                CloseCB();

                button_nh_them.Enabled = false;
                button_nh_save.Enabled = false;
                button_ncc_huybo.Enabled = true;
                button_nh_xoa.Enabled = true;
                button_nh_sua.Enabled = true;
            }
            catch
            {
            }
        }

        private void button_bh_thoat_Click(object sender, EventArgs e)
        {
            if (exit == false)
            {
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn chưa lưu hóa đơn nhập ! \n Bạn có muốn lưu ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
                if (thongbao == DialogResult.Yes)
                    MessageBox.Show("Vui lòng nhấn nút lưu !");
                else
                {
                    this.Hide();
                    Trangchinh tc = new Trangchinh();
                    tc.ShowDialog();
                }
            }
            else
            {
                this.Hide();
                Trangchinh tc = new Trangchinh();
                tc.ShowDialog();
            }
        }

        private void button_nh_luu_Click(object sender, EventArgs e)
        {
            DialogResult message = (MessageBox.Show("Vui lòng xem kỹ hóa đơn trước khi lưu ! \n Bạn đã chắc chắn chưa ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (message == DialogResult.No) return;
            Save(message, false);
        }

        private void button_bh_xoa_Click(object sender, EventArgs e)
        {

            thanhtien = int.Parse(textBox_nh_sl.Text) * int.Parse(comboBox_nh_dgn.Text);
            sp3.Rows.RemoveAt(dataGridView_nh.CurrentRow.Index);
            tongcong = 0;
            for (int i = 0; i < dataGridView_nh.Rows.Count; i++)
            {
                tongcong = tongcong + Convert.ToInt64(dataGridView_nh.Rows[i].Cells[5].Value);
            }
            textBox_nh_tongcong.Text = tongcong.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " VND";
            testButton();
            CloseCB();
        }

        private void button_bh_nhap_Click(object sender, EventArgs e)
        {
            addnew = false;
            button_nh_save.Enabled = true;
            button_nh_them.Enabled = false;
            button_nh_sua.Enabled = false;
            button_nh_xoa.Enabled = false;
            button_ncc_huybo.Enabled = true;
            Open();
            if (dataGridView_nh.Rows.Count == 1)
            {
                SetNull();
            } 
            else
            {
                textBox_ncc.Enabled = false;
                textbox_ghichu.Enabled = false;
                textBox_tnv.Enabled = false;

                comboBox_nh_tenhang.Text = "";
                textBox_dvt.Text = "";
                textBox_nh_sl.Text = "1";
                comboBox_nh_dgn.Text = "0";
                comboBox_nh_masp.SelectedIndex = 0;
            }
        }

        private void button_bh_suahang_Click(object sender, EventArgs e)
        {
            addnew = true;
            textBox_nh_sl.Enabled = true;
            button_nh_save.Enabled = true;
            button_nh_them.Enabled = false;
            button_nh_sua.Enabled = false;
            button_nh_xoa.Enabled = false;
            Open();
            this.textBox_nh_sl.Focus();
        }

        private void dataGridView_nh_Click(object sender, EventArgs e)
        {
            CloseCB();
            testButton();
        }

        private void textBox_nh_sl_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nh_sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_nh_dgb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_nh_save_Click(object sender, EventArgs e)
        {
            if (comboBox_nh_tenhang.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại tên sản phẩm !");
                return;
            }
            //-----------------------------------------------------------
            //-----------------------------------------------------------
            if (comboBox_nh_masp.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại nhà cung cấp !");
                return;
            }
            //-----------------------------------------------------------
            if (comboBox_nh_dgn.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại đơn giá nhập !");
                return;
            }
            //-----------------------------------------------------------
            //-----------------------------------------------------------
            if (textBox_nh_sl.Text == "" || int.Parse(textBox_nh_sl.Text) == 0)
            {
                MessageBox.Show("Xin mời nhập lại số lượng nhập !");
                return;
            }


            //-----------------------------------------------------------

            //-----------------------------------------------------------
            if (addnew == true)
            {
                sp3.Rows.RemoveAt(dataGridView_nh.CurrentRow.Index);
            }
            else
            {
                //var isDuplicate = false;
                //// SO SÁNH NẾU TRÙNG SẢN PHẨM THÌ CỘNG DỒN
                //if (dataGridView_nh.Rows.Count >= 2)
                //{
                //    try
                //    {
                //        for (int i = 0; i <= dataGridView_nh.Rows.Count - 1; i++)
                //        {
                //            string maSpGrid = dataGridView_nh.Rows[i].Cells[1]?.Value?.ToString();
                //            string maSpChon = comboBox_nh_masp.Text;

                //            if (!string.IsNullOrEmpty(maSpGrid) && maSpGrid == maSpChon)
                //            {
                //                int slCu = Convert.ToInt32(dataGridView_nh.Rows[i].Cells[4].Value ?? 0);
                //                int slMoi = Convert.ToInt32(textBox_nh_sl.Text);

                //                dataGridView_nh.Rows[i].Cells[4].Value = slCu + slMoi;
                //                int soLuong = int.Parse(dataGridView_nh.Rows[i].Cells[4].Value.ToString());
                //                decimal donGia = decimal.Parse(dataGridView_nh.Rows[i].Cells[5].Value.ToString());

                //                // Thành tiền = Số lượng * Đơn giá
                //                decimal thanhTien = soLuong * donGia;

                //                // Gán vào cột 6
                //                dataGridView_nh.Rows[i].Cells[6].Value = thanhTien;

                //                isDuplicate = true;
                //            }
                //        }
                //    }
                //    catch
                //    {
                //        MessageBox.Show("Lỗi thêm mới sản phẩm !");
                //        fail = true;
                //    }
                //}

                // HIỂN THỊ
                try
                {
                    thanhtien = int.Parse(textBox_nh_sl.Text) * int.Parse(comboBox_nh_dgn.Text);
                    //if (!isDuplicate)
                    //{

                    //}
                    sp3.Rows.Add(
                            comboBox_nh_masp.SelectedValue,
                            comboBox_nh_masp.Text,
                            comboBox_nh_tenhang.Text,
                            textBox_dvt.Text,
                            textBox_nh_sl.Text,
                            comboBox_nh_dgn.Text,
                            thanhtien);
                    dataGridView_nh.DataSource = sp3;
                    dataGridView_nh.Columns["Id"].Visible = false;
                    // TÍNH TỔNG CỘNG
                    tongcong = 0;
                    for (int i = 0; i < dataGridView_nh.Rows.Count; i++)
                    {
                        tongcong = tongcong + Convert.ToInt64(dataGridView_nh.Rows[i].Cells[6].Value);
                    }
                    textBox_nh_tongcong.Text = tongcong.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " VND";
                    testButton();
                    CloseCB();
                }
                catch
                {
                    MessageBox.Show("Lỗi tính tiền sản phẩm !");
                    fail = true;
                }
            }
            
        }

        private void dataGridView_nh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                if (e.Value != null && long.TryParse(e.Value.ToString(), out long val))
                {
                    e.Value = val.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " VND";
                    e.FormattingApplied = true;
                }
            }
        }

        private void comboBox_nh_pt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView_nh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox_nh_dgn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button_ncc_tc_Click(object sender, EventArgs e)
        {
            if (dataGridView_nh.Rows.Count == 1)
            {
                this.Hide();
                Trangchinh tc = new Trangchinh();
                tc.ShowDialog();
                return;
            }
            DialogResult message = (MessageBox.Show("Hóa đơn của bạn chưa được lưu! \n Bạn có muốn hủy chứ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (message == DialogResult.No) {
                return;
            } 
            Save(message, true);
        }

        private void comboBox_nh_masp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_nh_masp.SelectedItem is DataRowView row)
            {
                comboBox_nh_tenhang.Text = row["TenSanPham"].ToString();
                textBox_dvt.Text = row["DonViTinh"].ToString();
            }
        }

        private void button_ncc_huybo_Click(object sender, EventArgs e)
        {
            SetNull();
            CloseCB();
            button_nh_them.Enabled = true;
        }

        private void Save (DialogResult message, bool HasCancel)
        {
            DialogResult thongbao;
            thongbao = message;
            if (thongbao == DialogResult.Yes && !HasCancel)
            {
                try
                {
                    for (int i = 0; i < dataGridView_nh.Rows.Count - 1; i++)
                    {
                        var row = dataGridView_nh.Rows[i];
                        DTO_ChiTietPhieuNhap chiTietPhieuNhap = new DTO_ChiTietPhieuNhap()
                        {
                            SanPhamId = int.Parse(row.Cells[0].Value.ToString()!),
                            SoLuong = int.Parse(row.Cells[4].Value.ToString()!),
                            DonGiaNhap = int.Parse(row.Cells[5].Value.ToString()!)
                        };

                        chiTietPhieuNhaps.Add(chiTietPhieuNhap);
                    }

                    phieuNhapKhoEntity.MaPhieu = comboBox_nh_mahd.Text;
                    phieuNhapKhoEntity.NgayNhap = DateTime.Now;
                    phieuNhapKhoEntity.NhaCungCap = textBox_ncc.Text;
                    phieuNhapKhoEntity.NhanVienNhap = textBox_tnv.Text;
                    phieuNhapKhoEntity.TongTien = tongcong;
                    phieuNhapKhoEntity.GhiChu = textbox_ghichu.Text;
                    phieuNhapKhoEntity.chiTietPhieuNhaps = chiTietPhieuNhaps;
                    phieuNhap.AddData(phieuNhapKhoEntity);

                    MessageBox.Show("Lưu hóa đơn thành công !");
                    ExportHoaDonToPdf();
                    button_nh_thanhtoan.Enabled = false;
                    comboBox_nh_tenhang.Enabled = false;
                    textBox_nh_sl.Enabled = false;
                    comboBox_nh_masp.Enabled = false;
                    comboBox_nh_dgn.Enabled = false;
                    textBox_nh_tongcong.Enabled = false;
                    button_nh_xoa.Enabled = false;
                    button_nh_them.Enabled = false;
                    button_nh_sua.Enabled = false;
                    dataGridView_nh.Enabled = false;
                    this.Hide();
                    Trangchinh trangchinh = new Trangchinh();
                    trangchinh.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Không thể lưu hóa đơn !");
                    return;
                }
            }
            else
            {
                this.Hide();
                Trangchinh trangchinh = new Trangchinh();
                trangchinh.ShowDialog();
                return;
            }
        }

        private void ExportHoaDonToPdf()
        {
            try
            {
                // Đường dẫn file PDF (Desktop)
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(folderPath, $"HoaDonNhap_{phieuNhapKhoEntity.MaPhieu}.pdf");

                // Tạo document
                Document doc = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                // Font Unicode (để hiển thị tiếng Việt)
                BaseFont bf = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                // Tiêu đề
                Paragraph title = new Paragraph("HÓA ĐƠN BÁN HÀNG", fontTitle);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                doc.Add(new Paragraph("\n"));

                // Thông tin chung
                doc.Add(new Paragraph($"Mã hóa đơn: {phieuNhapKhoEntity.MaPhieu}", fontNormal));
                doc.Add(new Paragraph($"Ngày bán: {phieuNhapKhoEntity.NgayNhap:dd/MM/yyyy HH:mm}", fontNormal));
                doc.Add(new Paragraph($"Nhà cung cấp: {phieuNhapKhoEntity.NhaCungCap}", fontNormal));
                doc.Add(new Paragraph($"Nhân viên: {phieuNhapKhoEntity.NhanVienNhap}", fontNormal));
                doc.Add(new Paragraph("\n"));

                // Bảng chi tiết
                PdfPTable table = new PdfPTable(4); // 4 cột
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 20f, 40f, 20f, 20f });

                // Header
                table.AddCell(new Phrase("Mã Sản Phẩm", fontNormal));
                table.AddCell(new Phrase("Tên Sản Phẩm", fontNormal));
                table.AddCell(new Phrase("Số lượng", fontNormal));
                table.AddCell(new Phrase("Đơn giá", fontNormal));

                foreach (var sp in chiTietPhieuNhaps)
                {
                    table.AddCell(new Phrase(sp.SanPhamId.ToString(), fontNormal));
                    table.AddCell(new Phrase(comboBox_nh_masp.Text ?? "", fontNormal)); // nếu có tên SP
                    table.AddCell(new Phrase(sp.SoLuong.ToString(), fontNormal));
                    table.AddCell(new Phrase(sp.DonGiaNhap.ToString("N0"), fontNormal));
                }

                doc.Add(table);
                doc.Add(new Paragraph("\n"));

                // Tổng cộng
                doc.Add(new Paragraph($"Tổng tiền: {phieuNhapKhoEntity.TongTien:N0} VND", fontTitle));

                doc.Close();

                MessageBox.Show($"Xuất PDF thành công!\nFile lưu tại: {filePath}");
                Process.Start(new ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true  // bắt buộc để Windows chọn app mặc định (Adobe Reader/Edge)
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message);
            }
        }
    }
}
