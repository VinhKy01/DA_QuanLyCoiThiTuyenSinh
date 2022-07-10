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
    /// Interaction logic for UserControl_DoiTuong.xaml
    /// </summary>
    public partial class UserControl_DoiTuong : UserControl
    {
        bool flag = true;
        private List<ThiSinh_DTO> getID_ThiSinh;
        private List<DoiTuong_DTO> ListDanhSachDoituong;
        private DoiTuong_DTO KiemTraID_DoiTuong;
        private DoiTuong_DTO _selectedDoiTuong;

        public DoiTuong_DTO SelectedDoiTuong 
        { 
            get => _selectedDoiTuong;
            set 
            { 
                _selectedDoiTuong = value;
                if (SelectedDoiTuong == null)
                    return;
                txtMaDoiTuong.Text = SelectedDoiTuong.Madoituong;
                txtTenDoiTuong.Text = SelectedDoiTuong.Tendoituong;
            }
        }

        public UserControl_DoiTuong()
        {
            InitializeComponent();
            DataContext = this;
            load();
        }

        void load()
        {
            DanhSachDoiTuong();
        }

        void DanhSachDoiTuong()
        {
            ListDanhSachDoituong = DoiTuong_BUS.DanhSachDoiTuong();
            dtgDoiTuong.ItemsSource = ListDanhSachDoituong;
        }

        private void btnFlag_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                btnFlag.Content = "-";

                btnThemDoiTuong.IsEnabled = true;
                btnCapNhatDoiTuong.IsEnabled = false;
                btnXoaDoiTuong.IsEnabled = false;
                txtMaDoiTuong.IsEnabled = true;

                txtMaDoiTuong.Clear();
                txtTenDoiTuong.Clear();
                txtMaDoiTuong.Focus();
            }
            else
            {
                flag = true;
                btnFlag.Content = "+";

                btnThemDoiTuong.IsEnabled = false;
                btnCapNhatDoiTuong.IsEnabled = true;
                btnXoaDoiTuong.IsEnabled = true;
                txtMaDoiTuong.IsEnabled = false;
            }
        }

        private void btnThemDoiTuong_Click(object sender, RoutedEventArgs e)
        {
            DoiTuong_DTO dt = new DoiTuong_DTO();
            dt.Madoituong = txtMaDoiTuong.Text;
            dt.Tendoituong = txtTenDoiTuong.Text;

            if (dt.Madoituong == "" || dt.Tendoituong == "")
            {
                MessageBox.Show($"Phải nhập đầy đủ thông tin !!!", "Thông báo");
                return;
            }

            KiemTraID_DoiTuong = DoiTuong_BUS.KiemTraID_DoiTuong(dt);
            if (KiemTraID_DoiTuong == null)
            {
                if (DoiTuong_BUS.ThemDoiTuong_BUS(dt))
                {
                    MessageBox.Show($"Thêm đối tượng {dt.Madoituong} thành công", "Thông báo");
                    DanhSachDoiTuong();
                }
                else
                    MessageBox.Show($"Thêm đối tượng {dt.Madoituong} thất bại", "Thông báo");
            }
            else
                MessageBox.Show($"Mã đối tượng {dt.Madoituong} bị trùng vui lòng đặt mã khác", "Thông báo");
        }

        private void btnCapNhatDoiTuong_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedDoiTuong != null)
            {
                DoiTuong_DTO dt = new DoiTuong_DTO();
                dt.Madoituong = txtMaDoiTuong.Text;
                dt.Tendoituong = txtTenDoiTuong.Text;

                if (DoiTuong_BUS.CapNhatDoiTuong_BUS(dt))
                {
                    MessageBox.Show($"Đã cập nhật đói tượng có mã {dt.Madoituong} thành công", "Thông báo");
                    DanhSachDoiTuong();
                }
                else
                    MessageBox.Show($"Đã cập nhật đối tượng có mã {dt.Madoituong} thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show($"Bạn phải Click vào gì đó", "Thông báo");
                return;
            }
        }

        private void btnXoaDoiTuong_Click(object sender, RoutedEventArgs e)
        {
            DoiTuong_DTO dt = new DoiTuong_DTO();
            dt.Madoituong = txtMaDoiTuong.Text;
            dt.Tendoituong = txtTenDoiTuong.Text;

            //Lấy tất cả ID thí sinh có tham chiếu với mã đối tượng
            getID_ThiSinh = ThiSinh_BUS.getID_ThiSinh_FDoiTuong_BUS(dt);

            if (SelectedDoiTuong != null)
            {
                MessageBoxResult Result = MessageBox.Show("Nếu xóa bạn sẽ mất tất cả dữ liệu liên quan đến Đối Tượng này", "Thông báo", MessageBoxButton.OKCancel);
                if (Result == MessageBoxResult.OK)
                {
                    //Xóa tất cả tài khoản có tham chiếu mã thí sinh

                    if (getID_ThiSinh != null)
                    {
                        foreach (var item in getID_ThiSinh)
                        {
                            TaiKhoan_DTO tk = new TaiKhoan_DTO();
                            tk.Manguoidung = item.Sbd;
                            TaiKhoan_BUS.XoaFK_TaiKhoan_BUS(tk);
                        }
                    }

                    //Xóa tất cả thí sinh có tham chiếu 
                    if (ThiSinh_BUS.XoaFK_ThiSinh_FDoiTuong_BUS(dt.Madoituong)) ;

                    if (DoiTuong_BUS.XoaDoiTuong_BUS(dt.Madoituong))
                    {
                        MessageBox.Show($"Đã xóa tất cả thông tin liên quan đến đối tượng {dt.Tendoituong}", "Thông báo");
                        DanhSachDoiTuong();
                    }
                    else
                        MessageBox.Show($"Xóa thất bại", "Thông báo");
                }
                else
                    return;
            }
            else
            {
                MessageBox.Show("Bạn phải Click chọn vào gì đó", "Thông báo");
                return;
            }
               
        }
    }
}
