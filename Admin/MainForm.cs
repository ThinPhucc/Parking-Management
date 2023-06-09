using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Admin
{
    public partial class MainForm : Form
    {
        string chinhanh = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            ThongKeForm tkf = new ThongKeForm();
            tkf.Show();
        }

        private void themtaikhoan_Click(object sender, EventArgs e)
        {
            string tkhoan = taikhoan.Text;
            string passwd = matkhau.Text;
            string chinhanh = comboBox_chinhanh.Text;
            if (chinhanh == null || chinhanh == "")
                MessageBox.Show("Chọn chi nhánh");
            else
            {
                if (tkhoan == "" || passwd == "")
                    MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Được Bỏ Trống");
                else
                {
                    GlobalConnect.SendData(GlobalConnect.svcn, "ThemTaiKhoan-" + chinhanh + "-" + tkhoan + "-" + passwd);
                    taikhoan.Text = "";
                    matkhau.Text = "";
                    string nhan = GlobalConnect.RecieveData(GlobalConnect.svcn);
                    if (nhan == "0")
                        MessageBox.Show("Tài Khoản Đã Tồn Tại");
                    else
                        MessageBox.Show("Thêm Thành Công");
                }
            }
            LoadTaiKhoan();
        }

        private void xoataikhoan_Click(object sender, EventArgs e)
        {
            string tkhoan = taikhoanxoa.Text;
            string chinhanh = comboBox_xoataikhoan.Text;
            if (chinhanh == null || chinhanh == "")
                MessageBox.Show("Chọn chi nhánh");
            else
            {
                if (tkhoan == "")
                    MessageBox.Show("Tài Khoản Không Được Bỏ Trống");
                else
                {
                    GlobalConnect.SendData(GlobalConnect.svcn, "XoaTaiKhoan-" + chinhanh + "-" + tkhoan);
                    taikhoanxoa.Text = "";
                    string nhan = GlobalConnect.RecieveData(GlobalConnect.svcn);
                    if (nhan == "0")
                        MessageBox.Show("Tài Khoản Không Tồn Tại");
                    else
                        MessageBox.Show("Xoá Thành Công");
                }
            }
            LoadTaiKhoan();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_loadtaikhoan.SelectedIndex = 0;
            chinhanh = comboBox_loadtaikhoan.Text;
            LoadTaiKhoan();
        }

        public void LoadTaiKhoan()
        {
            GlobalConnect.SendData(GlobalConnect.svcn, "LoadTaiKhoan-" + chinhanh);
            List<TaiKhoan> l = new List<TaiKhoan>();
            string nhan = "";
            string[] tmp = new string[2];
            // Load dữ liệu tài khoản cho chi nhánh
            while(true)
            {
                nhan = GlobalConnect.RecieveData(GlobalConnect.svcn);
                if (nhan == "-1")
                    break;
                tmp = nhan.Split('-');
                l.Add(new TaiKhoan (tmp[0], tmp[1]) );
            }
            dataGridView_taikhoan.DataSource = l;
        }

        private void dataGridView_taikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView_taikhoan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                taikhoanxoa.Text = dataGridView_taikhoan.Rows[e.RowIndex].Cells["Tai_Khoan"].FormattedValue.ToString();
                comboBox_xoataikhoan.SelectedIndex = comboBox_loadtaikhoan.SelectedIndex;
            }
            else
                return;
        }

        private void comboBox_loadtaikhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            chinhanh = comboBox_loadtaikhoan.Text;
            LoadTaiKhoan();
        }
    }
}
 
public class TaiKhoan
{
    public string Tai_Khoan { get; set; }
    public string Mat_Khau { get; set; }

    public TaiKhoan(string taikhoan, string mathau)
    {
        this.Tai_Khoan = taikhoan;
        this.Mat_Khau = mathau;
    }
}
