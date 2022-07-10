using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhucVuc_DTO
    {
        private string makhuvuc;
        private string tenkhuvuc;

        public string Makhuvuc { get => makhuvuc; set => makhuvuc = value; }
        public string Tenkhuvuc { get => tenkhuvuc; set => tenkhuvuc = value; }
    }
}
