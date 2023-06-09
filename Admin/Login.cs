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

namespace Admin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            GlobalConnect.Connect();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            if (taikhoan.Text == "Admin" && matkhau.Text == "Admin")
            {
                MainForm mf = new MainForm();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}

// Class kết nối tổng.
public static class GlobalConnect
{
    static IPAddress ip = IPAddress.Parse("127.0.0.1");
    static IPEndPoint ipep = new IPEndPoint(ip, 9090);
    public static Socket svcn = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

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
        }
        catch (Exception)
        {
            MessageBox.Show("Cant connect to server");
        }
    }
}
