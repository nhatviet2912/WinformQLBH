namespace QuanLyBanHang
{
    partial class HoaDonBan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonBan));
            label_hh_masp = new Label();
            button_hh_huybo = new Button();
            dataGridView_hh = new DataGridView();
            MaHoaDon = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            NhanVienBan = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            NgayBan = new DataGridViewTextBoxColumn();
            label_hh_tsp = new Label();
            label_hh_dvt = new Label();
            label_HH_NSX = new Label();
            button_hh_tc = new Button();
            comboBox_ngaynhap = new ComboBox();
            comboBox_ncc = new ComboBox();
            textBox_tongtien = new ComboBox();
            comboBox_maphieu = new ComboBox();
            comboBox_timkiem = new ComboBox();
            label1 = new Label();
            button_timkiem = new Button();
            label3 = new Label();
            textBox_nhanvien = new TextBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_hh).BeginInit();
            SuspendLayout();
            // 
            // label_hh_masp
            // 
            label_hh_masp.AutoSize = true;
            label_hh_masp.BackColor = Color.Transparent;
            label_hh_masp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_hh_masp.ForeColor = Color.Brown;
            label_hh_masp.Location = new Point(5, 60);
            label_hh_masp.Margin = new Padding(4, 0, 4, 0);
            label_hh_masp.Name = "label_hh_masp";
            label_hh_masp.Size = new Size(156, 29);
            label_hh_masp.TabIndex = 40;
            label_hh_masp.Text = "Mã Hóa Đơn";
            // 
            // button_hh_huybo
            // 
            button_hh_huybo.BackColor = Color.Transparent;
            button_hh_huybo.FlatAppearance.BorderColor = Color.Tan;
            button_hh_huybo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_hh_huybo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_hh_huybo.FlatStyle = FlatStyle.Flat;
            button_hh_huybo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_hh_huybo.ForeColor = Color.Lime;
            button_hh_huybo.Image = Properties.Resources._1439854729_DeleteRed;
            button_hh_huybo.ImageAlign = ContentAlignment.MiddleLeft;
            button_hh_huybo.Location = new Point(1493, 331);
            button_hh_huybo.Margin = new Padding(4, 5, 4, 5);
            button_hh_huybo.Name = "button_hh_huybo";
            button_hh_huybo.Size = new Size(161, 72);
            button_hh_huybo.TabIndex = 15;
            button_hh_huybo.Text = "HỦY BỎ";
            button_hh_huybo.TextAlign = ContentAlignment.MiddleRight;
            button_hh_huybo.UseVisualStyleBackColor = false;
            button_hh_huybo.Click += button_hh_huybo_Click;
            // 
            // dataGridView_hh
            // 
            dataGridView_hh.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_hh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_hh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_hh.Columns.AddRange(new DataGridViewColumn[] { MaHoaDon, TenKhachHang, NhanVienBan, TongTien, NgayBan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_hh.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_hh.Location = new Point(-1, 415);
            dataGridView_hh.Margin = new Padding(4, 5, 4, 5);
            dataGridView_hh.Name = "dataGridView_hh";
            dataGridView_hh.ReadOnly = true;
            dataGridView_hh.RowHeadersWidth = 51;
            dataGridView_hh.Size = new Size(1804, 714);
            dataGridView_hh.TabIndex = 30;
            dataGridView_hh.CellContentClick += dataGridView_hh_CellContentClick;
            dataGridView_hh.CellFormatting += dataGridView1_CellFormatting;
            dataGridView_hh.CellMouseClick += dataGridView_hh_CellMouseClick;
            dataGridView_hh.Click += button_hh_huybo_Click;
            // 
            // MaHoaDon
            // 
            MaHoaDon.DataPropertyName = "MaHoaDon";
            MaHoaDon.HeaderText = "Mã Hóa Đơn";
            MaHoaDon.MinimumWidth = 6;
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.ReadOnly = true;
            MaHoaDon.Width = 200;
            // 
            // TenKhachHang
            // 
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Tên Khách Hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            TenKhachHang.ReadOnly = true;
            TenKhachHang.Width = 300;
            // 
            // NhanVienBan
            // 
            NhanVienBan.DataPropertyName = "NhanVienBan";
            NhanVienBan.HeaderText = "Nhân Viên";
            NhanVienBan.MinimumWidth = 6;
            NhanVienBan.Name = "NhanVienBan";
            NhanVienBan.ReadOnly = true;
            NhanVienBan.Width = 300;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            TongTien.Width = 300;
            // 
            // NgayBan
            // 
            NgayBan.DataPropertyName = "NgayBan";
            NgayBan.HeaderText = "Ngày Bán";
            NgayBan.MinimumWidth = 6;
            NgayBan.Name = "NgayBan";
            NgayBan.ReadOnly = true;
            NgayBan.Width = 200;
            // 
            // label_hh_tsp
            // 
            label_hh_tsp.AutoSize = true;
            label_hh_tsp.BackColor = Color.Transparent;
            label_hh_tsp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_hh_tsp.ForeColor = Color.Brown;
            label_hh_tsp.Location = new Point(587, 63);
            label_hh_tsp.Margin = new Padding(4, 0, 4, 0);
            label_hh_tsp.Name = "label_hh_tsp";
            label_hh_tsp.Size = new Size(125, 29);
            label_hh_tsp.TabIndex = 51;
            label_hh_tsp.Text = "Ngày Bán";
            // 
            // label_hh_dvt
            // 
            label_hh_dvt.AutoSize = true;
            label_hh_dvt.BackColor = Color.Transparent;
            label_hh_dvt.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_hh_dvt.ForeColor = Color.Brown;
            label_hh_dvt.Location = new Point(587, 143);
            label_hh_dvt.Margin = new Padding(4, 0, 4, 0);
            label_hh_dvt.Name = "label_hh_dvt";
            label_hh_dvt.Size = new Size(124, 29);
            label_hh_dvt.TabIndex = 52;
            label_hh_dvt.Text = "Tổng tiền";
            // 
            // label_HH_NSX
            // 
            label_HH_NSX.AutoSize = true;
            label_HH_NSX.BackColor = Color.Transparent;
            label_HH_NSX.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_HH_NSX.ForeColor = Color.Brown;
            label_HH_NSX.Location = new Point(13, 218);
            label_HH_NSX.Margin = new Padding(4, 0, 4, 0);
            label_HH_NSX.Name = "label_HH_NSX";
            label_HH_NSX.Size = new Size(206, 29);
            label_HH_NSX.TabIndex = 56;
            label_HH_NSX.Text = "Tên Khách Hàng";
            // 
            // button_hh_tc
            // 
            button_hh_tc.BackColor = Color.Transparent;
            button_hh_tc.Cursor = Cursors.Hand;
            button_hh_tc.FlatAppearance.BorderColor = Color.Tan;
            button_hh_tc.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_hh_tc.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_hh_tc.FlatStyle = FlatStyle.Flat;
            button_hh_tc.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_hh_tc.ForeColor = Color.Lime;
            button_hh_tc.Image = Properties.Resources._48px_Crystal_Clear_action_reload;
            button_hh_tc.Location = new Point(1667, 331);
            button_hh_tc.Margin = new Padding(4, 5, 4, 5);
            button_hh_tc.Name = "button_hh_tc";
            button_hh_tc.Size = new Size(113, 72);
            button_hh_tc.TabIndex = 16;
            button_hh_tc.UseVisualStyleBackColor = false;
            button_hh_tc.Click += button_hh_tc_Click_1;
            // 
            // comboBox_ngaynhap
            // 
            comboBox_ngaynhap.BackColor = Color.White;
            comboBox_ngaynhap.DropDownStyle = ComboBoxStyle.Simple;
            comboBox_ngaynhap.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_ngaynhap.ForeColor = Color.Blue;
            comboBox_ngaynhap.FormattingEnabled = true;
            comboBox_ngaynhap.IntegralHeight = false;
            comboBox_ngaynhap.ItemHeight = 29;
            comboBox_ngaynhap.Location = new Point(835, 63);
            comboBox_ngaynhap.Margin = new Padding(4, 5, 4, 5);
            comboBox_ngaynhap.Name = "comboBox_ngaynhap";
            comboBox_ngaynhap.Size = new Size(245, 37);
            comboBox_ngaynhap.TabIndex = 2;
            // 
            // comboBox_ncc
            // 
            comboBox_ncc.BackColor = Color.White;
            comboBox_ncc.DropDownStyle = ComboBoxStyle.Simple;
            comboBox_ncc.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_ncc.ForeColor = Color.Blue;
            comboBox_ncc.FormattingEnabled = true;
            comboBox_ncc.IntegralHeight = false;
            comboBox_ncc.ItemHeight = 29;
            comboBox_ncc.Location = new Point(247, 218);
            comboBox_ncc.Margin = new Padding(4, 5, 4, 5);
            comboBox_ncc.Name = "comboBox_ncc";
            comboBox_ncc.Size = new Size(245, 37);
            comboBox_ncc.TabIndex = 3;
            comboBox_ncc.KeyPress += comboBox_hh_gb_KeyPress;
            // 
            // textBox_tongtien
            // 
            textBox_tongtien.BackColor = Color.White;
            textBox_tongtien.DropDownStyle = ComboBoxStyle.Simple;
            textBox_tongtien.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_tongtien.ForeColor = Color.Blue;
            textBox_tongtien.FormattingEnabled = true;
            textBox_tongtien.IntegralHeight = false;
            textBox_tongtien.ItemHeight = 29;
            textBox_tongtien.Location = new Point(835, 145);
            textBox_tongtien.Margin = new Padding(4, 5, 4, 5);
            textBox_tongtien.Name = "textBox_tongtien";
            textBox_tongtien.Size = new Size(245, 37);
            textBox_tongtien.TabIndex = 5;
            // 
            // comboBox_maphieu
            // 
            comboBox_maphieu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_maphieu.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_maphieu.BackColor = Color.White;
            comboBox_maphieu.DropDownStyle = ComboBoxStyle.Simple;
            comboBox_maphieu.FlatStyle = FlatStyle.Flat;
            comboBox_maphieu.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_maphieu.ForeColor = Color.Blue;
            comboBox_maphieu.FormattingEnabled = true;
            comboBox_maphieu.IntegralHeight = false;
            comboBox_maphieu.ItemHeight = 29;
            comboBox_maphieu.Location = new Point(247, 63);
            comboBox_maphieu.Margin = new Padding(4, 5, 4, 5);
            comboBox_maphieu.Name = "comboBox_maphieu";
            comboBox_maphieu.Size = new Size(245, 37);
            comboBox_maphieu.TabIndex = 1;
            // 
            // comboBox_timkiem
            // 
            comboBox_timkiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_timkiem.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_timkiem.BackColor = Color.White;
            comboBox_timkiem.DropDownStyle = ComboBoxStyle.Simple;
            comboBox_timkiem.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_timkiem.ForeColor = Color.Blue;
            comboBox_timkiem.FormattingEnabled = true;
            comboBox_timkiem.IntegralHeight = false;
            comboBox_timkiem.ItemHeight = 29;
            comboBox_timkiem.Location = new Point(163, 345);
            comboBox_timkiem.Margin = new Padding(4, 5, 4, 5);
            comboBox_timkiem.Name = "comboBox_timkiem";
            comboBox_timkiem.Size = new Size(512, 39);
            comboBox_timkiem.TabIndex = 9;
            comboBox_timkiem.SelectedIndexChanged += comboBox_timkiem_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(12, 349);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 29);
            label1.TabIndex = 73;
            label1.Text = "Tìm kiếm :";
            // 
            // button_timkiem
            // 
            button_timkiem.BackColor = Color.Gray;
            button_timkiem.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            button_timkiem.FlatStyle = FlatStyle.Flat;
            button_timkiem.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_timkiem.ForeColor = Color.Red;
            button_timkiem.Image = Properties.Resources._1438980118_search_icon_tm;
            button_timkiem.Location = new Point(701, 335);
            button_timkiem.Margin = new Padding(4, 5, 4, 5);
            button_timkiem.Name = "button_timkiem";
            button_timkiem.Size = new Size(100, 66);
            button_timkiem.TabIndex = 10;
            button_timkiem.UseVisualStyleBackColor = false;
            button_timkiem.Click += button_timkiem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(133, 29);
            label3.TabIndex = 82;
            label3.Text = "Nhân Viên";
            // 
            // textBox_nhanvien
            // 
            textBox_nhanvien.BackColor = Color.White;
            textBox_nhanvien.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            textBox_nhanvien.ForeColor = Color.Blue;
            textBox_nhanvien.Location = new Point(247, 137);
            textBox_nhanvien.Name = "textBox_nhanvien";
            textBox_nhanvien.Size = new Size(245, 34);
            textBox_nhanvien.TabIndex = 8;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.DarkGray;
            richTextBox1.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.Brown;
            richTextBox1.Location = new Point(1302, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.Size = new Size(478, 187);
            richTextBox1.TabIndex = 93;
            richTextBox1.Text = "QUẢN LÝ HÓA ĐƠN BÁN";
            // 
            // HoaDonBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gray;
            ClientSize = new Size(1796, 1055);
            Controls.Add(richTextBox1);
            Controls.Add(textBox_nhanvien);
            Controls.Add(label3);
            Controls.Add(button_timkiem);
            Controls.Add(label1);
            Controls.Add(comboBox_timkiem);
            Controls.Add(comboBox_maphieu);
            Controls.Add(textBox_tongtien);
            Controls.Add(comboBox_ncc);
            Controls.Add(comboBox_ngaynhap);
            Controls.Add(button_hh_tc);
            Controls.Add(label_HH_NSX);
            Controls.Add(label_hh_dvt);
            Controls.Add(label_hh_tsp);
            Controls.Add(label_hh_masp);
            Controls.Add(button_hh_huybo);
            Controls.Add(dataGridView_hh);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "HoaDonBan";
            Text = "Hóa Đơn Nhập";
            Load += HangHoa_Load;
            Click += button_hh_huybo_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView_hh).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hh_masp;
        private System.Windows.Forms.Button button_hh_huybo;
        private System.Windows.Forms.DataGridView dataGridView_hh;
        private System.Windows.Forms.Label label_hh_tsp;
        private System.Windows.Forms.Label label_hh_dvt;
        private System.Windows.Forms.Label label_HH_NSX;
        private System.Windows.Forms.Button button_hh_tc;
        private System.Windows.Forms.ComboBox comboBox_ngaynhap;
        private System.Windows.Forms.ComboBox comboBox_ncc;
        private System.Windows.Forms.ComboBox textBox_tongtien;
        private System.Windows.Forms.ComboBox comboBox_maphieu;
        private System.Windows.Forms.ComboBox comboBox_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_timkiem;
        private Label label3;
        private TextBox textBox_nhanvien;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn NhanVienBan;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn NgayBan;
        private RichTextBox richTextBox1;
    }
}