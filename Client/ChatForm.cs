using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class ChatForm : Form
    {
        string ten, chinhanh;
        Thread t;

        public ChatForm(string tennn, string chinhanh)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.ten = tennn;
            this.chinhanh = chinhanh;
            t = new Thread(UpdateChat);
            t.Start();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (noidung_chat.Text == "")
            {
                return;
            }
            else
            {
                GlobalConnect.SendData(GlobalConnect.svcn2,"Chat-" + ten + "_ChiNhanh" + chinhanh + ": " + noidung_chat.Text);
                noidung_chat.Text = "";
            }
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            GlobalConnect.SendData(GlobalConnect.svcn, "LoadChat");
            string nhan = "";
            // Load tin nhắn cũ lên
            while (true)
            {
                nhan = GlobalConnect.RecieveData(GlobalConnect.svcn);
                if (nhan == "-1")
                {
                    break;
                }
                list_Message.Items.Add(nhan);
            }
        }

        /* Từ Winform 2003 trở đi, VS thêm tính năng Thread-Safe Calls. Chúng ta không thể truy suất các form, method của luồng chính từ 
           một luồng khác, trong trường hợp này, khi ta tạo luồng mới xử lý các tin nhắn tới từ các client khác, ta không có quyền 
           truy suất các form trong luồng hiện tại, đồng nghĩa ta không thể load dữ liệu lên các form của luồng hiện tại */
        /* Sử dụng InVoke để uỷ quyền truy cập form (xuyên luồng) cho thread. Thread gọi InVoke sẽ tạm thời có quyền khoá và
           truy cập sử dụng các phương thức, form của luồng khác, khi hết nhiệm vụ sẽ giải phóng lại form đó */
        void UpdateChat()
        {
            byte[] tmp = new byte[5000];
            int recv = 0;
            string nhan = "";
            while (t.IsAlive)
            {
                recv = GlobalConnect.svcn2.Receive(tmp);
                nhan = Encoding.Unicode.GetString(tmp, 0, recv);
                if (nhan == "-1")
                    break;
                //Invoke(new MethodInvoker
                //        (() => list_Message.Items.Add(nhan))
                //        );
                //this.list_Message.Items.Add(nhan);
                this.list_Message.Items.Add(nhan);
            }
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalConnect.SendData(GlobalConnect.svcn2, "EndChat");
        }
    }
}
