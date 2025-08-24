namespace QuanLyBanHang
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            dataGridView_kh = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            button_kh_them = new Button();
            button_kh_luu = new Button();
            button_kh_sua = new Button();
            button_kh_xoa = new Button();
            button_kh_huybo = new Button();
            textBox_kh_tenkh = new TextBox();
            textBox_kh_sdt = new TextBox();
            textBox_kh_dc = new TextBox();
            label_kh_tenkh = new Label();
            label_kh_sdt = new Label();
            label_kh_dc = new Label();
            button_kh_tc = new Button();
            label1 = new Label();
            comboBox_timkiem = new ComboBox();
            button_timkiem = new Button();
            label2 = new Label();
            textBox_kh_makh = new TextBox();
            label_email = new Label();
            textBox_kh_emailkh = new TextBox();
            comboBox_kh_gioitinh = new ComboBox();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_kh).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_kh
            // 
            dataGridView_kh.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_kh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_kh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_kh.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Email, GioiTinh });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_kh.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_kh.Location = new Point(4, 401);
            dataGridView_kh.Margin = new Padding(4, 5, 4, 5);
            dataGridView_kh.Name = "dataGridView_kh";
            dataGridView_kh.ReadOnly = true;
            dataGridView_kh.RowHeadersWidth = 51;
            dataGridView_kh.Size = new Size(1807, 723);
            dataGridView_kh.TabIndex = 0;
            dataGridView_kh.CellClick += dataGridView_kh_CellContentClick;
            dataGridView_kh.CellContentClick += dataGridView_kh_CellContentClick;
            dataGridView_kh.CellContentDoubleClick += dataGridView_kh_CellDoubleClick;
            dataGridView_kh.CellDoubleClick += dataGridView_kh_CellDoubleClick;
            dataGridView_kh.CellMouseClick += dataGridView_kh_CellMouseClick;
            dataGridView_kh.Click += button_kh_thoat_Click;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.DataPropertyName = "MaCode";
            Column1.HeaderText = "Mã khách hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "TenKhachHang";
            Column2.HeaderText = "Tên Khách Hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.DataPropertyName = "DienThoai";
            Column3.HeaderText = "Số điện thoại";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.DataPropertyName = "DiaChi";
            Column4.HeaderText = "Địa chỉ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 300;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            GioiTinh.Width = 125;
            // 
            // button_kh_them
            // 
            button_kh_them.BackColor = Color.Transparent;
            button_kh_them.FlatAppearance.BorderColor = Color.Tan;
            button_kh_them.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_kh_them.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_kh_them.FlatStyle = FlatStyle.Flat;
            button_kh_them.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_kh_them.ForeColor = Color.Lime;
            button_kh_them.Image = Properties.Resources._48px_Crystal_Clear_action_db_add;
            button_kh_them.ImageAlign = ContentAlignment.MiddleLeft;
            button_kh_them.Location = new Point(765, 311);
            button_kh_them.Margin = new Padding(4, 5, 4, 5);
            button_kh_them.Name = "button_kh_them";
            button_kh_them.Size = new Size(175, 80);
            button_kh_them.TabIndex = 9;
            button_kh_them.Text = "THÊM";
            button_kh_them.TextAlign = ContentAlignment.MiddleRight;
            button_kh_them.UseVisualStyleBackColor = false;
            button_kh_them.Click += button_kh_them_Click;
            // 
            // button_kh_luu
            // 
            button_kh_luu.BackColor = Color.Transparent;
            button_kh_luu.FlatAppearance.BorderColor = Color.Tan;
            button_kh_luu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_kh_luu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_kh_luu.FlatStyle = FlatStyle.Flat;
            button_kh_luu.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_kh_luu.ForeColor = Color.Lime;
            button_kh_luu.Image = Properties.Resources.Save_as_icon;
            button_kh_luu.ImageAlign = ContentAlignment.MiddleLeft;
            button_kh_luu.Location = new Point(948, 311);
            button_kh_luu.Margin = new Padding(4, 5, 4, 5);
            button_kh_luu.Name = "button_kh_luu";
            button_kh_luu.Size = new Size(175, 80);
            button_kh_luu.TabIndex = 10;
            button_kh_luu.Text = "LƯU";
            button_kh_luu.TextAlign = ContentAlignment.MiddleRight;
            button_kh_luu.UseVisualStyleBackColor = false;
            button_kh_luu.Click += button_kh_luu_Click;
            // 
            // button_kh_sua
            // 
            button_kh_sua.BackColor = Color.Transparent;
            button_kh_sua.FlatAppearance.BorderColor = Color.Tan;
            button_kh_sua.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_kh_sua.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_kh_sua.FlatStyle = FlatStyle.Flat;
            button_kh_sua.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_kh_sua.ForeColor = Color.Lime;
            button_kh_sua.Image = Properties.Resources._48px_Crystal_Clear_app_package_settings;
            button_kh_sua.ImageAlign = ContentAlignment.MiddleLeft;
            button_kh_sua.Location = new Point(1131, 311);
            button_kh_sua.Margin = new Padding(4, 5, 4, 5);
            button_kh_sua.Name = "button_kh_sua";
            button_kh_sua.Size = new Size(175, 80);
            button_kh_sua.TabIndex = 11;
            button_kh_sua.Text = "SỬA";
            button_kh_sua.TextAlign = ContentAlignment.MiddleRight;
            button_kh_sua.UseVisualStyleBackColor = false;
            button_kh_sua.Click += button_kh_sua_Click;
            // 
            // button_kh_xoa
            // 
            button_kh_xoa.BackColor = Color.Transparent;
            button_kh_xoa.FlatAppearance.BorderColor = Color.Tan;
            button_kh_xoa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_kh_xoa.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_kh_xoa.FlatStyle = FlatStyle.Flat;
            button_kh_xoa.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_kh_xoa.ForeColor = Color.Lime;
            button_kh_xoa.Image = Properties.Resources._1439855765_1_04;
            button_kh_xoa.ImageAlign = ContentAlignment.MiddleLeft;
            button_kh_xoa.Location = new Point(1313, 311);
            button_kh_xoa.Margin = new Padding(4, 5, 4, 5);
            button_kh_xoa.Name = "button_kh_xoa";
            button_kh_xoa.Size = new Size(175, 80);
            button_kh_xoa.TabIndex = 12;
            button_kh_xoa.Text = "XÓA";
            button_kh_xoa.TextAlign = ContentAlignment.MiddleRight;
            button_kh_xoa.UseVisualStyleBackColor = false;
            button_kh_xoa.Click += button_kh_xoa_Click;
            // 
            // button_kh_huybo
            // 
            button_kh_huybo.BackColor = Color.Transparent;
            button_kh_huybo.FlatAppearance.BorderColor = Color.Tan;
            button_kh_huybo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_kh_huybo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_kh_huybo.FlatStyle = FlatStyle.Flat;
            button_kh_huybo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_kh_huybo.ForeColor = Color.Lime;
            button_kh_huybo.Image = Properties.Resources._1439854729_DeleteRed1;
            button_kh_huybo.ImageAlign = ContentAlignment.MiddleLeft;
            button_kh_huybo.Location = new Point(1496, 311);
            button_kh_huybo.Margin = new Padding(4, 5, 4, 5);
            button_kh_huybo.Name = "button_kh_huybo";
            button_kh_huybo.Size = new Size(175, 80);
            button_kh_huybo.TabIndex = 13;
            button_kh_huybo.Text = "HỦY BỎ";
            button_kh_huybo.TextAlign = ContentAlignment.MiddleRight;
            button_kh_huybo.UseVisualStyleBackColor = false;
            button_kh_huybo.Click += button_kh_thoat_Click;
            // 
            // textBox_kh_tenkh
            // 
            textBox_kh_tenkh.BackColor = Color.White;
            textBox_kh_tenkh.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_kh_tenkh.ForeColor = Color.Blue;
            textBox_kh_tenkh.Location = new Point(272, 98);
            textBox_kh_tenkh.Margin = new Padding(4, 5, 4, 5);
            textBox_kh_tenkh.Multiline = true;
            textBox_kh_tenkh.Name = "textBox_kh_tenkh";
            textBox_kh_tenkh.Size = new Size(345, 40);
            textBox_kh_tenkh.TabIndex = 3;
            // 
            // textBox_kh_sdt
            // 
            textBox_kh_sdt.BackColor = Color.White;
            textBox_kh_sdt.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_kh_sdt.ForeColor = Color.Blue;
            textBox_kh_sdt.Location = new Point(865, 31);
            textBox_kh_sdt.Margin = new Padding(4, 5, 4, 5);
            textBox_kh_sdt.MaxLength = 11;
            textBox_kh_sdt.Multiline = true;
            textBox_kh_sdt.Name = "textBox_kh_sdt";
            textBox_kh_sdt.Size = new Size(345, 40);
            textBox_kh_sdt.TabIndex = 2;
            textBox_kh_sdt.TextChanged += textBox3_TextChanged;
            textBox_kh_sdt.KeyPress += textBox_kh_sdt_KeyPress;
            // 
            // textBox_kh_dc
            // 
            textBox_kh_dc.BackColor = Color.White;
            textBox_kh_dc.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_kh_dc.ForeColor = Color.Blue;
            textBox_kh_dc.Location = new Point(865, 107);
            textBox_kh_dc.Margin = new Padding(4, 5, 4, 5);
            textBox_kh_dc.Multiline = true;
            textBox_kh_dc.Name = "textBox_kh_dc";
            textBox_kh_dc.Size = new Size(345, 40);
            textBox_kh_dc.TabIndex = 4;
            // 
            // label_kh_tenkh
            // 
            label_kh_tenkh.AutoSize = true;
            label_kh_tenkh.BackColor = Color.Transparent;
            label_kh_tenkh.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_kh_tenkh.ForeColor = Color.Brown;
            label_kh_tenkh.Location = new Point(31, 99);
            label_kh_tenkh.Margin = new Padding(4, 0, 4, 0);
            label_kh_tenkh.Name = "label_kh_tenkh";
            label_kh_tenkh.Size = new Size(222, 31);
            label_kh_tenkh.TabIndex = 11;
            label_kh_tenkh.Text = "Tên khách hàng";
            label_kh_tenkh.Click += label2_Click;
            // 
            // label_kh_sdt
            // 
            label_kh_sdt.AutoSize = true;
            label_kh_sdt.BackColor = Color.Transparent;
            label_kh_sdt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_kh_sdt.ForeColor = Color.Brown;
            label_kh_sdt.Location = new Point(673, 32);
            label_kh_sdt.Margin = new Padding(4, 0, 4, 0);
            label_kh_sdt.Name = "label_kh_sdt";
            label_kh_sdt.Size = new Size(184, 31);
            label_kh_sdt.TabIndex = 12;
            label_kh_sdt.Text = "Số điện thoại";
            // 
            // label_kh_dc
            // 
            label_kh_dc.AutoSize = true;
            label_kh_dc.BackColor = Color.Transparent;
            label_kh_dc.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_kh_dc.ForeColor = Color.Brown;
            label_kh_dc.Location = new Point(673, 107);
            label_kh_dc.Margin = new Padding(4, 0, 4, 0);
            label_kh_dc.Name = "label_kh_dc";
            label_kh_dc.Size = new Size(104, 31);
            label_kh_dc.TabIndex = 13;
            label_kh_dc.Text = "Địa chỉ";
            // 
            // button_kh_tc
            // 
            button_kh_tc.BackColor = Color.Transparent;
            button_kh_tc.Cursor = Cursors.Hand;
            button_kh_tc.FlatAppearance.BorderColor = Color.Tan;
            button_kh_tc.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_kh_tc.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_kh_tc.FlatStyle = FlatStyle.Flat;
            button_kh_tc.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_kh_tc.ForeColor = Color.Lime;
            button_kh_tc.Image = Properties.Resources._48px_Crystal_Clear_action_reload;
            button_kh_tc.Location = new Point(1679, 311);
            button_kh_tc.Margin = new Padding(4, 5, 4, 5);
            button_kh_tc.Name = "button_kh_tc";
            button_kh_tc.Size = new Size(113, 80);
            button_kh_tc.TabIndex = 14;
            button_kh_tc.UseVisualStyleBackColor = false;
            button_kh_tc.Click += button_kh_tc_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(31, 314);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 29);
            label1.TabIndex = 83;
            label1.Text = "Tìm kiếm :";
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
            comboBox_timkiem.Location = new Point(291, 314);
            comboBox_timkiem.Margin = new Padding(4, 5, 4, 5);
            comboBox_timkiem.Name = "comboBox_timkiem";
            comboBox_timkiem.Size = new Size(285, 38);
            comboBox_timkiem.TabIndex = 7;
            // 
            // button_timkiem
            // 
            button_timkiem.BackColor = Color.Gray;
            button_timkiem.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            button_timkiem.FlatStyle = FlatStyle.Flat;
            button_timkiem.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_timkiem.ForeColor = Color.Red;
            button_timkiem.Image = Properties.Resources._1438980118_search_icon_tm;
            button_timkiem.Location = new Point(619, 318);
            button_timkiem.Margin = new Padding(4, 5, 4, 5);
            button_timkiem.Name = "button_timkiem";
            button_timkiem.Size = new Size(100, 66);
            button_timkiem.TabIndex = 8;
            button_timkiem.UseVisualStyleBackColor = false;
            button_timkiem.Click += button_timkiem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(31, 32);
            label2.Name = "label2";
            label2.Size = new Size(220, 31);
            label2.TabIndex = 86;
            label2.Text = "Mã Khách Hàng";
            // 
            // textBox_kh_makh
            // 
            textBox_kh_makh.BackColor = Color.White;
            textBox_kh_makh.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_kh_makh.ForeColor = Color.Blue;
            textBox_kh_makh.Location = new Point(272, 31);
            textBox_kh_makh.Margin = new Padding(4, 5, 4, 5);
            textBox_kh_makh.Multiline = true;
            textBox_kh_makh.Name = "textBox_kh_makh";
            textBox_kh_makh.Size = new Size(345, 40);
            textBox_kh_makh.TabIndex = 1;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label_email.ForeColor = Color.Brown;
            label_email.Location = new Point(31, 170);
            label_email.Name = "label_email";
            label_email.Size = new Size(86, 31);
            label_email.TabIndex = 88;
            label_email.Text = "Email";
            // 
            // textBox_kh_emailkh
            // 
            textBox_kh_emailkh.BackColor = Color.White;
            textBox_kh_emailkh.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_kh_emailkh.ForeColor = Color.Blue;
            textBox_kh_emailkh.Location = new Point(272, 170);
            textBox_kh_emailkh.Margin = new Padding(4, 5, 4, 5);
            textBox_kh_emailkh.Multiline = true;
            textBox_kh_emailkh.Name = "textBox_kh_emailkh";
            textBox_kh_emailkh.Size = new Size(345, 40);
            textBox_kh_emailkh.TabIndex = 5;
            // 
            // comboBox_kh_gioitinh
            // 
            comboBox_kh_gioitinh.FormattingEnabled = true;
            comboBox_kh_gioitinh.Location = new Point(865, 177);
            comboBox_kh_gioitinh.Name = "comboBox_kh_gioitinh";
            comboBox_kh_gioitinh.Size = new Size(345, 28);
            comboBox_kh_gioitinh.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(673, 179);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 91;
            label3.Text = "Giới tính";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.DarkGray;
            richTextBox1.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.Brown;
            richTextBox1.Location = new Point(1314, 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.Size = new Size(478, 187);
            richTextBox1.TabIndex = 92;
            richTextBox1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1800, 1055);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(comboBox_kh_gioitinh);
            Controls.Add(textBox_kh_emailkh);
            Controls.Add(label_email);
            Controls.Add(textBox_kh_makh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_timkiem);
            Controls.Add(button_timkiem);
            Controls.Add(button_kh_tc);
            Controls.Add(label_kh_dc);
            Controls.Add(label_kh_sdt);
            Controls.Add(label_kh_tenkh);
            Controls.Add(textBox_kh_dc);
            Controls.Add(textBox_kh_sdt);
            Controls.Add(textBox_kh_tenkh);
            Controls.Add(button_kh_huybo);
            Controls.Add(button_kh_xoa);
            Controls.Add(button_kh_sua);
            Controls.Add(button_kh_luu);
            Controls.Add(button_kh_them);
            Controls.Add(dataGridView_kh);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "KhachHang";
            Text = "KHÁCH HÀNG";
            Load += KhachHang_Load;
            Click += button_kh_thoat_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView_kh).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_kh;
        private System.Windows.Forms.Button button_kh_them;
        private System.Windows.Forms.Button button_kh_luu;
        private System.Windows.Forms.Button button_kh_sua;
        private System.Windows.Forms.Button button_kh_xoa;
        private System.Windows.Forms.Button button_kh_huybo;
        private System.Windows.Forms.TextBox textBox_kh_tenkh;
        private System.Windows.Forms.TextBox textBox_kh_sdt;
        private System.Windows.Forms.TextBox textBox_kh_dc;
        private System.Windows.Forms.Label label_kh_tenkh;
        private System.Windows.Forms.Label label_kh_sdt;
        private System.Windows.Forms.Label label_kh_dc;
        private System.Windows.Forms.Button button_kh_tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_timkiem;
        private System.Windows.Forms.Button button_timkiem;
        private Label label2;
        private TextBox textBox_kh_makh;
        private Label label_email;
        private TextBox textBox_kh_emailkh;
        private ComboBox comboBox_kh_gioitinh;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn GioiTinh;
        private RichTextBox richTextBox1;
    }
}