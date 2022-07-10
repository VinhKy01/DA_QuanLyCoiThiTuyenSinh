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
    /// Interaction logic for UserControl_User_MonThi.xaml
    /// </summary>
    public partial class UserControl_User_MonThi : UserControl
    {
        private List<MonHoc_DTO> ListDanhSachMonHoc;
        private List<Nganh_DTO> ListCBB_NganhHoc;
        public UserControl_User_MonThi()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            DanhSachMonHoc();
            LoadCBB_NganhHoc();
        }

        void DanhSachMonHoc()
        {
            ListDanhSachMonHoc = MonHoc_BUS.DanhSachMonHoc();
            dtgMonThi.ItemsSource = ListDanhSachMonHoc;
        }

        void LoadCBB_NganhHoc()
        {
            ListCBB_NganhHoc = Nganh_BUS.DanhSachNganhHoc_BUS();
            cbbNganhHoc.ItemsSource = ListCBB_NganhHoc;
            cbbNganhHoc.DisplayMemberPath = "Tennganh";
            cbbNganhHoc.SelectedValuePath = "Manganh";
        }

        private void txtTimTenMon_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tenMon = txtTimTenMon.Text;
            ListDanhSachMonHoc = MonHoc_BUS.TimTenMonHoc(tenMon);
            dtgMonThi.ItemsSource = ListDanhSachMonHoc;
        }

        private void cbbNganhHoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string maNganh = cbbNganhHoc.SelectedValue.ToString();
            ListDanhSachMonHoc = MonHoc_BUS.TimMon_TheoNganhThi(maNganh);
            dtgMonThi.ItemsSource = ListDanhSachMonHoc;
        }
    }
}
