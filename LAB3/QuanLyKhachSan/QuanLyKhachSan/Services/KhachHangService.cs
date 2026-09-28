using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class KhachHangService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query("SELECT MaKhach AS [Mã KH], HoTen AS [Họ Tên], SoCMND AS [CMND/CCCD], QuocTich AS [Quốc Tịch], SoDienThoai AS [Điện Thoại] FROM KhachHang");
        }


        public bool Them(string ma, string ten, string cmnd, string quocTich, string sdt)
        {
            string sql = "INSERT INTO KhachHang (MaKhach, HoTen, SoCMND, QuocTich, SoDienThoai) VALUES (@ma, @ten, @cmnd, @qt, @sdt)";
            try
            {
                int rows = Db.Execute(sql,
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@cmnd", cmnd),
                    new SqlParameter("@qt", quocTich),
                    new SqlParameter("@sdt", sdt));
                return rows > 0;
            }
            catch { return false; } 

        public bool Sua(string ma, string ten, string cmnd, string quocTich, string sdt)
        {
            string sql = "UPDATE KhachHang SET HoTen=@ten, SoCMND=@cmnd, QuocTich=@qt, SoDienThoai=@sdt WHERE MaKhach=@ma";
            try
            {
                int rows = Db.Execute(sql,
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@cmnd", cmnd),
                    new SqlParameter("@qt", quocTich),
                    new SqlParameter("@sdt", sdt));
                return rows > 0;
            }
            catch { return false; }
        }

        public bool Xoa(string ma)
        {
            string sql = "DELETE FROM KhachHang WHERE MaKhach=@ma";
            try
            {
                int rows = Db.Execute(sql, new SqlParameter("@ma", ma));
                return rows > 0;
            }
            catch { return false; } 
        }
    }
}