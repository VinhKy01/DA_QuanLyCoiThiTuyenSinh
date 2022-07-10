using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private string taikhoan;
        private string matkhau;
        private int loaitaikhoan;
        private string manguoidung;

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Loaitaikhoan { get => loaitaikhoan; set => loaitaikhoan = value; }
        public string Manguoidung { get => manguoidung; set => manguoidung = value; }
    }
}
