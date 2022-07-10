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
using System.Windows.Shapes;
using DTO;
using QuanLyCoiThiTuyenSinh.UserControl_User;

namespace QuanLyCoiThiTuyenSinh
{
    /// <summary>
    /// Interaction logic for fNguoiDung.xaml
    /// </summary>
    public partial class fNguoiDung : Window
    {
        public string tenTK;
        public string sbd;
        public string ten;
        public string ngaysinh;
        public string gioitinh;
        public string hokhau;
        public string doituong;
        public string nganh;
        public string khuvuc;
        public string phong;
        public string images;
        public fNguoiDung()
        {
            InitializeComponent();
            GridMain.Children.Clear();
            GridMain.Children.Add(new UserControl_User.UserControl_User_ThiSinh());
        }

        private void tab_Menu_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);
            int vitri = 10 + (150 * index);
            GridCursor.Margin = new Thickness(vitri, 0, 0, 0);

            switch (index)
            {
                case 0:
                    {
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new UserControl_User.UserControl_User_ThongTin(sbd, ten, ngaysinh, gioitinh, hokhau, doituong, nganh, khuvuc, phong, images));
                        break;
                    }
                case 1:
                    {
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new UserControl_User.UserControl_User_ThiSinh());
                        break;
                    }
                case 2:
                    {
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new UserControl_User.UserControl_User_PhongThi());
                        break;
                    }
                case 3:
                    {
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new UserControl_User.UserControl_User_NganhThi());
                        break;
                    }
                case 4:
                    {
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new UserControl_User.UserControl_User_MonThi());
                        break;
                    }
                case 5:
                    {
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new UserControl_User.UserControl_User_DiaDiemThi());
                        break;
                    }
                case 6:
                    {
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new UserControl_User.UserControl_User_GiamThi());
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void btnDoiMK_User_Click(object sender, RoutedEventArgs e)
        {
            fDoiMatKhau_User dmk = new fDoiMatKhau_User(tenTK);
            dmk.ShowDialog();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất ???", "Thông báo", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
            else
                return;
        }
    }
}
