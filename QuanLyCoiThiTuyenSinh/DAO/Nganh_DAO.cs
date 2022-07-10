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
    public class Nganh_DAO
    {
        static SqlConnection con;
        public static List<Nganh_DTO> DanhSachNganhHoc_DAO()
        {
            string query = string.Format("SELECT * FROM NGANH");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu ngành DTO
            List<Nganh_DTO> listNganhHoc = new List<Nganh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Nganh_DTO nganh = new Nganh_DTO();
                nganh.Manganh = dt.Rows[i]["maNganh"].ToString();
                nganh.Tennganh = dt.Rows[i]["tenNganh"].ToString();
                listNganhHoc.Add(nganh);
            }
            DataProvider.DongKetNoi(con);
            return listNganhHoc;
        }

        public static List<Nganh_DTO> TimNganhThi(string tenNganh)
        {
            string query = string.Format("SELECT * FROM NGANH WHERE tenNganh like N'%{0}%'", tenNganh);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu ngành DTO
            List<Nganh_DTO> listNganhHoc = new List<Nganh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Nganh_DTO nganh = new Nganh_DTO();
                nganh.Manganh = dt.Rows[i]["maNganh"].ToString();
                nganh.Tennganh = dt.Rows[i]["tenNganh"].ToString();
                listNganhHoc.Add(nganh);
            }
            DataProvider.DongKetNoi(con);
            return listNganhHoc;
        }

        public static bool XoaNganhHoc_DAO(Nganh_DTO n)
        {
            string query = string.Format("EXEC proc_XoaNganhHoc '{0}'", n.Manganh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapNhatNganhHoc_DAO(Nganh_DTO n)
        {
            string query = string.Format("EXEC proc_CapNhatNganhHoc '{0}', N'{1}'", n.Manganh, n.Tennganh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static Nganh_DTO KiemTraID_NganhHoc(Nganh_DTO n)
        {
            string query = string.Format("EXEC proc_KiemTraID_NganhHoc '{0}'", n.Manganh);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu ngành DTO
            Nganh_DTO nganh = new Nganh_DTO();
            nganh.Manganh = dt.Rows[0]["maNganh"].ToString();
            nganh.Tennganh = dt.Rows[0]["tenNganh"].ToString();
            DataProvider.DongKetNoi(con);
            return nganh;
        }

        public static bool ThemNganhHoc_DAO(Nganh_DTO n)
        {
            string query = string.Format("EXEC proc_ThemNganhHoc '{0}', N'{1}'", n.Manganh, n.Tennganh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
