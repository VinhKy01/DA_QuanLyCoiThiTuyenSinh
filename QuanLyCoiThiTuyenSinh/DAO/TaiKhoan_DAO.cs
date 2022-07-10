using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoan_DAO
    {
        static SqlConnection con;
        public static TaiKhoan_DTO DangNhap_DAO(TaiKhoan_DTO tk, string MKMH)
        {
            string query = string.Format("proc_DangNhap '{0}', '{1}'", tk.Taikhoan, MKMH);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu Tài Khoản DTO
            TaiKhoan_DTO taikhoan = new TaiKhoan_DTO();
            taikhoan.Taikhoan = dt.Rows[0]["tenDangNhap"].ToString();
            taikhoan.Matkhau = dt.Rows[0]["matKhau"].ToString();
            taikhoan.Loaitaikhoan = int.Parse(dt.Rows[0]["loaiTaiKhoan"].ToString());
            taikhoan.Manguoidung = dt.Rows[0]["soBaoDanh"].ToString();
            DataProvider.DongKetNoi(con);
            return taikhoan;
        }

        public static List<TaiKhoan_DTO> DanhSachNguoiDung_DAO()
        {
            string query = string.Format("SELECT tk.tenDangNhap, tk.matkhau, tk.loaiTaiKhoan, ts.hoTen FROM TAIKHOAN tk, THISINH ts where tk.soBaoDanh = ts.soBaoDanh");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu Tài Khoản DTO
            List<TaiKhoan_DTO> listTaiKhoan = new List<TaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO taikhoan = new TaiKhoan_DTO();
                taikhoan.Taikhoan = dt.Rows[i]["tenDangNhap"].ToString();
                taikhoan.Matkhau = dt.Rows[i]["matkhau"].ToString();
                taikhoan.Loaitaikhoan = int.Parse(dt.Rows[i]["loaiTaiKhoan"].ToString());
                taikhoan.Manguoidung = dt.Rows[i]["hoTen"].ToString();
                listTaiKhoan.Add(taikhoan);
            }
            DataProvider.DongKetNoi(con);
            return listTaiKhoan;
        }

        public static bool CapNhatMatKhau_DAO(TaiKhoan_DTO taikhoan, string mKhauMoiMH)
        {
            string query = string.Format("EXEC proc_CapNhatMK '{0}', '{1}'", taikhoan.Taikhoan, mKhauMoiMH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemTaiKhoan_DAO(TaiKhoan_DTO taikhoan, string mKhauMoiMH)
        {
            string query = string.Format("EXEC proc_ThemTaiKhoanMoi '{0}', '{1}', {2}, '{3}'", taikhoan.Taikhoan, mKhauMoiMH, taikhoan.Loaitaikhoan, taikhoan.Manguoidung);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool PhanQuyen_DAO(TaiKhoan_DTO tk)
        {
            string query = string.Format("EXEC proc_PhanQuyen '{0}', '{1}'", tk.Taikhoan, tk.Loaitaikhoan);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaFK_TaiKhoan_DAO(TaiKhoan_DTO tk)
        {
            string query = string.Format("EXEC proc_XoaFK_TaiKhoan '{0}'", tk.Manguoidung);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaTaiKhoan_DAO(TaiKhoan_DTO tk)
        {
            string query = string.Format("EXEC proc_XoaTaiKhoan '{0}'", tk.Taikhoan);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static TaiKhoan_DTO KiemTraIDTaiKhoan_DAO(TaiKhoan_DTO tk)
        {
            string query = string.Format("EXEC proc_KiemTraID_TaiKhoan '{0}'", tk.Taikhoan);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu Tài Khoản DTO
            TaiKhoan_DTO taikhoan = new TaiKhoan_DTO();
            taikhoan.Taikhoan = dt.Rows[0]["tenDangNhap"].ToString();
            taikhoan.Matkhau = dt.Rows[0]["matKhau"].ToString();
            taikhoan.Loaitaikhoan = int.Parse(dt.Rows[0]["loaiTaiKhoan"].ToString());
            taikhoan.Manguoidung = dt.Rows[0]["soBaoDanh"].ToString();
            DataProvider.DongKetNoi(con);
            return taikhoan;
        }

        public static bool ResetMK_DAO(TaiKhoan_DTO taikhoan, string mKhauMoiMH)
        {
            string query = string.Format("EXEC proc_ResetMK '{0}', '{1}'", taikhoan.Taikhoan, mKhauMoiMH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
