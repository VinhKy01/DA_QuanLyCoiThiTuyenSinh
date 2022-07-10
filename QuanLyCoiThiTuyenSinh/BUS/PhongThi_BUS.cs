using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class PhongThi_BUS
    {
        public static List<PhongThi_DTO> DanhSachPhongThi()
        {
            return PhongThi_DAO.DanhSachPhongThi();
        }

        public static PhongThi_DTO KiemTraID_PhongThi(PhongThi_DTO pt)
        {
            return PhongThi_DAO.KiemTraID_PhongThi(pt);
        }

        public static bool ThemPhongThi_BUS(PhongThi_DTO pt)
        {
            return PhongThi_DAO.ThemPhongThi_DAO(pt);
        }

        public static bool CapNhatPhongThi_BUS(PhongThi_DTO pt)
        {
            return PhongThi_DAO.CapNhatPhongThi_DAO(pt);
        }

        public static bool XoaPhongThi_BUS(PhongThi_DTO pt)
        {
            return PhongThi_DAO.XoaPhongThi_DAO(pt);
        }

        public static bool XoaFK_PhongThi_FDiaDiemThi(int madd)
        {
            return PhongThi_DAO.XoaFK_PhongThi_FDiaDiemThi(madd);
        }

        public static List<PhongThi_DTO> getID_PhongThi_FDiaDiemThi(int madd)
        {
            return PhongThi_DAO.getID_PhongThi_FDiaDiemThi(madd);
        }

        public static List<PhongThi_DTO> FindIDPhong(string iDPhong)
        {
            return PhongThi_DAO.FindIDPhong(iDPhong);
        }

        public static List<PhongThi_DTO> TimDiaChi_Phong(string diachi)
        {
            return PhongThi_DAO.TimDiaChi_Phong(diachi);
        }
    }
}
