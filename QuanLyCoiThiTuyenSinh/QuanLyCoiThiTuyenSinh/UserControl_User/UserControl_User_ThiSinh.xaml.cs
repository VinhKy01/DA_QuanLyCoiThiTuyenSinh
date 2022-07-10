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
    /// Interaction logic for UserControl_User_ThiSinh.xaml
    /// </summary>
    public partial class UserControl_User_ThiSinh : UserControl
    {
        private List<ThiSinh_DTO> ListThiSinh;
        private List<Nganh_DTO> ListCBB_NganhHoc;
        public UserControl_User_ThiSinh()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            DanhSachThiSinh();
            LoadCBB_NganhHoc();
        }

        void DanhSachThiSinh()
        {
            ListThiSinh = ThiSinh_BUS.DanhSachThiSinh();
            dtgThiSinh.ItemsSource = ListThiSinh;
        }

        void LoadCBB_NganhHoc()
        {
            ListCBB_NganhHoc = Nganh_BUS.DanhSachNganhHoc_BUS();
            cbbNganhHoc.ItemsSource = ListCBB_NganhHoc;
            cbbNganhHoc.DisplayMemberPath = "Tennganh";
            cbbNganhHoc.SelectedValuePath = "Manganh";
        }

        private void txtFindName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name = txtFindName.Text;
            ListThiSinh = ThiSinh_BUS.FindName_ThiSinh(name);
            dtgThiSinh.ItemsSource = ListThiSinh;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string maNganh = cbbNganhHoc.SelectedValue.ToString();
            ListThiSinh = ThiSinh_BUS.TimKiemTheoCBB_Nganh(maNganh);
            dtgThiSinh.ItemsSource = ListThiSinh;
        }

        private void txtFindMaPhong_TextChanged(object sender, TextChangedEventArgs e)
        {
            string IDPhong = txtFindMaPhong.Text;
            ListThiSinh = ThiSinh_BUS.FindIDPhong_ThiSinh(IDPhong);
            dtgThiSinh.ItemsSource = ListThiSinh;
        }
    }
}
