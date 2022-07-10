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
    public class DiaDiemThi_DAO
    {
        static SqlConnection con;
        public static List<DiaDiemThi_DTO> DanhSachDiemThiSo()
        {
            string query = string.Format("SELECT * FROM DIEMTHI");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu địa điểm thi DTO
            List<DiaDiemThi_DTO> listDiaDiemThi = new List<DiaDiemThi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DiaDiemThi_DTO diadiemthi = new DiaDiemThi_DTO();
                diadiemthi.Diemthiso = int.Parse(dt.Rows[i]["diemThiSo"].ToString());
                diadiemthi.Diachidiemthi = dt.Rows[i]["diaChiDiemThi"].ToString();
                listDiaDiemThi.Add(diadiemthi);
            }
            DataProvider.DongKetNoi(con);
            return listDiaDiemThi;
        }

        public static List<DiaDiemThi_DTO> TimDiaChiDiemThi(string diachi)
        {
            string query = string.Format("SELECT * FROM DIEMTHI WHERE diaChiDiemThi LIKE N'%{0}%'", diachi);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu địa điểm thi DTO
            List<DiaDiemThi_DTO> listDiaDiemThi = new List<DiaDiemThi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DiaDiemThi_DTO diadiemthi = new DiaDiemThi_DTO();
                diadiemthi.Diemthiso = int.Parse(dt.Rows[i]["diemThiSo"].ToString());
                diadiemthi.Diachidiemthi = dt.Rows[i]["diaChiDiemThi"].ToString();
                listDiaDiemThi.Add(diadiemthi);
            }
            DataProvider.DongKetNoi(con);
            return listDiaDiemThi;
        }

        public static string SoLuongDiaDiemThi()
        {
            string query = string.Format("SELECT * FROM view_SoDiaDiemToChuc");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            string slddt;
            slddt = dt.Rows[0]["SLDDT"].ToString();
            DataProvider.DongKetNoi(con);
            return slddt;
        }

        public static bool XoaDiaDiemThi_DAO(DiaDiemThi_DTO ddt)
        {
            string query = string.Format("EXEC proc_XoaDiaDiemThi {0}", ddt.Diemthiso);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapNhatDiaDiemThi_DAO(DiaDiemThi_DTO ddt)
        {
            string query = string.Format("EXEC proc_CapNhatDiaDiemThi {0}, N'{1}'", ddt.Diemthiso, ddt.Diachidiemthi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemDiaDiemThi_DAO(DiaDiemThi_DTO ddt)
        {
            string query = string.Format("EXEC proc_ThemDiaDiemThi {0}, N'{1}'", ddt.Diemthiso, ddt.Diachidiemthi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static DiaDiemThi_DTO KiemTraID_DiaDiemThi(DiaDiemThi_DTO ddt)
        {
            string query = string.Format("EXEC proc_KiemTraID_DiaDiemThi '{0}'", ddt.Diemthiso);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu địa chỉ điểm thi DTO
            DiaDiemThi_DTO diadiemthi = new DiaDiemThi_DTO();
            diadiemthi.Diemthiso = int.Parse(dt.Rows[0]["diemThiSo"].ToString());
            diadiemthi.Diachidiemthi = dt.Rows[0]["diaChiDiemThi"].ToString();
            DataProvider.DongKetNoi(con);
            return diadiemthi;
        }
    }
}
