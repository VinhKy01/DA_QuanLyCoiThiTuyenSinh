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

namespace QuanLyCoiThiTuyenSinh.UserControl_User
{
    /// <summary>
    /// Interaction logic for UserControl_User_PhongThi.xaml
    /// </summary>
    public partial class UserControl_User_PhongThi : UserControl
    {
        private List<PhongThi_DTO> ListDanhSach_PhongThi;
        public UserControl_User_PhongThi()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            DanhSachPhongThi();
        }

        void DanhSachPhongThi()
        {
            ListDanhSach_PhongThi = PhongThi_BUS.DanhSachPhongThi();
            dtgPhongThi.ItemsSource = ListDanhSach_PhongThi;
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
