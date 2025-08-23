namespace QuanLyBanHang
{
    partial class KhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangHoa));
            label_hh_masp = new Label();
            button_hh_huybo = new Button();
            button_hh_sua = new Button();
            dataGridView_hh = new DataGridView();
            label_hh_tsp = new Label();
            label_hh_dvt = new Label();
            label_HH_NSX = new Label();
            button_hh_luu = new Button();
            button_hh_tc = new Button();
            comboBox_hh_tensp = new ComboBox();
            comboBox_hh_gb = new ComboBox();
            textBox_dvt = new ComboBox();
            comboBox_hh_masp = new ComboBox();
            comboBox_timkiem = new ComboBox();
            label1 = new Label();
            button_timkiem = new Button();
            pictureBox_bh = new PictureBox();
            button_hh_them = new Button();
            button_hh_xoa = new Button();
            label2 = new Label();
            textBox_mota = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_ThuongHieu = new TextBox();
            textBox_XuatXu = new TextBox();
            combobox_LSP = new ComboBox();
            MaSanPham = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            ThuongHieu = new DataGridViewTextBoxColumn();
            XuatXu = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            NgayTao = new DataGridViewTextBoxColumn();
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
            label_hh_masp.Size = new Size(167, 29);
            label_hh_masp.TabIndex = 40;
            label_hh_masp.Text = "Mã sản phẩm";
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
            // button_hh_sua
            // 
            button_hh_sua.BackColor = Color.Transparent;
            button_hh_sua.FlatAppearance.BorderColor = Color.Tan;
            button_hh_sua.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_hh_sua.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_hh_sua.FlatStyle = FlatStyle.Flat;
            button_hh_sua.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_hh_sua.ForeColor = Color.Lime;
            button_hh_sua.Image = Properties.Resources._48px_Crystal_Clear_app_package_settings;
            button_hh_sua.ImageAlign = ContentAlignment.MiddleLeft;
            button_hh_sua.Location = new Point(1172, 331);
            button_hh_sua.Margin = new Padding(4, 5, 4, 5);
            button_hh_sua.Name = "button_hh_sua";
            button_hh_sua.Size = new Size(153, 72);
            button_hh_sua.TabIndex = 13;
            button_hh_sua.Text = "SỬA";
            button_hh_sua.TextAlign = ContentAlignment.MiddleRight;
            button_hh_sua.UseVisualStyleBackColor = false;
            button_hh_sua.Click += button_hh_sua_Click;
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
            dataGridView_hh.Columns.AddRange(new DataGridViewColumn[] { MaSanPham, TenSanPham, TenLoai, GiaBan, ThuongHieu, XuatXu, DonViTinh, MoTa, NgayTao });
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
            // label_hh_tsp
            // 
            label_hh_tsp.AutoSize = true;
            label_hh_tsp.BackColor = Color.Transparent;
            label_hh_tsp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_hh_tsp.ForeColor = Color.Brown;
            label_hh_tsp.Location = new Point(497, 63);
            label_hh_tsp.Margin = new Padding(4, 0, 4, 0);
            label_hh_tsp.Name = "label_hh_tsp";
            label_hh_tsp.Size = new Size(178, 29);
            label_hh_tsp.TabIndex = 51;
            label_hh_tsp.Text = "Tên sản phẩm";
            // 
            // label_hh_dvt
            // 
            label_hh_dvt.AutoSize = true;
            label_hh_dvt.BackColor = Color.Transparent;
            label_hh_dvt.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_hh_dvt.ForeColor = Color.Brown;
            label_hh_dvt.Location = new Point(497, 145);
            label_hh_dvt.Margin = new Padding(4, 0, 4, 0);
            label_hh_dvt.Name = "label_hh_dvt";
            label_hh_dvt.Size = new Size(135, 29);
            label_hh_dvt.TabIndex = 52;
            label_hh_dvt.Text = "Đơn vị tính";
            // 
            // label_HH_NSX
            // 
            label_HH_NSX.AutoSize = true;
            label_HH_NSX.BackColor = Color.Transparent;
            label_HH_NSX.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_HH_NSX.ForeColor = Color.Brown;
            label_HH_NSX.Location = new Point(981, 68);
            label_HH_NSX.Margin = new Padding(4, 0, 4, 0);
            label_HH_NSX.Name = "label_HH_NSX";
            label_HH_NSX.Size = new Size(103, 29);
            label_HH_NSX.TabIndex = 56;
            label_HH_NSX.Text = "Giá bán";
            // 
            // button_hh_luu
            // 
            button_hh_luu.BackColor = Color.Transparent;
            button_hh_luu.FlatAppearance.BorderColor = Color.Tan;
            button_hh_luu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_hh_luu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_hh_luu.FlatStyle = FlatStyle.Flat;
            button_hh_luu.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_hh_luu.ForeColor = Color.Lime;
            button_hh_luu.Image = Properties.Resources.Save_as_icon;
            button_hh_luu.ImageAlign = ContentAlignment.MiddleLeft;
            button_hh_luu.Location = new Point(1005, 331);
            button_hh_luu.Margin = new Padding(4, 5, 4, 5);
            button_hh_luu.Name = "button_hh_luu";
            button_hh_luu.Size = new Size(159, 72);
            button_hh_luu.TabIndex = 12;
            button_hh_luu.Text = "LƯU";
            button_hh_luu.TextAlign = ContentAlignment.MiddleRight;
            button_hh_luu.UseVisualStyleBackColor = false;
            button_hh_luu.Click += button_hh_luu_Click;
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
            // comboBox_hh_tensp
            // 
            comboBox_hh_tensp.BackColor = Color.White;
            comboBox_hh_tensp.DropDownStyle = ComboBoxStyle.Simple;
            comboBox_hh_tensp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_hh_tensp.ForeColor = Color.Blue;
            comboBox_hh_tensp.FormattingEnabled = true;
            comboBox_hh_tensp.IntegralHeight = false;
            comboBox_hh_tensp.ItemHeight = 29;
            comboBox_hh_tensp.Location = new Point(701, 63);
            comboBox_hh_tensp.Margin = new Padding(4, 5, 4, 5);
            comboBox_hh_tensp.Name = "comboBox_hh_tensp";
            comboBox_hh_tensp.Size = new Size(245, 37);
            comboBox_hh_tensp.TabIndex = 2;
            // 
            // comboBox_hh_gb
            // 
            comboBox_hh_gb.BackColor = Color.White;
            comboBox_hh_gb.DropDownStyle = ComboBoxStyle.Simple;
            comboBox_hh_gb.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_hh_gb.ForeColor = Color.Blue;
            comboBox_hh_gb.FormattingEnabled = true;
            comboBox_hh_gb.IntegralHeight = false;
            comboBox_hh_gb.ItemHeight = 29;
            comboBox_hh_gb.Location = new Point(1115, 57);
            comboBox_hh_gb.Margin = new Padding(4, 5, 4, 5);
            comboBox_hh_gb.Name = "comboBox_hh_gb";
            comboBox_hh_gb.Size = new Size(182, 37);
            comboBox_hh_gb.TabIndex = 3;
            comboBox_hh_gb.KeyPress += comboBox_hh_gb_KeyPress;
            // 
            // textBox_dvt
            // 
            textBox_dvt.BackColor = Color.White;
            textBox_dvt.DropDownStyle = ComboBoxStyle.Simple;
            textBox_dvt.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_dvt.ForeColor = Color.Blue;
            textBox_dvt.FormattingEnabled = true;
            textBox_dvt.IntegralHeight = false;
            textBox_dvt.ItemHeight = 29;
            textBox_dvt.Location = new Point(701, 149);
            textBox_dvt.Margin = new Padding(4, 5, 4, 5);
            textBox_dvt.Name = "textBox_dvt";
            textBox_dvt.Size = new Size(245, 37);
            textBox_dvt.TabIndex = 5;
            // 
            // comboBox_hh_masp
            // 
            comboBox_hh_masp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_hh_masp.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_hh_masp.BackColor = Color.White;
            comboBox_hh_masp.DropDownStyle = ComboBoxStyle.Simple;
            comboBox_hh_masp.FlatStyle = FlatStyle.Flat;
            comboBox_hh_masp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_hh_masp.ForeColor = Color.Blue;
            comboBox_hh_masp.FormattingEnabled = true;
            comboBox_hh_masp.IntegralHeight = false;
            comboBox_hh_masp.ItemHeight = 29;
            comboBox_hh_masp.Location = new Point(205, 60);
            comboBox_hh_masp.Margin = new Padding(4, 5, 4, 5);
            comboBox_hh_masp.Name = "comboBox_hh_masp";
            comboBox_hh_masp.Size = new Size(245, 37);
            comboBox_hh_masp.TabIndex = 1;
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
            // button_hh_them
            // 
            button_hh_them.BackColor = Color.Transparent;
            button_hh_them.Cursor = Cursors.Hand;
            button_hh_them.FlatAppearance.BorderColor = Color.Tan;
            button_hh_them.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_hh_them.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_hh_them.FlatStyle = FlatStyle.Flat;
            button_hh_them.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_hh_them.ForeColor = Color.Lime;
            button_hh_them.Image = Properties.Resources._48px_Crystal_Clear_action_db_add;
            button_hh_them.ImageAlign = ContentAlignment.MiddleLeft;
            button_hh_them.Location = new Point(835, 331);
            button_hh_them.Margin = new Padding(4, 5, 4, 5);
            button_hh_them.Name = "button_hh_them";
            button_hh_them.Size = new Size(163, 72);
            button_hh_them.TabIndex = 11;
            button_hh_them.Text = "THÊM";
            button_hh_them.TextAlign = ContentAlignment.MiddleRight;
            button_hh_them.UseVisualStyleBackColor = false;
            button_hh_them.Click += button_nh_them_Click;
            // 
            // button_hh_xoa
            // 
            button_hh_xoa.BackColor = Color.Transparent;
            button_hh_xoa.Cursor = Cursors.Hand;
            button_hh_xoa.FlatAppearance.BorderColor = Color.Tan;
            button_hh_xoa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_hh_xoa.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_hh_xoa.FlatStyle = FlatStyle.Flat;
            button_hh_xoa.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_hh_xoa.ForeColor = Color.Lime;
            button_hh_xoa.Image = Properties.Resources._1439855765_1_04;
            button_hh_xoa.ImageAlign = ContentAlignment.MiddleLeft;
            button_hh_xoa.Location = new Point(1333, 331);
            button_hh_xoa.Margin = new Padding(4, 5, 4, 5);
            button_hh_xoa.Name = "button_hh_xoa";
            button_hh_xoa.Size = new Size(152, 72);
            button_hh_xoa.TabIndex = 14;
            button_hh_xoa.Text = "XÓA";
            button_hh_xoa.TextAlign = ContentAlignment.MiddleRight;
            button_hh_xoa.UseVisualStyleBackColor = false;
            button_hh_xoa.Click += button_hh_xoa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(12, 224);
            label2.Name = "label2";
            label2.Size = new Size(77, 29);
            label2.TabIndex = 80;
            label2.Text = "Mô tả";
            // 
            // textBox_mota
            // 
            textBox_mota.BackColor = Color.White;
            textBox_mota.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            textBox_mota.ForeColor = Color.Blue;
            textBox_mota.Location = new Point(205, 224);
            textBox_mota.Name = "textBox_mota";
            textBox_mota.Size = new Size(245, 34);
            textBox_mota.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(182, 29);
            label3.TabIndex = 82;
            label3.Text = "Loại sản phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(497, 230);
            label4.Name = "label4";
            label4.Size = new Size(159, 29);
            label4.TabIndex = 83;
            label4.Text = "Thương hiệu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(981, 145);
            label5.Name = "label5";
            label5.Size = new Size(99, 29);
            label5.TabIndex = 84;
            label5.Text = "Xuất xứ";
            // 
            // textBox_ThuongHieu
            // 
            textBox_ThuongHieu.BackColor = Color.White;
            textBox_ThuongHieu.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            textBox_ThuongHieu.ForeColor = Color.Blue;
            textBox_ThuongHieu.Location = new Point(701, 230);
            textBox_ThuongHieu.Name = "textBox_ThuongHieu";
            textBox_ThuongHieu.Size = new Size(245, 34);
            textBox_ThuongHieu.TabIndex = 8;
            // 
            // textBox_XuatXu
            // 
            textBox_XuatXu.BackColor = Color.White;
            textBox_XuatXu.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            textBox_XuatXu.ForeColor = Color.Blue;
            textBox_XuatXu.Location = new Point(1115, 144);
            textBox_XuatXu.Name = "textBox_XuatXu";
            textBox_XuatXu.Size = new Size(182, 34);
            textBox_XuatXu.TabIndex = 6;
            // 
            // combobox_LSP
            // 
            combobox_LSP.BackColor = Color.White;
            combobox_LSP.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            combobox_LSP.ForeColor = Color.Blue;
            combobox_LSP.FormattingEnabled = true;
            combobox_LSP.Location = new Point(205, 149);
            combobox_LSP.Name = "combobox_LSP";
            combobox_LSP.Size = new Size(245, 37);
            combobox_LSP.TabIndex = 4;
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
            TenSanPham.Width = 200;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "LoaiSanPhamTen";
            TenLoai.HeaderText = "Tên Loại";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            TenLoai.ReadOnly = true;
            TenLoai.Width = 200;
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            GiaBan.HeaderText = "Giá Bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            GiaBan.Width = 200;
            // 
            // ThuongHieu
            // 
            ThuongHieu.DataPropertyName = "ThuongHieu";
            ThuongHieu.HeaderText = "Thương Hiệu";
            ThuongHieu.MinimumWidth = 6;
            ThuongHieu.Name = "ThuongHieu";
            ThuongHieu.ReadOnly = true;
            ThuongHieu.Width = 200;
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
            // DonViTinh
            // 
            DonViTinh.DataPropertyName = "DonViTinh";
            DonViTinh.HeaderText = "Đơn Vị Tính";
            DonViTinh.MinimumWidth = 6;
            DonViTinh.Name = "DonViTinh";
            DonViTinh.ReadOnly = true;
            DonViTinh.Width = 200;
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.HeaderText = "Mô Tả";
            MoTa.MinimumWidth = 6;
            MoTa.Name = "MoTa";
            MoTa.ReadOnly = true;
            MoTa.Width = 200;
            // 
            // NgayTao
            // 
            NgayTao.DataPropertyName = "NgayTao";
            NgayTao.HeaderText = "Ngày Tạo";
            NgayTao.MinimumWidth = 6;
            NgayTao.Name = "NgayTao";
            NgayTao.ReadOnly = true;
            NgayTao.Width = 200;
            // 
            // HangHoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gray;
            ClientSize = new Size(1796, 1055);
            Controls.Add(combobox_LSP);
            Controls.Add(textBox_XuatXu);
            Controls.Add(textBox_ThuongHieu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox_mota);
            Controls.Add(label2);
            Controls.Add(button_hh_xoa);
            Controls.Add(button_hh_them);
            Controls.Add(pictureBox_bh);
            Controls.Add(button_timkiem);
            Controls.Add(label1);
            Controls.Add(comboBox_timkiem);
            Controls.Add(comboBox_hh_masp);
            Controls.Add(textBox_dvt);
            Controls.Add(comboBox_hh_gb);
            Controls.Add(comboBox_hh_tensp);
            Controls.Add(button_hh_tc);
            Controls.Add(button_hh_luu);
            Controls.Add(label_HH_NSX);
            Controls.Add(label_hh_dvt);
            Controls.Add(label_hh_tsp);
            Controls.Add(label_hh_masp);
            Controls.Add(button_hh_huybo);
            Controls.Add(button_hh_sua);
            Controls.Add(dataGridView_hh);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "HangHoa";
            Text = "HÀNG HÓA";
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
        private System.Windows.Forms.Button button_hh_sua;
        private System.Windows.Forms.DataGridView dataGridView_hh;
        private System.Windows.Forms.Label label_hh_tsp;
        private System.Windows.Forms.Label label_hh_dvt;
        private System.Windows.Forms.Label label_HH_NSX;
        private System.Windows.Forms.Button button_hh_luu;
        private System.Windows.Forms.Button button_hh_tc;
        private System.Windows.Forms.ComboBox comboBox_hh_tensp;
        private System.Windows.Forms.ComboBox comboBox_hh_gb;
        private System.Windows.Forms.ComboBox textBox_dvt;
        private System.Windows.Forms.ComboBox comboBox_hh_masp;
        private System.Windows.Forms.ComboBox comboBox_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.PictureBox pictureBox_bh;
        private System.Windows.Forms.Button button_hh_them;
        private System.Windows.Forms.Button button_hh_xoa;
        private Label label2;
        private TextBox textBox_mota;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_ThuongHieu;
        private TextBox textBox_XuatXu;
        private ComboBox combobox_LSP;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn ThuongHieu;
        private DataGridViewTextBoxColumn XuatXu;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn NgayTao;
    }
}