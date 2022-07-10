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
    public class ThoiGian_DAO
    {
        static SqlConnection con;
        public static List<ThoiGian_DTO> DanhSachThoiGian()
        {
            string query = string.Format("SELECT * FROM THOIGIANTHI");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu thời gian DTO
            List<ThoiGian_DTO> listThoiGian = new List<ThoiGian_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThoiGian_DTO tg = new ThoiGian_DTO();
                tg.Matg = dt.Rows[i]["maThoiGian"].ToString();
                tg.Thoigian = dt.Rows[i]["thoiGian"].ToString();
                listThoiGian.Add(tg);
            }
            DataProvider.DongKetNoi(con);
            return listThoiGian;
        }

        public static bool XoaThoiGian(ThoiGian_DTO tg)
        {
            string query = string.Format("EXEC proc_XoaThoiGianThi '{0}'", tg.Matg);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapNhatThoiGian_DAO(ThoiGian_DTO tg)
        {
            string query = string.Format("EXEC proc_CapNhatThoiGian '{0}', N'{1}'", tg.Matg, tg.Thoigian);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemThoiGianMoi_DAO(ThoiGian_DTO tg)
        {
            string query = string.Format("EXEC proc_ThemThoiGian '{0}', N'{1}'", tg.Matg, tg.Thoigian);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static ThoiGian_DTO KIemTraID_ThoiGian(ThoiGian_DTO tg)
        {
            string query = string.Format("EXEC proc_KiemTraID_ThoiGian '{0}'", tg.Matg);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ThoiGian_DTO thoigian = new ThoiGian_DTO();
            thoigian.Matg = dt.Rows[0]["maThoiGian"].ToString();
            thoigian.Thoigian = dt.Rows[0]["thoiGian"].ToString();
            DataProvider.DongKetNoi(con);
            return thoigian;
        }
    }
}
