Họ tên: Trần Nguyễn Tuấn Sang, MSSV: 1250080160, Lab 3 Thiết kế hệ thống, Môi trường sử dụng là Visual Studio 2022 và SQL Server.

Các lỗi gặp phải trong quá trình làm
 Lỗi khóa file cơ sở dữ liệu (.mdf) khi Push code
   - Tình trạng: Git báo lỗi không thể đồng bộ file `QuanLyKhachSan.mdf` lên GitHub vì file đang được sử dụng bởi một tiến trình khác.
 Lỗi mất giao diện Design của Form:
Lỗi NullReferenceException khi click vào DataGridView:
   - Tình trạng: Ứng dụng bị văng (crash) khi người dùng vô tình click vào vùng xám trống hoặc tiêu đề cột của bảng danh sách khách hàng.
Lỗi xung đột kiểu dữ liệu đầu vào:
   - Tình trạng: Khi test chức năng thêm khách hàng mới, cơ sở dữ liệu báo lỗi do thiếu các trường bắt buộc (NOT NULL) như CMND hoặc Quốc tịch mà trên giao diện không thiết kế ô nhập.
 
