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

namespace Client
{
    public partial class MainForm : Form
    {
        private string ten;
        private string chinhanh;

        public MainForm(string tenn, string chinhanhh)
        {
            InitializeComponent();
            this.ten = tenn;
            this.chinhanh = chinhanhh;
        }

        public DateTime ParseDateTime(string date)
        {
            DateTime oDate = DateTime.ParseExact(date, "dd/MM/yyyy HH:mm tt", null);
            return oDate;
        }

        public void Update()
        {
            List<Info_Xe> l = new List<Info_Xe>();
            GlobalConnect.SendData(GlobalConnect.svcn, "AllXeGui-" + chinhanh);
            string nhan = "";
            while (true)
            {
                nhan = GlobalConnect.RecieveData(GlobalConnect.svcn);
                //MessageBox.Show(nhan);
                if (nhan == "-1")
                    break;
                string[] tmp = nhan.Split(',');
                string tenxe = tmp[1];
                string bienso = tmp[2];
                DateTime thoigian = ParseDateTime(tmp[3]);
                l.Add(new Info_Xe(tenxe, bienso, thoigian));
            }
            dataGridView.DataSource = l;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Update();
            hello.Text = "Xin chào: " + ten;
        }

        private void guixe_Click(object sender, EventArgs e)
        {
            string tenXe = tenxe.Text;
            string bienSoXe = biensoxe.Text;
            if (tenXe == "" || bienSoXe == "")
            {
                return;
            }
            else
            {
                string send = "AddXe" + "-" + chinhanh + "-" + "0" + "," + tenXe + "," + bienSoXe + "," + DateTime.Now.ToString("dd/MM/yyyy HH:mm tt");
                GlobalConnect.SendData(GlobalConnect.svcn, send);
                if (GlobalConnect.RecieveData(GlobalConnect.svcn) == "0")
                {
                    MessageBox.Show("Xe đã tồn tại");
                }
                tenxe.Text = "";
                biensoxe.Text = "";
                Update();
            }    
        }

        private void traxe_Click(object sender, EventArgs e)
        {
            string biensoxe = biensoxetra.Text;
            if (biensoxe == "")
            {
                return;
            }
            else
            {
                string send = "TraXe" + "-" + chinhanh + "-" + biensoxe;
                GlobalConnect.SendData(GlobalConnect.svcn, send);
                biensoxetra.Text = "";
                // Nhận về tiền và hiển thị lên
                string nhan = GlobalConnect.RecieveData(GlobalConnect.svcn);
                sotien.Text = string.Format("{0:#,###}", int.Parse(nhan));
                Update();
            }
        }

        private void chat_Click(object sender, EventArgs e)
        {
            ChatForm chatform = new ChatForm(ten, chinhanh);
            chatform.Show();
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            ThongKeForm tk = new ThongKeForm(chinhanh);
            tk.Show();
        }

        private void tim_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == null || txt_timkiem.Text == "")
                return;
            // Clear dữ liệu và định dạng đang có, để nó hiện đủ dữ liệu hoy
            dataGridView.DataSource = null;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            // Gửi yêu cầu và load dữ liệu
            string send = "TimXe" + "-" + chinhanh + "-" + txt_timkiem.Text;
            GlobalConnect.SendData(GlobalConnect.svcn, send);
            // Load dữ liệu
            List<ThongKe> l = new List<ThongKe>();
            string nhan = "";
            string TinhTrang, TenXe, BienSoXe, ThoiGianGui, ThoiGianNhan, SoTien;
            int tongTien = 0;
            while (true)
            {
                nhan = GlobalConnect.RecieveData(GlobalConnect.svcn);
                //MessageBox.Show(nhan);
                if (nhan == "-1")
                    break;
                string[] tmp = nhan.Split(',');
                // Ktra đang gửi hay đã trả. Nếu đang gửi thì không có dữ liệu về thời gian trả và tiền.
                if (tmp[0] == "0")
                {
                    TinhTrang = "Đang Gửi";
                    TenXe = tmp[1];
                    BienSoXe = tmp[2];
                    ThoiGianGui = tmp[3];
                    l.Add(new ThongKe(TinhTrang, TenXe, BienSoXe, ThoiGianGui, "", ""));
                    continue;
                }
                else
                {
                    TinhTrang = "Đã Trả";
                    TenXe = tmp[1];
                    BienSoXe = tmp[2];
                    ThoiGianGui = tmp[3];
                    ThoiGianNhan = tmp[4];
                    SoTien = string.Format("{0:#,###}", int.Parse(tmp[5])).ToString();
                    tongTien += int.Parse(tmp[5]);
                    l.Add(new ThongKe(TinhTrang, TenXe, BienSoXe, ThoiGianGui, ThoiGianNhan, SoTien));
                    continue;
                }
            }
            dataGridView.DataSource = l;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                biensoxetra.Text = dataGridView.Rows[e.RowIndex].Cells["BienSoXe"].FormattedValue.ToString();
            }
            else
                return;
        }
    }
}
