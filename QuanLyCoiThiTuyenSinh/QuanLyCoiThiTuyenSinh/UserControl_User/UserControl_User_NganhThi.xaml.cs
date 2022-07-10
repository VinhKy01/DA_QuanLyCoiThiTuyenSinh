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
    /// Interaction logic for UserControl_User_NganhThi.xaml
    /// </summary>
    public partial class UserControl_User_NganhThi : UserControl
    {
        private List<Nganh_DTO> listNganhHoc;
        public UserControl_User_NganhThi()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            DanhSachNganhHoc();
        }

        void DanhSachNganhHoc()
        {
            listNganhHoc = Nganh_BUS.DanhSachNganhHoc_BUS();
            dtgNganhHoc.ItemsSource = listNganhHoc;
        }

        private void txtTimTenNganh_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tenNganh = txtTimTenNganh.Text;
            listNganhHoc = Nganh_BUS.TimNganhThi(tenNganh);
            dtgNganhHoc.ItemsSource = listNganhHoc;
        }
    }
}
