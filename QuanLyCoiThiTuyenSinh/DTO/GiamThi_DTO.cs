using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiamThi_DTO
    {
        private string magiamthi;
        private string tengiamthi;
        private string tendonvi;
        private string gioitinh;
        private string tenchucvu;
        private string diachidiemthi;

        public string Magiamthi { get => magiamthi; set => magiamthi = value; }
        public string Tengiamthi { get => tengiamthi; set => tengiamthi = value; }
        public string Tendonvi { get => tendonvi; set => tendonvi = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Tenchucvu { get => tenchucvu; set => tenchucvu = value; }
        public string Diachidiemthi { get => diachidiemthi; set => diachidiemthi = value; }
    }
}
