using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BuoiThi_BUS
    {
        public static List<BuoiThi_DTO> DanhSachBuoiThi()
        {
            return BuoiThi_DAO.DanhSachBuoiThi();
        }

        public static BuoiThi_DTO KiemTraID_BuoiThi(BuoiThi_DTO bt)
        {
            return BuoiThi_DAO.KiemTraID_BuoiThi(bt);
        }

        public static bool ThemBuoiThi_BUS(BuoiThi_DTO bt)
        {
            return BuoiThi_DAO.ThemBuoiThi_DAO(bt);
        }

        public static bool CapNhatBuoiThi_BUS(BuoiThi_DTO bt)
        {
            return BuoiThi_DAO.CapNhatBuoiThi_DAO(bt);
        }

        public static bool XoaBuoiThi_BUS(BuoiThi_DTO bt)
        {
            return BuoiThi_DAO.XoaBuoiThi_DAO(bt);
        }
    }
}
