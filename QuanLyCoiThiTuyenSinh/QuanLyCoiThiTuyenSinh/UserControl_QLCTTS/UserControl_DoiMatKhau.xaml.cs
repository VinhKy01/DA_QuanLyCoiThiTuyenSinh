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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DTO;
using BUS;

namespace QuanLyCoiThiTuyenSinh.UserControl_QLCTTS
{
    /// <summary>
    /// Interaction logic for UserControl_DoiMatKhau.xaml
    /// </summary>
    public partial class UserControl_DoiMatKhau : UserControl
    {
        private string tenDangNhap;
        private TaiKhoan_DTO KiemTraMK;
        public UserControl_DoiMatKhau(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
            truyendulieu();
        }

        void truyendulieu()
        {
            txtTenTruyCap.Text = tenDangNhap;
        }

        void XoaTextBlock()
        {
            txtMatKhauCu.Clear();
            txtMatKhauMoi.Clear();
            txtXacNhanMK.Clear();
        }

        private void btnCapNhatMK_Click(object sender, RoutedEventArgs e)
        {
            TaiKhoan_DTO taikhoan = new TaiKhoan_DTO();
            taikhoan.Taikhoan = txtTenTruyCap.Text;
            taikhoan.Matkhau = txtMatKhauCu.Password;
            string MKMoi = txtMatKhauMoi.Password;
            string XNMK = txtXacNhanMK.Password;

            if (!taikhoan.Matkhau.Trim(' ').Equals("") && !MKMoi.Trim(' ').Equals("") && !XNMK.Trim(' ').Equals(""))
            {
                if (MKMoi.Equals(XNMK))
                {
                    //Kiểm tra xem đã đúng tài khoản và mật khẩu cũ
                    KiemTraMK = TaiKhoan_BUS.DangNhap_BUS(taikhoan);
                    if (KiemTraMK != null)
                    {
                        if (TaiKhoan_BUS.CapNhatMatKhau_BUS(taikhoan, MKMoi))
                        {
                            MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo");
                            XoaTextBlock();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật mật khẩu thất bại", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu không đúng !", "Thông báo");
                }
                
            }
            else
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin");
            }
            
        }

        private void btnHuyCapNhatMK_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc muốn hủy ?", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.OK)
            {
                XoaTextBlock();
            }
        }
    }
}
