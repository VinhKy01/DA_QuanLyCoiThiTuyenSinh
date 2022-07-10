using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DTO;
using BUS;

namespace QuanLyCoiThiTuyenSinh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string SLTS;
        public static string SLDDT;
        public static string SLGV;
        public string tenDangNhap;
        private string tenHienThi;

        public MainWindow()
        {
            InitializeComponent();
            load();
            this.DataContext = this;
        }

        void load()
        {
            truyendulieu();
            //DiemSoLuongThiSinh();
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_TaiKhoan());

            SoLuongThiSinh();
            SoLuongDiaDiemToChuc();
            SoLuongCanBoCoiThi();
        }

        void truyendulieu()
        {
            txtTenHienThi.Text = tenHienThi;
        }



        void SoLuongThiSinh()
        {
            SLTS = ThiSinh_BUS.SoLuongThiSinh();
            txtSoLuongThiSinh.Text = $"{SLTS} Thí Sinh";
        }

        void SoLuongDiaDiemToChuc()
        {
            SLDDT = DiaDiemThi_BUS.SoLuongDiaDiemThi();
            txtSoDiaDiem.Text = $"{SLDDT} địa điểm";
        }

        void SoLuongCanBoCoiThi()
        {
            SLGV = GiamThi_BUS.SoLuongCanBoCoiThi();
            txtSoGiangVien.Text = $"{SLGV} giảng viên";
        }

        private void Close_mainForm_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        //Sự kiện click của listview người dùng
        private void ListViewNguoiDung_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewNguoiDung.SelectedIndex;

            switch(index)
            {
                case 0:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_TaiKhoan());
                        break;
                    }
                case 1:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_DoiMatKhau(tenDangNhap));
                        break;
                    }
                case 2:
                    {
                        MessageBoxResult result = System.Windows.MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (result == MessageBoxResult.Yes)
                        {
                            this.Close();
                            DangNhap dn = new DangNhap();
                            dn.Show();
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }    
        }

        //Sự kiện click của listview quản lý
        private void ListViewQuanLy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewQuanLy.SelectedIndex;

            switch (index)
            {
                case 0:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.fHocSinh());
                        break;
                    }
                case 1:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_PhongThi());
                        break;
                    }
                case 2:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_NganhHoc());
                        break;
                    }
                case 3:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_MonThi());
                        break;
                    }
                case 4:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_DiemThiSo());
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        //Sự kiện click của listview nghiệp vụ
        private void ListViewNghiepVu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewNghiepVu.SelectedIndex;

            switch (index)
            {
                case 0:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_GiamThiCoiThi());
                        break;
                    }
                case 1:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_ChucVu());
                        break;
                    }
                case 2:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_DonVi());
                        break;
                    }
                case 3:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_KhuVuc());
                        break;
                    }
                case 4:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_DoiTuong());
                        break;
                    }
                case 5:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_ThoiGianThi());
                        break;
                    }
                case 6:
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UserControl_QLCTTS.UserControl_BuoiThi());
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            Expaner_UpDown(sender as Expander);
        }

        private void Expaner_UpDown(Expander exp)
        {
            foreach (var child in grid1.Children)
            {
                if (child is Expander && child != exp)
                {
                    ((Expander)child).IsExpanded = false;
                }
            }
            foreach (var child in grid2.Children)
            {
                if (child is Expander && child != exp)
                {
                    ((Expander)child).IsExpanded = false;
                }
            }
            foreach (var child in grid3.Children)
            {
                if (child is Expander && child != exp)
                {
                    ((Expander)child).IsExpanded = false;
                }
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindows.DragMove();
        }
    }
}
