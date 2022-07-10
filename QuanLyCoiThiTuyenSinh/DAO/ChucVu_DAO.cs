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
    public class ChucVu_DAO
    {
        static SqlConnection con;
        public static List<ChucVu_DTO> DanhSachChucVu_BUS()
        {
            string query = string.Format("SELECT * FROM CHUCVU");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu chức vụ DTO
            List<ChucVu_DTO> listChucVu = new List<ChucVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVu_DTO cv = new ChucVu_DTO();
                cv.Machucvu = dt.Rows[i]["maChucVu"].ToString();
                cv.Tenchucvu = dt.Rows[i]["tenChucVu"].ToString();
                listChucVu.Add(cv);
            }
            DataProvider.DongKetNoi(con);
            return listChucVu;
        }

        public static bool XoaChucVu_DAO(ChucVu_DTO cv)
        {
            string query = string.Format("EXEC proc_XoaChucVu '{0}'", cv.Machucvu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapNhatChucVu_DAO(ChucVu_DTO cv)
        {
            string query = string.Format("EXEC proc_CapNhatChucVu '{0}', N'{1}'", cv.Machucvu, cv.Tenchucvu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemChucVu_DAO(ChucVu_DTO cv)
        {
            string query = string.Format("EXEC proc_ThemChucVu '{0}', N'{1}'", cv.Machucvu, cv.Tenchucvu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static ChucVu_DTO KiemTraID_ChucVu_DAO(ChucVu_DTO cv)
        {
            string query = string.Format("EXEC proc_KiemTraID_ChucVu '{0}'", cv.Machucvu);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu ngành DTO
            ChucVu_DTO chucvu = new ChucVu_DTO();
            chucvu.Machucvu = dt.Rows[0]["maChucVu"].ToString();
            chucvu.Tenchucvu = dt.Rows[0]["tenChucVu"].ToString();
            DataProvider.DongKetNoi(con);
            return chucvu;
        }
    }
}
