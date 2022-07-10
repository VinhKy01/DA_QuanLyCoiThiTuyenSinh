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
    /// Interaction logic for UserControl_GiamThiCoiThi.xaml
    /// </summary>
    public partial class UserControl_GiamThiCoiThi : UserControl
    {
        bool flag = true;
        private List<DonVi_DTO> ListDanhSach_CBBDonVi;
        private List<ChucVu_DTO> ListDanhSach_CBBChucVu;
        private List<DiaDiemThi_DTO> ListDanhSach_CBBDiaDiemThi;
        private List<GiamThi_DTO> ListDanhSachGiamThi;
        private GiamThi_DTO KiemTraID_GiamThi;
        private GiamThi_DTO _selectedGiamThi;

        public GiamThi_DTO SelectedGiamThi 
        { 
            get => _selectedGiamThi;
            set 
            { 
                _selectedGiamThi = value;
                if (SelectedGiamThi == null)
                    return;
                txtMaGiamThi.Text = SelectedGiamThi.Magiamthi;
                txtTenGiamThi.Text = SelectedGiamThi.Tengiamthi;
                cbbDonVi.Text = SelectedGiamThi.Tendonvi;
                if (SelectedGiamThi.Gioitinh == "Nam")
                    rbNam.IsChecked = true;
                else
                    rbNu.IsChecked = true;
                cbbChucVu.Text = SelectedGiamThi.Tenchucvu;
                cbbDiaDiemThi.Text = SelectedGiamThi.Diachidiemthi;
            }
        }

        public UserControl_GiamThiCoiThi()
        {
            InitializeComponent();
            DataContext = this;
            load();
        }

        void load()
        {
            //Load combobox đơn vị
            DanhSach_CBBDonVi();
            //Load combobox chức vụ
            DanhSach_CBBChucVu();
            //Load combobox địa điểm thi
            DanhSach_CBBDiaDiemThi();
            //Load danh sách giám thị lên Datagrid
            DanhSachGiamThi();
        }

        void DanhSach_CBBDonVi()
        {
            ListDanhSach_CBBDonVi = DonVi_BUS.DanhSachDonVi();
            cbbDonVi.ItemsSource = ListDanhSach_CBBDonVi;
            cbbDonVi.DisplayMemberPath = "Tendonvi";
            cbbDonVi.SelectedValuePath = "Madonvi";
        }

        void DanhSach_CBBChucVu()
        {
            ListDanhSach_CBBChucVu = ChucVu_BUS.DanhSachChucVu_BUS();
            cbbChucVu.ItemsSource = ListDanhSach_CBBChucVu;
            cbbChucVu.DisplayMemberPath = "Tenchucvu";
            cbbChucVu.SelectedValuePath = "Machucvu";
        }

        void DanhSach_CBBDiaDiemThi()
        {
            ListDanhSach_CBBDiaDiemThi = DiaDiemThi_BUS.DanhSachDiemThiSo();
            cbbDiaDiemThi.ItemsSource = ListDanhSach_CBBDiaDiemThi;
            cbbDiaDiemThi.DisplayMemberPath = "Diachidiemthi";
            cbbDiaDiemThi.SelectedValuePath = "Diemthiso";
        }

        void DanhSachGiamThi()
        {
            ListDanhSachGiamThi = GiamThi_BUS.DanhSachGiamThi();
            dtgGiamThi.ItemsSource = ListDanhSachGiamThi;
        }

        private void btnFlag_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                btnFlag.Content = "-";

                btnThemGiamThi.IsEnabled = true;
                btnCapNhatGiamThi.IsEnabled = false;
                btnXoaGiamThi.IsEnabled = false;
                txtMaGiamThi.IsEnabled = true;

                txtMaGiamThi.Clear();
                txtTenGiamThi.Clear();
                txtMaGiamThi.Focus();
            }
            else
            {
                flag = true;
                btnFlag.Content = "+";

                btnThemGiamThi.IsEnabled = false;
                btnCapNhatGiamThi.IsEnabled = true;
                btnXoaGiamThi.IsEnabled = true;
                txtMaGiamThi.IsEnabled = false;
            }
        }

        private void btnThemGiamThi_Click(object sender, RoutedEventArgs e)
        {
            GiamThi_DTO gt = new GiamThi_DTO();
            gt.Magiamthi = txtMaGiamThi.Text;
            gt.Tengiamthi = txtTenGiamThi.Text;
            gt.Tendonvi = cbbDonVi.SelectedValue.ToString();
            if (rbNam.IsChecked == true)
                gt.Gioitinh = "Nam";
            else
                gt.Gioitinh = "Nữ";
            gt.Tenchucvu = cbbChucVu.SelectedValue.ToString();
            gt.Diachidiemthi = cbbDiaDiemThi.SelectedValue.ToString();

            if (txtMaGiamThi.Text == "" || txtTenGiamThi.Text == "" || cbbDonVi.SelectedValue.ToString() == "" || cbbChucVu.SelectedValue.ToString() == "" || cbbDiaDiemThi.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin !!!", "Thông báo");
                return;
            }

            KiemTraID_GiamThi = GiamThi_BUS.KiemTraID_GiamThi(gt);
            if (KiemTraID_GiamThi == null)
            {
                if (GiamThi_BUS.ThemGiamThi_BUS(gt))
                {
                    MessageBox.Show($"Thêm giám thị có mã {gt.Magiamthi} thành công");
                    string slgv = GiamThi_BUS.SoLuongCanBoCoiThi();
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(MainWindow))
                        {
                            (window as MainWindow).txtSoGiangVien.Text = $"{slgv} giám thị";
                        }
                    }
                    DanhSachGiamThi();
                }
                else
                    MessageBox.Show($"Thêm giám thị có mã {gt.Magiamthi} thất bại");
            }
            else
            {
                MessageBox.Show($"Mã giám thị {gt.Magiamthi} bị trùng vui lòng đặt mã khác", "Thông báo");
                return;
            }
        }

        private void btnCapNhatGiamThi_Click(object sender, RoutedEventArgs e)
        {
            GiamThi_DTO gt = new GiamThi_DTO();
            gt.Magiamthi = txtMaGiamThi.Text;
            gt.Tengiamthi = txtTenGiamThi.Text;
            gt.Tendonvi = cbbDonVi.SelectedValue.ToString();
            if (rbNam.IsChecked == true)
                gt.Gioitinh = "Nam";
            else
                gt.Gioitinh = "Nữ";
            gt.Tenchucvu = cbbChucVu.SelectedValue.ToString();
            gt.Diachidiemthi = cbbDiaDiemThi.SelectedValue.ToString();

            if (SelectedGiamThi != null)
            {
                if (GiamThi_BUS.CapNhatGiamThi_BUS(gt))
                {
                    MessageBox.Show($"Cập nhật giám thị {gt.Tengiamthi} thành công");
                    DanhSachGiamThi();
                }
                else
                    MessageBox.Show($"Cập nhật giám thị {gt.Tengiamthi} thất bại");
            }
            else
            {
                MessageBox.Show("Bạn phải Click chọn gì đó", "Thông báo");
                return;
            }
        }

        private void btnXoaGiamThi_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedGiamThi != null)
            {
                GiamThi_DTO gt = new GiamThi_DTO();
                gt.Magiamthi = txtMaGiamThi.Text;
                gt.Tengiamthi = txtTenGiamThi.Text;

                if (GiamThi_BUS.XoaGiamThi_BUS(gt))
                {
                    MessageBox.Show($"Xóa giám thị {gt.Tengiamthi} thành công", "Thông báo");
                    string slgv = GiamThi_BUS.SoLuongCanBoCoiThi();
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(MainWindow))
                        {
                            (window as MainWindow).txtSoGiangVien.Text = $"{slgv} giám thị";
                        }
                    }
                    DanhSachGiamThi();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải Click chọn gì đó !!!", "Thông báo");
                return;
            }
        }

        private void txtFindName_GiamThi_TextChanged(object sender, TextChangedEventArgs e)
        {
            string ten = txtFindName_GiamThi.Text;
            ListDanhSachGiamThi = GiamThi_BUS.TimTenGiamThi(ten);
            dtgGiamThi.ItemsSource = ListDanhSachGiamThi;
        }

        private void txtTimDiaChiDiemThi_TextChanged(object sender, TextChangedEventArgs e)
        {
            string diachidiemthi = txtTimDiaChiDiemThi.Text;
            ListDanhSachGiamThi = GiamThi_BUS.TimDiaChiDiemThi_GiamThi(diachidiemthi);
            dtgGiamThi.ItemsSource = ListDanhSachGiamThi;
        }

    }
}
