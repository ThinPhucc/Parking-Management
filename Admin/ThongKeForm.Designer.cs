namespace Admin
{
    partial class ThongKeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox_chiNhanh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tongtien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loc = new System.Windows.Forms.Button();
            this.dateTime_To = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_From = new System.Windows.Forms.DateTimePicker();
            this.thangtruoc = new System.Windows.Forms.Button();
            this.homqua = new System.Windows.Forms.Button();
            this.thangnay = new System.Windows.Forms.Button();
            this.homnay = new System.Windows.Forms.Button();
            this.tatca = new System.Windows.Forms.Button();
            this.dataGridView_thongke = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.timxe = new System.Windows.Forms.TextBox();
            this.btntimxe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_chiNhanh
            // 
            this.comboBox_chiNhanh.FormattingEnabled = true;
            this.comboBox_chiNhanh.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox_chiNhanh.Location = new System.Drawing.Point(749, 76);
            this.comboBox_chiNhanh.Name = "comboBox_chiNhanh";
            this.comboBox_chiNhanh.Size = new System.Drawing.Size(50, 21);
            this.comboBox_chiNhanh.TabIndex = 31;
            this.comboBox_chiNhanh.SelectedIndexChanged += new System.EventHandler(this.comboBox_chiNhanh_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(680, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Chi Nhánh:";
            // 
            // tongtien
            // 
            this.tongtien.AutoSize = true;
            this.tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtien.Location = new System.Drawing.Point(670, 438);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(51, 20);
            this.tongtien.TabIndex = 29;
            this.tongtien.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tổng tiền:";
            // 
            // loc
            // 
            this.loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc.Location = new System.Drawing.Point(489, 67);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(75, 23);
            this.loc.TabIndex = 27;
            this.loc.Text = "Lọc";
            this.loc.UseVisualStyleBackColor = true;
            this.loc.Click += new System.EventHandler(this.loc_Click);
            // 
            // dateTime_To
            // 
            this.dateTime_To.CustomFormat = "dd/MM/yyyy";
            this.dateTime_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_To.Location = new System.Drawing.Point(559, 39);
            this.dateTime_To.MinDate = new System.DateTime(2001, 6, 24, 0, 0, 0, 0);
            this.dateTime_To.Name = "dateTime_To";
            this.dateTime_To.Size = new System.Drawing.Size(98, 20);
            this.dateTime_To.TabIndex = 26;
            this.dateTime_To.Value = new System.DateTime(2021, 12, 20, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Lựa chọn lọc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "From:";
            // 
            // dateTime_From
            // 
            this.dateTime_From.CustomFormat = "dd/MM/yyyy";
            this.dateTime_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_From.Location = new System.Drawing.Point(413, 39);
            this.dateTime_From.MinDate = new System.DateTime(2010, 5, 25, 0, 0, 0, 0);
            this.dateTime_From.Name = "dateTime_From";
            this.dateTime_From.Size = new System.Drawing.Size(98, 20);
            this.dateTime_From.TabIndex = 22;
            this.dateTime_From.Value = new System.DateTime(2021, 12, 20, 0, 0, 0, 0);
            // 
            // thangtruoc
            // 
            this.thangtruoc.AutoSize = true;
            this.thangtruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thangtruoc.Location = new System.Drawing.Point(204, 43);
            this.thangtruoc.Name = "thangtruoc";
            this.thangtruoc.Size = new System.Drawing.Size(95, 26);
            this.thangtruoc.TabIndex = 21;
            this.thangtruoc.Text = "Tháng Trước";
            this.thangtruoc.UseVisualStyleBackColor = true;
            this.thangtruoc.Click += new System.EventHandler(this.thangtruoc_Click);
            // 
            // homqua
            // 
            this.homqua.AutoSize = true;
            this.homqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homqua.Location = new System.Drawing.Point(113, 43);
            this.homqua.Name = "homqua";
            this.homqua.Size = new System.Drawing.Size(75, 26);
            this.homqua.TabIndex = 20;
            this.homqua.Text = "Hôm Qua";
            this.homqua.UseVisualStyleBackColor = true;
            this.homqua.Click += new System.EventHandler(this.homqua_Click);
            // 
            // thangnay
            // 
            this.thangnay.AutoSize = true;
            this.thangnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thangnay.Location = new System.Drawing.Point(204, 11);
            this.thangnay.Name = "thangnay";
            this.thangnay.Size = new System.Drawing.Size(95, 26);
            this.thangnay.TabIndex = 19;
            this.thangnay.Text = "Tháng Này";
            this.thangnay.UseVisualStyleBackColor = true;
            this.thangnay.Click += new System.EventHandler(this.thangnay_Click);
            // 
            // homnay
            // 
            this.homnay.AutoSize = true;
            this.homnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homnay.Location = new System.Drawing.Point(113, 11);
            this.homnay.Name = "homnay";
            this.homnay.Size = new System.Drawing.Size(75, 26);
            this.homnay.TabIndex = 18;
            this.homnay.Text = "Hôm Nay";
            this.homnay.UseVisualStyleBackColor = true;
            this.homnay.Click += new System.EventHandler(this.homnay_Click);
            // 
            // tatca
            // 
            this.tatca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tatca.Location = new System.Drawing.Point(12, 12);
            this.tatca.Name = "tatca";
            this.tatca.Size = new System.Drawing.Size(80, 40);
            this.tatca.TabIndex = 17;
            this.tatca.Text = "Tất Cả";
            this.tatca.UseVisualStyleBackColor = true;
            this.tatca.Click += new System.EventHandler(this.tatca_Click);
            // 
            // dataGridView_thongke
            // 
            this.dataGridView_thongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_thongke.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_thongke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_thongke.Location = new System.Drawing.Point(0, 96);
            this.dataGridView_thongke.Name = "dataGridView_thongke";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_thongke.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_thongke.Size = new System.Drawing.Size(800, 334);
            this.dataGridView_thongke.TabIndex = 16;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(4, 77);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 32;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // timxe
            // 
            this.timxe.Location = new System.Drawing.Point(72, 438);
            this.timxe.Name = "timxe";
            this.timxe.Size = new System.Drawing.Size(156, 20);
            this.timxe.TabIndex = 34;
            // 
            // btntimxe
            // 
            this.btntimxe.Location = new System.Drawing.Point(12, 436);
            this.btntimxe.Name = "btntimxe";
            this.btntimxe.Size = new System.Drawing.Size(54, 23);
            this.btntimxe.TabIndex = 35;
            this.btntimxe.Text = "Tìm Xe:";
            this.btntimxe.UseVisualStyleBackColor = true;
            this.btntimxe.Click += new System.EventHandler(this.btntimxe_Click);
            // 
            // ThongKeForm
            // 
            this.AcceptButton = this.btntimxe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.btntimxe);
            this.Controls.Add(this.timxe);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.comboBox_chiNhanh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tongtien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.dateTime_To);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime_From);
            this.Controls.Add(this.thangtruoc);
            this.Controls.Add(this.homqua);
            this.Controls.Add(this.thangnay);
            this.Controls.Add(this.homnay);
            this.Controls.Add(this.tatca);
            this.Controls.Add(this.dataGridView_thongke);
            this.Name = "ThongKeForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_chiNhanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tongtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loc;
        private System.Windows.Forms.DateTimePicker dateTime_To;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime_From;
        private System.Windows.Forms.Button thangtruoc;
        private System.Windows.Forms.Button homqua;
        private System.Windows.Forms.Button thangnay;
        private System.Windows.Forms.Button homnay;
        private System.Windows.Forms.Button tatca;
        private System.Windows.Forms.DataGridView dataGridView_thongke;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox timxe;
        private System.Windows.Forms.Button btntimxe;
    }
}