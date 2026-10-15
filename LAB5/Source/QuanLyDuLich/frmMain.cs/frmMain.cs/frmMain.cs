using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDuLich
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // thuộc tính Form
            this.Text = "Hệ Thống Quản Lý Công Ty Du Lịch";
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            // MenuStrip
            MenuStrip menuMain = new MenuStrip();
            menuMain.BackColor = Color.LightCyan;
            menuMain.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);

            // Menu chính
            ToolStripMenuItem mnuHeThong = new ToolStripMenuItem("Hệ thống");
            ToolStripMenuItem mnuQuanLy = new ToolStripMenuItem("Quản lý Thông tin");
            ToolStripMenuItem mnuDangKy = new ToolStripMenuItem("Đăng ký & Thanh toán");
            ToolStripMenuItem mnuDieuHanh = new ToolStripMenuItem("Điều hành");
            ToolStripMenuItem mnuBaoCao = new ToolStripMenuItem("Báo cáo Thống kê");

            // Thêm các mục con 
            mnuHeThong.DropDownItems.Add("Đăng xuất");
            mnuHeThong.DropDownItems.Add(new ToolStripSeparator());
            ToolStripMenuItem mnuThoat = new ToolStripMenuItem("Thoát");
            mnuThoat.Click += (s, e) => Application.Exit();
            mnuHeThong.DropDownItems.Add(mnuThoat);

            
            menuMain.Items.AddRange(new ToolStripItem[] {
                mnuHeThong,
                mnuQuanLy,
                mnuDangKy,
                mnuDieuHanh,
                mnuBaoCao
            });

            
            this.MainMenuStrip = menuMain;
            this.Controls.Add(menuMain);
        }
    }
}