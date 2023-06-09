namespace Client
{
    partial class ChatForm
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
            this.submit = new System.Windows.Forms.Button();
            this.noidung_chat = new System.Windows.Forms.TextBox();
            this.list_Message = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(12, 405);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(77, 28);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // noidung_chat
            // 
            this.noidung_chat.Location = new System.Drawing.Point(95, 405);
            this.noidung_chat.Multiline = true;
            this.noidung_chat.Name = "noidung_chat";
            this.noidung_chat.Size = new System.Drawing.Size(388, 28);
            this.noidung_chat.TabIndex = 1;
            // 
            // list_Message
            // 
            this.list_Message.FormattingEnabled = true;
            this.list_Message.Location = new System.Drawing.Point(12, 13);
            this.list_Message.Name = "list_Message";
            this.list_Message.Size = new System.Drawing.Size(471, 381);
            this.list_Message.TabIndex = 2;
            // 
            // ChatForm
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 442);
            this.Controls.Add(this.list_Message);
            this.Controls.Add(this.noidung_chat);
            this.Controls.Add(this.submit);
            this.Name = "ChatForm";
            this.Text = "Chatting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox noidung_chat;
        private System.Windows.Forms.ListBox list_Message;
    }
}