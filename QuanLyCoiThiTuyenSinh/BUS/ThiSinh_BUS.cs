using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class ThiSinh_BUS
    {
        public static ThiSinh_DTO getTenThiSinh_BUS(string maNguoiDung)
        {
            return ThiSinh_DAO.getTenThiSinh_DAO(maNguoiDung);
        }

        public static List<ThiSinh_DTO> DanhSachThiSinh()
        {
            return ThiSinh_DAO.DanhSachThiSinh();
        }

        public static string SoLuongThiSinh()
        {
            return ThiSinh_DAO.SoLuongThiSinh();
        }

        public static bool ThemThiSinh_BUS(ThiSinh_DTO ts)
        {
            return ThiSinh_DAO.ThemThiSinh_DAO(ts);
        }

        public static bool CapNhatThiSinh_BUS(ThiSinh_DTO ts)
        {
            return ThiSinh_DAO.CapNhatThiSinh_DAO(ts);
        }

        public static bool XoaThiSinh_BUS(ThiSinh_DTO ts)
        {
            return ThiSinh_DAO.XoaThiSinh_DAO(ts);
        }

        public static List<ThiSinh_DTO> getID_ThiSinh_FDoiTuong_BUS(DoiTuong_DTO dt)
        {
            return ThiSinh_DAO.getID_ThiSinh_FDoiTuong_DAO(dt);
        }

        public static bool XoaFK_ThiSinh_FDoiTuong_BUS(string ma)
        {
            return ThiSinh_DAO.XoaFK_ThiSinh_FDoiTuong_DAO(ma);
        }

        public static List<ThiSinh_DTO> FindName_ThiSinh(string name)
        {
            return ThiSinh_DAO.FindName_ThiSinh(name);
        }

        public static bool XoaFK_IDnganh_FThiSinh(ThiSinh_DTO ts)
        {
            return ThiSinh_DAO.XoaFK_IDnganh_FThiSinh(ts);
        }

        public static List<ThiSinh_DTO> getID_ThiSinh_FNganh(ThiSinh_DTO ts)
        {
            return ThiSinh_DAO.getID_ThiSinh_FNganh(ts);
        }

        public static List<ThiSinh_DTO> getID_ThiSinh_FKhuVuc(string makc)
        {
            return ThiSinh_DAO.getID_ThiSinh_FKhuVuc(makc);
        }

        public static List<ThiSinh_DTO> TimKiemTheoCBB_Nganh(string maNganh)
        {
            return ThiSinh_DAO.TimKiemTheoCBB_Nganh(maNganh);
        }

        public static bool XoaFK_ThiSinh_FKhuVuc_BUS(string makhuvuc)
        {
            return ThiSinh_DAO.XoaFK_ThiSinh_FKhuVuc_DAO(makhuvuc);
        }

        public static List<ThiSinh_DTO> FindIDPhong_ThiSinh(string iDPhong)
        {
            return ThiSinh_DAO.FindIDPhong_ThiSinh(iDPhong);
        }

        public static ThiSinh_DTO getValueInfo(string maNguoiDung)
        {
            return ThiSinh_DAO.getValueInfo(maNguoiDung);
        }

        public static bool XoaFK_ThiSinh_FPhongThi_BUS(string maPhong)
        {
            return ThiSinh_DAO.XoaFK_ThiSinh_FPhongThi_DAO(maPhong);
        }

        public static List<ThiSinh_DTO> getID_ThiSinh_FPhongThi(string maPhong)
        {
            return ThiSinh_DAO.getID_ThiSinh_FPhongThi(maPhong);
        }

        public static bool XoaFK_ThiSinh_FDiaDiemThi(string maPhong)
        {
            return ThiSinh_DAO.XoaFK_ThiSinh_FDiaDiemThi(maPhong);
        }

        public static List<ThiSinh_DTO> getID_ThiSinh_FDiaDiemThi(string maPhong)
        {
            return ThiSinh_DAO.getID_ThiSinh_FDiaDiemThi(maPhong);
        }

        public static ThiSinh_DTO KiemTraID_ThiSinh(string sbd)
        {
            return ThiSinh_DAO.KiemTraID_ThiSinh(sbd);
        }
    }
}
