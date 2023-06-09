using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class ThongKeForm : Form
    {
        string chinhanh = "";
        public ThongKeForm(string chinhanhh)
        {
            InitializeComponent();
            this.chinhanh = chinhanhh;
        }

        private void ThongKeForm_Load(object sender, EventArgs e)
        {
            LoadThongKe("ThongKe");
        }

        void LoadThongKe(string key)
        {
            List<ThongKe> l = new List<ThongKe>();
            if (key == "LocThongKe")
            {
                string from = dateTime_From.Value.ToString("dd/MM/yyyy");
                string to = dateTime_To.Value.ToString("dd/MM/yyyy");
                GlobalConnect.SendData(GlobalConnect.svcn, key + "-" + chinhanh + "-" + from + "-" + to);
            }
            else
            {
                GlobalConnect.SendData(GlobalConnect.svcn, key + "-" + chinhanh);
            }
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
            dataGridView_thongke.DataSource = l;
            tongtien.Text = string.Format("{0:#,###}", tongTien).ToString();
        }

        private void tatca_Click(object sender, EventArgs e)
        {
            LoadThongKe("ThongKe");
        }

        private void homnay_Click(object sender, EventArgs e)
        {
            LoadThongKe("ThongKeHomNay");
        }

        private void homqua_Click(object sender, EventArgs e)
        {
            LoadThongKe("ThongKeHomQua");
        }

        private void thangnay_Click(object sender, EventArgs e)
        {
            LoadThongKe("ThongKeThangNay");
        }

        private void thangtruoc_Click(object sender, EventArgs e)
        {
            LoadThongKe("ThongKeThangTruoc");
        }

        private void loc_Click(object sender, EventArgs e)
        {
            LoadThongKe("LocThongKe");
            //MessageBox.Show(dateTime_From.Value.ToString("dd/MM/yyyy"));
            //MessageBox.Show(dateTime_To.Value.ToString("dd/MM/yyyy"));
        }

        private void comboBox_sapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
