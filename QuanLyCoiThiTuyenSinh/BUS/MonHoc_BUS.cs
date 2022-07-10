using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class MonHoc_BUS
    {
        public static List<MonHoc_DTO> DanhSachMonHoc()
        {
            return MonHoc_DAO.DanhSachMonHoc();
        }

        public static MonHoc_DTO KiemTraID_MonHoc(MonHoc_DTO mh)
        {
            return MonHoc_DAO.KiemTraID_MonHoc(mh);
        }

        public static bool ThemMonHoc_BUS(MonHoc_DTO mh)
        {
            return MonHoc_DAO.ThemMonHoc_DAO(mh);
        }

        public static bool CapNhatMonHoc_BUS(MonHoc_DTO mh)
        {
            return MonHoc_DAO.CapNhatMonHoc_DAO(mh);
        }

        public static bool XoaFK_IDNganh_FMonThi(MonHoc_DTO mh)
        {
            return MonHoc_DAO.XoaFK_IDNganh_FMonThi(mh);
        }

        public static bool XoaMonThi(MonHoc_DTO mh)
        {
            return MonHoc_DAO.XoaMonThi(mh);
        }

        public static bool XoaFK_Mon_FBuoiThi(string maBT)
        {
            return MonHoc_DAO.XoaFK_Mon_FBuoiThi(maBT);
        }

        public static bool XoaFK_Mon_FThoiGianThi(string maTG)
        {
            return MonHoc_DAO.XoaFK_Mon_FThoiGianThi(maTG);
        }

        public static List<MonHoc_DTO> TimTenMonHoc(string tenMon)
        {
            return MonHoc_DAO.TimTenMonHoc(tenMon);
        }

        public static List<MonHoc_DTO> TimMon_TheoNganhThi(string maNganh)
        {
            return MonHoc_DAO.TimMon_TheoNganhThi(maNganh);
        }
    }
}