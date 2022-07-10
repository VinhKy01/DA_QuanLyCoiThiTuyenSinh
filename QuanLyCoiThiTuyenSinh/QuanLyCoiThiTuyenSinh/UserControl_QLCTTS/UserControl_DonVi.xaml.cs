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
    /// Interaction logic for UserControl_DonVi.xaml
    /// </summary>
    public partial class UserControl_DonVi : UserControl
    {
        bool flag = true;
        private DonVi_DTO KiemTraID_DonVi;
        private List<DonVi_DTO> listDonVi;
        private DonVi_DTO _selectedDonVi;

        public DonVi_DTO SelectedDonVi 
        { 
            get => _selectedDonVi;
            set 
            { 
                _selectedDonVi = value;
                if (SelectedDonVi == null)
                    return;
                txtMaDonVi.Text = SelectedDonVi.Madonvi;
                txtTenDonVi.Text = SelectedDonVi.Tendonvi;
            }
        }

        public UserControl_DonVi()
        {
            InitializeComponent();
            DataContext = this;
            load();
        }

        void load()
        {
            DanhSachDonVi();
        }

        void DanhSachDonVi()
        {
            listDonVi = DonVi_BUS.DanhSachDonVi();
            dtgDonVi.ItemsSource = listDonVi;
        }

        private void btnFlag_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                btnFlag.Content = "-";

                btnThemDonVi.IsEnabled = true;
                btnCapNhatDonVi.IsEnabled = false;
                btnXoaDonVi.IsEnabled = false;
                txtMaDonVi.IsEnabled = true;

                txtMaDonVi.Clear();
                txtTenDonVi.Clear();
                txtMaDonVi.Focus();
            }
            else
            {
                flag = true;
                btnFlag.Content = "+";

                btnThemDonVi.IsEnabled = false;
                btnCapNhatDonVi.IsEnabled = true;
                btnXoaDonVi.IsEnabled = true;
                txtMaDonVi.IsEnabled = false;
            }
        }

        private void btnThemDonVi_Click(object sender, RoutedEventArgs e)
        {
            DonVi_DTO dv = new DonVi_DTO();
            dv.Madonvi = txtMaDonVi.Text;
            dv.Tendonvi = txtTenDonVi.Text;

            if (dv.Madonvi == "" || dv.Tendonvi == "")
            {
                MessageBox.Show("Bạn phải đầy đủ thông tin !!!", "Thông báo");
                return;
            }

            KiemTraID_DonVi = DonVi_BUS.KiemTraID_DonVi(dv);
            if (KiemTraID_DonVi == null)
            {
                if (DonVi_BUS.ThemDonVi_BUS(dv))
                {
                    MessageBox.Show($"Thêm đơn vị {dv.Tendonvi} thành công", "Thông báo");
                    DanhSachDonVi();
                }
                else
                {
                    MessageBox.Show($"Thêm đơn vị {dv.Tendonvi} thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show($"Mã đơn vị {dv.Madonvi} bị trùng vui lòng đặt mã khác !", "Thông báo");
            }
        }

        private void btnCapNhatDonVi_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedDonVi != null)
            {
                DonVi_DTO dv = new DonVi_DTO();
                dv.Madonvi = txtMaDonVi.Text;
                dv.Tendonvi = txtTenDonVi.Text;

                if (DonVi_BUS.CapNhatDonVi_BUS(dv))
                {
                    MessageBox.Show($"Đã cập nhật đơn vị {SelectedDonVi.Tendonvi} thành {dv.Tendonvi}", "Thông báo");
                    DanhSachDonVi();
                }
                else
                {
                    MessageBox.Show($"Cập nhật đơn vị {SelectedDonVi.Tendonvi} thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải Click chọn gì đó !", "Thông báo");
                return;
            }
        }

        private void btnXoaDonVi_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedDonVi != null)
            {
                DonVi_DTO dv = new DonVi_DTO();
                dv.Madonvi = txtMaDonVi.Text;
                dv.Tendonvi = txtTenDonVi.Text;

                MessageBoxResult result = MessageBox.Show("Dữ liệu liên quan đến Đơn Vị sẽ bị xóa bạn có chắc ???", "Thông báo", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    //Xóa tham chiếu đơn vị đến Giám Thị
                    string madv = dv.Madonvi;
                    GiamThi_BUS.XoaFK_GiamThi_FDonVi(madv);

                    //Xóa đơn vị
                    if (DonVi_BUS.XoaDonVi_BUS(dv))
                    {
                        MessageBox.Show($"Xóa đơn vị {dv.Tendonvi} thành công", "Thông báo");
                        DanhSachDonVi();
                    }
                    else
                    {
                        MessageBox.Show($"Xóa đơn vị {dv.Tendonvi} thất bại", "Thông báo");
                    }
                }
                else
                    return;
            }
            else
            {
                MessageBox.Show("Bạn phải Click chọn gì đó !", "Thông báo");
                return;
            }
        }
    }
}
