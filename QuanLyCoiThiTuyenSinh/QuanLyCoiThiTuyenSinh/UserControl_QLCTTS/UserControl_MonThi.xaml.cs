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
    /// Interaction logic for UserControl_MonThi.xaml
    /// </summary>
    public partial class UserControl_MonThi : UserControl
    {
        bool flag = true;
        private List<Nganh_DTO> ListCBB_NganhHoc;
        private List<BuoiThi_DTO> ListCBB_BuoiThi;
        private List<ThoiGian_DTO> ListCBB_ThoiGian;
        private List<MonHoc_DTO> ListDanhSachMonHoc;
        private MonHoc_DTO KiemTraID_MonHoc;
        private MonHoc_DTO _selectedMonThi;

        public MonHoc_DTO SelectedMonThi 
        { 
            get => _selectedMonThi;
            set
            { 
                _selectedMonThi = value;
                if (SelectedMonThi == null)
                    return;
                txtMaMonHoc.Text = SelectedMonThi.Mamon;
                txtTenMonHoc.Text = SelectedMonThi.Tenmon;
                dtpkNgayThi.Text = (SelectedMonThi.Ngaythi).ToString();
                cbbBuoiThi.Text = SelectedMonThi.Buoithi;
                cbbThoiGianThi.Text = (SelectedMonThi.Thoigian).ToString();
                cbbNganhHoc.Text = SelectedMonThi.Tennganh;
            }
        }

        public UserControl_MonThi()
        {
            InitializeComponent();
            DataContext = this;
            load();
        }

        void load()
        {

            //Load danh sach thời gian lên combobox
            DanhSachCBB_ThoiGianThi();
            //Load danh sach buổi thi lên combobox
            DanhSachCBB_BuoiThi();
            //Load danh sách ngành học lên combobox
            DanhSachCBB_NganhHoc();
            //Load danh sách môn học lên datagrid
            DanhSachMonHoc();
            //Danh sách combobox tìm ngành học
            DanhSachCBB_TimNganhHoc();
        }
        
        void DanhSachCBB_BuoiThi()
        {
            ListCBB_BuoiThi = BuoiThi_BUS.DanhSachBuoiThi();
            cbbBuoiThi.ItemsSource = ListCBB_BuoiThi;
            cbbBuoiThi.DisplayMemberPath = "Tenbt";
            cbbBuoiThi.SelectedValuePath = "Mabt";
        }

        void DanhSachCBB_ThoiGianThi()
        {
            ListCBB_ThoiGian = ThoiGian_BUS.DanhSachThoiGian();
            cbbThoiGianThi.ItemsSource = ListCBB_ThoiGian;
            cbbThoiGianThi.DisplayMemberPath = "Thoigian";
            cbbThoiGianThi.SelectedValuePath = "Matg";
        }

        void DanhSachCBB_NganhHoc()
        {
            ListCBB_NganhHoc = Nganh_BUS.DanhSachNganhHoc_BUS();
            cbbNganhHoc.ItemsSource = ListCBB_NganhHoc;
            cbbNganhHoc.DisplayMemberPath = "Tennganh";
            cbbNganhHoc.SelectedValuePath = "Manganh";
        }

        void DanhSachCBB_TimNganhHoc()
        {
            ListCBB_NganhHoc = Nganh_BUS.DanhSachNganhHoc_BUS();
            cbbTimNganhHoc.ItemsSource = ListCBB_NganhHoc;
            cbbTimNganhHoc.DisplayMemberPath = "Tennganh";
            cbbTimNganhHoc.SelectedValuePath = "Manganh";
        }

        void DanhSachMonHoc()
        {
            ListDanhSachMonHoc = MonHoc_BUS.DanhSachMonHoc();
            dtgMonThi.ItemsSource = ListDanhSachMonHoc;
        }

        private void btnFlag_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                btnFlag.Content = "-";

                btnThemMonHoc.IsEnabled = true;
                btnCapNhatMonHoc.IsEnabled = false;
                btnXoaMonHoc.IsEnabled = false;
                txtMaMonHoc.IsEnabled = true;

                txtMaMonHoc.Clear();
                txtTenMonHoc.Clear();
                txtMaMonHoc.Focus();
            }
            else
            {
                flag = true;
                btnFlag.Content = "+";

                btnThemMonHoc.IsEnabled = false;
                btnCapNhatMonHoc.IsEnabled = true;
                btnXoaMonHoc.IsEnabled = true;
                txtMaMonHoc.IsEnabled = false;
            }
        }

        private void btnThemMonHoc_Click(object sender, RoutedEventArgs e)
        {
            MonHoc_DTO mh = new MonHoc_DTO();
            mh.Mamon = txtMaMonHoc.Text;
            mh.Tenmon = txtTenMonHoc.Text;
            mh.Ngaythi = DateTime.Parse(dtpkNgayThi.Text);
            mh.Buoithi = cbbBuoiThi.SelectedValue.ToString();
            mh.Thoigian = cbbThoiGianThi.SelectedValue.ToString();
            mh.Tennganh = cbbNganhHoc.SelectedValue.ToString();

            if (txtMaMonHoc.Text == "" || txtTenMonHoc.Text == "" || dtpkNgayThi.Text == "" || cbbBuoiThi.SelectedValue.ToString() == "" || cbbThoiGianThi.SelectedValue.ToString() == "" || cbbNganhHoc.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin !!!", "Thông báo");
                return;
            }

            KiemTraID_MonHoc = MonHoc_BUS.KiemTraID_MonHoc(mh);
            if (KiemTraID_MonHoc == null)
            {
                if (MonHoc_BUS.ThemMonHoc_BUS(mh))
                {
                    MessageBox.Show($"Thêm môn học {mh.Tenmon} thành công");
                    DanhSachMonHoc();
                }
                else
                    MessageBox.Show($"Thêm môn học {mh.Tenmon} thất bại");
            }
            else
            {
                MessageBox.Show($"Mã môn {mh.Mamon} đã bị trùng vui lòng đặt mã khác", "Thông báo");
            }
        }

        private void btnCapNhatMonHoc_Click(object sender, RoutedEventArgs e)
        {
            MonHoc_DTO mh = new MonHoc_DTO();
            mh.Mamon = txtMaMonHoc.Text;
            mh.Tenmon = txtTenMonHoc.Text;
            mh.Ngaythi = DateTime.Parse(dtpkNgayThi.Text);
            mh.Buoithi = cbbBuoiThi.SelectedValue.ToString();
            mh.Thoigian = cbbThoiGianThi.SelectedValue.ToString();
            mh.Tennganh = cbbNganhHoc.SelectedValue.ToString();

            if (SelectedMonThi != null)
            {
                if (MonHoc_BUS.CapNhatMonHoc_BUS(mh))
                {
                    MessageBox.Show($"Đã cập nhật môn học {mh.Tenmon} thành công", "Thông báo");
                    DanhSachMonHoc();
                }
                else
                {
                    MessageBox.Show($"Đã cập nhật môn học {mh.Tenmon} thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show($"Bạn phải Click vào gì đó", "Thông báo");
                return;
            }
        }

        private void btnXoaMonHoc_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedMonThi != null)
            {
                MonHoc_DTO mh = new MonHoc_DTO();
                mh.Mamon = txtMaMonHoc.Text;
                mh.Tenmon = txtTenMonHoc.Text;
                mh.Ngaythi = DateTime.Parse(dtpkNgayThi.Text);
                mh.Buoithi = cbbBuoiThi.SelectedValue.ToString();
                mh.Thoigian = cbbThoiGianThi.SelectedValue.ToString();
                mh.Tennganh = cbbNganhHoc.SelectedValue.ToString();

                if (MonHoc_BUS.XoaMonThi(mh))
                {
                    MessageBox.Show($"Xóa môn thi {mh.Tenmon} thành công", "Thông báo");
                    DanhSachMonHoc();
                }
                else
                    MessageBox.Show($"Xóa môn {mh.Tenmon} thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn phải Click vào gì đó !", "Thông báo");
                return;
            }
        }

        private void txtTimTenMon_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tenMon = txtTimTenMon.Text;
            ListDanhSachMonHoc = MonHoc_BUS.TimTenMonHoc(tenMon);
            dtgMonThi.ItemsSource = ListDanhSachMonHoc;
        }

        private void cbbTimNganhHoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string maNganh = cbbTimNganhHoc.SelectedValue.ToString();
            ListDanhSachMonHoc = MonHoc_BUS.TimMon_TheoNganhThi(maNganh);
            dtgMonThi.ItemsSource = ListDanhSachMonHoc;
        }
    }
}
