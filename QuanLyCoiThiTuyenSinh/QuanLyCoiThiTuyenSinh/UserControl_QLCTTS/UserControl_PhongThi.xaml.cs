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
    /// Interaction logic for UserControl_PhongThi.xaml
    /// </summary>
    public partial class UserControl_PhongThi : UserControl
    {
        bool flag = true;
        private List<ThiSinh_DTO> getID_ThiSinh_FPhongThi;
        private List<DiaDiemThi_DTO> ListCBB_DiaDiemThi;
        private List<PhongThi_DTO> ListDanhSach_PhongThi;
        private PhongThi_DTO KiemTraID_PhongThi;
        private PhongThi_DTO _selectedPhongHoc;

        public PhongThi_DTO SelectedPhongHoc 
        { 
            get => _selectedPhongHoc;
            set
            {
                _selectedPhongHoc = value;
                if (SelectedPhongHoc == null)
                    return;
                txtMaPhong.Text = SelectedPhongHoc.Maphong;
                cbbDiaDiemThi.Text = SelectedPhongHoc.Diachidiemthi;
                txtGhiChu.Text = SelectedPhongHoc.Ghichu;
            }
        }

        public UserControl_PhongThi()
        {
            InitializeComponent();
            DataContext = this;
            load();
        }

        void load()
        {
            //Load danh sách combobox chức vụ
            DanhSachCBB_DiaDiemThi();
            //Load danh sách phòng thi lên datagrid
            DanhSachPhongThi();
        }

        void DanhSachCBB_DiaDiemThi()
        {
            ListCBB_DiaDiemThi = DiaDiemThi_BUS.DanhSachDiemThiSo();
            cbbDiaDiemThi.ItemsSource = ListCBB_DiaDiemThi;
            cbbDiaDiemThi.DisplayMemberPath = "Diachidiemthi";
            cbbDiaDiemThi.SelectedValuePath = "Diemthiso";
        }

        void DanhSachPhongThi()
        {
            ListDanhSach_PhongThi = PhongThi_BUS.DanhSachPhongThi();
            dtgPhongThi.ItemsSource = ListDanhSach_PhongThi;
        }

        private void btnFlag_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                btnFlag.Content = "-";

                btnThemPhongThi.IsEnabled = true;
                btnCapNhatPhongThi.IsEnabled = false;
                btnXoaPhongThi.IsEnabled = false;
                txtMaPhong.IsEnabled = true;

                txtMaPhong.Clear();
                txtGhiChu.Clear();
                txtMaPhong.Focus();
            }
            else
            {
                flag = true;
                btnFlag.Content = "+";

                btnThemPhongThi.IsEnabled = false;
                btnCapNhatPhongThi.IsEnabled = true;
                btnXoaPhongThi.IsEnabled = true;
                txtMaPhong.IsEnabled = false;
            }
        }

        private void btnThemPhongThi_Click(object sender, RoutedEventArgs e)
        {
            PhongThi_DTO pt = new PhongThi_DTO();
            pt.Maphong = txtMaPhong.Text;
            pt.Diachidiemthi = cbbDiaDiemThi.SelectedValue.ToString();
            pt.Ghichu = txtGhiChu.Text;

            if (txtMaPhong.Text == "" || cbbDiaDiemThi.SelectedValue.ToString() == "" || txtGhiChu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin !!!", "Thông báo");
                return;
            }

            KiemTraID_PhongThi = PhongThi_BUS.KiemTraID_PhongThi(pt);
            if (KiemTraID_PhongThi == null)
            {
                if (PhongThi_BUS.ThemPhongThi_BUS(pt))
                {
                    MessageBox.Show($"Đã thêm vào phòng {pt.Maphong} thành công");
                    DanhSachPhongThi();
                }
                else
                {
                    MessageBox.Show($"Đã thêm vào phòng {pt.Maphong} thất bại");
                }
            }
            else
            {
                MessageBox.Show($"Mã phòng {pt.Maphong} bị trùng vui lòng đặt mã khác", "Thông báo");
            }
        }

        private void btnCapNhatPhongThi_Click(object sender, RoutedEventArgs e)
        {
            PhongThi_DTO pt = new PhongThi_DTO();
            pt.Maphong = txtMaPhong.Text;
            pt.Diachidiemthi = cbbDiaDiemThi.SelectedValue.ToString();
            pt.Ghichu = txtGhiChu.Text;

            if (SelectedPhongHoc != null)
            {
                if (PhongThi_BUS.CapNhatPhongThi_BUS(pt))
                {
                    MessageBox.Show($"Cập nhật phòng thi {pt.Maphong} thành công", "Thông báo");
                    DanhSachPhongThi();
                }
                else
                {
                    MessageBox.Show($"Cập nhật phòng thi {pt.Maphong} thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải Click vào gì đó", "Thông báo");
                return;
            }
        }

        private void btnXoaPhongThi_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedPhongHoc != null)
            {
                PhongThi_DTO pt = new PhongThi_DTO();
                pt.Maphong = txtMaPhong.Text;
                string maPhong = pt.Maphong;
                getID_ThiSinh_FPhongThi = ThiSinh_BUS.getID_ThiSinh_FPhongThi(maPhong);

                //Xóa tài khoản
                if (getID_ThiSinh_FPhongThi != null)
                {
                    foreach (var item in getID_ThiSinh_FPhongThi)
                    {
                        TaiKhoan_DTO tk = new TaiKhoan_DTO();
                        tk.Manguoidung = item.Sbd;
                        TaiKhoan_BUS.XoaFK_TaiKhoan_BUS(tk);
                    }
                }

                //Xóa thí sinh
                if (ThiSinh_BUS.XoaFK_ThiSinh_FPhongThi_BUS(maPhong)) ;

                //Xóa Phòng
                if (PhongThi_BUS.XoaPhongThi_BUS(pt))
                {
                    MessageBox.Show($"Xóa thành công phòng thi có mã {pt.Maphong}");
                    DanhSachPhongThi();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải Click vào gì đó !", "Thông báo");
                return;
            }
                
        }

        private void txtFindID_Phong_TextChanged(object sender, TextChangedEventArgs e)
        {
            string IDPhong = txtFindID_Phong.Text;
            ListDanhSach_PhongThi = PhongThi_BUS.FindIDPhong(IDPhong);
            dtgPhongThi.ItemsSource = ListDanhSach_PhongThi;
        }

        private void txtTimDiaChi_TextChanged(object sender, TextChangedEventArgs e)
        {
            string diachi = txtTimDiaChi.Text;
            ListDanhSach_PhongThi = PhongThi_BUS.TimDiaChi_Phong(diachi);
            dtgPhongThi.ItemsSource = ListDanhSach_PhongThi;
        }
    }
}
