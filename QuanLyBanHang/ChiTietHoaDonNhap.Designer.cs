namespace QuanLyBanHang
{
    partial class ChiTietHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietHoaDonNhap));
            label_hh_masp = new Label();
            button_hh_huybo = new Button();
            dataGridView_hh = new DataGridView();
            MaSanPham = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGiaNhap = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            ThuongHieu = new DataGridViewTextBoxColumn();
            XuatXu = new DataGridViewTextBoxColumn();
            label_hh_tsp = new Label();
            label_hh_dvt = new Label();
            label_HH_NSX = new Label();
            button_hh_tc = new Button();
            comboBox_tsp = new ComboBox();
            comboBox_tt = new ComboBox();
            textBox_dg = new ComboBox();
            comboBox_msp = new ComboBox();
            pictureBox_bh = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            textBox_sl = new TextBox();
            textBox_xx = new TextBox();
            label1 = new Label();
            combobox_thuonghieu = new ComboBox();
            label2 = new Label();
            comboBox_tongtien = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_hh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_bh).BeginInit();
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
            label_hh_masp.Size = new Size(173, 29);
            label_hh_masp.TabIndex = 40;
            label_hh_masp.Text = "Mã Sản Phẩm";
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
            dataGridView_hh.Columns.AddRange(new DataGridViewColumn[] { MaSanPham, TenSanPham, SoLuong, DonGiaNhap, ThanhTien, ThuongHieu, XuatXu });
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
            // MaSanPham
            // 
            MaSanPham.DataPropertyName = "MaSanPham";
            MaSanPham.HeaderText = "Mã Sản Phẩm";
            MaSanPham.MinimumWidth = 6;
            MaSanPham.Name = "MaSanPham";
            MaSanPham.ReadOnly = true;
            MaSanPham.Width = 200;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            TenSanPham.Width = 300;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng Nhập";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            SoLuong.Width = 200;
            // 
            // DonGiaNhap
            // 
            DonGiaNhap.DataPropertyName = "DonGiaNhap";
            DonGiaNhap.HeaderText = "Đơn Giá";
            DonGiaNhap.MinimumWidth = 6;
            DonGiaNhap.Name = "DonGiaNhap";
            DonGiaNhap.ReadOnly = true;
            DonGiaNhap.Width = 250;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            ThanhTien.Width = 250;
            // 
            // ThuongHieu
            // 
            ThuongHieu.DataPropertyName = "ThuongHieu";
            ThuongHieu.HeaderText = "Thương Hiệu";
            ThuongHieu.MinimumWidth = 6;
            ThuongHieu.Name = "ThuongHieu";
            ThuongHieu.ReadOnly = true;
            ThuongHieu.Width = 400;
            // 
            // XuatXu
            // 
            XuatXu.DataPropertyName = "XuatXu";
            XuatXu.HeaderText = "Xuất Xứ";
            XuatXu.MinimumWidth = 6;
            XuatXu.Name = "XuatXu";
            XuatXu.ReadOnly = true;
            XuatXu.Width = 200;
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
            label_hh_tsp.Size = new Size(184, 29);
            label_hh_tsp.TabIndex = 51;
            label_hh_tsp.Text = "Tên Sản Phẩm";
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
            label_hh_dvt.Size = new Size(107, 29);
            label_hh_dvt.TabIndex = 52;
            label_hh_dvt.Text = "Đơn Giá";
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
            label_HH_NSX.Size = new Size(146, 29);
            label_HH_NSX.TabIndex = 56;
            label_HH_NSX.Text = "Thành Tiền";
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
            // comboBox_tsp
            // 
            comboBox_tsp.BackColor = Color.White;
            comboBox_tsp.DropDownStyle = ComboBoxStyle.Simple;
            comboBox_tsp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_tsp.ForeColor = Color.Blue;
            comboBox_tsp.FormattingEnabled = true;
            comboBox_tsp.IntegralHeight = false;
            comboBox_tsp.ItemHeight = 29;
            comboBox_tsp.Location = new Point(835, 63);
            comboBox_tsp.Margin = new Padding(4, 5, 4, 5);
            comboBox_tsp.Name = "comboBox_tsp";
            comboBox_tsp.Size = new Size(245, 37);
            comboBox_tsp.TabIndex = 2;
            // 
            // comboBox_tt
            // 
            comboBox_tt.BackColor = Color.White;
            comboBox_tt.DropDownStyle = ComboBoxStyle.Simple;
            comboBox_tt.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_tt.ForeColor = Color.Blue;
            comboBox_tt.FormattingEnabled = true;
            comboBox_tt.IntegralHeight = false;
            comboBox_tt.ItemHeight = 29;
            comboBox_tt.Location = new Point(247, 218);
            comboBox_tt.Margin = new Padding(4, 5, 4, 5);
            comboBox_tt.Name = "comboBox_tt";
            comboBox_tt.Size = new Size(245, 37);
            comboBox_tt.TabIndex = 3;
            comboBox_tt.KeyPress += comboBox_hh_gb_KeyPress;
            // 
            // textBox_dg
            // 
            textBox_dg.BackColor = Color.White;
            textBox_dg.DropDownStyle = ComboBoxStyle.Simple;
            textBox_dg.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_dg.ForeColor = Color.Blue;
            textBox_dg.FormattingEnabled = true;
            textBox_dg.IntegralHeight = false;
            textBox_dg.ItemHeight = 29;
            textBox_dg.Location = new Point(835, 145);
            textBox_dg.Margin = new Padding(4, 5, 4, 5);
            textBox_dg.Name = "textBox_dg";
            textBox_dg.Size = new Size(245, 37);
            textBox_dg.TabIndex = 5;
            // 
            // comboBox_msp
            // 
            comboBox_msp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_msp.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_msp.BackColor = Color.White;
            comboBox_msp.DropDownStyle = ComboBoxStyle.Simple;
            comboBox_msp.FlatStyle = FlatStyle.Flat;
            comboBox_msp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_msp.ForeColor = Color.Blue;
            comboBox_msp.FormattingEnabled = true;
            comboBox_msp.IntegralHeight = false;
            comboBox_msp.ItemHeight = 29;
            comboBox_msp.Location = new Point(247, 63);
            comboBox_msp.Margin = new Padding(4, 5, 4, 5);
            comboBox_msp.Name = "comboBox_msp";
            comboBox_msp.Size = new Size(245, 37);
            comboBox_msp.TabIndex = 1;
            // 
            // pictureBox_bh
            // 
            pictureBox_bh.BackColor = Color.Transparent;
            pictureBox_bh.BorderStyle = BorderStyle.Fixed3D;
            pictureBox_bh.Image = Properties.Resources.coollogo_com_289623578;
            pictureBox_bh.Location = new Point(1345, 18);
            pictureBox_bh.Margin = new Padding(4, 5, 4, 5);
            pictureBox_bh.Name = "pictureBox_bh";
            pictureBox_bh.Size = new Size(433, 270);
            pictureBox_bh.TabIndex = 75;
            pictureBox_bh.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(193, 29);
            label3.TabIndex = 82;
            label3.Text = "Số Lượng Nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(587, 223);
            label5.Name = "label5";
            label5.Size = new Size(105, 29);
            label5.TabIndex = 84;
            label5.Text = "Xuất Xứ";
            // 
            // textBox_sl
            // 
            textBox_sl.BackColor = Color.White;
            textBox_sl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            textBox_sl.ForeColor = Color.Blue;
            textBox_sl.Location = new Point(247, 137);
            textBox_sl.Name = "textBox_sl";
            textBox_sl.Size = new Size(245, 34);
            textBox_sl.TabIndex = 8;
            // 
            // textBox_xx
            // 
            textBox_xx.BackColor = Color.White;
            textBox_xx.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            textBox_xx.ForeColor = Color.Blue;
            textBox_xx.Location = new Point(835, 221);
            textBox_xx.Name = "textBox_xx";
            textBox_xx.Size = new Size(245, 34);
            textBox_xx.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(12, 293);
            label1.Name = "label1";
            label1.Size = new Size(163, 29);
            label1.TabIndex = 85;
            label1.Text = "Thương Hiệu";
            // 
            // combobox_thuonghieu
            // 
            combobox_thuonghieu.BackColor = Color.White;
            combobox_thuonghieu.DropDownStyle = ComboBoxStyle.Simple;
            combobox_thuonghieu.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combobox_thuonghieu.ForeColor = Color.Blue;
            combobox_thuonghieu.FormattingEnabled = true;
            combobox_thuonghieu.IntegralHeight = false;
            combobox_thuonghieu.ItemHeight = 29;
            combobox_thuonghieu.Location = new Point(247, 293);
            combobox_thuonghieu.Margin = new Padding(4, 5, 4, 5);
            combobox_thuonghieu.Name = "combobox_thuonghieu";
            combobox_thuonghieu.Size = new Size(833, 37);
            combobox_thuonghieu.TabIndex = 86;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(25, 360);
            label2.Name = "label2";
            label2.Size = new Size(242, 29);
            label2.TabIndex = 87;
            label2.Text = "Tổng Tiền Hóa Đơn";
            // 
            // comboBox_tongtien
            // 
            comboBox_tongtien.BackColor = Color.White;
            comboBox_tongtien.DropDownStyle = ComboBoxStyle.Simple;
            comboBox_tongtien.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_tongtien.ForeColor = Color.Blue;
            comboBox_tongtien.FormattingEnabled = true;
            comboBox_tongtien.IntegralHeight = false;
            comboBox_tongtien.ItemHeight = 29;
            comboBox_tongtien.Location = new Point(307, 357);
            comboBox_tongtien.Margin = new Padding(4, 5, 4, 5);
            comboBox_tongtien.Name = "comboBox_tongtien";
            comboBox_tongtien.Size = new Size(385, 37);
            comboBox_tongtien.TabIndex = 88;
            // 
            // ChiTietHoaDonNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gray;
            ClientSize = new Size(1796, 1055);
            Controls.Add(comboBox_tongtien);
            Controls.Add(label2);
            Controls.Add(combobox_thuonghieu);
            Controls.Add(label1);
            Controls.Add(textBox_xx);
            Controls.Add(textBox_sl);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(pictureBox_bh);
            Controls.Add(comboBox_msp);
            Controls.Add(textBox_dg);
            Controls.Add(comboBox_tt);
            Controls.Add(comboBox_tsp);
            Controls.Add(button_hh_tc);
            Controls.Add(label_HH_NSX);
            Controls.Add(label_hh_dvt);
            Controls.Add(label_hh_tsp);
            Controls.Add(label_hh_masp);
            Controls.Add(button_hh_huybo);
            Controls.Add(dataGridView_hh);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChiTietHoaDonNhap";
            Text = "Chi Tiết Hóa Đơn Nhập";
            Load += HangHoa_Load;
            Click += button_hh_huybo_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView_hh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_bh).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox_tsp;
        private System.Windows.Forms.ComboBox comboBox_tt;
        private System.Windows.Forms.ComboBox textBox_dg;
        private System.Windows.Forms.ComboBox comboBox_msp;
        private System.Windows.Forms.PictureBox pictureBox_bh;
        private Label label3;
        private Label label5;
        private TextBox textBox_sl;
        private TextBox textBox_xx;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGiaNhap;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn ThuongHieu;
        private DataGridViewTextBoxColumn XuatXu;
        private Label label1;
        private ComboBox combobox_thuonghieu;
        private Label label2;
        private ComboBox comboBox_tongtien;
    }
}