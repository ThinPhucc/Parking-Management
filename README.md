# Ứng dụng quản lý bãi đỗ xe.
=============================
C# WinForm.

1. Ứng dụng mình xây dựng sử dụng CSDL dựa trên file .text, mặc dù việc này khiến khả năng xử lý của dữ liệu sẽ không hiệu quả.
   Nhưng nó sẽ giúp mọi người dễ cài đặt và sử dụng hơn.

2. Ứng dụng hiện chỉ xây dựng trong mạng LAN, dựa trên IP Loopback.
   Có thể thay đổi thành IP Server khác nếu muốn tại:
   Server > Main
   Admin > LoginForm.cs > GlobalConnect Class
   Client > LoginForm.cs > GlobalConnect Class

3. Dữ liệu tài khoản và đoạn chat nằm tại: .\Server\bin\Debug\
