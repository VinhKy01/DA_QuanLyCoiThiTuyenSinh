using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class Nganh_BUS
    {
        public static List<Nganh_DTO> DanhSachNganhHoc_BUS()
        {
            return Nganh_DAO.DanhSachNganhHoc_DAO();
        }

        public static bool ThemNganhHoc_BUS(Nganh_DTO n)
        {
            return Nganh_DAO.ThemNganhHoc_DAO(n);
        }

        public static Nganh_DTO KiemTraID_NganhHoc(Nganh_DTO n)
        {
            return Nganh_DAO.KiemTraID_NganhHoc(n);
        }

        public static bool CapNhatNganhHoc_BUS(Nganh_DTO n)
        {
            return Nganh_DAO.CapNhatNganhHoc_DAO(n);
        }

        public static bool XoaNganhHoc_BUS(Nganh_DTO n)
        {
            return Nganh_DAO.XoaNganhHoc_DAO(n);
        }

        public static List<Nganh_DTO> TimNganhThi(string tenNganh)
        {
            return Nganh_DAO.TimNganhThi(tenNganh);
        }
    }
}
