using System;
using System.Collections.Generic;
using System.IO;
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

namespace QuanLyCoiThiTuyenSinh.UserControl_User
{
    /// <summary>
    /// Interaction logic for UserControl_User_ThongTin.xaml
    /// </summary>
    public partial class UserControl_User_ThongTin : UserControl
    {
        string directory = "";
        private string sbd;
        private string hoten;
        private string ngaysinh;
        private string gioitinh;
        private string hokhau;
        private string doituong;
        private string nganh;
        private string khuvuc;
        private string phong;
        private string images;
        public UserControl_User_ThongTin(string sbd, string hoten, string ngaysinh, string gioitinh, string hokhau, string doituong, string nganh, string khuvuc, string phong, string images)
        {
            InitializeComponent();
            this.sbd = sbd;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.hokhau = hokhau;
            this.doituong = doituong;
            this.nganh = nganh;
            this.khuvuc = khuvuc;
            this.phong = phong;
            this.images = images;
            directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            load();
        }

        void load()
        {
            truyendulieu();
        }

        void truyendulieu()
        {
            txtID.Text = sbd;
            txtName.Text = hoten;
            txtBirthday.Text = ngaysinh;
            txtSex.Text = gioitinh;
            txtLocation.Text = hokhau;
            txtDT.Text = doituong;
            txtN.Text = nganh;
            txtKV.Text = khuvuc;
            txtP.Text = phong;
            imgFace.ImageSource = new BitmapImage(new Uri(directory + images));
        }
    }
}
