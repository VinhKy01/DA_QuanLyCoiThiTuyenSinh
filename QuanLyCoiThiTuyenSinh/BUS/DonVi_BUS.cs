using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class DonVi_BUS
    {
        public static List<DonVi_DTO> DanhSachDonVi()
        {
            return DonVi_DAO.DanhSachDonVi();
        }

        public static DonVi_DTO KiemTraID_DonVi(DonVi_DTO dv)
        {
            return DonVi_DAO.KiemTraID_DonVi(dv);
        }

        public static bool ThemDonVi_BUS(DonVi_DTO dv)
        {
            return DonVi_DAO.ThemDonVi_DAO(dv);
        }

        public static bool CapNhatDonVi_BUS(DonVi_DTO dv)
        {
            return DonVi_DAO.CapNhatDonVi_DAO(dv);
        }

        public static bool XoaDonVi_BUS(DonVi_DTO dv)
        {
            return DonVi_DAO.XoaDonVi_DAO(dv);
        }
    }
}
