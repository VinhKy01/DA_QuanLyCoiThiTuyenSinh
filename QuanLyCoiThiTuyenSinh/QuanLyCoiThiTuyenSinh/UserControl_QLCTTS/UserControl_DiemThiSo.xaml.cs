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
    /// Interaction logic for UserControl_DiemThiSo.xaml
    /// </summary>
    public partial class UserControl_DiemThiSo : UserControl
    {
        bool flag = true;
        private List<ThiSinh_DTO> getID_ThiSinh_FDiaDiemThi;
        private List<PhongThi_DTO> getID_PhongThi_FDiaDiemThi;
        private DiaDiemThi_DTO KiemTraID_DiaDiemThi;
        private List<DiaDiemThi_DTO> listDiemThiSo { get; set; }
        public DiaDiemThi_DTO SelectedDiaDiemThi
        {
            get => _selectedDiaDiemThi;
            set 
            { 
                _selectedDiaDiemThi = value;
                if (SelectedDiaDiemThi == null)
                    return;
                txtDiemThiSo.Text = (SelectedDiaDiemThi.Diemthiso).ToString();
                txtDiaChiDiemThi.Text = SelectedDiaDiemThi.Diachidiemthi;
            }
        }
        private DiaDiemThi_DTO _selectedDiaDiemThi;

        public UserControl_DiemThiSo()
        {
            InitializeComponent();
            DataContext = this;
            load();
        }

        void load()
        {
            DanhSachDiemThiSo();
        }

        void DanhSachDiemThiSo()
        {
            listDiemThiSo = DiaDiemThi_BUS.DanhSachDiemThiSo();
            dtgDiemThiSo.ItemsSource = listDiemThiSo;
        }

        private void btnFlag_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                btnFlag.Content = "-";

                btnThemDiaDiemThi.IsEnabled = true;
                btnCapNhatDiaDiemThi.IsEnabled = false;
                btnXoaDiaDiemThi.IsEnabled = false;
                txtDiemThiSo.IsEnabled = true;

                txtDiemThiSo.Clear();
                txtDiaChiDiemThi.Clear();
                txtDiemThiSo.Focus();
            }
            else
            {
                flag = true;
                btnFlag.Content = "+";

                btnThemDiaDiemThi.IsEnabled = false;
                btnCapNhatDiaDiemThi.IsEnabled = true;
                btnXoaDiaDiemThi.IsEnabled = true;
                txtDiemThiSo.IsEnabled = false;
            }
        }

        private void btnThemDiaDiemThi_Click(object sender, RoutedEventArgs e)
        {
            DiaDiemThi_DTO ddt = new DiaDiemThi_DTO();
            ddt.Diemthiso = int.Parse(txtDiemThiSo.Text);
            ddt.Diachidiemthi = txtDiaChiDiemThi.Text;

            if (txtDiemThiSo.Text == "" || ddt.Diachidiemthi == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin !", "Thông báo");
                return;
            }

            KiemTraID_DiaDiemThi = DiaDiemThi_BUS.KiemTraID_DiaDiemThi(ddt);
            if (KiemTraID_DiaDiemThi == null)
            {
                if (DiaDiemThi_BUS.ThemDiaDiemThi_BUS(ddt))
                {
                    MessageBox.Show($"Đã thêm vào thành công điểm thi {ddt.Diemthiso}", "Thông báo");
                    string sldd = DiaDiemThi_BUS.SoLuongDiaDiemThi();
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(MainWindow))
                        {
                            (window as MainWindow).txtSoDiaDiem.Text = $"{sldd} địa điểm";
                        }
                    }
                    DanhSachDiemThiSo();
                }
                else
                {
                    MessageBox.Show($"Đã thêm vào điểm thi {ddt.Diemthiso} thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show($"Mã địa điểm {ddt.Diemthiso} bị trùng vui lòng đặt mã khác", "Thông báo");
                return;
            }
        }

        private void txtDiemThiSo_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            Int32 selectionStart = textBox.SelectionStart;
            Int32 selectionLength = textBox.SelectionLength;

            String newText = String.Empty;
            foreach (Char c in textBox.Text.ToCharArray())
            {
                if (Char.IsDigit(c) || Char.IsControl(c)) newText += c;
            }

            textBox.Text = newText;

            textBox.SelectionStart = selectionStart <= textBox.Text.Length ?
                selectionStart : textBox.Text.Length;
        }

        private void btnCapNhatDiaDiemThi_Click(object sender, RoutedEventArgs e)
        {
            DiaDiemThi_DTO ddt = new DiaDiemThi_DTO();
            ddt.Diemthiso = int.Parse(txtDiemThiSo.Text);
            ddt.Diachidiemthi = txtDiaChiDiemThi.Text;

            if (SelectedDiaDiemThi != null)
            {
                if (DiaDiemThi_BUS.CapNhatDiaDiemThi_BUS(ddt))
                {
                    MessageBox.Show($"Đã cập nhật địa chỉ tên {SelectedDiaDiemThi.Diachidiemthi} thành {ddt.Diachidiemthi}");
                    DanhSachDiemThiSo();
                }
                else
                {
                    MessageBox.Show($"Cập nhật địa chỉ thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải Click vào gì đó", "Thông báo");
            }
        }

        private void btnXoaDiaDiemThi_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedDiaDiemThi != null)
            {
                DiaDiemThi_DTO ddt = new DiaDiemThi_DTO();
                ddt.Diemthiso = int.Parse(txtDiemThiSo.Text);
                ddt.Diachidiemthi = txtDiaChiDiemThi.Text;
                int madd = ddt.Diemthiso;
                getID_PhongThi_FDiaDiemThi = PhongThi_BUS.getID_PhongThi_FDiaDiemThi(madd);

                //Xóa tài khoản
                if (getID_PhongThi_FDiaDiemThi != null)
                {
                    foreach (var item in getID_PhongThi_FDiaDiemThi)
                    {
                        string maPhong = item.Maphong;
                        getID_ThiSinh_FDiaDiemThi = ThiSinh_BUS.getID_ThiSinh_FDiaDiemThi(maPhong);
                        if (getID_ThiSinh_FDiaDiemThi != null)
                        {
                            foreach (var itemTS in getID_ThiSinh_FDiaDiemThi)
                            {
                                string mats = itemTS.Sbd;
                                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                                tk.Manguoidung = mats;
                                TaiKhoan_BUS.XoaFK_TaiKhoan_BUS(tk);
                            }
                        }
                    }
                }
                
                //Xóa thí sinh
                if (getID_PhongThi_FDiaDiemThi != null)
                {
                    foreach (var item in getID_PhongThi_FDiaDiemThi)
                    {
                        string maPhong = item.Maphong;
                        ThiSinh_BUS.XoaFK_ThiSinh_FDiaDiemThi(maPhong);
                    }
                }

                //Xóa giám thị coi thi
                if (GiamThi_BUS.XoaFK_GiamThi_FDiaDiemThi(madd)) ;

                //Xóa phòng
                if (PhongThi_BUS.XoaFK_PhongThi_FDiaDiemThi(madd)) ;

                //Xóa địa điểm thi
                if (DiaDiemThi_BUS.XoaDiaDiemThi_BUS(ddt))
                {
                    MessageBox.Show($"Đã xóa địa điểm thi sô {ddt.Diemthiso} thành công", "Thông báo");
                    string sldd = DiaDiemThi_BUS.SoLuongDiaDiemThi();
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(MainWindow))
                        {
                            (window as MainWindow).txtSoDiaDiem.Text = $"{sldd} địa điểm";
                        }
                    }
                    DanhSachDiemThiSo();
                }
                else
                {
                    MessageBox.Show($"Xóa địa điểm thi sô {ddt.Diemthiso} thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải Click chọn gì đó !", "Thông báo");
                return;
            }
        }

        private void txtTimDiaChiDiemThi_TextChanged(object sender, TextChangedEventArgs e)
        {
            string diachi = txtTimDiaChiDiemThi.Text;
            listDiemThiSo = DiaDiemThi_BUS.TimDiaChiDiemThi(diachi);
            dtgDiemThiSo.ItemsSource = listDiemThiSo;
        }

    }
}
