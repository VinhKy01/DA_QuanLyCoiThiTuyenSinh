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
    public class PhongThi_DAO
    {
        static SqlConnection con;
        public static List<PhongThi_DTO> DanhSachPhongThi()
        {
            string query = string.Format("SELECT * FROM view_DanhSachPhongThi");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu địa điểm thi DTO
            List<PhongThi_DTO> listPhongHoc = new List<PhongThi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhongThi_DTO ph = new PhongThi_DTO();
                ph.Maphong = dt.Rows[i]["maPhong"].ToString();
                ph.Diachidiemthi = dt.Rows[i]["diaChiDiemThi"].ToString();
                ph.Ghichu = dt.Rows[i]["ghiChu"].ToString();
                listPhongHoc.Add(ph);
            }
            DataProvider.DongKetNoi(con);
            return listPhongHoc;
        }

        public static List<PhongThi_DTO> getID_PhongThi_FDiaDiemThi(int madd)
        {
            string query = string.Format("SELECT * FROM PHONGTHI WHERE diemThiSo = {0}", madd);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu địa điểm thi DTO
            List<PhongThi_DTO> listPhongHoc = new List<PhongThi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhongThi_DTO ph = new PhongThi_DTO();
                ph.Maphong = dt.Rows[i]["maPhong"].ToString();
                listPhongHoc.Add(ph);
            }
            DataProvider.DongKetNoi(con);
            return listPhongHoc;
        }

        public static List<PhongThi_DTO> TimDiaChi_Phong(string diachi)
        {
            string query = string.Format("EXEC proc_TimPhong_TheoDiaDiem N'%{0}%'", diachi);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu địa điểm thi DTO
            List<PhongThi_DTO> listPhongHoc = new List<PhongThi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhongThi_DTO ph = new PhongThi_DTO();
                ph.Maphong = dt.Rows[i]["maPhong"].ToString();
                ph.Diachidiemthi = dt.Rows[i]["diaChiDiemThi"].ToString();
                ph.Ghichu = dt.Rows[i]["ghiChu"].ToString();
                listPhongHoc.Add(ph);
            }
            DataProvider.DongKetNoi(con);
            return listPhongHoc;
        }

        public static List<PhongThi_DTO> FindIDPhong(string iDPhong)
        {
            string query = string.Format("EXEC proc_TimMaPhong '%{0}%'", iDPhong);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu địa điểm thi DTO
            List<PhongThi_DTO> listPhongHoc = new List<PhongThi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhongThi_DTO ph = new PhongThi_DTO();
                ph.Maphong = dt.Rows[i]["maPhong"].ToString();
                ph.Diachidiemthi = dt.Rows[i]["diaChiDiemThi"].ToString();
                ph.Ghichu = dt.Rows[i]["ghiChu"].ToString();
                listPhongHoc.Add(ph);
            }
            DataProvider.DongKetNoi(con);
            return listPhongHoc;
        }

        public static bool XoaFK_PhongThi_FDiaDiemThi(int madd)
        {
            string query = string.Format("EXEC proc_XoaFK_PhongThi_FDiaDiemThi {0}", madd);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaPhongThi_DAO(PhongThi_DTO pt)
        {
            string query = string.Format("EXEC proc_XoaPhongThi '{0}'", pt.Maphong);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapNhatPhongThi_DAO(PhongThi_DTO pt)
        {
            string query = string.Format("EXEC proc_CapNhatPhongThi '{0}', {1}, N'{2}'", pt.Maphong, pt.Diachidiemthi, pt.Ghichu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemPhongThi_DAO(PhongThi_DTO pt)
        {
            string query = string.Format("EXEC proc_ThemPhongThi '{0}', {1}, N'{2}'", pt.Maphong, pt.Diachidiemthi, pt.Ghichu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static PhongThi_DTO KiemTraID_PhongThi(PhongThi_DTO pt)
        {
            string query = string.Format("EXEC proc_KiemTraID_PhongThi '{0}'", pt.Maphong);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            PhongThi_DTO phonghoc = new PhongThi_DTO();
            phonghoc.Maphong = dt.Rows[0]["maPhong"].ToString();
            DataProvider.DongKetNoi(con);
            return phonghoc;
        }
    }
}
