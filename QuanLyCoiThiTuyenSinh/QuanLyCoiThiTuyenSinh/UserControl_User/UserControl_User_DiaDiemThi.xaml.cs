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
    /// Interaction logic for UserControl_User_DiaDiemThi.xaml
    /// </summary>
    public partial class UserControl_User_DiaDiemThi : UserControl
    {
        private List<DiaDiemThi_DTO> listDiemThiSo;
        public UserControl_User_DiaDiemThi()
        {
            InitializeComponent();
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

        private void txtTimDiaChiDiemThi_TextChanged(object sender, TextChangedEventArgs e)
        {
            string diachi = txtTimDiaChiDiemThi.Text;
            listDiemThiSo = DiaDiemThi_BUS.TimDiaChiDiemThi(diachi);
            dtgDiemThiSo.ItemsSource = listDiemThiSo;
        }
    }
}
