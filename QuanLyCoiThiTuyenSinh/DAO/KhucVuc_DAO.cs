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
    public class KhucVuc_DAO
    {
        static SqlConnection con;
        public static List<KhucVuc_DTO> DanhSachKhuVuc()
        {
            string query = string.Format("SELECT * FROM KHUVUC");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu khu vực DTO
            List<KhucVuc_DTO> listKhuVuc = new List<KhucVuc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhucVuc_DTO kv = new KhucVuc_DTO();
                kv.Makhuvuc = dt.Rows[i]["maKhuVuc"].ToString();
                kv.Tenkhuvuc = dt.Rows[i]["tenKhuVuc"].ToString();
                listKhuVuc.Add(kv);
            }
            DataProvider.DongKetNoi(con);
            return listKhuVuc;
        }

        public static bool XoaKhuVuc_DAO(KhucVuc_DTO kv)
        {
            string query = string.Format("EXEC proc_XoaKhuVuc '{0}'", kv.Makhuvuc);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapNhatKhuVuc_DAO(KhucVuc_DTO kv)
        {
            string query = string.Format("EXEC proc_CapNhatKhuVuc '{0}', N'{1}'", kv.Makhuvuc, kv.Tenkhuvuc);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemKhuVuc_DAO(KhucVuc_DTO kv)
        {
            string query = string.Format("EXEC proc_ThemKhuVuc '{0}', N'{1}'", kv.Makhuvuc, kv.Tenkhuvuc);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static KhucVuc_DTO KiemTraID_KhuVuc(KhucVuc_DTO kv)
        {
            string query = string.Format("EXEC proc_KiemTraID_KhuVuc '{0}'", kv.Makhuvuc);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KhucVuc_DTO khuvuc = new KhucVuc_DTO();
            khuvuc.Makhuvuc = dt.Rows[0]["maKhuVuc"].ToString();
            khuvuc.Tenkhuvuc = dt.Rows[0]["tenKhuVuc"].ToString();
            DataProvider.DongKetNoi(con);
            return khuvuc;
        }
    }
}
