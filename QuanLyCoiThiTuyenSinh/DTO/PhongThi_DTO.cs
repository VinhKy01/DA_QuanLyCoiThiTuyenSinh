using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongThi_DTO
    {
        private string maphong;
        private string diachidiemthi;
        private string ghichu;

        public string Maphong { get => maphong; set => maphong = value; }
        public string Diachidiemthi { get => diachidiemthi; set => diachidiemthi = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
