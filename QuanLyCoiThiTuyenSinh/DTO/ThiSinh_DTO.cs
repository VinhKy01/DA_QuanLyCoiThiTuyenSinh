using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThiSinh_DTO
    {
        private string sbd;
        private string hoten;
        private DateTime ngaysinh;
        private string gioitinh;
        private string hokhau;
        private string doituong;
        private string manganh;
        private string khuvuc;
        private string maphong;
        private string images;

        public string Sbd { get => sbd; set => sbd = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Hokhau { get => hokhau; set => hokhau = value; }
        public string Doituong { get => doituong; set => doituong = value; }
        public string Manganh { get => manganh; set => manganh = value; }
        public string Khuvuc { get => khuvuc; set => khuvuc = value; }
        public string Maphong { get => maphong; set => maphong = value; }
        public string Images { get => images; set => images = value; }
    }
}
