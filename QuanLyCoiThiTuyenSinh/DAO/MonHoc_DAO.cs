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
    public class MonHoc_DAO
    {
        static SqlConnection con;
        public static List<MonHoc_DTO> DanhSachMonHoc()
        {
            string query = string.Format("SELECT * FROM view_DanhSachMonThi");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu môn học DTO
            List<MonHoc_DTO> listMonHoc = new List<MonHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonHoc_DTO mh = new MonHoc_DTO();
                mh.Mamon = dt.Rows[i]["maMon"].ToString();
                mh.Tenmon = dt.Rows[i]["tenMon"].ToString();
                mh.Ngaythi = DateTime.Parse(dt.Rows[i]["ngayThi"].ToString());
                mh.Buoithi = dt.Rows[i]["buoiThi"].ToString();
                mh.Thoigian = dt.Rows[i]["thoiGian"].ToString();
                mh.Tennganh = dt.Rows[i]["tenNganh"].ToString();
                listMonHoc.Add(mh);
            }
            DataProvider.DongKetNoi(con);
            return listMonHoc;
        }

        public static List<MonHoc_DTO> TimTenMonHoc(string tenMon)
        {
            string query = string.Format("EXEC proc_TimTenMonHoc N'%{0}%'", tenMon);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu môn học DTO
            List<MonHoc_DTO> listMonHoc = new List<MonHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonHoc_DTO mh = new MonHoc_DTO();
                mh.Mamon = dt.Rows[i]["maMon"].ToString();
                mh.Tenmon = dt.Rows[i]["tenMon"].ToString();
                mh.Ngaythi = DateTime.Parse(dt.Rows[i]["ngayThi"].ToString());
                mh.Buoithi = dt.Rows[i]["buoiThi"].ToString();
                mh.Thoigian = dt.Rows[i]["thoiGian"].ToString();
                mh.Tennganh = dt.Rows[i]["tenNganh"].ToString();
                listMonHoc.Add(mh);
            }
            DataProvider.DongKetNoi(con);
            return listMonHoc;
        }

        public static List<MonHoc_DTO> TimMon_TheoNganhThi(string maNganh)
        {
            string query = string.Format("EXEC proc_TimTenMon_TheoNganh N'%{0}%'", maNganh);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu môn học DTO
            List<MonHoc_DTO> listMonHoc = new List<MonHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonHoc_DTO mh = new MonHoc_DTO();
                mh.Mamon = dt.Rows[i]["maMon"].ToString();
                mh.Tenmon = dt.Rows[i]["tenMon"].ToString();
                mh.Ngaythi = DateTime.Parse(dt.Rows[i]["ngayThi"].ToString());
                mh.Buoithi = dt.Rows[i]["buoiThi"].ToString();
                mh.Thoigian = dt.Rows[i]["thoiGian"].ToString();
                mh.Tennganh = dt.Rows[i]["tenNganh"].ToString();
                listMonHoc.Add(mh);
            }
            DataProvider.DongKetNoi(con);
            return listMonHoc;
        }

        public static bool XoaFK_Mon_FThoiGianThi(string maTG)
        {
            string query = string.Format("EXEC proc_XoaFK_Mon_FThoiGianThi '{0}'", maTG);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaFK_Mon_FBuoiThi(string maBT)
        {
            string query = string.Format("EXEC proc_XoaFK_Mon_FBuoiThi '{0}'", maBT);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaMonThi(MonHoc_DTO mh)
        {
            string query = string.Format("EXEC proc_XoaMonThi '{0}'", mh.Mamon);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaFK_IDNganh_FMonThi(MonHoc_DTO mh)
        {
            string query = string.Format("EXEC proc_XoaFK_MonThi_IDNganhHoc '{0}'", mh.Tennganh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapNhatMonHoc_DAO(MonHoc_DTO mh)
        {
            string query = string.Format("EXEC proc_CapNhatMonHoc '{0}', N'{1}', '{2}', N'{3}', {4}, '{5}'", mh.Mamon, mh.Tenmon, mh.Ngaythi, mh.Buoithi, mh.Thoigian, mh.Tennganh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemMonHoc_DAO(MonHoc_DTO mh)
        {
            string query = string.Format("EXEC proc_ThemMonHoc '{0}', N'{1}', '{2}', N'{3}', N'{4}', '{5}'", mh.Mamon, mh.Tenmon, mh.Ngaythi, mh.Buoithi, mh.Thoigian, mh.Tennganh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static MonHoc_DTO KiemTraID_MonHoc(MonHoc_DTO mh)
        {
            string query = string.Format("EXEC proc_KiemTraID_MonThi '{0}'", mh.Mamon);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            MonHoc_DTO monhoc = new MonHoc_DTO();
            monhoc.Mamon = dt.Rows[0]["maMon"].ToString();
            monhoc.Tenmon = dt.Rows[0]["tenMon"].ToString();
            monhoc.Ngaythi = DateTime.Parse(dt.Rows[0]["ngayThi"].ToString());
            monhoc.Buoithi = dt.Rows[0]["maBuoiThi"].ToString();
            monhoc.Thoigian = dt.Rows[0]["maThoiGian"].ToString();
            monhoc.Tennganh = dt.Rows[0]["maNganh"].ToString();
            DataProvider.DongKetNoi(con);
            return monhoc;
        }
    }
}
