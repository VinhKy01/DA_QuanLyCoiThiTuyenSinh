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
    /// Interaction logic for UserControl_ThoiGianThi.xaml
    /// </summary>
    public partial class UserControl_ThoiGianThi : UserControl
    {
        bool flag = true;
        private List<ThoiGian_DTO> ListDanhSachThoiGian;
        private ThoiGian_DTO KIemTraID_ThoiGian;
        private ThoiGian_DTO _selectedThoiGian;

        public ThoiGian_DTO SelectedThoiGian 
        { 
            get => _selectedThoiGian;
            set
            {
                _selectedThoiGian = value;
                if (SelectedThoiGian == null)
                    return;
                txtMaTG.Text = SelectedThoiGian.Matg;
                txtTG.Text = SelectedThoiGian.Thoigian;
            }
        }

        public UserControl_ThoiGianThi()
        {
            InitializeComponent();
            DataContext = this;
            load();
        }

        void load()
        {
            DanhSachThoiGian();
        }

        void DanhSachThoiGian()
        {
            ListDanhSachThoiGian = ThoiGian_BUS.DanhSachThoiGian();
            dtgThoiGian.ItemsSource = ListDanhSachThoiGian;
        }

        private void btnFlag_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                btnFlag.Content = "-";

                btnThemThoiGian.IsEnabled = true;
                btnCapNhatThoiGian.IsEnabled = false;
                btnXoaThoiGian.IsEnabled = false;
                txtMaTG.IsEnabled = true;

                txtMaTG.Clear();
                txtTG.Clear();
                txtMaTG.Focus();
            }
            else
            {
                flag = true;
                btnFlag.Content = "+";

                btnThemThoiGian.IsEnabled = false;
                btnCapNhatThoiGian.IsEnabled = true;
                btnXoaThoiGian.IsEnabled = true;
                txtMaTG.IsEnabled = false;
            }
        }

        private void btnThemThoiGian_Click(object sender, RoutedEventArgs e)
        {
            ThoiGian_DTO tg = new ThoiGian_DTO();
            tg.Matg = txtMaTG.Text;
            tg.Thoigian = txtTG.Text;

            if (txtMaTG.Text == "" || txtTG.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            KIemTraID_ThoiGian = ThoiGian_BUS.KIemTraID_ThoiGian(tg);
            if (KIemTraID_ThoiGian == null)
            {
                if (ThoiGian_BUS.ThemThoiGianMoi_BUS(tg))
                {
                    MessageBox.Show($"Vừa thêm thời {tg.Thoigian} vào danh sách", "Thông báo");
                    DanhSachThoiGian();
                }
                else
                {
                    MessageBox.Show($"Thêm mới thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show($"Mã {tg.Matg} bị trùng vui lòng đặt mã khác", "Thông báo");
            }
        }

        private void btnCapNhatThoiGian_Click(object sender, RoutedEventArgs e)
        {
            ThoiGian_DTO tg = new ThoiGian_DTO();
            tg.Matg = txtMaTG.Text;
            tg.Thoigian = txtTG.Text;

            if (SelectedThoiGian != null)
            {
                if (ThoiGian_BUS.CapNhatThoiGian_BUS(tg))
                {
                    MessageBox.Show($"Đã cập nhật {SelectedThoiGian.Thoigian} thành {tg.Thoigian}", "Thông báo");
                    DanhSachThoiGian();
                }
                else
                {
                    MessageBox.Show($"Cập nhật thời gian thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show($"Bạn phải Click vào gì đó", "Thông báo");
                return;
            }
        }

        private void btnXoaThoiGian_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedThoiGian != null)
            {
                ThoiGian_DTO tg = new ThoiGian_DTO();
                tg.Matg = txtMaTG.Text;
                tg.Thoigian = txtTG.Text;

                //Xóa Môn có tham chiếu thời gian
                string maTG = tg.Matg;
                MonHoc_BUS.XoaFK_Mon_FThoiGianThi(maTG);

                //Xóa thời gian
                if (ThoiGian_BUS.XoaThoiGian(tg))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    DanhSachThoiGian();
                }
                else
                    MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn phải Click chọn gì đó !", "Thông báo");
                return;
            }
        }
    }
}
