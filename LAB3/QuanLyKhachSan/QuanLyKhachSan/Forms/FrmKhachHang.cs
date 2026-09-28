using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan
{
    public partial class FrmKhachHang : Form
    {
        private KhachHangService khService = new KhachHangService();

        public FrmKhachHang()
        {
            InitializeComponent();

            this.Load += FrmKhachHang_Load;
            dgvKhachHang.CellClick += DgvKhachHang_CellClick;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
        }

        private void LoadDuLieu()
        {
            dgvKhachHang.DataSource = khService.LayDanhSach();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void DgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["Mã KH"].Value.ToString();
                txtTenKH.Text = row.Cells["Họ Tên"].Value.ToString();
                txtDienThoai.Text = row.Cells["Điện Thoại"].Value.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (khService.Them(txtMaKH.Text, txtTenKH.Text, "000000000", "Việt Nam", txtDienThoai.Text))
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDuLieu();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (khService.Sua(txtMaKH.Text, txtTenKH.Text, "000000000", "Việt Nam", txtDienThoai.Text))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDuLieu();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (khService.Xoa(txtMaKH.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                }
                else
                {
                    MessageBox.Show("Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}