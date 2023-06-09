using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    class Program
    {
        public static bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);
            if (part1 && part2)
                // Mất kết nối tới client
                return false;
            else
                return true;
        }

        private static int SendData(Socket a, string nhan)
        {
            byte[] data = new byte[1024];
            data = Encoding.Unicode.GetBytes(nhan);
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

        private static string RecieveData(Socket a)
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

        public static void CheckLogin(Socket socket, string nhan)
        {
            // Chi nhánh - Tài Khoản - Mật Khẩu.
            string[] user_type = nhan.Split('-');
            string chinhanh = user_type[1];
            string tkhoan = user_type[2];
            string matkhau = user_type[3];
            // Get path
            string path = "Account/" + chinhanh + ".txt";
            bool check = false;
            // Luu du lieu file
            string[] tmp = File.ReadAllLines(path);
            int i = 0;
            while (i < tmp.Length)
            {
                if (tmp[i] == "" || tmp == null)
                    continue;
                string[] account = tmp[i].Split('-');
                if (account[0] == tkhoan && account[1] == matkhau)
                {
                    check = true;
                    break;
                }
                i++;
            }
            if (!check)
            {
                SendData(socket, "0");
            }
            else
            {
                SendData(socket, "1");
            }
        }

        public static void GetAllXeGui(Socket socket, string chinhanh)
        {          
            //Lấy thông tin file
            string path = "Data/" + chinhanh + ".txt";
            var data = File.ReadAllLines(path).Reverse();
            //Send
            foreach (string s in data)
            {
                if (s == null || s == "")
                    continue;
                string[] tmpp = s.Split(',');
                if (tmpp[0] == "0")
                {
                    SendData(socket, s);
                }
            }    
            SendData(socket, "-1");
        }

        public static void ThemXeGui(Socket socket, string nhan)
        {
            bool check = false;
            //Lấy thông tin file
            string[] tmp = nhan.Split('-');
            string path = "Data/" + tmp[1] + ".txt";
            // Xử lý, tmp[2] = tất cả thông tin xe muốn thêm
            string[] info_xe = tmp[2].Split(',');
            string[] data = File.ReadAllLines(path);
            // Kiểm tra biển số xe đã tồn tại trong bãi đỗ hay chưa. Xe đã trả không tính.
            foreach (string s in data)
            {
                if (s == "" || s == null)
                    continue;
                string[] tmppp = s.Split(',');
                if (tmppp[0] == "0" && tmppp[2] == info_xe[2])
                {
                    check = true;
                    break;
                }
            }
            // Check == true > Tồn tại xe trong khu
            if (check)
            {
                // Gửi kết quả
                SendData(socket, "0");
            }
            else
            {
                // Tạo mảng mới nhiều hơn 1 dòng để ghi dữ liệu
                string[] insert = new string[data.Length + 1];
                // Copy mảng cũ vô mảng mới
                Array.Copy(data, insert, data.Length);
                insert[data.Length] = tmp[2];
                File.WriteAllLines(path, insert);
                // Gửi kết quả
                SendData(socket, "1");
            }
        }

        public static void TraXe(Socket socket, string nhan)
        {
            //Lấy thông tin file
            string[] client_type = nhan.Split('-');
            string path = "Data/" + client_type[1] + ".txt";
            string[] data = File.ReadAllLines(path);
            // client_type[2] == biển số xe.
            string ngaytra = "";
            string ngaygui = "";
            for (int i = 0; i <= data.Length; i++)
            {
                // Đặt đkiện đọc hết file mà không có xe, trả về số tiền 0
                if (i == data.Length)
                {
                    SendData(socket, "0");
                    break;
                }
                if (data[i] == "" || data[i] == null)
                    continue;
                string[] check = data[i].Split(',');
                // Check biển số xe trong file > Lấy ngày gửi tính toán và thêm ngày trả, số tiền vào file.
                if (check[0] == "0" && check[2] == client_type[2])
                {
                    ngaygui = check[3];
                    ngaytra = DateTime.Now.ToString("dd/MM/yyyy HH:mm tt");
                    // Chuyển chuỗi tgian về đúng định dạng trước
                    DateTime gui = DateTime.ParseExact(ngaygui, "dd/MM/yyyy HH:mm tt", null);
                    DateTime tra = DateTime.ParseExact(ngaytra, "dd/MM/yyyy HH:mm tt", null);
                    // Gọi hàm tính toán thời gian để tính thời gian giữa 2 mốc gửi - trả.
                    TimeSpan thoigian = tra.Subtract(gui);

                    // Hàm trên trả về chuỗi kiểu giờ:phút:giây, nếu thời gian lớn hơn 24h thì ngày.giờ:phút:giây
                    string[] split_time = thoigian.ToString().Split(':');
                    int ngay = 0;
                    int gio = 0;
                    int tien = 0;
                    // Cắt chuỗi lấy ngày và giờ để tính, kiểm tra xem trả về giờ hay cả giờ và ngày.
                    if (split_time[0].Length > 2)
                    {
                        string[] tmp = split_time[0].Split('.');
                        ngay = int.Parse(tmp[0]);
                        gio = int.Parse(tmp[1]) + 1;
                    }
                    else gio = int.Parse(split_time[0]) + 1;
                    // Tínk tiền gòi trả tiền về cho Client
                    if (ngay != 0)
                    {
                        tien = (ngay * 24 + gio) * 5000;
                    }
                    else tien = gio * 5000;
                    // Tạo dòng dữ liệu ghi file
                    data[i] = "1" + "," + check[1] + "," + check[2] + "," + check[3] + "," + DateTime.Now.ToString("dd/MM/yyyy HH:mm tt") + "," + tien;
                    SendData(socket, tien.ToString());
                    break;
                }
            }
            File.WriteAllLines(path, data);
        }

        public static void TimXe(Socket socket, string nhan)
        {
            string[] tmp = nhan.Split('-');
            //Lấy thông tin file
            string path = "Data/" + tmp[1] + ".txt";
            string biensoXe = tmp[2];
            var data = File.ReadAllLines(path).Reverse();
            //Send
            foreach (string s in data)
            {
                if (s == "" || s == null)
                    continue;
                string[] tmppp = s.Split(',');
                if (tmppp[2] == biensoXe)
                {
                    SendData(socket, s);
                    Console.WriteLine(s);
                }
            }
            SendData(socket, "-1");
        }

        public static void Chat(List<Socket> list_sock, string nhan)
        {
            byte[] tmp;
            string[] data = File.ReadAllLines("Chat.txt");
            // Tạo mảng mới nhiều hơn 1 dòng để ghi dữ liệu
            string[] insert = new string[data.Length + 1];
            // Copy mảng cũ vô mảng mới gòi ghi đè file.
            Array.Copy(data, insert, data.Length);
            insert[data.Length] = nhan;
            File.WriteAllLines("Chat.txt", insert);
            // Gửi tin nhắn cho các client khác.
            foreach (Socket sock in list_sock)
            {
                tmp = Encoding.Unicode.GetBytes(nhan);
                sock.Send(tmp);
                Console.WriteLine(nhan);
            }
        }

        public static void LoadChat(Socket socket)
        {
            // Đọc file, gửi từng dòng cho client để load.
            string[] data_chat = File.ReadAllLines("Chat.txt");
            byte[] send = new byte[1024];
            foreach (string c in data_chat)
            {
                SendData(socket, c);
            }
            SendData(socket, "-1");
        }

        public static void ThongKe(Socket socket, string chinhanh)
        {
            //Lấy thông tin file
            string path = "Data/" + chinhanh + ".txt";
            var data = File.ReadAllLines(path).Reverse();
            //Send
            foreach (string s in data)
            {
                if (s == null || s == "")
                    continue;
                SendData(socket, s);
            }
            SendData(socket, "-1");
        }

        public static void ThongKeHomNay(Socket socket, string chinhanh)
        {
            //Lấy thông tin file
            string path = "Data/" + chinhanh + ".txt";
            var data = File.ReadAllLines(path).Reverse();
            // Tạo mốc thời gian đầu ngày và cuối ngày để so sánh
            DateTime dauNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
            DateTime cuoiNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            //Send
            foreach (string s in data)
            {
                if (s == null || s == "")
                    continue;
                string[] tmp = s.Split(',');
                /* Kiểm tra xe đang gửi hay đã trả, nếu đã trả thì lấy ngày trả để so sánh,
                chưa trả thì lấy ngày gửi để so sánh. */
                // 0 = đang gửi
                if (tmp[0] == "0")
                {
                    DateTime ngayGui = DateTime.ParseExact(tmp[3], "dd/MM/yyyy HH:mm tt", null);
                    if (dauNgay < ngayGui && ngayGui < cuoiNgay)
                    {
                        SendData(socket, s);
                    }    
                }
                // 1 = đã trả
                else
                {
                    DateTime ngayGui = DateTime.ParseExact(tmp[4], "dd/MM/yyyy HH:mm tt", null);
                    if (dauNgay < ngayGui && ngayGui < cuoiNgay)
                    {
                        SendData(socket, s);
                    }
                }    
            }
            SendData(socket, "-1");
        }

        public static void ThongKeHomQua(Socket socket, string chinhanh)
        {
            //Lấy thông tin file
            string path = "Data/" + chinhanh + ".txt";
            var data = File.ReadAllLines(path).Reverse();
            // Tạo mốc thời gian đầu và cuối để so sánh
            DateTime dauNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
            DateTime cuoiNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            // Lấy mốc thời gian trên, giảm đi 1 ngày để về ngày hôm qua
            dauNgay = dauNgay.AddDays(-1);
            cuoiNgay = cuoiNgay.AddDays(-1);
            //Send
            foreach (string s in data)
            {
                if (s == null || s == "")
                    continue;
                string[] tmp = s.Split(',');
                /* Kiểm tra xe đang gửi hay đã trả, nếu đã trả thì lấy ngày trả để so sánh,
                chưa trả thì lấy ngày gửi để so sánh. */
                // 0 = đang gửi
                if (tmp[0] == "0")
                {
                    DateTime ngayGui = DateTime.ParseExact(tmp[3], "dd/MM/yyyy HH:mm tt", null);
                    if (dauNgay < ngayGui && ngayGui < cuoiNgay)
                    {
                        SendData(socket, s);
                    }
                }
                else
                {
                    DateTime ngayGui = DateTime.ParseExact(tmp[4], "dd/MM/yyyy HH:mm tt", null);
                    if (dauNgay < ngayGui && ngayGui < cuoiNgay)
                    {
                        SendData(socket, s);
                    }
                }
            }
            SendData(socket, "-1");
        }

        public static void ThongKeThangNay(Socket socket, string chinhanh)
        {
            //Lấy thông tin file
            string path = "Data/" + chinhanh + ".txt";
            var data = File.ReadAllLines(path).Reverse();
            // Lấy số ngày của tháng trong 1 năm nhất định để tạo ngày cuối cùng trong tháng.
            int ngayCuoiThang = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            // Lấy mốc thời gian đầu và cuối tháng.
            DateTime dauThang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 00, 00, 00);
            DateTime cuoiThang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, ngayCuoiThang, 23, 59, 59);
            //Send
            foreach (string s in data)
            {
                if (s == null || s == "")
                    continue;
                /* Kiểm tra xe đang gửi hay đã trả, nếu đã trả thì lấy ngày trả
                chưa trả thì lấy ngày gửi để tính toán. */
                string[] tmp = s.Split(',');
                // 0 = đang gửi
                if (tmp[0] == "0")
                {
                    DateTime ngayGui = DateTime.ParseExact(tmp[3], "dd/MM/yyyy HH:mm tt", null);
                    if (dauThang < ngayGui && ngayGui < cuoiThang)
                    {
                        SendData(socket, s);
                    }
                }
                // 1 = đã trả
                else
                {
                    DateTime ngayGui = DateTime.ParseExact(tmp[4], "dd/MM/yyyy HH:mm tt", null);
                    if (dauThang < ngayGui && ngayGui < cuoiThang)
                    {
                        SendData(socket, s);
                    }
                }
            }
            SendData(socket, "-1");
        }

        public static void ThongKeThangTruoc(Socket socket, string chinhanh)
        {
            //Lấy thông tin file
            string path = "Data/" + chinhanh + ".txt";
            var data = File.ReadAllLines(path).Reverse();
            // Lấy thời gian hiện tại rồi giảm đi 1 tháng để lấy thông tin năm trước, tháng trước
            DateTime now = DateTime.Now;
            now = now.AddMonths(-1);
            // Lấy tổng số ngày của tháng trước để tạo ngày cuối cùng trong tháng.
            int ngayCuoiThang = DateTime.DaysInMonth(now.Year, now.Month);
            // Lấy mốc thời gian đầu và cuối tháng.
            DateTime dauThang = new DateTime(now.Year, now.Month, 1, 00, 00, 00);
            DateTime cuoiThang = new DateTime(now.Year, now.Month, ngayCuoiThang, 23, 59, 59);
            //Send
            foreach (string s in data)
            {
                if (s == null || s == "")
                    continue;
                /* Kiểm tra xe đang gửi hay đã trả, nếu đã trả thì lấy ngày trả
                chưa trả thì lấy ngày gửi để tính toán. */
                string[] tmp = s.Split(',');
                // 0 = đang gửi
                if (tmp[0] == "0")
                {
                    DateTime ngayGui = DateTime.ParseExact(tmp[3], "dd/MM/yyyy HH:mm tt", null);
                    if (dauThang < ngayGui && ngayGui < cuoiThang)
                    {
                        SendData(socket, s);
                    }
                }
                // 1 = đã trả
                else
                {
                    DateTime ngayGui = DateTime.ParseExact(tmp[4], "dd/MM/yyyy HH:mm tt", null);
                    if (dauThang < ngayGui && ngayGui < cuoiThang)
                    {
                        SendData(socket, s);
                    }
                }
            }
            SendData(socket, "-1");
        }

        public static void LocThongKe(Socket socket, string nhan)
        {
            // Chuỗi gửi về gồm Key-ChiNhánh-NgàyĐầu-NgàyCuối, cắt chuỗi lấy đúng giá trị để tính
            string[] client_type = nhan.Split('-');
            //Lấy thông tin file
            string path = "Data/" + client_type[1] + ".txt";
            var data = File.ReadAllLines(path).Reverse();
            // Xử lý thời gian người dùng chọn. Thời gian người dùng nhập có dạng dd/MM/yyyy
            string[] from = client_type[2].Split('/');
            string[] to = client_type[3].Split('/');
            // Tạo biến thời gian dựa trên giá trị của người dùng.
            DateTime dateTime_From = new DateTime( int.Parse(from[2]), int.Parse(from[1]), int.Parse(from[0]), 00, 00, 00);
            DateTime dateTime_To = new DateTime(int.Parse(to[2]), int.Parse(to[1]), int.Parse(to[0]), 23, 59, 59);
            //Send
            foreach (string s in data)
            {
                if (s == null || s == "")
                    continue;
                /* Kiểm tra xe đang gửi hay đã trả, nếu đã trả thì lấy ngày trả
                chưa trả thì lấy ngày gửi để tính toán. */
                string[] tmp = s.Split(',');
                // 0 = đang gửi
                if (tmp[0] == "0")
                {
                    DateTime ngayGui = DateTime.ParseExact(tmp[3], "dd/MM/yyyy HH:mm tt", null);
                    if (dateTime_From < ngayGui && ngayGui < dateTime_To)
                    {
                        SendData(socket, s);
                    }
                }
                // 1 = đã trả
                else
                {
                    DateTime ngayGui = DateTime.ParseExact(tmp[4], "dd/MM/yyyy HH:mm tt", null);
                    if (dateTime_From < ngayGui && ngayGui < dateTime_To)
                    {
                        SendData(socket, s);
                    }
                }
            }
            SendData(socket, "-1");
        }

        public static void TimXe_Extend(Socket socket, string nhan)
        {
            string[] tmp = nhan.Split('-');
            //Lấy thông tin file
            string path = "Data/" + tmp[1] + ".txt";
            string client_type = tmp[2];
            var data = File.ReadAllLines(path).Reverse();
            //Send
            foreach (string s in data)
            {
                if (s == "" || s == null)
                    continue;
                string[] tmppp = s.Split(',');
                if (tmppp[1] == client_type || tmppp[2] == client_type)
                {
                    SendData(socket, s);
                    Console.WriteLine(s);
                }
            }
            SendData(socket, "-1");
        }

        public static void ThemTaiKhoan(Socket socket, string nhan)
        {
            bool check = false;
            // Key - Chi nhánh - tkhoan - pass
            string[] user_type = nhan.Split('-');
            string chinhanh = user_type[1];
            string taikhoan = user_type[2];
            string matkhau = user_type[3];
            // Lấy đường dẫn > đọc file
            string path = "Account/" + chinhanh + ".txt";
            string[] AllAccount = File.ReadAllLines(path);
            // Ktra tài khoản tồn tại hay không
            int i = 0;
            while (i < AllAccount.Length)
            {
                if (AllAccount[i] == "" || AllAccount == null)
                    continue;
                string[] account = AllAccount[i].Split('-');
                if (account[0] == taikhoan)
                {
                    // Tài khoản tồn tại
                    check = true;
                    break;
                }
                i++;
            }
            if (check)
            {
                SendData(socket, "0");
            }
            else
            {
                // Tạo mảng mới nhiều hơn 1 dòng để ghi dữ liệu
                string[] insert = new string[AllAccount.Length + 1];
                // Copy mảng cũ vô mảng mới
                Array.Copy(AllAccount, insert, AllAccount.Length);
                insert[AllAccount.Length] = taikhoan + "-" + matkhau;
                File.WriteAllLines(path, insert);
                // Gửi kết quả
                SendData(socket, "1");
            }
        }

        public static void XoaTaiKhoan(Socket socket, string nhan)
        {
            bool check = false;
            // Key - Chi nhánh - tkhoan
            string[] user_type = nhan.Split('-');
            string chinhanh = user_type[1];
            string taikhoan = user_type[2];
            // Lấy đường dẫn > đọc file
            string path = "Account/" + chinhanh + ".txt";
            string[] AllAccount = File.ReadAllLines(path);
            // Ktra tài khoản tồn tại hay không
            int i = 0;
            while (i < AllAccount.Length)
            {
                if (AllAccount[i] == "" || AllAccount == null)
                    continue;
                string[] account = AllAccount[i].Split('-');
                if (account[0] == taikhoan)
                {
                    // Tài khoản tồn tại
                    check = true;
                    // Xoá dòng dữ liệu
                    AllAccount[i] = null;
                    break;
                }
                i++;
            }
            if (!check)
            {
                SendData(socket, "0");
            }
            else
            {
                // Tạo mảng mới ít hơn 1 dòng để ghi dữ liệu
                string[] insert = new string[AllAccount.Length - 1];
                // Copy mảng cũ vô mảng mới
                for (i = 0; i < AllAccount.Length; i++)
                {
                    if (AllAccount[i] == null || AllAccount[i] == "")
                        continue;
                    for (int j = 0; j < insert.Length; j++)
                    {
                        if (insert[j] == null || insert[j] == "")
                            insert[j] = AllAccount[i];
                    }    
                }
                File.WriteAllLines(path, insert);
                // Gửi kết quả
                SendData(socket, "1");
            }
        }

        public static void LoadTaiKhoan(Socket socket, string nhan)
        {
            // Đọc file
            string[] user_type = nhan.Split('-');
            string chinhanh = user_type[1];
            string path = "Account/" + chinhanh + ".txt";
            string[] AllAccount = File.ReadAllLines(path);
            // Gửi dữ liệu
            foreach (string s in AllAccount)
            {
                SendData(socket, s);
            }    
            SendData(socket, "-1");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Server:");
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipep = new IPEndPoint(ip, 9090);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipep);
            server.Listen(10);
            List<Socket> list_sock = new List<Socket>();
            while (true)
            {
                Socket socket = server.Accept();
                string add = RecieveData(socket);
                if (add == "Chat")
                {
                    list_sock.Add(socket);
                }
                Thread t = new Thread(() =>
                {
                    while (SocketConnected(socket))
                    {
                        try
                        {
                            string nhan = RecieveData(socket);
                            Console.WriteLine(nhan);
                            string[] tmp = nhan.Split('-');
                            // Chuỗi đầu luôn là từ khoá để gọi hàm
                            switch (tmp[0])
                            {
                                case "EndChat":
                                    SendData(socket, "-1");
                                    break;
                                case "Login":
                                    CheckLogin(socket, nhan);
                                    break;
                                case "AllXeGui":
                                    GetAllXeGui(socket, tmp[1]);
                                    break;
                                case "AddXe":
                                    ThemXeGui(socket, nhan);
                                    break;
                                case "TraXe":
                                    TraXe(socket, nhan);
                                    break;
                                case "TimXe":
                                    TimXe(socket, nhan);
                                    break;
                                case "Chat":
                                    Chat(list_sock, tmp[1]);
                                    break;
                                case "LoadChat":
                                    LoadChat(socket);
                                    break;
                                case "ThongKe":
                                    ThongKe(socket, tmp[1]);
                                    break;
                                case "ThongKeHomNay":
                                    ThongKeHomNay(socket, tmp[1]);
                                    break;
                                case "ThongKeHomQua":
                                    ThongKeHomQua(socket, tmp[1]);
                                    break;
                                case "ThongKeThangNay":
                                    ThongKeThangNay(socket, tmp[1]);
                                    break;
                                case "ThongKeThangTruoc":
                                    ThongKeThangTruoc(socket, tmp[1]);
                                    break;
                                case "LocThongKe":
                                    LocThongKe(socket, nhan);
                                    break;
                                case "TimXe_Extend":
                                    TimXe_Extend(socket, nhan);
                                    break;
                                case "ThemTaiKhoan":
                                    ThemTaiKhoan(socket, nhan);
                                    break;
                                case "XoaTaiKhoan":
                                    XoaTaiKhoan(socket, nhan);
                                    break;
                                case "LoadTaiKhoan":
                                    LoadTaiKhoan(socket, nhan);
                                    break;
                            }
                        }
                        catch (Exception e)
                        { }
                    }
                });
                t.Start();
            }
        }
    }
}
