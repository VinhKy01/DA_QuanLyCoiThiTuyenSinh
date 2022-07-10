using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class ThoiGian_BUS
    {
        public static List<ThoiGian_DTO> DanhSachThoiGian()
        {
            return ThoiGian_DAO.DanhSachThoiGian();
        }

        public static ThoiGian_DTO KIemTraID_ThoiGian(ThoiGian_DTO tg)
        {
            return ThoiGian_DAO.KIemTraID_ThoiGian(tg);
        }

        public static bool ThemThoiGianMoi_BUS(ThoiGian_DTO tg)
        {
            return ThoiGian_DAO.ThemThoiGianMoi_DAO(tg);
        }

        public static bool CapNhatThoiGian_BUS(ThoiGian_DTO tg)
        {
            return ThoiGian_DAO.CapNhatThoiGian_DAO(tg);
        }

        public static bool XoaThoiGian(ThoiGian_DTO tg)
        {
            return ThoiGian_DAO.XoaThoiGian(tg);
        }
    }
}
