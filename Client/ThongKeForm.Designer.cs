namespace Client
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
            this.dataGridView_thongke = new System.Windows.Forms.DataGridView();
            this.tatca = new System.Windows.Forms.Button();
            this.homnay = new System.Windows.Forms.Button();
            this.thangnay = new System.Windows.Forms.Button();
            this.homqua = new System.Windows.Forms.Button();
            this.thangtruoc = new System.Windows.Forms.Button();
            this.dateTime_From = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTime_To = new System.Windows.Forms.DateTimePicker();
            this.loc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tongtien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_sapXep = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongke)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_thongke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_thongke.Location = new System.Drawing.Point(0, 106);
            this.dataGridView_thongke.Name = "dataGridView_thongke";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_thongke.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_thongke.Size = new System.Drawing.Size(800, 330);
            this.dataGridView_thongke.TabIndex = 0;
            // 
            // tatca
            // 
            this.tatca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tatca.Location = new System.Drawing.Point(10, 27);
            this.tatca.Name = "tatca";
            this.tatca.Size = new System.Drawing.Size(80, 40);
            this.tatca.TabIndex = 1;
            this.tatca.Text = "Tất Cả";
            this.tatca.UseVisualStyleBackColor = true;
            this.tatca.Click += new System.EventHandler(this.tatca_Click);
            // 
            // homnay
            // 
            this.homnay.AutoSize = true;
            this.homnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homnay.Location = new System.Drawing.Point(113, 17);
            this.homnay.Name = "homnay";
            this.homnay.Size = new System.Drawing.Size(75, 26);
            this.homnay.TabIndex = 2;
            this.homnay.Text = "Hôm Nay";
            this.homnay.UseVisualStyleBackColor = true;
            this.homnay.Click += new System.EventHandler(this.homnay_Click);
            // 
            // thangnay
            // 
            this.thangnay.AutoSize = true;
            this.thangnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thangnay.Location = new System.Drawing.Point(204, 17);
            this.thangnay.Name = "thangnay";
            this.thangnay.Size = new System.Drawing.Size(95, 26);
            this.thangnay.TabIndex = 3;
            this.thangnay.Text = "Tháng Này";
            this.thangnay.UseVisualStyleBackColor = true;
            this.thangnay.Click += new System.EventHandler(this.thangnay_Click);
            // 
            // homqua
            // 
            this.homqua.AutoSize = true;
            this.homqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homqua.Location = new System.Drawing.Point(113, 49);
            this.homqua.Name = "homqua";
            this.homqua.Size = new System.Drawing.Size(75, 26);
            this.homqua.TabIndex = 4;
            this.homqua.Text = "Hôm Qua";
            this.homqua.UseVisualStyleBackColor = true;
            this.homqua.Click += new System.EventHandler(this.homqua_Click);
            // 
            // thangtruoc
            // 
            this.thangtruoc.AutoSize = true;
            this.thangtruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thangtruoc.Location = new System.Drawing.Point(204, 49);
            this.thangtruoc.Name = "thangtruoc";
            this.thangtruoc.Size = new System.Drawing.Size(95, 26);
            this.thangtruoc.TabIndex = 5;
            this.thangtruoc.Text = "Tháng Trước";
            this.thangtruoc.UseVisualStyleBackColor = true;
            this.thangtruoc.Click += new System.EventHandler(this.thangtruoc_Click);
            // 
            // dateTime_From
            // 
            this.dateTime_From.CustomFormat = "dd/MM/yyyy";
            this.dateTime_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_From.Location = new System.Drawing.Point(519, 46);
            this.dateTime_From.MinDate = new System.DateTime(2010, 5, 25, 0, 0, 0, 0);
            this.dateTime_From.Name = "dateTime_From";
            this.dateTime_From.Size = new System.Drawing.Size(98, 20);
            this.dateTime_From.TabIndex = 6;
            this.dateTime_From.Value = new System.DateTime(2021, 12, 18, 0, 18, 58, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(605, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lựa chọn lọc:";
            // 
            // dateTime_To
            // 
            this.dateTime_To.CustomFormat = "dd/MM/yyyy";
            this.dateTime_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_To.Location = new System.Drawing.Point(689, 46);
            this.dateTime_To.MinDate = new System.DateTime(2001, 6, 24, 0, 0, 0, 0);
            this.dateTime_To.Name = "dateTime_To";
            this.dateTime_To.Size = new System.Drawing.Size(98, 20);
            this.dateTime_To.TabIndex = 10;
            this.dateTime_To.Value = new System.DateTime(2021, 12, 18, 0, 18, 43, 0);
            // 
            // loc
            // 
            this.loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc.Location = new System.Drawing.Point(608, 73);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(75, 23);
            this.loc.TabIndex = 11;
            this.loc.Text = "Lọc";
            this.loc.UseVisualStyleBackColor = true;
            this.loc.Click += new System.EventHandler(this.loc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tổng tiền:";
            // 
            // tongtien
            // 
            this.tongtien.AutoSize = true;
            this.tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtien.Location = new System.Drawing.Point(670, 444);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(51, 20);
            this.tongtien.TabIndex = 13;
            this.tongtien.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sắp Xếp:";
            // 
            // comboBox_sapXep
            // 
            this.comboBox_sapXep.FormattingEnabled = true;
            this.comboBox_sapXep.Items.AddRange(new object[] {
            "Theo Biển Số Xe",
            "Theo Số Tiền"});
            this.comboBox_sapXep.Location = new System.Drawing.Point(80, 444);
            this.comboBox_sapXep.Name = "comboBox_sapXep";
            this.comboBox_sapXep.Size = new System.Drawing.Size(108, 21);
            this.comboBox_sapXep.TabIndex = 15;
            this.comboBox_sapXep.SelectedIndexChanged += new System.EventHandler(this.comboBox_sapXep_SelectedIndexChanged);
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.comboBox_sapXep);
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
            this.Text = "ThongKeForm";
            this.Load += new System.EventHandler(this.ThongKeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_thongke;
        private System.Windows.Forms.Button tatca;
        private System.Windows.Forms.Button homnay;
        private System.Windows.Forms.Button thangnay;
        private System.Windows.Forms.Button homqua;
        private System.Windows.Forms.Button thangtruoc;
        private System.Windows.Forms.DateTimePicker dateTime_From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTime_To;
        private System.Windows.Forms.Button loc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_sapXep;
    }
}