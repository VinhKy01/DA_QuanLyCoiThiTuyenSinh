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
    public class ThiSinh_DAO
    {
        static SqlConnection con;

        public static ThiSinh_DTO getTenThiSinh_DAO(string maNguoiDung)
        {
            string query = string.Format("SELECT * FROM THISINH WHERE soBaoDanh = '{0}'", maNguoiDung);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu địa chỉ điểm thi DTO
            ThiSinh_DTO ts = new ThiSinh_DTO();
            ts.Sbd = dt.Rows[0]["soBaoDanh"].ToString();
            ts.Hoten = dt.Rows[0]["hoTen"].ToString();
            DataProvider.DongKetNoi(con);
            return ts;
        }

        public static bool ThemThiSinh_DAO(ThiSinh_DTO ts)
        {
            string query = string.Format("EXEC proc_ThemThiSinh '{0}', N'{1}', '{2}', N'{3}', N'{4}', '{5}', '{6}', '{7}', '{8}', '{9}'", ts.Sbd, ts.Hoten, ts.Ngaysinh, ts.Gioitinh, ts.Hokhau, ts.Doituong, ts. Manganh, ts.Khuvuc, ts.Maphong, ts.Images);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<ThiSinh_DTO> FindName_ThiSinh(string name)
        {
            string query = string.Format("EXEC proc_FindName_ThiSinh N'%{0}%'", name);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu giám thị DTO
            List<ThiSinh_DTO> listThiSinh = new List<ThiSinh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThiSinh_DTO ts = new ThiSinh_DTO();
                ts.Sbd = dt.Rows[i]["soBaoDanh"].ToString();
                ts.Hoten = dt.Rows[i]["hoTen"].ToString();
                ts.Ngaysinh = DateTime.Parse(dt.Rows[i]["ngaySinh"].ToString());
                ts.Gioitinh = dt.Rows[i]["gioiTinh"].ToString();
                ts.Hokhau = dt.Rows[i]["hoKhau"].ToString();
                ts.Doituong = dt.Rows[i]["tenDoiTuong"].ToString();
                ts.Manganh = dt.Rows[i]["tenNganh"].ToString();
                ts.Khuvuc = dt.Rows[i]["tenKhuVuc"].ToString();
                ts.Maphong = dt.Rows[i]["maPhong"].ToString();
                if (!Convert.IsDBNull(dt.Rows[i]["images"]))
                {
                    ts.Images = dt.Rows[i]["images"].ToString();
                }
                listThiSinh.Add(ts);
            }
            DataProvider.DongKetNoi(con);
            return listThiSinh;
        }

        public static List<ThiSinh_DTO> FindIDPhong_ThiSinh(string iDPhong)
        {
            string query = string.Format("EXEC proc_FindIDPhong_ThiSinh N'%{0}%'", iDPhong);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu thí sinh DTO
            List<ThiSinh_DTO> listThiSinh = new List<ThiSinh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThiSinh_DTO ts = new ThiSinh_DTO();
                ts.Sbd = dt.Rows[i]["soBaoDanh"].ToString();
                ts.Hoten = dt.Rows[i]["hoTen"].ToString();
                ts.Ngaysinh = DateTime.Parse(dt.Rows[i]["ngaySinh"].ToString());
                ts.Gioitinh = dt.Rows[i]["gioiTinh"].ToString();
                ts.Hokhau = dt.Rows[i]["hoKhau"].ToString();
                ts.Doituong = dt.Rows[i]["tenDoiTuong"].ToString();
                ts.Manganh = dt.Rows[i]["tenNganh"].ToString();
                ts.Khuvuc = dt.Rows[i]["tenKhuVuc"].ToString();
                ts.Maphong = dt.Rows[i]["maPhong"].ToString();
                if (!Convert.IsDBNull(dt.Rows[i]["images"]))
                {
                    ts.Images = dt.Rows[i]["images"].ToString();
                }
                listThiSinh.Add(ts);
            }
            DataProvider.DongKetNoi(con);
            return listThiSinh;
        }

        public static List<ThiSinh_DTO> TimKiemTheoCBB_Nganh(string maNganh)
        {
            string query = string.Format("EXEC proc_FindMajor_ThiSinh N'%{0}%'", maNganh);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu giám thị DTO
            List<ThiSinh_DTO> listThiSinh = new List<ThiSinh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThiSinh_DTO ts = new ThiSinh_DTO();
                ts.Sbd = dt.Rows[i]["soBaoDanh"].ToString();
                ts.Hoten = dt.Rows[i]["hoTen"].ToString();
                ts.Ngaysinh = DateTime.Parse(dt.Rows[i]["ngaySinh"].ToString());
                ts.Gioitinh = dt.Rows[i]["gioiTinh"].ToString();
                ts.Hokhau = dt.Rows[i]["hoKhau"].ToString();
                ts.Doituong = dt.Rows[i]["tenDoiTuong"].ToString();
                ts.Manganh = dt.Rows[i]["tenNganh"].ToString();
                ts.Khuvuc = dt.Rows[i]["tenKhuVuc"].ToString();
                ts.Maphong = dt.Rows[i]["maPhong"].ToString();
                if (!Convert.IsDBNull(dt.Rows[i]["images"]))
                {
                    ts.Images = dt.Rows[i]["images"].ToString();
                }
                listThiSinh.Add(ts);
            }
            DataProvider.DongKetNoi(con);
            return listThiSinh;
        }

        public static bool XoaFK_ThiSinh_FDoiTuong_DAO(string ma)
        {
            string query = string.Format("EXEC proc_XoaF_ThiSinh_FDoiTuong '{0}'", ma);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<ThiSinh_DTO> getID_ThiSinh_FNganh(ThiSinh_DTO thissinh)
        {
            string query = string.Format("SELECT * FROM THISINH WHERE maNganh = '{0}'", thissinh.Manganh);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu địa chỉ điểm thi DTO
            List<ThiSinh_DTO> listThiSinh = new List<ThiSinh_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThiSinh_DTO ts = new ThiSinh_DTO();
                ts.Sbd = dt.Rows[0]["soBaoDanh"].ToString();
                listThiSinh.Add(ts);
            }
            DataProvider.DongKetNoi(con);
            return listThiSinh;
        }

        public static ThiSinh_DTO getValueInfo(string maNguoiDung)
        {
            string query = string.Format("EXEC proc_GetValue_Info '{0}'", maNguoiDung);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu giám thị DTO
            ThiSinh_DTO ts = new ThiSinh_DTO();
            ts.Sbd = dt.Rows[0]["soBaoDanh"].ToString();
            ts.Hoten = dt.Rows[0]["hoTen"].ToString();
            ts.Ngaysinh = DateTime.Parse(dt.Rows[0]["ngaySinh"].ToString());
            ts.Gioitinh = dt.Rows[0]["gioiTinh"].ToString();
            ts.Hokhau = dt.Rows[0]["hoKhau"].ToString();
            ts.Doituong = dt.Rows[0]["tenDoiTuong"].ToString();
            ts.Manganh = dt.Rows[0]["tenNganh"].ToString();
            ts.Khuvuc = dt.Rows[0]["tenKhuVuc"].ToString();
            ts.Maphong = dt.Rows[0]["maPhong"].ToString();
            if (!Convert.IsDBNull(dt.Rows[0]["images"]))
            {
                ts.Images = dt.Rows[0]["images"].ToString();
            }
            DataProvider.DongKetNoi(con);
            return ts;
        }

        public static List<ThiSinh_DTO> getID_ThiSinh_FDiaDiemThi(string maPhong)
        {
            string query = string.Format("SELECT * FROM THISINH WHERE maPhong = '{0}'", maPhong);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu địa chỉ phòng thi DTO
            List<ThiSinh_DTO> listThiSinh = new List<ThiSinh_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThiSinh_DTO ts = new ThiSinh_DTO();
                ts.Sbd = dt.Rows[0]["soBaoDanh"].ToString();
                listThiSinh.Add(ts);
            }
            DataProvider.DongKetNoi(con);
            return listThiSinh;
        }

        public static ThiSinh_DTO KiemTraID_ThiSinh(string sbd)
        {
            string query = string.Format("EXEC proc_KiemTraID_ThiSinh '{0}'", sbd);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ThiSinh_DTO ts = new ThiSinh_DTO();
            ts.Maphong = dt.Rows[0]["soBaoDanh"].ToString();
            DataProvider.DongKetNoi(con);
            return ts;
        }

        public static bool XoaFK_ThiSinh_FDiaDiemThi(string maPhong)
        {
            string query = string.Format("EXEC proc_XoaFK_ThiSinh_FDiaDiemThi '{0}'", maPhong);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<ThiSinh_DTO> getID_ThiSinh_FPhongThi(string maPhong)
        {
            string query = string.Format("SELECT * FROM THISINH WHERE maPhong = '{0}'", maPhong);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu địa chỉ phòng thi DTO
            List<ThiSinh_DTO> listThiSinh = new List<ThiSinh_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThiSinh_DTO ts = new ThiSinh_DTO();
                ts.Sbd = dt.Rows[0]["soBaoDanh"].ToString();
                listThiSinh.Add(ts);
            }
            DataProvider.DongKetNoi(con);
            return listThiSinh;
        }

        public static bool XoaFK_ThiSinh_FPhongThi_DAO(string maPhong)
        {
            string query = string.Format("EXEC proc_XoaFK_ThiSinh_FPhongThi_DAO '{0}'", maPhong);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaFK_ThiSinh_FKhuVuc_DAO(string makhuvuc)
        {
            string query = string.Format("EXEC proc_XoaFK_ThiSinh_FKhuVuc '{0}'", makhuvuc);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<ThiSinh_DTO> getID_ThiSinh_FKhuVuc(string makc)
        {
            string query = string.Format("SELECT * FROM THISINH WHERE maKhuVuc = '{0}'", makc);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu địa chỉ điểm thi DTO
            List<ThiSinh_DTO> listThiSinh = new List<ThiSinh_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThiSinh_DTO ts = new ThiSinh_DTO();
                ts.Sbd = dt.Rows[0]["soBaoDanh"].ToString();
                listThiSinh.Add(ts);
            }
            DataProvider.DongKetNoi(con);
            return listThiSinh;
        }

        public static bool XoaFK_IDnganh_FThiSinh(ThiSinh_DTO ts)
        {
            string query = string.Format("EXEC proc_XoaFK_Nganh_FThiSinh '{0}'", ts.Manganh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<ThiSinh_DTO> getID_ThiSinh_FDoiTuong_DAO(DoiTuong_DTO doituong)
        {
            string query = string.Format("SELECT * FROM THISINH WHERE maDoiTuong = '{0}'", doituong.Madoituong);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu địa chỉ điểm thi DTO
            List<ThiSinh_DTO> listThiSinh = new List<ThiSinh_DTO>();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThiSinh_DTO ts = new ThiSinh_DTO();
                ts.Sbd = dt.Rows[0]["soBaoDanh"].ToString();
                listThiSinh.Add(ts);
            }
            DataProvider.DongKetNoi(con);
            return listThiSinh;
        }

        public static bool XoaThiSinh_DAO(ThiSinh_DTO ts)
        {
            string query = string.Format("EXEC proc_XoaThiSinh '{0}'", ts.Sbd);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapNhatThiSinh_DAO(ThiSinh_DTO ts)
        {
            string query = string.Format("EXEC proc_CapNhatThiSinh '{0}', N'{1}', '{2}', N'{3}', N'{4}', '{5}', '{6}', '{7}', '{8}', '{9}'", ts.Sbd, ts.Hoten, ts.Ngaysinh, ts.Gioitinh, ts.Hokhau, ts.Doituong, ts.Manganh, ts.Khuvuc, ts.Maphong, ts.Images);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static string SoLuongThiSinh()
        {
            string query = string.Format("SELECT * FROM view_SoLuongThiSinh");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            string slts;
            slts = dt.Rows[0]["SLTS"].ToString();
            DataProvider.DongKetNoi(con);
            return slts;
        }

        public static List<ThiSinh_DTO> DanhSachThiSinh()
        {
            string query = string.Format("SELECT * FROM view_DanhSachThiSinh");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu giám thị DTO
            List<ThiSinh_DTO> listThiSinh = new List<ThiSinh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThiSinh_DTO ts = new ThiSinh_DTO();
                ts.Sbd = dt.Rows[i]["soBaoDanh"].ToString();
                ts.Hoten = dt.Rows[i]["hoTen"].ToString();
                ts.Ngaysinh = DateTime.Parse(dt.Rows[i]["ngaySinh"].ToString());
                ts.Gioitinh = dt.Rows[i]["gioiTinh"].ToString();
                ts.Hokhau = dt.Rows[i]["hoKhau"].ToString();
                ts.Doituong = dt.Rows[i]["tenDoiTuong"].ToString();
                ts.Manganh = dt.Rows[i]["tenNganh"].ToString();
                ts.Khuvuc = dt.Rows[i]["tenKhuVuc"].ToString();
                ts.Maphong = dt.Rows[i]["maPhong"].ToString();
                if (!Convert.IsDBNull(dt.Rows[i]["images"]))
                {
                    ts.Images = dt.Rows[i]["images"].ToString();
                }
                listThiSinh.Add(ts);
            }
            DataProvider.DongKetNoi(con);
            return listThiSinh;
        }
    }
}
