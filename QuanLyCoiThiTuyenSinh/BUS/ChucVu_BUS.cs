using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class ChucVu_BUS
    {
        public static List<ChucVu_DTO> DanhSachChucVu_BUS()
        {
            return ChucVu_DAO.DanhSachChucVu_BUS();
        }

        public static ChucVu_DTO KiemTraID_ChucVu_BUS(ChucVu_DTO cv)
        {
            return ChucVu_DAO.KiemTraID_ChucVu_DAO(cv);
        }

        public static bool ThemChucVu_BUS(ChucVu_DTO cv)
        {
            return ChucVu_DAO.ThemChucVu_DAO(cv);
        }

        public static bool CapNhatChucVu_BUS(ChucVu_DTO cv)
        {
            return ChucVu_DAO.CapNhatChucVu_DAO(cv);
        }

        public static bool XoaChucVu_BUS(ChucVu_DTO cv)
        {
            return ChucVu_DAO.XoaChucVu_DAO(cv);
        }
    }
}
