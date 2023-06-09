namespace Admin
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.thongke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_chinhanh = new System.Windows.Forms.ComboBox();
            this.taikhoan = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.themtaikhoan = new System.Windows.Forms.Button();
            this.xoataikhoan = new System.Windows.Forms.Button();
            this.taikhoanxoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_xoataikhoan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_taikhoan = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_loadtaikhoan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_taikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // thongke
            // 
            this.thongke.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongke.Location = new System.Drawing.Point(12, 12);
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(100, 36);
            this.thongke.TabIndex = 0;
            this.thongke.Text = "Thống Kê";
            this.thongke.UseVisualStyleBackColor = true;
            this.thongke.Click += new System.EventHandler(this.thongke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài Khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu:";
            // 
            // comboBox_chinhanh
            // 
            this.comboBox_chinhanh.FormattingEnabled = true;
            this.comboBox_chinhanh.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox_chinhanh.Location = new System.Drawing.Point(423, 83);
            this.comboBox_chinhanh.Name = "comboBox_chinhanh";
            this.comboBox_chinhanh.Size = new System.Drawing.Size(36, 21);
            this.comboBox_chinhanh.TabIndex = 4;
            // 
            // taikhoan
            // 
            this.taikhoan.Location = new System.Drawing.Point(343, 115);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(116, 20);
            this.taikhoan.TabIndex = 5;
            // 
            // matkhau
            // 
            this.matkhau.Location = new System.Drawing.Point(343, 149);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(116, 20);
            this.matkhau.TabIndex = 6;
            // 
            // themtaikhoan
            // 
            this.themtaikhoan.Location = new System.Drawing.Point(331, 187);
            this.themtaikhoan.Name = "themtaikhoan";
            this.themtaikhoan.Size = new System.Drawing.Size(101, 23);
            this.themtaikhoan.TabIndex = 7;
            this.themtaikhoan.Text = "Thêm Tài Khoản";
            this.themtaikhoan.UseVisualStyleBackColor = true;
            this.themtaikhoan.Click += new System.EventHandler(this.themtaikhoan_Click);
            // 
            // xoataikhoan
            // 
            this.xoataikhoan.Location = new System.Drawing.Point(331, 324);
            this.xoataikhoan.Name = "xoataikhoan";
            this.xoataikhoan.Size = new System.Drawing.Size(101, 23);
            this.xoataikhoan.TabIndex = 10;
            this.xoataikhoan.Text = "Xoá Tài Khoản";
            this.xoataikhoan.UseVisualStyleBackColor = true;
            this.xoataikhoan.Click += new System.EventHandler(this.xoataikhoan_Click);
            // 
            // taikhoanxoa
            // 
            this.taikhoanxoa.Location = new System.Drawing.Point(343, 289);
            this.taikhoanxoa.Name = "taikhoanxoa";
            this.taikhoanxoa.Size = new System.Drawing.Size(116, 20);
            this.taikhoanxoa.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tài Khoản";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox_xoataikhoan
            // 
            this.comboBox_xoataikhoan.FormattingEnabled = true;
            this.comboBox_xoataikhoan.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox_xoataikhoan.Location = new System.Drawing.Point(423, 257);
            this.comboBox_xoataikhoan.Name = "comboBox_xoataikhoan";
            this.comboBox_xoataikhoan.Size = new System.Drawing.Size(36, 21);
            this.comboBox_xoataikhoan.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chi Nhánh:";
            // 
            // dataGridView_taikhoan
            // 
            this.dataGridView_taikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_taikhoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_taikhoan.Location = new System.Drawing.Point(2, 118);
            this.dataGridView_taikhoan.Name = "dataGridView_taikhoan";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_taikhoan.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_taikhoan.Size = new System.Drawing.Size(255, 258);
            this.dataGridView_taikhoan.TabIndex = 15;
            this.dataGridView_taikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_taikhoan_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tài Khoản Chi Nhánh";
            // 
            // comboBox_loadtaikhoan
            // 
            this.comboBox_loadtaikhoan.FormattingEnabled = true;
            this.comboBox_loadtaikhoan.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox_loadtaikhoan.Location = new System.Drawing.Point(115, 94);
            this.comboBox_loadtaikhoan.Name = "comboBox_loadtaikhoan";
            this.comboBox_loadtaikhoan.Size = new System.Drawing.Size(39, 21);
            this.comboBox_loadtaikhoan.TabIndex = 16;
            this.comboBox_loadtaikhoan.SelectedIndexChanged += new System.EventHandler(this.comboBox_loadtaikhoan_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 388);
            this.Controls.Add(this.comboBox_loadtaikhoan);
            this.Controls.Add(this.dataGridView_taikhoan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_xoataikhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xoataikhoan);
            this.Controls.Add(this.taikhoanxoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.themtaikhoan);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.taikhoan);
            this.Controls.Add(this.comboBox_chinhanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thongke);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_taikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button thongke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_chinhanh;
        private System.Windows.Forms.TextBox taikhoan;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Button themtaikhoan;
        private System.Windows.Forms.Button xoataikhoan;
        private System.Windows.Forms.TextBox taikhoanxoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_xoataikhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_taikhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_loadtaikhoan;
    }
}