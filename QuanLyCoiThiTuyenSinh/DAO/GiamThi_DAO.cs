using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiamThi_DAO
    {
        static SqlConnection con;
        public static List<GiamThi_DTO> DanhSachGiamThi()
        {
            string query = string.Format("SELECT * FROM view_DanhSachGiamThi");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu giám thị DTO
            List<GiamThi_DTO> listGiamThi = new List<GiamThi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GiamThi_DTO gt = new GiamThi_DTO();
                gt.Magiamthi = dt.Rows[i]["maCanBo"].ToString();
                gt.Tengiamthi = dt.Rows[i]["tenCanBo"].ToString();
                gt.Tendonvi = dt.Rows[i]["tenDonVi"].ToString();
                gt.Gioitinh = dt.Rows[i]["gioiTinh"].ToString();
                gt.Tenchucvu = dt.Rows[i]["tenChucVu"].ToString();
                gt.Diachidiemthi = dt.Rows[i]["diaChiDiemThi"].ToString();
                listGiamThi.Add(gt);
            }
            DataProvider.DongKetNoi(con);
            return listGiamThi;
        }

        public static string SoLuongCanBoCoiThi()
        {
            string query = string.Format("SELECT * FROM view_SoGiangVien");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            string slgv;
            slgv = dt.Rows[0]["SLGV"].ToString();
            DataProvider.DongKetNoi(con);
            return slgv;
        }

        public static List<GiamThi_DTO> TimDiaChiDiemThi_GiamThi(string diachidiemthi)
        {
            string query = string.Format("EXEC proc_TimGiamThi_TheoDiaChi N'%{0}%'", diachidiemthi);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu giám thị DTO
            List<GiamThi_DTO> listGiamThi = new List<GiamThi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GiamThi_DTO gt = new GiamThi_DTO();
                gt.Magiamthi = dt.Rows[i]["maCanBo"].ToString();
                gt.Tengiamthi = dt.Rows[i]["tenCanBo"].ToString();
                gt.Tendonvi = dt.Rows[i]["tenDonVi"].ToString();
                gt.Gioitinh = dt.Rows[i]["gioiTinh"].ToString();
                gt.Tenchucvu = dt.Rows[i]["tenChucVu"].ToString();
                gt.Diachidiemthi = dt.Rows[i]["diaChiDiemThi"].ToString();
                listGiamThi.Add(gt);
            }
            DataProvider.DongKetNoi(con);
            return listGiamThi;
        }

        public static List<GiamThi_DTO> TimTenGiamThi(string ten)
        {
            string query = string.Format("EXEC proc_TimTenGiamThi N'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu giám thị DTO
            List<GiamThi_DTO> listGiamThi = new List<GiamThi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GiamThi_DTO gt = new GiamThi_DTO();
                gt.Magiamthi = dt.Rows[i]["maCanBo"].ToString();
                gt.Tengiamthi = dt.Rows[i]["tenCanBo"].ToString();
                gt.Tendonvi = dt.Rows[i]["tenDonVi"].ToString();
                gt.Gioitinh = dt.Rows[i]["gioiTinh"].ToString();
                gt.Tenchucvu = dt.Rows[i]["tenChucVu"].ToString();
                gt.Diachidiemthi = dt.Rows[i]["diaChiDiemThi"].ToString();
                listGiamThi.Add(gt);
            }
            DataProvider.DongKetNoi(con);
            return listGiamThi;
        }

        public static bool XoaGiamThi_BUS(GiamThi_DTO gt)
        {
            string query = string.Format("EXEC proc_XoaGiamThi '{0}'", gt.Magiamthi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaFK_GiamThi_FChucVu(string macv)
        {
            string query = string.Format("EXEC proc_XoaFK_GiamThi_FChucVu '{0}'", macv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaFK_GiamThi_FDonVi(string madv)
        {
            string query = string.Format("EXEC proc_XoaFK_GiamThi_FDonVi '{0}'", madv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaFK_GiamThi_FDiaDiemThi(int madd)
        {
            string query = string.Format("EXEC proc_XoaFK_GiamThi_FDiaDiemThi {0}", madd);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapNhatGiamThi_DAO(GiamThi_DTO gt)
        {
            string query = string.Format("EXEC proc_CapNhatGiamThi '{0}', N'{1}', '{2}', N'{3}', '{4}', '{5}'", gt.Magiamthi, gt.Tengiamthi, gt.Tendonvi, gt.Gioitinh, gt.Tenchucvu, gt.Diachidiemthi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemGiamThi_DAO(GiamThi_DTO gt)
        {
            string query = string.Format("EXEC proc_ThemGiamThi '{0}', N'{1}', '{2}', N'{3}', '{4}', '{5}'", gt.Magiamthi, gt.Tengiamthi, gt.Tendonvi, gt.Gioitinh, gt.Tenchucvu, gt.Diachidiemthi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static GiamThi_DTO KiemTraID_GiamThi(GiamThi_DTO gt)
        {
            string query = string.Format("EXEC proc_KiemTraID_GiamThi '{0}'",gt.Magiamthi);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu giám thị DTO
            GiamThi_DTO giamthi = new GiamThi_DTO();
            giamthi.Magiamthi = dt.Rows[0]["maCanBo"].ToString();
            giamthi.Tengiamthi = dt.Rows[0]["tenCanBo"].ToString();
            DataProvider.DongKetNoi(con);
            return giamthi;
        }
    }
}
