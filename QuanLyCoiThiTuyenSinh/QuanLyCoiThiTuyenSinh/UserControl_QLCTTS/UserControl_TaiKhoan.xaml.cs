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
using System.Collections.ObjectModel;
using System.Data;

namespace QuanLyCoiThiTuyenSinh.UserControl_QLCTTS
{
    /// <summary>
    /// Interaction logic for UserControl_TaiKhoan.xaml
    /// </summary>
    public partial class UserControl_TaiKhoan : UserControl
    {
        public List<TaiKhoan_DTO> listTaiKhoan { get; set; }

        private TaiKhoan_DTO _SelectedTaikhoan;
        public TaiKhoan_DTO SelectedTaiKhoan
        {
            get => _SelectedTaikhoan;
            set
            {
                _SelectedTaikhoan = value;
                if (SelectedTaiKhoan == null)
                    return;
                txtTenDangNhap.Text = SelectedTaiKhoan.Taikhoan;
                txtMatKhau.Text = SelectedTaiKhoan.Matkhau;
                txtTenNguoiDung.Text = SelectedTaiKhoan.Manguoidung;
                cbbLoaiTK.Text = (SelectedTaiKhoan.Loaitaikhoan).ToString();

                if (SelectedTaiKhoan.Loaitaikhoan == 1)
                    btnPhanQuyenTK.Content = "Hạ quyền";
                else
                    btnPhanQuyenTK.Content = "Nâng quyền";

            }
        }
        public UserControl_TaiKhoan()
        {
            InitializeComponent();
            DataContext = this;
            load();
        }


        void load()
        {
            DanhSachNguoiDung();
        }
        
        void DanhSachNguoiDung()
        {
            listTaiKhoan = TaiKhoan_BUS.DanhSachNguoiDung_BUS();
            dtgTaiKhoan.ItemsSource = listTaiKhoan;
        }

        private void btnXoaTaiKhoan_Click(object sender, RoutedEventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Taikhoan = txtTenDangNhap.Text;

            if (TaiKhoan_BUS.XoaTaiKhoan_BUS(tk))
            {
                MessageBox.Show($"Đã xóa tài khoản {tk.Taikhoan} thành công");
                DanhSachNguoiDung();
            }
            else
            {
                MessageBox.Show($"Đã xóa tài khoản {tk.Taikhoan} thành công");
            }
        }

        private void btnResetMK_Click(object sender, RoutedEventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Taikhoan = txtTenDangNhap.Text;

            if (SelectedTaiKhoan != null)
            {
                if (TaiKhoan_BUS.ResetMK_BUS(tk))
                    MessageBox.Show("Mật khẩu đã được Reset về 123", "Thông báo");
                else
                    MessageBox.Show("Reset mật khẩu thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn phải Click chọn 1 tài khoản", "Thông báo");
            }
        }

        private void btnPhanQuyenTK_Click(object sender, RoutedEventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Taikhoan = txtTenDangNhap.Text;
            tk.Loaitaikhoan = int.Parse(cbbLoaiTK.Text);

            if (SelectedTaiKhoan != null)
            {
                if (TaiKhoan_BUS.PhanQuyen_BUS(tk))
                {
                    if (tk.Loaitaikhoan == 1)
                        MessageBox.Show("Tài khoản đã được cấp quyền người dùng", "Thông báo");
                    else
                        MessageBox.Show("Tài khoản đã được cấp quyền Admin", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải Click chọn 1 tài khoản", "Thông báo");
            }
            DanhSachNguoiDung();
        }
    }
}
