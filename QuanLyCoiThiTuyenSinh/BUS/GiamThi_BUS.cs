using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class GiamThi_BUS
    {
        public static List<GiamThi_DTO> DanhSachGiamThi()
        {
            return GiamThi_DAO.DanhSachGiamThi();
        }

        public static GiamThi_DTO KiemTraID_GiamThi(GiamThi_DTO gt)
        {
            return GiamThi_DAO.KiemTraID_GiamThi(gt);
        }

        public static bool ThemGiamThi_BUS(GiamThi_DTO gt)
        {
            return GiamThi_DAO.ThemGiamThi_DAO(gt);
        }

        public static bool CapNhatGiamThi_BUS(GiamThi_DTO gt)
        {
            return GiamThi_DAO.CapNhatGiamThi_DAO(gt);
        }

        public static bool XoaFK_GiamThi_FDiaDiemThi(int madd)
        {
            return GiamThi_DAO.XoaFK_GiamThi_FDiaDiemThi(madd);
        }

        public static bool XoaFK_GiamThi_FDonVi(string madv)
        {
            return GiamThi_DAO.XoaFK_GiamThi_FDonVi(madv);
        }

        public static bool XoaFK_GiamThi_FChucVu(string macv)
        {
            return GiamThi_DAO.XoaFK_GiamThi_FChucVu(macv);
        }

        public static bool XoaGiamThi_BUS(GiamThi_DTO gt)
        {
            return GiamThi_DAO.XoaGiamThi_BUS(gt);
        }

        public static List<GiamThi_DTO> TimTenGiamThi(string ten)
        {
            return GiamThi_DAO.TimTenGiamThi(ten);
        }

        public static string SoLuongCanBoCoiThi()
        {
            return GiamThi_DAO.SoLuongCanBoCoiThi();
        }

        public static List<GiamThi_DTO> TimDiaChiDiemThi_GiamThi(string diachidiemthi)
        {
            return GiamThi_DAO.TimDiaChiDiemThi_GiamThi(diachidiemthi);
        }
    }
}
