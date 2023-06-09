namespace Client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guixe = new System.Windows.Forms.Button();
            this.traxe = new System.Windows.Forms.Button();
            this.chat = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.thongke = new System.Windows.Forms.Button();
            this.hello = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tenxe = new System.Windows.Forms.TextBox();
            this.biensoxe = new System.Windows.Forms.TextBox();
            this.biensoxetra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sotien = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guixe
            // 
            this.guixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guixe.Location = new System.Drawing.Point(641, 230);
            this.guixe.Name = "guixe";
            this.guixe.Size = new System.Drawing.Size(75, 28);
            this.guixe.TabIndex = 2;
            this.guixe.Text = "Gửi Xe";
            this.guixe.UseVisualStyleBackColor = true;
            this.guixe.Click += new System.EventHandler(this.guixe_Click);
            // 
            // traxe
            // 
            this.traxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traxe.Location = new System.Drawing.Point(641, 388);
            this.traxe.Name = "traxe";
            this.traxe.Size = new System.Drawing.Size(75, 29);
            this.traxe.TabIndex = 3;
            this.traxe.Text = "Trả Xe";
            this.traxe.UseVisualStyleBackColor = true;
            this.traxe.Click += new System.EventHandler(this.traxe_Click);
            // 
            // chat
            // 
            this.chat.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chat.Location = new System.Drawing.Point(683, 22);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(105, 40);
            this.chat.TabIndex = 4;
            this.chat.Text = "Chatting";
            this.chat.UseVisualStyleBackColor = true;
            this.chat.Click += new System.EventHandler(this.chat_Click);
            // 
            // timkiem
            // 
            this.timkiem.AutoSize = true;
            this.timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem.Location = new System.Drawing.Point(422, 85);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(81, 26);
            this.timkiem.TabIndex = 5;
            this.timkiem.Text = "Tìm Kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.tim_Click);
            // 
            // thongke
            // 
            this.thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongke.Location = new System.Drawing.Point(422, 36);
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(81, 27);
            this.thongke.TabIndex = 6;
            this.thongke.Text = "Thống Kê";
            this.thongke.UseVisualStyleBackColor = true;
            this.thongke.Click += new System.EventHandler(this.thongke_Click);
            // 
            // hello
            // 
            this.hello.AutoSize = true;
            this.hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello.Location = new System.Drawing.Point(12, 9);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(39, 24);
            this.hello.TabIndex = 7;
            this.hello.Text = "text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Xe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Biển Số Xe:";
            // 
            // tenxe
            // 
            this.tenxe.Location = new System.Drawing.Point(595, 154);
            this.tenxe.Name = "tenxe";
            this.tenxe.Size = new System.Drawing.Size(173, 20);
            this.tenxe.TabIndex = 11;
            // 
            // biensoxe
            // 
            this.biensoxe.Location = new System.Drawing.Point(595, 195);
            this.biensoxe.Name = "biensoxe";
            this.biensoxe.Size = new System.Drawing.Size(173, 20);
            this.biensoxe.TabIndex = 13;
            // 
            // biensoxetra
            // 
            this.biensoxetra.Location = new System.Drawing.Point(595, 352);
            this.biensoxetra.Name = "biensoxetra";
            this.biensoxetra.Size = new System.Drawing.Size(173, 20);
            this.biensoxetra.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Biển Số Xe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Số Tiền:";
            // 
            // sotien
            // 
            this.sotien.AutoSize = true;
            this.sotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sotien.Location = new System.Drawing.Point(661, 442);
            this.sotien.Name = "sotien";
            this.sotien.Size = new System.Drawing.Size(16, 18);
            this.sotien.TabIndex = 17;
            this.sotien.Text = "0";
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.Control;
            this.refresh.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(0, 83);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(77, 35);
            this.refresh.TabIndex = 18;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tìm kiếm biển số xe";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(255, 89);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(161, 20);
            this.txt_timkiem.TabIndex = 20;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 115);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(503, 365);
            this.dataGridView.TabIndex = 21;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sotien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.biensoxetra);
            this.Controls.Add(this.biensoxe);
            this.Controls.Add(this.tenxe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hello);
            this.Controls.Add(this.thongke);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.traxe);
            this.Controls.Add(this.guixe);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button guixe;
        private System.Windows.Forms.Button traxe;
        private System.Windows.Forms.Button chat;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button thongke;
        private System.Windows.Forms.Label hello;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenxe;
        private System.Windows.Forms.TextBox biensoxe;
        private System.Windows.Forms.TextBox biensoxetra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sotien;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}