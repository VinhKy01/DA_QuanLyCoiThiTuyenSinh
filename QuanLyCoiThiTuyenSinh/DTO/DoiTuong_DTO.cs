using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoiTuong_DTO
    {
        private string madoituong;
        private string tendoituong;

        public string Madoituong { get => madoituong; set => madoituong = value; }
        public string Tendoituong { get => tendoituong; set => tendoituong = value; }
    }
}
