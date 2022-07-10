using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class KhuVuc_BUS
    {
        public static List<KhucVuc_DTO> DanhSachKhuVuc()
        {
            return KhucVuc_DAO.DanhSachKhuVuc();
        }

        public static KhucVuc_DTO KiemTraID_KhuVuc(KhucVuc_DTO kv)
        {
            return KhucVuc_DAO.KiemTraID_KhuVuc(kv);
        }

        public static bool ThemKhuVuc_BUS(KhucVuc_DTO kv)
        {
            return KhucVuc_DAO.ThemKhuVuc_DAO(kv);
        }

        public static bool CapNhatKhuVuc_BUS(KhucVuc_DTO dt)
        {
            return KhucVuc_DAO.CapNhatKhuVuc_DAO(dt);
        }

        public static bool XoaKhuVuc_BUS(KhucVuc_DTO kv)
        {
            return KhucVuc_DAO.XoaKhuVuc_DAO(kv);
        }
    }
}
