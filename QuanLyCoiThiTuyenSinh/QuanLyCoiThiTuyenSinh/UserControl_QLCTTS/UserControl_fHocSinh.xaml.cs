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
using Microsoft.Win32;
using System.IO;

namespace QuanLyCoiThiTuyenSinh.UserControl_QLCTTS
{
    /// <summary>
    /// Interaction logic for fHocSinh.xaml
    /// </summary>
    public partial class fHocSinh : UserControl
    {
        string directory;
        string fileiamge ="";
        string dialog;

        bool flag = true;
        private string linkImages;
        private ThiSinh_DTO KiemTraID_ThiSinh;
        private List<DoiTuong_DTO> ListCBB_DoiTuong;
        private List<Nganh_DTO> ListCBB_NganhHoc;
        private List<KhucVuc_DTO> ListCBB_KhuVuc;
        private List<PhongThi_DTO> ListCBB_Phong;
        private List<ThiSinh_DTO> ListThiSinh;
        private ThiSinh_DTO _selectedThiSinh;

        public ThiSinh_DTO SelectedThiSinh 
        { 
            get => _selectedThiSinh;
            set
            {
                _selectedThiSinh = value;
                if (SelectedThiSinh == null)
                    return;
                txtSBD.Text = SelectedThiSinh.Sbd;
                txtHoTen.Text = SelectedThiSinh.Hoten;
                dtpkNgaySinh.Text = (SelectedThiSinh.Ngaysinh).ToString();
                if (SelectedThiSinh.Gioitinh == "Nam")
                    rbNam.IsChecked = true;
                else
                    rbNu.IsChecked = true;
                txtHoKhau.Text = SelectedThiSinh.Hokhau;
                cbbDoiTuong.Text = SelectedThiSinh.Doituong;
                cbbNganhHoc.Text = SelectedThiSinh.Manganh;
                cbbKhuVuc.Text = SelectedThiSinh.Khuvuc;
                cbbPhongHoc.Text = SelectedThiSinh.Maphong;

                if (SelectedThiSinh.Images == null)
                {
                    img.Source = null;
                }
                else
                    img.Source = new BitmapImage(new Uri(directory + SelectedThiSinh.Images));
            }
        }

        public fHocSinh()
        {
            InitializeComponent();
            DataContext = this;
            load();

            directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        }

        void load()
        {
            DanhSachThiSinh();
            DanhSachCBB_DoiTuong();
            DanhSachCBB_NganhHoc();
            DanhSachCBB_KhuVuc();
            DanhSachCBB_Phong();
            DanhSachCBB_TimNganhHoc();
        }

        void DanhSachThiSinh()
        {
            ListThiSinh = ThiSinh_BUS.DanhSachThiSinh();
            dtgThiSinh.ItemsSource = ListThiSinh;
        }

        void DanhSachCBB_DoiTuong()
        {
            ListCBB_DoiTuong = DoiTuong_BUS.DanhSachDoiTuong();
            cbbDoiTuong.ItemsSource = ListCBB_DoiTuong;
            cbbDoiTuong.DisplayMemberPath = "Tendoituong";
            cbbDoiTuong.SelectedValuePath = "Madoituong";
        }
        void DanhSachCBB_NganhHoc()
        {
            ListCBB_NganhHoc = Nganh_BUS.DanhSachNganhHoc_BUS();
            cbbNganhHoc.ItemsSource = ListCBB_NganhHoc;
            cbbNganhHoc.DisplayMemberPath = "Tennganh";
            cbbNganhHoc.SelectedValuePath = "Manganh";
        }
        void DanhSachCBB_KhuVuc()
        {
            ListCBB_KhuVuc = KhuVuc_BUS.DanhSachKhuVuc();
            cbbKhuVuc.ItemsSource = ListCBB_KhuVuc;
            cbbKhuVuc.DisplayMemberPath = "Tenkhuvuc";
            cbbKhuVuc.SelectedValuePath = "Makhuvuc";
        }

        void DanhSachCBB_Phong()
        {
            ListCBB_Phong = PhongThi_BUS.DanhSachPhongThi();
            cbbPhongHoc.ItemsSource = ListCBB_Phong;
            cbbPhongHoc.DisplayMemberPath = "Maphong";
            cbbPhongHoc.SelectedValuePath = "Maphong";
        }

        void DanhSachCBB_TimNganhHoc()
        {
            ListCBB_NganhHoc = Nganh_BUS.DanhSachNganhHoc_BUS();
            cbbTimNganhHoc.ItemsSource = ListCBB_NganhHoc;
            cbbTimNganhHoc.DisplayMemberPath = "Tennganh";
            cbbTimNganhHoc.SelectedValuePath = "Manganh";
        }

        private void btnOpenfile_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = openfiledialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";
            if (openfiledialog.ShowDialog() == true)
            {
                
                img.Source = new BitmapImage(new Uri(openfiledialog.FileName));
                linkImages = openfiledialog.SafeFileName;

                //cop[y anh vai folder Anh
                dialog = openfiledialog.FileName;
                fileiamge = "\\Anh\\" + openfiledialog.SafeFileName;
            }
        }

        private void btnThemThiSinh_Click(object sender, RoutedEventArgs e)
        {
            if (fileiamge == "" || txtSBD.Text == "" || txtHoTen.Text == "" || dtpkNgaySinh.Text == "" || txtHoKhau.Text == "" || cbbDoiTuong.SelectedValue.ToString() == "" || cbbNganhHoc.SelectedValue.ToString() == "" || cbbKhuVuc.SelectedValue.ToString() == "" || cbbPhongHoc.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Phải nhập đủ thông tin", "Thông báo");
                return;
            }
            ThiSinh_DTO ts = new ThiSinh_DTO();
            ts.Sbd = txtSBD.Text;
            ts.Hoten = txtHoTen.Text;
            ts.Ngaysinh = DateTime.Parse(dtpkNgaySinh.Text);
            if (rbNam.IsChecked == true)
                ts.Gioitinh = "Nam";
            else
                ts.Gioitinh = "Nữ";
            ts.Hokhau = txtHoKhau.Text;
            ts.Doituong = cbbDoiTuong.SelectedValue.ToString();
            ts.Manganh = cbbNganhHoc.SelectedValue.ToString();
            ts.Khuvuc = cbbKhuVuc.SelectedValue.ToString();
            ts.Maphong = cbbPhongHoc.SelectedValue.ToString();
            ts.Images = fileiamge;
            KiemTraID_ThiSinh = ThiSinh_BUS.KiemTraID_ThiSinh(ts.Sbd);

            if (KiemTraID_ThiSinh != null)
            {
                MessageBox.Show("Số báo danh đã có vui lòng đặt sô báo danh khác !!!", "Thông báo");
                return;
            }

            if (ThiSinh_BUS.ThemThiSinh_BUS(ts))
            {
                
                MessageBox.Show("Thêm thành công");
                //Copy file anh vao folder Anh
                try
                {
                    File.Copy(dialog, directory + fileiamge);
                }
                catch { }
                ThemTaiKhoan tkk = new ThemTaiKhoan();
                tkk.IdThiSinh = ts.Sbd;
                tkk.ShowDialog();

                DanhSachThiSinh();
                string slts = ThiSinh_BUS.SoLuongThiSinh();
                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).txtSoLuongThiSinh.Text = $"{slts} Thí Sinh";
                    }
                }
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnCapNhatThiSinh_Click(object sender, RoutedEventArgs e)
        {
            ThiSinh_DTO ts = new ThiSinh_DTO();
            ts.Sbd = txtSBD.Text;
            ts.Hoten = txtHoTen.Text;
            ts.Ngaysinh = DateTime.Parse(dtpkNgaySinh.Text);
            if (rbNam.IsChecked == true)
                ts.Gioitinh = "Nam";
            else
                ts.Gioitinh = "Nữ";
            ts.Hokhau = txtHoKhau.Text;
            ts.Doituong = cbbDoiTuong.SelectedValue.ToString();
            ts.Manganh = cbbNganhHoc.SelectedValue.ToString();
            ts.Khuvuc = cbbKhuVuc.SelectedValue.ToString();
            ts.Maphong = cbbPhongHoc.SelectedValue.ToString();
            if (fileiamge == "")
            {
                ts.Images = SelectedThiSinh.Images;
            }
            ts.Images = fileiamge;
            

            if (SelectedThiSinh != null)
            {
                if (ThiSinh_BUS.CapNhatThiSinh_BUS(ts))
                {
                    MessageBox.Show($"Cập nhật thông tin thí sinh {ts.Hoten} thành công", "Thông báo");
                    DanhSachThiSinh();
                    MainWindow mws = new MainWindow();
                    string slts = ThiSinh_BUS.SoLuongThiSinh();
                    mws.txtSoLuongThiSinh.Text = $"{slts} Thí Sinh";
                }
            }
            else
                MessageBox.Show("Bạn phải Click chọn 1 thí sinh nào đó", "Thông báo");
        }

        private void btnXoaThiSinh_Click(object sender, RoutedEventArgs e)
        {
            ThiSinh_DTO ts = new ThiSinh_DTO();
            ts.Sbd = txtSBD.Text;
            ts.Hoten = txtHoTen.Text;
            ts.Ngaysinh = DateTime.Parse(dtpkNgaySinh.Text);
            if (rbNam.IsChecked == true)
                ts.Gioitinh = "Nam";
            else
                ts.Gioitinh = "Nữ";
            ts.Hokhau = txtHoKhau.Text;
            ts.Doituong = cbbDoiTuong.SelectedValue.ToString();
            ts.Manganh = cbbNganhHoc.SelectedValue.ToString();
            ts.Khuvuc = cbbKhuVuc.SelectedValue.ToString();
            ts.Maphong = cbbPhongHoc.SelectedValue.ToString();
            ts.Images = fileiamge;

            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Manguoidung = ts.Sbd;
            if (SelectedThiSinh != null)
            {
                MessageBoxResult kq = MessageBox.Show($"Nếu xóa tài khoản của {ts.Hoten} cũng sẽ bị xóa", "Thông báo", MessageBoxButton.OKCancel);
                if (kq == MessageBoxResult.OK)
                {
                    if (TaiKhoan_BUS.XoaFK_TaiKhoan_BUS(tk))
                    {
                        if (ThiSinh_BUS.XoaThiSinh_BUS(ts))
                        {
                            MessageBox.Show($"Xóa thành công thí sinh");
                            string slts = ThiSinh_BUS.SoLuongThiSinh();
                            foreach (Window window in Application.Current.Windows)
                            {
                                if (window.GetType() == typeof(MainWindow))
                                {
                                    (window as MainWindow).txtSoLuongThiSinh.Text = $"{slts} Thí Sinh";
                                }
                            }
                            DanhSachThiSinh();
                        }
                    }
                }
                else
                    return;
            }
            else
                MessageBox.Show("Bạn phải Click chọn 1 thí sinh nào đó", "Thông báo");
        }

        private void btnFlag_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                btnFlag.Content = "-";

                btnThemThiSinh.IsEnabled = true;
                btnCapNhatThiSinh.IsEnabled = false;
                btnXoaThiSinh.IsEnabled = false;
                txtSBD.IsEnabled = true;

                txtSBD.Clear();
                txtHoTen.Clear();
                txtHoKhau.Clear();
                txtSBD.Focus();
            }
            else
            {
                flag = true;
                btnFlag.Content = "+";

                btnThemThiSinh.IsEnabled = false;
                btnCapNhatThiSinh.IsEnabled = true;
                btnXoaThiSinh.IsEnabled = true;
                txtSBD.IsEnabled = false;
            }
        }

        private void txtFindName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name = txtFindName.Text;
            ListThiSinh = ThiSinh_BUS.FindName_ThiSinh(name);
            dtgThiSinh.ItemsSource = ListThiSinh;
        }

        private void txtFindMaPhong_TextChanged(object sender, TextChangedEventArgs e)
        {
            string IDPhong = txtFindMaPhong.Text;
            ListThiSinh = ThiSinh_BUS.FindIDPhong_ThiSinh(IDPhong);
            dtgThiSinh.ItemsSource = ListThiSinh;
        }

        private void cbbTimNganhHoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string maNganh = cbbTimNganhHoc.SelectedValue.ToString();
            ListThiSinh = ThiSinh_BUS.TimKiemTheoCBB_Nganh(maNganh);
            dtgThiSinh.ItemsSource = ListThiSinh;
        }
    }
}
