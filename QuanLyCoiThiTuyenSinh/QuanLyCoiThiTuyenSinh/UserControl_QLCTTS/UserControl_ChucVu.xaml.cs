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
    /// Interaction logic for UserControl_ChucVu.xaml
    /// </summary>
    public partial class UserControl_ChucVu : UserControl
    {
        bool flag = true;
        private List<ChucVu_DTO> listChucVu { get; set; }

        private ChucVu_DTO KiemTraID_ChucVu;
        private ChucVu_DTO _selectedChucVu;
        public ChucVu_DTO SelectedChucVu 
        { 
            get => _selectedChucVu;
            set 
            {
                _selectedChucVu = value;
                if (SelectedChucVu == null)
                    return;
                txtMaChucVu.Text = SelectedChucVu.Machucvu;
                txtTenChucVu.Text = SelectedChucVu.Tenchucvu;
            }
        }
        public UserControl_ChucVu()
        {
            InitializeComponent();
            DataContext = this;
            load();
        }

        void load()
        {
            DanhSachChucVu();
        }

        void DanhSachChucVu()
        {
            listChucVu = ChucVu_BUS.DanhSachChucVu_BUS();
            dtgChucVu.ItemsSource = listChucVu;
        }

        private void btnFlag_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                btnFlag.Content = "-";

                btnThemChucVu.IsEnabled = true;
                btnCapNhatChucVu.IsEnabled = false;
                btnXoaChucVu.IsEnabled = false;
                txtMaChucVu.IsEnabled = true;

                txtMaChucVu.Clear();
                txtTenChucVu.Clear();
                txtMaChucVu.Focus();
            }
            else
            {
                flag = true;
                btnFlag.Content = "+";

                btnThemChucVu.IsEnabled = false;
                btnCapNhatChucVu.IsEnabled = true;
                btnXoaChucVu.IsEnabled = true;
                txtMaChucVu.IsEnabled = false;
            }
        }

        private void btnThemChucVu_Click(object sender, RoutedEventArgs e)
        {
            ChucVu_DTO cv = new ChucVu_DTO();
            cv.Machucvu = txtMaChucVu.Text;
            cv.Tenchucvu = txtTenChucVu.Text;

            if (cv.Machucvu == "" || cv.Tenchucvu == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            KiemTraID_ChucVu = ChucVu_BUS.KiemTraID_ChucVu_BUS(cv);
            if (KiemTraID_ChucVu == null)
            {
                if (ChucVu_BUS.ThemChucVu_BUS(cv))
                {
                    MessageBox.Show($"Thêm chức vụ {cv.Tenchucvu} thành công", "Thông báo");
                    DanhSachChucVu();
                }
                else
                {
                    MessageBox.Show($"Thêm chức vụ {cv.Tenchucvu} thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show($"Mã chức vụ {cv.Machucvu} bị trùng vui lòng đặt mã khác", "Thông báo");
                return;
            }
        }

        private void btnCapNhatChucVu_Click(object sender, RoutedEventArgs e)
        {
            ChucVu_DTO cv = new ChucVu_DTO();
            cv.Machucvu = txtMaChucVu.Text;
            cv.Tenchucvu = txtTenChucVu.Text;

            if (SelectedChucVu != null)
            {
                if (ChucVu_BUS.CapNhatChucVu_BUS(cv))
                {
                    MessageBox.Show($"Đã cập nhật chức vụ {SelectedChucVu.Tenchucvu} thành {cv.Tenchucvu}", "Thông báo");
                    DanhSachChucVu();
                }
                else
                {
                    MessageBox.Show($"Đã cập nhật chức vụ {SelectedChucVu.Tenchucvu} thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải Click chọn gì đó !", "Thông báo");
                return;
            }
        }

        private void btnXoaChucVu_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedChucVu != null)
            {
                ChucVu_DTO cv = new ChucVu_DTO();
                cv.Machucvu = txtMaChucVu.Text;
                cv.Tenchucvu = txtTenChucVu.Text;

                //Xóa Giám Thị tham chiếu Chức Vụ
                string macv = cv.Machucvu;
                if(GiamThi_BUS.XoaFK_GiamThi_FChucVu(macv)) ;

                //Xóa chức vụ
                if (ChucVu_BUS.XoaChucVu_BUS(cv))
                {
                    MessageBox.Show($"Xóa chức vụ {cv.Tenchucvu} thành công", "Thông báo");
                    DanhSachChucVu();
                }
                else
                {
                    MessageBox.Show($"Xóa chức vụ {cv.Tenchucvu} thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải Click chọn gì đó !", "Thông báo");
                return;
            }    
        }
    }
}
