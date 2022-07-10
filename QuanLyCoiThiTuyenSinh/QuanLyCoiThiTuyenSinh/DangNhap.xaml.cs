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
using BUS;
using DTO;
using QuanLyCoiThiTuyenSinh.UserControl_QLCTTS;
using QuanLyCoiThiTuyenSinh.UserControl_User;

namespace QuanLyCoiThiTuyenSinh
{
    /// <summary>
    /// Interaction logic for DangNhap.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        private ThiSinh_DTO getTenThiSinh;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Close_Dangnhap_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc muốn thoát ???", "Thông báo", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
                return;
        }
            

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Taikhoan = txtTenDangNhap.Text;
            tk.Matkhau = txtMatKhau.Password;
            TaiKhoan_DTO DangNhap = TaiKhoan_BUS.DangNhap_BUS(tk);
            


            if (DangNhap != null)
            {
                string taiKhoan = DangNhap.Taikhoan;
                string maNguoiDung = DangNhap.Manguoidung;
                int LoaiTK = DangNhap.Loaitaikhoan;
                getTenThiSinh = ThiSinh_BUS.getTenThiSinh_BUS(maNguoiDung);

                if (LoaiTK == 1)
                {
                    MainWindow mw = new MainWindow();
                    mw.txtTenHienThi.Text = getTenThiSinh.Hoten;
                    mw.tenDangNhap = tk.Taikhoan;
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công !", "Thông báo");
                    mw.Show();
                }
                else
                {
                    ThiSinh_DTO getValueInfo = ThiSinh_BUS.getValueInfo(maNguoiDung);
                    fNguoiDung nd = new fNguoiDung();
                    nd.sbd = getValueInfo.Sbd;
                    nd.ten = getValueInfo.Hoten;
                    nd.ngaysinh = getValueInfo.Ngaysinh.ToString();
                    nd.gioitinh = getValueInfo.Gioitinh;
                    nd.hokhau = getValueInfo.Hokhau;
                    nd.doituong = getValueInfo.Doituong;
                    nd.nganh = getValueInfo.Manganh;
                    nd.khuvuc = getValueInfo.Khuvuc;
                    nd.phong = getValueInfo.Maphong;
                    nd.images = getValueInfo.Images;
                    nd.txtTimeLogin.Text = $"Login: {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year} lúc {DateTime.Now.Hour} giờ {DateTime.Now.Minute} phút";
                    nd.txtTenHienThi.Text = $"Name: {getValueInfo.Hoten}";
                    nd.tenTK = taiKhoan;
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công !", "Thông báo");
                    nd.Show();
                    
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu !", "Thông báo");
            }
        }
    }
}
