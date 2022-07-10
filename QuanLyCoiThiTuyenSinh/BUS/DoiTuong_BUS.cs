using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class DoiTuong_BUS
    {
        public static List<DoiTuong_DTO> DanhSachDoiTuong()
        {
            return DoiTuong_DAO.DanhSachDoiTuong();
        }

        public static DoiTuong_DTO KiemTraID_DoiTuong(DoiTuong_DTO dt)
        {
            return DoiTuong_DAO.KiemTraID_DoiTuong(dt);
        }

        public static bool ThemDoiTuong_BUS(DoiTuong_DTO dt)
        {
            return DoiTuong_DAO.ThemDoiTuong_DAO(dt);
        }

        public static bool CapNhatDoiTuong_BUS(DoiTuong_DTO dt)
        {
            return DoiTuong_DAO.CapNhatDoiTuong_DAO(dt);
        }

        public static bool XoaDoiTuong_BUS(string madoituong)
        {
            return DoiTuong_DAO.XoaDoiTuong_DAO(madoituong);
        }
    }
}
