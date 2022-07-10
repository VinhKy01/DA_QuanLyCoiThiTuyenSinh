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
    /// Interaction logic for fDoiMatKhau_User.xaml
    /// </summary>
    public partial class fDoiMatKhau_User : Window
    {
        private string tenTK;
        private TaiKhoan_DTO DangNhap;
        public fDoiMatKhau_User(string tenTK)
        {
            InitializeComponent();
            this.tenTK = tenTK;
            TruyenDuLieu();
        }

        void TruyenDuLieu()
        {
            txtTenTruyCap.Text = tenTK;
        }

        void XoaTextBlock()
        {
            txtMatKhauCu.Clear();
            txtMatKhauMoi.Clear();
            txtXacNhanMK.Clear();
        }

        private void btnCapNhatMK_Click(object sender, RoutedEventArgs e)
        {
            if (txtMatKhauCu.Password == "" || txtMatKhauMoi.Password == "" || txtXacNhanMK.Password == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin !!!", "Thông báo");
                return;
            }

            if (txtMatKhauMoi.Password != txtXacNhanMK.Password)
            {
                MessageBox.Show("Xác nhận mật khẩu chưa đúng !!!", "Thông báo");
                return;
            }

            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Taikhoan = txtTenTruyCap.Text;
            tk.Matkhau = txtMatKhauCu.Password;
            string mkMoi = txtXacNhanMK.Password;

            DangNhap = TaiKhoan_BUS.DangNhap_BUS(tk);
            if (DangNhap != null)
            {
                TaiKhoan_BUS.CapNhatMatKhau_BUS(tk, mkMoi);
                MessageBox.Show("Đã cập nhật mật khẩu thành công !!!", "Thông báo");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu !!!", "Thông báo");
                return;
            }
        }

        private void btnHuyCapNhatMK_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc muốn hủy ?", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.OK)
            {
                XoaTextBlock();
                this.Hide();
            }
        }
    }
}
