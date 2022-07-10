using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DTO;
using BUS;

namespace QuanLyCoiThiTuyenSinh
{
    /// <summary>
    /// Interaction logic for ThemTaiKhoan.xaml
    /// </summary>
    public partial class ThemTaiKhoan : Window
    {
        public string IdThiSinh;
        private TaiKhoan_DTO getIDTaiKhoan;
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnTaoTaiKhoan_Click(object sender, RoutedEventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Taikhoan = txtTenDangNhap.Text;
            tk.Matkhau = txtMatKhau.Password.ToString();
            tk.Loaitaikhoan = 2;
            tk.Manguoidung = IdThiSinh;

            if (tk.Matkhau != txtXacNhanMK.Password.ToString())
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng !!!", "Thông báo");
                return;
            }

            getIDTaiKhoan = TaiKhoan_BUS.KiemTraIDTaiKhoan_BUS(tk);
            if (getIDTaiKhoan == null)
            {
                if (TaiKhoan_BUS.ThemTaiKhoan_BUS(tk))
                    MessageBox.Show("Thêm tài khoản thành công");
                else
                    MessageBox.Show("Thêm tài khoản thất bại");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản đã có vui lòng đặt tài khoản khac !!!", "Thông báo");
                return;
            }
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Nếu hủy sẽ không được cấp tài khoản đăng nhập", "Thông báo", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
                this.Hide();
            else
                return;
        }
    }
}
