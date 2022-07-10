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
    /// Interaction logic for UserControl_NganhHoc.xaml
    /// </summary>
    public partial class UserControl_NganhHoc : UserControl
    {
        bool flag = true;
        private List<ThiSinh_DTO> getID_MaNganh;
        private Nganh_DTO kiemTraID_NganhHoc;
        private List<Nganh_DTO> listNganhHoc { get; set; }
        private Nganh_DTO _SelectedNganhHoc;

        public Nganh_DTO SelectedNganhHoc 
        { 
            get => _SelectedNganhHoc; 
            set
            {
                _SelectedNganhHoc = value;
                if (SelectedNganhHoc == null)
                    return;
                txtMaNganh.Text = SelectedNganhHoc.Manganh;
                txtTenNganh.Text = SelectedNganhHoc.Tennganh;
            }
        }

        public UserControl_NganhHoc()
        {
            InitializeComponent();
            DataContext = this;
            load();
        }

        void load()
        {
            DanhSachNganhHoc();
        }

        void DanhSachNganhHoc()
        {
            listNganhHoc = Nganh_BUS.DanhSachNganhHoc_BUS();
            dtgNganhHoc.ItemsSource = listNganhHoc;
        }

        private void btnThemNganhHoc_Click(object sender, RoutedEventArgs e)
        {
            Nganh_DTO n = new Nganh_DTO();
            n.Manganh = txtMaNganh.Text;
            n.Tennganh = txtTenNganh.Text;

            if (txtMaNganh.Text == "" || txtTenNganh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            kiemTraID_NganhHoc = Nganh_BUS.KiemTraID_NganhHoc(n);
            if (kiemTraID_NganhHoc == null)
            {
                if (Nganh_BUS.ThemNganhHoc_BUS(n))
                {
                    MessageBox.Show($"Đã thêm vào ngành mới {n.Tennganh} thành công");
                    DanhSachNganhHoc();
                }
                else
                {
                    MessageBox.Show($"Thêm vào ngành {n.Tennganh} thất bại");
                }
            }
            else
            {
                MessageBox.Show($"Mã ngành {n.Manganh} đã có vui lòng chọn mã khác");
            }
            
        }

        private void btnCapNhatNganhHoc_Click(object sender, RoutedEventArgs e)
        {
            Nganh_DTO n = new Nganh_DTO();
            n.Manganh = txtMaNganh.Text;
            n.Tennganh = txtTenNganh.Text;

            if (Nganh_BUS.CapNhatNganhHoc_BUS(n))
            {
                if (SelectedNganhHoc != null)
                {
                    MessageBox.Show($"Đã cập nhật tên ngành {SelectedNganhHoc.Tennganh} thành {n.Tennganh}", "thông báo");
                    DanhSachNganhHoc();
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn Click chọn gì đó", "Thông báo");
                    return;
                }
            }
            else
            {
                MessageBox.Show($"Đã cập nhật tên ngành [{SelectedNganhHoc.Tennganh}] thành [{n.Tennganh}] thất bại", "thông báo");
            }
        }

        private void btnXoaNganhHoc_Click(object sender, RoutedEventArgs e)
        {
            Nganh_DTO n = new Nganh_DTO();
            n.Manganh = txtMaNganh.Text;
            n.Tennganh = txtTenNganh.Text;

            if (SelectedNganhHoc != null)
            {
                MessageBoxResult Result = MessageBox.Show("Nếu xóa bạn sẽ mất tất cả dữ liệu liên quan đến Đối Tượng này", "Thông báo", MessageBoxButton.OKCancel);
                if (Result == MessageBoxResult.OK)
                {
                    ThiSinh_DTO ts = new ThiSinh_DTO();
                    ts.Manganh = n.Manganh;
                    //Lấy tất cả id thí sinh có mã ngành ở trên
                    getID_MaNganh = ThiSinh_BUS.getID_ThiSinh_FNganh(ts);
                    //Xóa tài khoản có tham chiếu của ngành và thí sinh ở trên
                    if (getID_MaNganh != null)
                    {
                        foreach (var item in getID_MaNganh)
                        {
                            TaiKhoan_DTO tk = new TaiKhoan_DTO();
                            tk.Manguoidung = item.Sbd;
                            TaiKhoan_BUS.XoaFK_TaiKhoan_BUS(tk);
                        }
                    }

                    //Xóa khóa phụ thí sinh
                    if (ThiSinh_BUS.XoaFK_IDnganh_FThiSinh(ts)) ;

                    MonHoc_DTO mh = new MonHoc_DTO();
                    mh.Tennganh = n.Manganh;
                    //Xóa khóa phụ môn học
                    if (MonHoc_BUS.XoaFK_IDNganh_FMonThi(mh)) ;

                    //Xóa ngành học
                    if (Nganh_BUS.XoaNganhHoc_BUS(n))
                    {
                        MessageBox.Show($"Xóa ngành {n.Tennganh} thành công");
                        string slts = ThiSinh_BUS.SoLuongThiSinh();
                        foreach (Window window in Application.Current.Windows)
                        {
                            if (window.GetType() == typeof(MainWindow))
                            {
                                (window as MainWindow).txtSoLuongThiSinh.Text = $"{slts} Thí Sinh";
                            }
                        }
                        DanhSachNganhHoc();
                    }
                }
                else
                    return;
            }
            else
            {
                MessageBox.Show("Bạn phải Click chọn gì đó", "Thông báo");
                return;
            }
        }

        private void btnFlag_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                btnFlag.Content = "-";

                btnThemNganhHoc.IsEnabled = true;
                btnCapNhatNganhHoc.IsEnabled = false;
                btnXoaNganhHoc.IsEnabled = false;
                txtMaNganh.IsEnabled = true;

                txtMaNganh.Clear();
                txtTenNganh.Clear();
                txtMaNganh.Focus();
            }
            else
            {
                flag = true;
                btnFlag.Content = "+";

                btnThemNganhHoc.IsEnabled = false;
                btnCapNhatNganhHoc.IsEnabled = true;
                btnXoaNganhHoc.IsEnabled = true;
                txtMaNganh.IsEnabled = false;
            }
        }

        private void txtTimTenNganh_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tenNganh = txtTimTenNganh.Text;
            listNganhHoc = Nganh_BUS.TimNganhThi(tenNganh);
            dtgNganhHoc.ItemsSource = listNganhHoc;
        }

    }
}
