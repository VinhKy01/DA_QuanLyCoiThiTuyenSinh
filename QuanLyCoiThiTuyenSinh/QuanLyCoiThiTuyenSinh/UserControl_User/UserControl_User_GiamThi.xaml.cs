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
    /// Interaction logic for UserControl_User_GiamThi.xaml
    /// </summary>
    public partial class UserControl_User_GiamThi : UserControl
    {
        private List<GiamThi_DTO> ListDanhSachGiamThi;
        public UserControl_User_GiamThi()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            DanhSachGiamThi();
        }

        void DanhSachGiamThi()
        {
            ListDanhSachGiamThi = GiamThi_BUS.DanhSachGiamThi();
            dtgGiamThi.ItemsSource = ListDanhSachGiamThi;
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
