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
    /// Interaction logic for UserControl_KhuVuc.xaml
    /// </summary>
    public partial class UserControl_KhuVuc : UserControl
    {
        bool flag = true;
        private List<ThiSinh_DTO> getID_ThiSinh_FKhuVuc;
        private List<KhucVuc_DTO> ListDanhSachKhuVuc;
        private KhucVuc_DTO KiemTraID_KhuVuc;
        private KhucVuc_DTO _selectedKhuVuc;

        public KhucVuc_DTO SelectedKhuVuc 
        { 
            get => _selectedKhuVuc;
            set
            { 
                _selectedKhuVuc = value;
                if (SelectedKhuVuc == null)
                    return;
                txtMaKhuVuc.Text = SelectedKhuVuc.Makhuvuc;
                txtTenKhuVuc.Text = SelectedKhuVuc.Tenkhuvuc;
            }
        }

        public UserControl_KhuVuc()
        {
            InitializeComponent();
            DataContext = this;
            load();
        }

        void load()
        {
            DanhSachKhuVuc();
        }

        void DanhSachKhuVuc()
        {
            ListDanhSachKhuVuc = KhuVuc_BUS.DanhSachKhuVuc();
            dtgKhuVuc.ItemsSource = ListDanhSachKhuVuc;
        }

        private void btnFlag_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                btnFlag.Content = "-";

                btnThemKhuVuc.IsEnabled = true;
                btnCapNhatKhuVuc.IsEnabled = false;
                btnXoaKhuVuc.IsEnabled = false;
                txtMaKhuVuc.IsEnabled = true;

                txtMaKhuVuc.Clear();
                txtTenKhuVuc.Clear();
                txtMaKhuVuc.Focus();
            }
            else
            {
                flag = true;
                btnFlag.Content = "+";

                btnThemKhuVuc.IsEnabled = false;
                btnCapNhatKhuVuc.IsEnabled = true;
                btnXoaKhuVuc.IsEnabled = true;
                txtMaKhuVuc.IsEnabled = false;
            }
        }

        private void btnThemKhuVuc_Click(object sender, RoutedEventArgs e)
        {
            KhucVuc_DTO kv = new KhucVuc_DTO();
            kv.Makhuvuc = txtMaKhuVuc.Text;
            kv.Tenkhuvuc = txtTenKhuVuc.Text;

            if (txtMaKhuVuc.Text == "" || txtTenKhuVuc.Text == "")
            {
                MessageBox.Show($"Bạn phải nhập đầy đủ thông tin !!!", "Thông báo");
                return;
            }

            KiemTraID_KhuVuc = KhuVuc_BUS.KiemTraID_KhuVuc(kv);
            if (KiemTraID_KhuVuc == null)
            {
                if (KhuVuc_BUS.ThemKhuVuc_BUS(kv))
                {
                    MessageBox.Show($"Đã thêm khu vực {kv.Makhuvuc} thành công", "Thông báo");
                    DanhSachKhuVuc();
                }
            }
            else
                MessageBox.Show($"Mã khu vực {kv.Makhuvuc} bị trùng vui lòng đặt mã khác", "Thông báo");
        }

        private void btnCapNhatKhuVuc_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedKhuVuc != null)
            {
                KhucVuc_DTO kv = new KhucVuc_DTO();
                kv.Makhuvuc = txtMaKhuVuc.Text;
                kv.Tenkhuvuc = txtTenKhuVuc.Text;

                if (KhuVuc_BUS.CapNhatKhuVuc_BUS(kv))
                {
                    MessageBox.Show($"Đã cập nhật khu vực có mã {kv.Makhuvuc} thành công", "Thông báo");
                    DanhSachKhuVuc();
                }
                else
                {
                    MessageBox.Show($"Đã cập nhật khu vực có mã {kv.Makhuvuc} thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show($"Bạn phải Click vào gì đó", "Thông báo");
                return;
            }
        }

        private void btnXoaKhuVuc_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedKhuVuc != null)
            {
                KhucVuc_DTO kv = new KhucVuc_DTO();
                kv.Makhuvuc = txtMaKhuVuc.Text;
                kv.Tenkhuvuc = txtTenKhuVuc.Text;
                
                string makc = kv.Makhuvuc;
                getID_ThiSinh_FKhuVuc = ThiSinh_BUS.getID_ThiSinh_FKhuVuc(makc);
                if (getID_ThiSinh_FKhuVuc != null)
                {
                    foreach (var item in getID_ThiSinh_FKhuVuc)
                    {
                        TaiKhoan_DTO tk = new TaiKhoan_DTO();
                        tk.Manguoidung = item.Sbd;
                        TaiKhoan_BUS.XoaFK_TaiKhoan_BUS(tk);
                    }
                }

                string makhuvuc = kv.Makhuvuc;
                if (ThiSinh_BUS.XoaFK_ThiSinh_FKhuVuc_BUS(makhuvuc)) ;

                if (KhuVuc_BUS.XoaKhuVuc_BUS(kv))
                {
                    MessageBox.Show($"Đã xóa khu vực {kv.Tenkhuvuc} thành công", "Thông báo");
                    DanhSachKhuVuc();
                }
            }
            else
            {
                MessageBox.Show($"Bạn phải Click vào gì đó", "Thông báo");
                return;
            }
        }
    }
}
