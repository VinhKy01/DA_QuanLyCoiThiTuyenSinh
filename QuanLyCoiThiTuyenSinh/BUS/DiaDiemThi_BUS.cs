using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class DiaDiemThi_BUS
    {
        public static List<DiaDiemThi_DTO> DanhSachDiemThiSo()
        {
            return DiaDiemThi_DAO.DanhSachDiemThiSo();
        }

        public static DiaDiemThi_DTO KiemTraID_DiaDiemThi(DiaDiemThi_DTO ddt)
        {
            return DiaDiemThi_DAO.KiemTraID_DiaDiemThi(ddt);
        }

        public static bool ThemDiaDiemThi_BUS(DiaDiemThi_DTO ddt)
        {
            return DiaDiemThi_DAO.ThemDiaDiemThi_DAO(ddt);
        }

        public static bool CapNhatDiaDiemThi_BUS(DiaDiemThi_DTO ddt)
        {
            return DiaDiemThi_DAO.CapNhatDiaDiemThi_DAO(ddt);
        }

        public static bool XoaDiaDiemThi_BUS(DiaDiemThi_DTO ddt)
        {
            return DiaDiemThi_DAO.XoaDiaDiemThi_DAO(ddt);
        }

        public static string SoLuongDiaDiemThi()
        {
            return DiaDiemThi_DAO.SoLuongDiaDiemThi();
        }

        public static List<DiaDiemThi_DTO> TimDiaChiDiemThi(string diachi)
        {
            return DiaDiemThi_DAO.TimDiaChiDiemThi(diachi);
        }
    }
}
