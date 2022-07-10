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
    /// Interaction logic for UserControl_BuoiThi.xaml
    /// </summary>
    public partial class UserControl_BuoiThi : UserControl
    {
        bool flag = true;
        private List<BuoiThi_DTO> ListDanhSachBuoiThi;
        private BuoiThi_DTO KiemTraID_BuoiThi;
        private BuoiThi_DTO _selectedBuoiThi;

        public BuoiThi_DTO SelectedBuoiThi 
        { 
            get => _selectedBuoiThi;
            set
            { 
                _selectedBuoiThi = value;
                if (SelectedBuoiThi == null)
                    return;
                txtMaBuoiThi.Text = SelectedBuoiThi.Mabt;
                txtBuoiThi.Text = SelectedBuoiThi.Tenbt;
            }
        }

        public UserControl_BuoiThi()
        {
            InitializeComponent();
            DataContext = this;
            load();
        }

        void load()
        {
            DanhSachBuoiThi();
        }

        void DanhSachBuoiThi()
        {
            ListDanhSachBuoiThi = BuoiThi_BUS.DanhSachBuoiThi();
            dtgBuoiThi.ItemsSource = ListDanhSachBuoiThi;
        }

        private void btnFlag_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                btnFlag.Content = "-";

                btnThemBuoiThi.IsEnabled = true;
                btnCapNhatBuoiThi.IsEnabled = false;
                btnXoaBuoiThi.IsEnabled = false;
                txtMaBuoiThi.IsEnabled = true;

                txtMaBuoiThi.Clear();
                txtBuoiThi.Clear();
                txtMaBuoiThi.Focus();
            }
            else
            {
                flag = true;
                btnFlag.Content = "+";

                btnThemBuoiThi.IsEnabled = false;
                btnCapNhatBuoiThi.IsEnabled = true;
                btnXoaBuoiThi.IsEnabled = true;
                txtMaBuoiThi.IsEnabled = false;
            }
        }

        private void btnThemBuoiThi_Click(object sender, RoutedEventArgs e)
        {
            BuoiThi_DTO bt = new BuoiThi_DTO();
            bt.Mabt = txtMaBuoiThi.Text;
            bt.Tenbt = txtBuoiThi.Text;

            if (bt.Mabt == "" || bt.Tenbt == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            KiemTraID_BuoiThi = BuoiThi_BUS.KiemTraID_BuoiThi(bt);
            if (KiemTraID_BuoiThi == null)
            {
                if (BuoiThi_BUS.ThemBuoiThi_BUS(bt))
                {
                    MessageBox.Show("Thêm mới thành công", "Thông báo");
                    DanhSachBuoiThi();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show($"Mã buổi thi {bt.Mabt} bị trùng vui lòng đặt mã khác", "Thông báo");
            }
        }

        private void btnCapNhatBuoiThi_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedBuoiThi != null)
            {
                BuoiThi_DTO bt = new BuoiThi_DTO();
                bt.Mabt = txtMaBuoiThi.Text;
                bt.Tenbt = txtBuoiThi.Text;

                if (BuoiThi_BUS.CapNhatBuoiThi_BUS(bt))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    DanhSachBuoiThi();
                }
                else
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn phải Click chọn gì đó", "Thông báo");
                return;
            }
        }

        private void btnXoaBuoiThi_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedBuoiThi != null)
            {
                MessageBoxResult result = MessageBox.Show("Mọi dữ liệu liên quan đến buổi thi cũng sẽ bị xóa bạn có chắc ???", "Thông báo", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    BuoiThi_DTO bt = new BuoiThi_DTO();
                    bt.Mabt = txtMaBuoiThi.Text;
                    bt.Tenbt = txtBuoiThi.Text;

                    //Xóa môn thi có tham chiếu buổi thi
                    string maBT = bt.Mabt;
                    if (MonHoc_BUS.XoaFK_Mon_FBuoiThi(maBT)) ;

                    //Xóa buổi thi
                    if (BuoiThi_BUS.XoaBuoiThi_BUS(bt))
                    {
                        MessageBox.Show($"Xóa buổi thi {bt.Tenbt} thành công");
                        DanhSachBuoiThi();
                    }
                    else
                        MessageBox.Show($"Xóa buổi thi {bt.Tenbt} thất bại", "Thông báo");
                }
                else
                    return;
            }
            else
            {
                MessageBox.Show($"Bạn phải Click chọn vào gì đó !", "Thông báo");
                return;
            }
        }
    }
}
