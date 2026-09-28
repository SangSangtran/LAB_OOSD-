using System;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FrmTrangChu : Form
    {
        public FrmTrangChu()
        {
            InitializeComponent();

            // Gắn sự kiện click cho các nút bấm để mở Form tương ứng
            btnKhachHang.Click += (s, e) => { new FrmKhachHang().ShowDialog(); };
            btnQuanLyPhong.Click += (s, e) => { new FrmQuanLyPhong().ShowDialog(); };
            btnDatPhong.Click += (s, e) => { new FrmDatPhong().ShowDialog(); };
            btnDangXuat.Click += (s, e) => { this.Close(); };
        }
    }
}