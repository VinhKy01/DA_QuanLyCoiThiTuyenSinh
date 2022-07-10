using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc_DTO
    {
        private string mamon;
        private string tenmon;
        private DateTime ngaythi;
        private string buoithi;
        private string thoigian;
        private string tennganh;

        public string Mamon { get => mamon; set => mamon = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public DateTime Ngaythi { get => ngaythi; set => ngaythi = value; }
        public string Buoithi { get => buoithi; set => buoithi = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
        public string Tennganh { get => tennganh; set => tennganh = value; }
    }
}
