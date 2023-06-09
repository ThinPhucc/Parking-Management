using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            GlobalConnect.Connect();
        }
        
        private void login_Click(object sender, EventArgs e)
        {
            string tkhoan = taikhoan.Text;
            string passwd = matkhau.Text;
            string chinhanh = comboBox.Text;
            if (chinhanh == "")
            {
                MessageBox.Show("Chọn Chi Nhánh");
                return;
            }
            string send = "Login-" + chinhanh + "-" + tkhoan + "-" + passwd;
            GlobalConnect.SendData(GlobalConnect.svcn, send);
            string nhan = GlobalConnect.RecieveData(GlobalConnect.svcn);
            if (nhan == "0")
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
            }
            else
            {
                MainForm mf = new MainForm(tkhoan, chinhanh);
                mf.Show();
                this.Hide();
            }
        }
    }
}

// Tạo vùng kết nối tổng cho chương trình
public static class GlobalConnect 
{
    static IPAddress ip = IPAddress.Parse("127.0.0.1");
    static IPEndPoint ipep = new IPEndPoint(ip, 9090);
    public static Socket svcn = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    public static Socket svcn2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

    public static int SendData(Socket a, string send)
    {
        byte[] data = new byte[1024];
        data = Encoding.Unicode.GetBytes(send);
        int total = 0;
        int size = data.Length;
        int dataleft = size;
        int sent;
        byte[] datasize = new byte[4];
        datasize = BitConverter.GetBytes(size);
        sent = a.Send(datasize);
        while (total < size)
        {
            sent = a.Send(data, total, dataleft, SocketFlags.None);
            total += sent;
            dataleft -= sent;
        }
        return total;
    }

    public static string RecieveData(Socket a)
    {
        int recv, total = 0;
        byte[] datasize = new byte[4];
        recv = a.Receive(datasize, 0, 4, 0);
        int size = BitConverter.ToInt32(datasize, 0);
        int dataleft = size;
        byte[] data = new byte[size];
        while (total < size)
        {
            recv = a.Receive(data, total, dataleft, 0);
            if (recv == 0)
            {
                data = Encoding.Unicode.GetBytes("exit ");
                break;
            }
            total += recv;
            dataleft -= recv;
        }
        string nhan = Encoding.Unicode.GetString(data);
        return nhan;
    }

    public static void Connect()
    {
        try
        {
            svcn.Connect(ipep);
            SendData(svcn, "");
            svcn2.Connect(ipep);
            SendData(svcn2, "Chat");
        }
        catch (Exception)
        {
            MessageBox.Show("Cant connect to server");
        }
    }
}
